using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonPatterns.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using RedVentures.Bot_O_Mat.API.Hubs;
using RedVentures.Bot_O_Mat.API.Models;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class RobotController : ControllerBase
    {
        #region constructor && private members
        private readonly HelpersManager _helpersManager;
        private readonly IRobotService _robotService;
        private readonly IHubContext<NotificationHub> _notificationHub;

        public RobotController(HelpersManager helperManager, IRobotService robotService, IHubContext<NotificationHub> notificationHub)
        {
            _helpersManager = helperManager;
            _robotService = robotService;
            _notificationHub = notificationHub;
        }
        #endregion

        #region public members
        [HttpGet("{id}")]
        public async Task<ActionResult<RobotViewModel>> Get(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var robot = await _robotService.GetRobot(id);
            if (robot == null) return NotFound();
            return Ok(new RobotViewModel(await _robotService.GetRobot(id)));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RobotViewModel>>> Get()
        {
            var cacheResponse = _helpersManager.Cache.TryGet<Tuple<DateTime, ActorType>, RobotViewModel[]>(new Tuple<DateTime, ActorType>(DateTime.Today, ActorType.Robot), out bool IsFound);
            if (IsFound) return Ok(await Task.FromResult(cacheResponse));
            else return Ok(await RefreshCache());
        }

        //[ServiceFilter(typeof(RefreshRobotCacheFilter))]
        [HttpPost]
        public async Task<ActionResult<RobotViewModel>> Post([FromBody] RobotViewModel robot)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var newRobot = await _robotService.CreateRobot(robot.Name, robot.Type);
            await _notificationHub.Clients.All.SendAsync("Notify", new Notification($"{robot.Name} (Robot) created!", SeverityLevel.Success));
            return Ok(new RobotViewModel(newRobot));
        }

        //[ServiceFilter(typeof(RefreshRobotCacheFilter))]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var robot = await _robotService.ScrapRobot(id);
            await _notificationHub.Clients.All.SendAsync("Notify", new Notification($"{robot.Name} deactivated!", SeverityLevel.Info));
            return Ok();
        }
        #endregion

        #region helpers
        private async Task<RobotViewModel[]> RefreshCache()
        {
            var robots = await _robotService.GetRobotsBy(string.Empty, null);
            return robots.Select(e => new RobotViewModel(e)).ToArray();
            //TODO: determine better caching process, perhaps at the services layer instead the api boundary
            //return _helpersManager.Cache.Set((DateTime.Today, ActorType.Cyborg), robots.Select(e => new CyborgViewModel(e)).ToArray());
        }
        #endregion
    }
}
