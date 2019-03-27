using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public class BattleService : IBattleService
    {
        private readonly IRobotService _robotService;
        private readonly ICyborgService _cyborgService;
        private readonly Random _randomGenerator;

        public BattleService(IRobotService robotService, ICyborgService cyborgService)
        {
            _robotService = robotService;
            _cyborgService = cyborgService;
            _randomGenerator = new Random();
        }

        /// <summary>
        /// actor destroyed another actor!!!!
        /// </summary>
        /// <param name="actor"></param>
        /// <returns></returns>
        //TODO: cleanify
        public async Task<ICanPerformErrand> KillAnotherActor(ICanPerformErrand actor)
        {
            if (actor.ActorType == ActorType.Cyborg)
            {
                var deadActorRange = await _robotService.GetRobotsBy(string.Empty, null);

                int toSkip = _randomGenerator.Next(0, deadActorRange.Count());
                var deadActor = deadActorRange.Skip(toSkip).Take(1).First();

                if (deadActor != null)
                {
                    deadActor.IsActive = false;
                    deadActor.KilledById = actor.Id;
                    return deadActor;
                }
            }
            else
            {
                var deadActorRange = await _cyborgService.GetCyborgsBy(string.Empty, null);
                var deadActor = await _cyborgService.GetCyborg(_randomGenerator.Next(1, deadActorRange.Count()));
                if (deadActor != null)
                {
                    deadActor.IsActive = false;
                    deadActor.KilledById = actor.Id;
                    return deadActor;
                }
            }
            return null;
        }
    }
}
