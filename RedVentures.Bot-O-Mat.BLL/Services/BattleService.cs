using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.BLL.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Services
{
    //TODO: we can refactor to use the base ErrandActor
    public class BattleService : IBattleService
    {
        #region ctor && private
        private readonly IRobotService _robotService;
        private readonly ICyborgService _cyborgService;
        private readonly Random _randomGenerator;

        public BattleService(IRobotService robotService, ICyborgService cyborgService)
        {
            _robotService = robotService;
            _cyborgService = cyborgService;
            _randomGenerator = new Random();
        } 
        #endregion

        /// <summary>
        /// actor destroyed another actor!!!!
        /// </summary>
        /// <param name="actor"></param>
        /// <returns></returns>
        public async Task<ICanBeDestroyed> DestroyAnotherActor(ICanPerformErrand actor)
        {
            if (actor.ActorType == ActorType.Cyborg) return await DeactivateRandomRobot(actor);
            else return await DeactivateRandomCyborg(actor);
        }

        #region helpers
        private async Task<ICanBeDestroyed> DeactivateRandomCyborg(ICanPerformErrand actor)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
            //var targettedActors = await _cyborgService.GetCyborgsBy(string.Empty, null);
            //return TerminateActor(actor, targettedActors);
        }

        private async Task<ICanBeDestroyed> DeactivateRandomRobot(ICanPerformErrand actor)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
            //var targettedActors = await _robotService.GetRobotsBy(string.Empty, null);
            //return TerminateActor(actor, targettedActors);
        }

        private ICanBeDestroyed TerminateActor(ICanPerformErrand actor, System.Collections.Generic.IEnumerable<ICanBeDestroyed> targettedActors)
        {
            int randomSkipCount = _randomGenerator.Next(0, targettedActors.Count());
            var actorToDeactivate = targettedActors.Skip(randomSkipCount).Take(1).First();

            if (actorToDeactivate != null)
            {
                actorToDeactivate.DestroyedBy(actor.Id);
                return actorToDeactivate;
            }
            else return null;
        }
        #endregion
    }
}
