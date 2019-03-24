using RedVentures.Bot_O_Mat.Web.DTOs;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class RobotViewModel
    {
        public RobotViewModel(LeaderBoardRecord leaderBoardRecord)
        {
            CompletedErrandCount = leaderBoardRecord.CompletedErrandCount;
            Name = leaderBoardRecord.Name;
        }

        public RobotViewModel(KillBoardRecord killboardRecord)
        {
            Name = killboardRecord.Name;
        }

        public string Name { get; set; }
        public int CompletedErrandCount { get; set; }
    }
}