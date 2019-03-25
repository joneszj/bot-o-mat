using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class PerformErrandResult
    {
        public ICanPerformErrand PerformingActor { get; set; }
        public ICanPerformErrand TerminatedActor { get; set; }
        public Errand PerformedErrand { get; set; }
    }
}
