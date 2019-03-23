using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using RedVentures.Bot_O_Mat.API.Modles;
using RedVentures.Bot_O_Mat.API.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CommonPatterns.Filters
{
    /// <summary>
    /// Will run during request/response pipeline on attributed controller/actions
    /// </summary>
    /// <example>[ServiceFilter(typeof(RefreshRobotCacheFilter))]</example>
    public class RefreshRobotCacheFilter : ActionFilterAttribute
    {
        #region ctor && private
        private readonly HelpersManager _helpersManager;
        IRobotService _robotService;
        public RefreshRobotCacheFilter(HelpersManager helpersManager, IRobotService robotService)
        {
            _helpersManager = helpersManager;
            _robotService = robotService;
        }
        #endregion
        #region public
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            //TODO: invalidate cache, this is inefficient
            var robots = await _robotService.GetRobotsBy(string.Empty, null);
            _helpersManager.Cache.Set(DateTime.Today, robots.Select(e => new RobotViewModel(e)).ToArray());
        }

        public static void Configure(IServiceCollection services) => services.AddScoped<RefreshRobotCacheFilter>();
        #endregion
    }
}
