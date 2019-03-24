using RedVentures.Bot_O_Mat.API.Data.Enums;
using System.Collections.Generic;
using System.Linq;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class LeaderBoardViewModel
    {
        public IEnumerable<LeaderBoardRecord> LeaderBoardRecord { get; set; }
    }

    public class LeaderBoardRecord
    {
        public LeaderBoardRecord(RobotViewModel robotViewModel)
        {
            ActorType = "Robot";
            Name = robotViewModel.Name;
            CompletedErrandCount = robotViewModel.Errands?.Count(i => i.ErrandStatus == ErrandStatus.Completed) ?? 0;
            FailedErrandCount = robotViewModel.Errands?.Count(i => i.ErrandStatus == ErrandStatus.Failed) ?? 0;
        }
        public LeaderBoardRecord(CyborgViewModel cyborgViewModel)
        {
            ActorType = "Cyborg";
            Name = cyborgViewModel.Name;
            CompletedErrandCount = cyborgViewModel.Errands?.Count(i => i.ErrandStatus == ErrandStatus.Completed) ?? 0;
            FailedErrandCount = cyborgViewModel.Errands?.Count(i => i.ErrandStatus == ErrandStatus.Failed) ?? 0;
        }
        public string Name { get; set; }
        public string ActorType { get; set; }
        public int CompletedErrandCount { get; set; }
        public int FailedErrandCount { get; set; }
    }
}
