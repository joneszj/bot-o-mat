using System.Collections.Generic;
using System.Linq;
using RedVentures.Bot_O_Mat.Web.DTOs;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class KillBoardViewModel
    {
        public KillBoardViewModel() { }
        public KillBoardViewModel(KillBoardViewModelDTO killboardBoardDto)
        {
            Robots = killboardBoardDto.KillBoardRecord
                .Where(e => e.ActorType == "Robot")
                .OrderByDescending(e => e.KillCount)
                .Take(5)
                .Select(e => new KillerRobotViewModel(e));
            Cyborgs = killboardBoardDto
                .KillBoardRecord.Where(e => e.ActorType == "Cyborg")
                .OrderByDescending(e => e.KillCount)
                .Take(5)
                .Select(e => new KillerCyborgViewModel(e));
        }

        public IEnumerable<KillerRobotViewModel> Robots { get; set; }
        public IEnumerable<KillerCyborgViewModel> Cyborgs { get; set; }
    }
}