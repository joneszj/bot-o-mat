using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Services
{
    //TODO: we can refactor to use the base ErrandActor
    public class BattleService : IBattleService
    {
        #region ctor && private
        private readonly IRobotService _robotService;
        private readonly ICyborgService _cyborgService;
        private readonly Random _randomGenerator;
        private readonly BotOMatContext _botOMatContext;

        public BattleService(IRobotService robotService, ICyborgService cyborgService, BotOMatContext botOMatContext)
        {
            _robotService = robotService;
            _cyborgService = cyborgService;
            _randomGenerator = new Random();
            _botOMatContext = botOMatContext;
        } 
        #endregion

        /// <summary>
        /// actor destroyed another actor!!!!
        /// </summary>
        /// <param name="actor"></param>
        /// <returns></returns>
        public async Task<ICanPerformErrand> KillAnotherActor(ICanPerformErrand actor)
        {
            if (actor.ActorType == ActorType.Cyborg) return await DeactivateRandomRobot(actor);
            else return await DeactivateRandomCyborg(actor);
        }

        #region helpers
        private async Task<ICanPerformErrand> DeactivateRandomCyborg(ICanPerformErrand actor)
        {
            var targettedActors = await _cyborgService.GetCyborgsBy(string.Empty, null);
            var randomSkipCount = _randomGenerator.Next(1, targettedActors.Count());
            var actorToDeactivate = await _cyborgService.GetCyborg(randomSkipCount);
            if (actorToDeactivate != null)
            {
                actorToDeactivate.IsActive = false;
                actorToDeactivate.KilledById = actor.Id;
                _botOMatContext.Entry(actorToDeactivate).State = EntityState.Modified;
                return actorToDeactivate;
            }
            else return null;
        }

        private async Task<ICanPerformErrand> DeactivateRandomRobot(ICanPerformErrand actor)
        {
            var targettedActors = await _robotService.GetRobotsBy(string.Empty, null);

            int randomSkipCount = _randomGenerator.Next(0, targettedActors.Count());
            var actorToDeactivate = targettedActors.Skip(randomSkipCount).Take(1).First();

            if (actorToDeactivate != null)
            {
                actorToDeactivate.IsActive = false;
                actorToDeactivate.KilledById = actor.Id;
                return actorToDeactivate;
            }
            else return null;
        } 
        #endregion
    }
}
