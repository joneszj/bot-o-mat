using System;
using System.Linq;
using System.Threading.Tasks;
using CommonPatterns.Filters;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.API.Modles;
using RedVentures.Bot_O_Mat.API.Services;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly ILeaderBoardService _leaderBoardService;
        private readonly IKillBoardService _killBoardService;

        public StatisticsController(ILeaderBoardService leaderBoardService, IKillBoardService killBoardService)
        {
            _leaderBoardService = leaderBoardService;
            _killBoardService = killBoardService;
        }

        [Route("api/[controller]/LeaderBoard")]
        [HttpGet]
        public async Task<ActionResult<LeaderBoardViewModel>> GetLeaderBoard() => Ok(await _leaderBoardService.GetLeaderBoard());

        [Route("api/[controller]/KillBoard")]
        [HttpGet]
        public async Task<ActionResult<KillBoardViewModel>> GetKillBoard() => Ok(await _killBoardService.GetKillCounts());
    }
}
