using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public class ErrandService : IErrandService
    {
        private readonly BotOMatContext _botOMatContext;
        private readonly Random _randomGenerator;

        public ErrandService(BotOMatContext botOMatContext)
        {
            _botOMatContext = botOMatContext;
            _randomGenerator = new Random();
        }

        public async Task<ICanPerformErrand> PerformErrand(ICanPerformErrand actor, ErrandType errandType)
        {
            var errand = new Errand(actor, errandType) { Status = ErrandStatus.In_Progress };

            //TODO: calculate weighted augmentation preferences on robot type
            //higher RobotTypes reduce the speed of completion, but have extra 'dice rolls' to fail
            //... (int)((Robot)robot).Type)) actually works
            foreach (var item in Enumerable.Range(0, (int)actor.ActorType))
            {
                Thread.Sleep((int)errandType / (int)actor.ActorType);
                //TODO: add chance to fail (perhaps on robot type?)
                if (_randomGenerator.Next(100) < 20)
                {
                    //robot destroyed the errand task!!!!
                    errand.Status = ErrandStatus.Failed;
                    break;
                }
            }

            if (errand.Status != ErrandStatus.Failed) errand.Status = ErrandStatus.Completed;
            await _botOMatContext.SaveChangesAsync();
            return actor;
        }
    }
}
