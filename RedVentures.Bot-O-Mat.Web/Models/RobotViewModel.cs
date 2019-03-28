using RedVentures.Bot_O_Mat.Web.DTOs;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class RobotViewModel
    {
        public RobotViewModel(LeaderBoardRecord leaderBoardRecord)
        {
            Id = leaderBoardRecord.Id;
            CompletedErrandCount = leaderBoardRecord.CompletedErrandCount;
            Name = leaderBoardRecord.Name;
        }

        public RobotViewModel(KillBoardRecord killboardRecord)
        {
            Id = killboardRecord.Id;
            Name = killboardRecord.Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CompletedErrandCount { get; set; }
    }
}