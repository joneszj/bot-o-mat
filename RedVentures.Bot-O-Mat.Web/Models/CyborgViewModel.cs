using RedVentures.Bot_O_Mat.Web.DTOs;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class CyborgViewModel
    {
        public CyborgViewModel(LeaderBoardRecord leaderBoardRecord)
        {
            CompletedErrandCount = leaderBoardRecord.CompletedErrandCount;
            Name = leaderBoardRecord.Name;
        }

        public CyborgViewModel(KillBoardRecord killboardRecord) => Name = killboardRecord.Name;

        public string Name { get; set; }
        public int CompletedErrandCount { get; set; }
    }
}