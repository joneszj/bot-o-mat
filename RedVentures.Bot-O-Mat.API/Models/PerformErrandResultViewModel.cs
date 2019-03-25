using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class PerformErrandResultViewModel
    {
        public PerformErrandResultViewModel(PerformErrandResult errandResult)
        {
            PerformingActorId = errandResult.PerformedErrand.ActorId;
            ErrandId = errandResult.PerformedErrand.Id;
            TerminatedActorId = errandResult.TerminatedActor?.Id;
            CompletedSuccessfully = errandResult.PerformedErrand.Status == ErrandStatus.Completed;
            ElapsedTime = errandResult.PerformedErrand.TimeToComplete;
        }

        public int PerformingActorId { get; set; }
        public int ErrandId { get; set; }
        public bool CompletedSuccessfully { get; set; }
        public int? TerminatedActorId { get; set; }
        public int ElapsedTime { get; set; }
    }
}
