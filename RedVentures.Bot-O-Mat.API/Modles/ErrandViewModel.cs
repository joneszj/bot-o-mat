using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Modles
{
    public class ErrandViewModel
    {
        public ErrandViewModel(Errand errand)
        {
            ErrandType = errand.Type;
            ErrandStatus = errand.Status;
            TimeToComplete = errand.TimeToComplete;
        }

        public ErrandType ErrandType { get; set; }
        public ErrandStatus ErrandStatus { get; set; }
        public int TimeToComplete { get; set; }
    }
}
