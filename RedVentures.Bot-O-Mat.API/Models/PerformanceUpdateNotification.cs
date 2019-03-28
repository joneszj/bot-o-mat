using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class PerformanceUpdateNotification
    {
        public PerformanceUpdateNotification(PerformErrandResult result)
        {
            PerformingActorId = result.PerformingActor.Id;
            ErrandSuccess = result.PerformedErrand.Status == ErrandStatus.Completed;
            NewKill = result.TerminatedActor != null;
        }

        public int PerformingActorId { get; }
        public bool ErrandSuccess { get; }
        public bool NewKill { get; }
    }
}
