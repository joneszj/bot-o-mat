using CommonPatterns.Helpers;
using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.API.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public class KillBoardService : IKillBoardService
    {
        private readonly HelpersManager _helpersManager;
        private readonly BotOMatContext _botOMatContext;

        public KillBoardService(HelpersManager helpersManager, BotOMatContext botOMatContext)
        {
            _helpersManager = helpersManager;
            _botOMatContext = botOMatContext;
        }

        public async Task<KillBoardViewModel> GetKillCounts()
        {
            var cachedKillers = _helpersManager.Cache.TryGet<Tuple<DateTime, string>, KillBoardRecord[]>(new Tuple<DateTime, string>(DateTime.Today, "killers"), out bool killersFound);
            if (!killersFound) cachedKillers = await RefreshKillersCache();

            return new KillBoardViewModel
            {
                KillBoardRecord = cachedKillers
            };
        }

        #region helpers
        private async Task<KillBoardRecord[]> RefreshKillersCache()
        {
            var killerIds = _botOMatContext.ErrandActors.IgnoreQueryFilters().Where(e => e.KilledById != null).GroupBy(e => e.KilledById).ToList();
            var killerActors = await _botOMatContext.ErrandActors
                .Where(killers => killerIds
                .Select(i => i.Key).Contains(killers.Id))
                .Select(e => new KillBoardRecord
                {
                    Name = e.Name,
                    KillCount = killerIds.Where(i => i.Key.Value == e.Id).SelectMany(y => y).Count(),
                    ActorType = Enum.GetName(typeof(ActorType), e.ActorType)
                })
                .OrderByDescending(e => e.KillCount).Take(100).ToArrayAsync();
            return _helpersManager.Cache.Set((DateTime.Today, "killers"), (killerActors));
        }
        #endregion
    }
}
