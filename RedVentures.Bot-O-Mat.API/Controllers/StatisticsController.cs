using System.Threading.Tasks;
using CommonPatterns.Filters;
using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.API.Models;
using RedVentures.Bot_O_Mat.API.Services;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        #region ctor && private
        private readonly ILeaderBoardService _leaderBoardService;
        private readonly IKillBoardService _killBoardService;
        private readonly IGraveyardService _graveyardService;

        public StatisticsController(ILeaderBoardService leaderBoardService, IKillBoardService killBoardService, IGraveyardService graveyardService)
        {
            _leaderBoardService = leaderBoardService;
            _killBoardService = killBoardService;
            _graveyardService = graveyardService;
        }
        #endregion

        #region public
        [Route("LeaderBoard")]
        [HttpGet]
        public async Task<ActionResult<LeaderBoardViewModel>> GetLeaderBoard() => Ok(await _leaderBoardService.GetLeaderBoard());

        [Route("KillBoard")]
        [HttpGet]
        public async Task<ActionResult<KillBoardViewModel>> GetKillBoard() => Ok(await _killBoardService.GetKillCounts());

        [Route("Graveyard")]
        [HttpGet]
        public async Task<ActionResult<GraveyardViewModel>> GetGraveyard() => Ok(await _graveyardService.GetFallenActors()); 
        #endregion
    }
}
