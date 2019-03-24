using System;
using System.Linq;
using System.Threading.Tasks;
using CommonPatterns.Helpers;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.API.Models;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public class LeaderBoardService : ILeaderBoardService
    {
        private readonly HelpersManager _helpersManager;
        private readonly IRobotService _robotService;
        private readonly ICyborgService _cyborgService;

        public LeaderBoardService(HelpersManager helpersManager, IRobotService robotService, ICyborgService cyborgService)
        {
            _helpersManager = helpersManager;
            _robotService = robotService;
            _cyborgService = cyborgService;
        }
        public async Task<LeaderBoardViewModel> GetLeaderBoard()
        {
            var cachedRobots = _helpersManager.Cache.TryGet<(DateTime, ActorType), RobotViewModel[]>(GetLeaderBoardRobotKey(), out bool robotsFound);
            if (!robotsFound) cachedRobots = await RefreshRobotCache();
            var cachedCyborgs = _helpersManager.Cache.TryGet<(DateTime, ActorType), CyborgViewModel[]>(GetLeaderBoardCyborgKey(), out bool cyborgsFound);
            if (!cyborgsFound) cachedCyborgs = await RefreshCyborgCache();

            return new LeaderBoardViewModel
            {
                LeaderBoardRecord = cachedRobots.Select(e => new LeaderBoardRecord(e) )
                    .Union(cachedCyborgs.Select(e => new LeaderBoardRecord(e)))
                    .OrderByDescending(e => e.CompletedErrandCount)
            };
        }

        #region helpers
        private async Task<RobotViewModel[]> RefreshRobotCache()
        {
            var robots = await _robotService.GetRobotsBy(string.Empty, null);
            return _helpersManager.Cache.Set(GetLeaderBoardRobotKey(), robots.Select(e => new RobotViewModel(e)).ToArray());
        }


        private async Task<CyborgViewModel[]> RefreshCyborgCache()
        {
            var cyborgs = await _cyborgService.GetCyborgsBy(string.Empty, null);
            return _helpersManager.Cache.Set(GetLeaderBoardCyborgKey(), cyborgs.Select(e => new CyborgViewModel(e)).ToArray());
        }

        private static (DateTime Today, ActorType Robot) GetLeaderBoardRobotKey() => (DateTime.Today, ActorType.Robot);
        private static (DateTime Today, ActorType Cyborg) GetLeaderBoardCyborgKey() => (DateTime.Today, ActorType.Cyborg);
        #endregion
    }
}
