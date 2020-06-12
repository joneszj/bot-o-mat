using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Globalization;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class ErrandViewModel
    {
        public ErrandViewModel() { }
        public ErrandViewModel(Errand errand)
        {
            ErrandType = errand.Type;
            ErrandTypeName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Enum.GetName(typeof(ErrandType), errand.Type).Replace('_', ' '));
            ErrandStatus = errand.Status;
            TimeToComplete = errand.TimeToComplete;
        }

        public ErrandType ErrandType { get; set; }
        public string ErrandTypeName { get; }
        public ErrandStatus ErrandStatus { get; set; }
        public int TimeToComplete { get; set; }
    }
}
