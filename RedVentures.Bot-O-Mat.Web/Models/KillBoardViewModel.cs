using System.Collections.Generic;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class KillBoardViewModel
    {
        public IEnumerable<KillerRobotViewModel> Robots { get; set; }
        public IEnumerable<KillerCyborgViewModel> Cyborgs { get; set; }
    }
}