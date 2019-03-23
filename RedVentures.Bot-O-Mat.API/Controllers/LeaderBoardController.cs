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
    public class LeaderBoardController : ControllerBase
    {
        private readonly HelpersManager _helpersManager;
        private readonly IRobotService _robotService;
        private readonly ICyborgService _cyborgService;

        public LeaderBoardController(HelpersManager helperManager, IRobotService robotService, ICyborgService cyborgService)
        {
            _helpersManager = helperManager;
            _robotService = robotService;
            _cyborgService = cyborgService;
        }

        [HttpGet]
        public async Task<ActionResult<LeaderBoardViewModel>> Get()
        {
            var cachedRobots = _helpersManager.Cache.TryGet<Tuple<DateTime, ActorType>, RobotViewModel[]>(new Tuple<DateTime, ActorType>(DateTime.Today, ActorType.Cyborg), out bool robotsFound);
            if (!robotsFound) cachedRobots = await RefreshRobotCache();
            var cachedCyborgs = _helpersManager.Cache.TryGet<Tuple<DateTime, ActorType>, CyborgViewModel[]>(new Tuple<DateTime, ActorType>(DateTime.Today, ActorType.Cyborg), out bool cyborgsFound);
            if (!cyborgsFound) cachedCyborgs = await RefreshCyborgCache();

            return Ok(new LeaderBoardViewModel
            {
                LeaderBoardRecord = cachedRobots.Select(e => 
                        new LeaderBoardRecord { ActorType = "Robot", Name = e.Name, CompletedErrandCount = e.Errands?.Count(i => i.ErrandStatus == ErrandStatus.Completed) ?? 0, FailedErrandCount = e.Errands?.Count(i=>i.ErrandStatus == ErrandStatus.Failed) ?? 0 })
                    .Union(cachedCyborgs.Select(e => 
                        new LeaderBoardRecord { ActorType = "Cyborg", Name = e.Name, CompletedErrandCount = e.Errands?.Count(i => i.ErrandStatus == ErrandStatus.Completed) ?? 0, FailedErrandCount = e.Errands?.Count(i => i.ErrandStatus == ErrandStatus.Failed) ?? 0 }))
                    .OrderByDescending(e => e.CompletedErrandCount)
            });
        }

        #region helpers
        private async Task<RobotViewModel[]> RefreshRobotCache()
        {
            var robots = await _robotService.GetRobotsBy(string.Empty, null);
            return _helpersManager.Cache.Set((DateTime.Today, ActorType.Robot), robots.Select(e => new RobotViewModel(e)).ToArray());
        }
        private async Task<CyborgViewModel[]> RefreshCyborgCache()
        {
            var cyborgs = await _cyborgService.GetCyborgsBy(string.Empty, null);
            return _helpersManager.Cache.Set((DateTime.Today, ActorType.Cyborg), cyborgs.Select(e => new CyborgViewModel(e)).ToArray());
        }
        #endregion
    }
}
