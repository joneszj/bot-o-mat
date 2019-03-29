using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class PerformErrandResult
    {
        public PerformErrandResult() { }

        public PerformErrandResult(ICanPerformErrand actor, Errand errand)
        {
            PerformingActor = actor;
            PerformedErrand = errand;
        }
        public ICanPerformErrand PerformingActor { get; set; }
        public ICanBeDestroyed TerminatedActor { get; set; }
        public Errand PerformedErrand { get; set; }
    }
}
