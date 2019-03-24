using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.API.Models;
using RedVentures.Bot_O_Mat.API.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CommonPatterns.Filters
{
    /// <summary>
    /// Will run during request/response pipeline on attributed controller/actions
    /// </summary>
    /// <example>[ServiceFilter(typeof(RefreshCyborgCacheFilter))]</example>
    public class RefreshCyborgCacheFilter : ActionFilterAttribute
    {
        #region ctor && private
        private readonly HelpersManager _helpersManager;
        readonly ICyborgService _cyborgService;
        public RefreshCyborgCacheFilter(HelpersManager helpersManager, ICyborgService cyborgService)
        {
            _helpersManager = helpersManager;
            _cyborgService = cyborgService;
        }
        #endregion
        #region public
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            //TODO: invalidate cache, this is inefficient
            var robots = await _cyborgService.GetCyborgsBy(string.Empty, null);
            _helpersManager.Cache.Set((DateTime.Today, ActorType.Cyborg), robots.Select(e => new CyborgViewModel(e)).ToArray());
        }

        public static void Configure(IServiceCollection services) => services.AddScoped<RefreshCyborgCacheFilter>();
        #endregion
    }
}
