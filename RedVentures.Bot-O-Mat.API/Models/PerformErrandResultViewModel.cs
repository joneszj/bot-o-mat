using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Globalization;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class PerformErrandResultViewModel
    {
        public PerformErrandResultViewModel(PerformErrandResult errandResult)
        {
            PerformingActorId = errandResult.PerformedErrand.ActorId;
            Errand = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Enum.GetName(typeof(ErrandType), errandResult.PerformedErrand.Type).Replace('_', ' '));
            TerminatedActorId = errandResult.TerminatedActor?.Id;
            TerminatedActorName = errandResult.TerminatedActor?.Name;
            CompletedSuccessfully = errandResult.PerformedErrand.Status == ErrandStatus.Completed;
            ElapsedTime = errandResult.PerformedErrand.TimeToComplete;
        }

        public int PerformingActorId { get; set; }
        public string Errand { get; set; }
        public bool CompletedSuccessfully { get; set; }
        public int? TerminatedActorId { get; set; }
        public string TerminatedActorName { get; }
        public int ElapsedTime { get; set; }
    }
}
