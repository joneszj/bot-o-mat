using System.Collections.Generic;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class LeaderBoardViewModel
    {
        public IEnumerable<RobotViewModel> Robots { get; set; }
        public IEnumerable<CyborgViewModel> Cyborgs { get; set; }
    }
}
