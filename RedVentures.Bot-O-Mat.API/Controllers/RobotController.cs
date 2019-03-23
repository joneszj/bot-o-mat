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
        public async Task<RobotViewModel> Get(int id) => new RobotViewModel(await _robotService.GetRobot(id));

        [HttpGet]
        public async Task<IEnumerable<RobotViewModel>> Get()
        {
            var cacheResponse = _helpersManager.Cache.TryGet<DateTime, RobotViewModel[]>(DateTime.Today, out bool IsFound);
            if (IsFound) return await Task.FromResult(cacheResponse);
            else
            {
                var robots = await _robotService.GetRobotsBy(string.Empty, null);
                return _helpersManager.Cache.Set(DateTime.Today, robots.Select(e => new RobotViewModel(e)).ToArray());
            }
        }

        [HttpPost]
        public async Task<RobotViewModel> Post([FromBody] RobotViewModel robot) => new RobotViewModel(await _robotService.CreateRobot(robot.Name, robot.Type));

        [HttpDelete("{id}")]
        public async Task Delete(int id) => await _robotService.ScrapRobot(id);
        #endregion
    }
}
