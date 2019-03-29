using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.BLL.Interfaces;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace RedVentures.Bot_O_Mat.BLL.DTOs
{
    public class ErrandDTO
    {
        private Random _random;
        private Stopwatch _stopwatch;
        public ErrandDTO(ICanPerformErrand actor, ErrandType errandType, Stopwatch stopwatch, Random random)
        {
            Actor = actor;
            ErrandType = errandType;
            _random = random;
            _stopwatch = stopwatch;
        }
        public ICanPerformErrand Actor { get; set; }
        public ErrandType ErrandType { get; set; }
        public ErrandStatus Status { get; set; }
        public ICanBeDestroyed TerminatedActor { get; set; }
        public int TimeToComplete { get; set; }
        public void AttemptToCompleteErrand()
        {
            _stopwatch.Start();
            //higher actorTypes have extra chances to kill an opponent, but have extra 'dice rolls' to fail their task
            foreach (var item in Enumerable.Range(0, ((int)Actor.ActorType) + 1))
            {
                Thread.Sleep((int)ErrandType / ((int)Actor.ActorType + 1) + _random.Next(1000));
                if (TaskedFailedDiceRoll())
                {
                    SetErrandFailed();
                    break;
                }
            }
        }

        public bool ErrandDidNotFail() => Status != ErrandStatus.Failed;
        public void SetErrandCompletedSuccessfully()
        {
            SetErrnadCompletedTime();
            Status = ErrandStatus.Completed;
        }
        private void SetErrnadCompletedTime()
        {
            _stopwatch.Stop();
            TimeToComplete = Convert.ToInt32(_stopwatch.ElapsedMilliseconds);
        }
        public void SetErrandFailed()
        {
            SetErrnadCompletedTime();
            Status = ErrandStatus.Failed;
        }
        private bool TaskedFailedDiceRoll() => _random.Next(100) < 20;
    }
}