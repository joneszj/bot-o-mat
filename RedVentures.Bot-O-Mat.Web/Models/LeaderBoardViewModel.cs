using System.Collections.Generic;
using System.Linq;
using RedVentures.Bot_O_Mat.Web.DTOs;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class LeaderBoardViewModel
    {
        public LeaderBoardViewModel() { }
        public LeaderBoardViewModel(LeaderBoardViewModelDTO leaderBoardDto)
        {
            Robots = leaderBoardDto.LeaderBoardRecord
                .Where(e => e.ActorType == "Robot")
                .OrderByDescending(e => e.CompletedErrandCount)
                .Take(5)
                .Select(e => new RobotViewModel(e));
            Cyborgs = leaderBoardDto.LeaderBoardRecord
                .Where(e => e.ActorType == "Cyborg")
                .OrderByDescending(e => e.CompletedErrandCount)
                .Take(5)
                .Select(e => new CyborgViewModel(e));
        }

        public IEnumerable<RobotViewModel> Robots { get; set; }
        public IEnumerable<CyborgViewModel> Cyborgs { get; set; }
    }
}
