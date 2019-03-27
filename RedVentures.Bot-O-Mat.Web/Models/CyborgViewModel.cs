using RedVentures.Bot_O_Mat.Web.DTOs;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class CyborgViewModel
    {
        public CyborgViewModel(LeaderBoardRecord leaderBoardRecord)
        {
            CompletedErrandCount = leaderBoardRecord.CompletedErrandCount;
            Name = leaderBoardRecord.Name;
            Id = leaderBoardRecord.Id;
        }

        public CyborgViewModel(KillBoardRecord killboardRecord) => Name = killboardRecord.Name;

        public int Id { get; set; }
        public string Name { get; set; }
        public int CompletedErrandCount { get; set; }
    }
}