using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonPatterns.Filters;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.API.Models;
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
        private readonly HelpersManager _helpersManager;
        private readonly IErrandService _errandService;
        private readonly IRobotService _robotService;

        public RobotController(HelpersManager helperManager, IRobotService robotService, IErrandService errandService)
        {
            _helpersManager = helperManager;
            _errandService = errandService;
            _robotService = robotService;
        }
        #endregion

        #region public members
        [HttpGet("{id}")]
        public async Task<ActionResult<RobotViewModel>> Get(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var robot = new RobotViewModel(await _robotService.GetRobot(id));
            if (robot == null) return NotFound();
            return new RobotViewModel(await _robotService.GetRobot(id));
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RobotViewModel>>> Get()
        {
            var cacheResponse = _helpersManager.Cache.TryGet<Tuple<DateTime, ActorType>, RobotViewModel[]>(new Tuple<DateTime, ActorType>(DateTime.Today, ActorType.Robot), out bool IsFound);
            if (IsFound) return Ok(await Task.FromResult(cacheResponse));
            else return Ok(await RefreshCache());
        }

        [ServiceFilter(typeof(RefreshRobotCacheFilter))]
        [HttpPost]
        public async Task<ActionResult<RobotViewModel>> Post([FromBody] RobotViewModel robot)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            return Ok(new RobotViewModel(await _robotService.CreateRobot(robot.Name, robot.Type)));
        }

        [ServiceFilter(typeof(RefreshRobotCacheFilter))]
        [HttpPut]
        public async Task<ActionResult<PerformErrandResult>> Put([FromBody] PerformErrandViewModel performErrandViewModel)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var robot = await _robotService.GetRobot(performErrandViewModel.ActorId);
            if (robot == null) return NotFound();
            return await _errandService.PerformErrand(robot, performErrandViewModel.ErrandType);
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
            return _helpersManager.Cache.Set((DateTime.Today, ActorType.Robot), robots.Select(e => new RobotViewModel(e)).ToArray());
        } 
        #endregion
    }
}
