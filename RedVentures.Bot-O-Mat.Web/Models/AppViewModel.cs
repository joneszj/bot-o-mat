using RedVentures.Bot_O_Mat.Web.DTOs;
using System.Linq;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class AppViewModel
    {
        public AppViewModel(LeaderBoardViewModelDTO leaderBoardDto)
        {
            LeaderBoardViewModel = new LeaderBoardViewModel
            {
                Robots = leaderBoardDto.LeaderBoardRecord
                    .Where(e => e.ActorType == "Robot").OrderByDescending(e => e.CompletedErrandCount).Take(5)
                    .Select(e => new RobotViewModel { CompletedErrandCount = e.CompletedErrandCount, Name = e.Name }),
                Cyborgs = leaderBoardDto.LeaderBoardRecord
                    .Where(e => e.ActorType == "Cyborg").OrderByDescending(e => e.CompletedErrandCount).Take(5)
                    .Select(e => new CyborgViewModel { CompletedErrandCount = e.CompletedErrandCount, Name = e.Name })
            };
        }

        public LeaderBoardViewModel LeaderBoardViewModel { get; set; }
        public KillBoardViewModel KillBoardViewModel { get; set; }
        public GraveyardViewModel GraveyardViewModel { get; set; }
        public FactoryViewModel FactoryViewModel { get; set; }
    }
}
