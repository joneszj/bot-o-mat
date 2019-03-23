using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonPatterns.Filters;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.API.Modles;
using RedVentures.Bot_O_Mat.API.Services;

namespace RedVentures.Bot_O_Mat.API.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("api/[controller]")]
    [ApiController]
    public class RobotController : ControllerBase
    {
        #region constructor && private members
        private HelpersManager _helpersManager;
        private IRobotService _robotService;

        public RobotController(HelpersManager helperManager, IRobotService robotService)
        {
            _helpersManager = helperManager;
            _robotService = robotService;
        }
        #endregion

        #region public members
        [HttpGet("{id}")]
        public async Task<ActionResult<RobotViewModel>> Get(int id)
        {
            var robot = new RobotViewModel(await _robotService.GetRobot(id));
            if (robot == null) return NotFound();
            return new RobotViewModel(await _robotService.GetRobot(id));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RobotViewModel>>> Get()
        {
            var cacheResponse = _helpersManager.Cache.TryGet<DateTime, RobotViewModel[]>(DateTime.Today, out bool IsFound);
            if (IsFound) return Ok(await Task.FromResult(cacheResponse));
            else return Ok(await RefreshCache());
        }

        [ServiceFilter(typeof(RefreshRobotCacheFilter))]
        [HttpPost]
        public async Task<ActionResult<RobotViewModel>> Post([FromBody] RobotViewModel robot)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return new RobotViewModel(await _robotService.CreateRobot(robot.Name, robot.Type));
        }

        [ServiceFilter(typeof(RefreshRobotCacheFilter))]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            await _robotService.ScrapRobot(id);
            return Ok();
        }
        #endregion

        #region helpers
        private async Task<RobotViewModel[]> RefreshCache()
        {
            var robots = await _robotService.GetRobotsBy(string.Empty, null);
            return _helpersManager.Cache.Set(DateTime.Today, robots.Select(e => new RobotViewModel(e)).ToArray());
        } 
        #endregion
    }
}
