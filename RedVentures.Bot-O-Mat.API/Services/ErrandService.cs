using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.API.Models;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public class ErrandService : IErrandService
    {
        private readonly BotOMatContext _botOMatContext;
        private readonly IBattleService _battleService;
        private readonly Random _randomGenerator;
        private readonly Stopwatch _stopwatch;

        public ErrandService(BotOMatContext botOMatContext, IBattleService battleService)
        {
            _botOMatContext = botOMatContext;
            _battleService = battleService;
            _randomGenerator = new Random();
            _stopwatch = new Stopwatch();
        }

        public async Task<PerformErrandResult> PerformErrand(ICanPerformErrand actor, ErrandType errandType)
        {
            var errand = new Errand(actor, errandType) { Status = ErrandStatus.In_Progress };
            var result = new PerformErrandResult
            {
                PerformingActor = actor,
                PerformedErrand = errand
            };

            //TODO: calculate weighted augmentation preferences on robot type
            //higher actorTypes have extra chances to kill an opponent, but have extra 'dice rolls' to fail their task
            foreach (var item in Enumerable.Range(0, ((int)actor.ActorType) + 1))
            {
                _stopwatch.Start();
                Thread.Sleep((int)errandType / ((int)actor.ActorType + 1) + _randomGenerator.Next(1000));
                if (_randomGenerator.Next(100) < 20)
                {
                    //actor destroyed the errand task!!!!
                    errand.Status = ErrandStatus.Failed;
                    result.TerminatedActor = await _battleService.KillAnotherActor(actor);
                    break;
                }
            }

            if (errand.Status != ErrandStatus.Failed) errand.Status = ErrandStatus.Completed;
            errand.TimeToComplete = Convert.ToInt32(_stopwatch.ElapsedMilliseconds);
            actor.Errands.Add(errand);
            await _botOMatContext.SaveChangesAsync();
            return result;
        }
    }
}
