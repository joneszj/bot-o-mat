using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonPatterns.Helpers;
using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Models;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public class GraveyardService : IGraveyardService
    {
        #region ctor && private
        private readonly HelpersManager _helpersManager;
        private readonly BotOMatContext _botOMatContext;
        public GraveyardService(HelpersManager helpersManager, BotOMatContext botOMatContext)
        {
            _botOMatContext = botOMatContext;
            _helpersManager = helpersManager;
        } 
        #endregion

        public async Task<GraveyardViewModel> GetFallenActors()
        {
            var cachedFallen = _helpersManager.Cache.TryGet<(DateTime, string), IEnumerable<GraveyardRecord>>(GetFallenKey(), out bool fallenFound);
            if (!fallenFound) cachedFallen = await RefreshFallenCache();

            return new GraveyardViewModel(cachedFallen);
        }

        #region helpers
        private async Task<IEnumerable<GraveyardRecord>> RefreshFallenCache()
        {
            var fallenActors = await _botOMatContext.ErrandActors.IgnoreQueryFilters().Where(e => e.KilledById != null)
                .Join(_botOMatContext.ErrandActors, e => e.KilledById, i => i.Id, (e, i) => new GraveyardRecord(e, i)).ToArrayAsync();
            return _helpersManager.Cache.Set(GetFallenKey(), (fallenActors));
        }

        private static (DateTime Today, string) GetFallenKey() => (DateTime.Today, "fallen");
        #endregion
    }
}
