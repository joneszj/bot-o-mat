using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.BLL.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Services
{
    public class LeaderBoardService : ILeaderBoardService
    {
        #region ctor && private
        private readonly HelpersManager _helpersManager;
        private readonly IRobotService _robotService;
        private readonly ICybordService _cyborgService;

        public LeaderBoardService(HelpersManager helpersManager, IRobotService robotService, ICybordService cyborgService)
        {
            _helpersManager = helpersManager;
            _robotService = robotService;
            _cyborgService = cyborgService;
        } 
        #endregion

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
            return robots.Select(e => new RobotViewModel(e)).ToArray();
            //TODO: determine better caching process, perhaps at the services layer instead the api boundary
            //return _helpersManager.Cache.Set((DateTime.Today, ActorType.Cyborg), robots.Select(e => new CyborgViewModel(e)).ToArray());
        }


        private async Task<CyborgViewModel[]> RefreshCyborgCache()
        {
            var cyborgs = await _cyborgService.GetCyborgsBy(string.Empty, null);
            return cyborgs.Select(e => new CyborgViewModel(e)).ToArray();
            //TODO: determine better caching process, perhaps at the services layer instead the api boundary
            //return _helpersManager.Cache.Set(GetLeaderBoardCyborgKey(), cyborgs.Select(e => new CyborgViewModel(e)).ToArray());
        }

        private static (DateTime Today, ActorType Robot) GetLeaderBoardRobotKey() => (DateTime.Today, ActorType.Robot);
        private static (DateTime Today, ActorType Cyborg) GetLeaderBoardCyborgKey() => (DateTime.Today, ActorType.Cyborg);
        #endregion
    }
}
