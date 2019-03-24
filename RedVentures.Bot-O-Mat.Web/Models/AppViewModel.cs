using RedVentures.Bot_O_Mat.Web.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class AppViewModel
    {
        public AppViewModel(LeaderBoardViewModelDTO leaderBoardDto, KillBoardViewModelDTO killboardBoardDto, GraveYardViewModelDTO graveYardViewModelDTO)
        {
            LeaderBoardViewModel = new LeaderBoardViewModel
            {
                Robots = leaderBoardDto.LeaderBoardRecord
                    .Where(e => e.ActorType == "Robot").OrderByDescending(e => e.CompletedErrandCount).Take(5)
                    .Select(e => new RobotViewModel(e)),
                Cyborgs = leaderBoardDto.LeaderBoardRecord
                    .Where(e => e.ActorType == "Cyborg").OrderByDescending(e => e.CompletedErrandCount).Take(5)
                    .Select(e => new CyborgViewModel(e))
            };
            KillBoardViewModel = new KillBoardViewModel
            {
                Robots = killboardBoardDto.KillBoardRecord.Where(e=>e.ActorType == "Robot").OrderByDescending(e => e.KillCount).Take(5)
                    .Select(e=> new KillerRobotViewModel(e)),
                Cyborgs = killboardBoardDto.KillBoardRecord.Where(e=>e.ActorType == "Cyborg").OrderByDescending(e => e.KillCount).Take(5)
                    .Select(e=> new KillerCyborgViewModel(e))
            };
            GraveyardViewModel = graveYardViewModelDTO.GraveYardRecords.Select(e=> new GraveyardViewModel(e)).OrderByDescending(e => e.DeathDate).Take(5);
        }

        public LeaderBoardViewModel LeaderBoardViewModel { get; set; }
        public KillBoardViewModel KillBoardViewModel { get; set; }
        public IEnumerable<GraveyardViewModel> GraveyardViewModel { get; set; }
        public FactoryViewModel FactoryViewModel { get; set; }
    }
}
