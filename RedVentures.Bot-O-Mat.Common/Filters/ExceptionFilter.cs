using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace CommonPatterns.Filters
{
    /// <summary>
    /// Will run on any exception thrown on attributed controller/actions
    /// </summary>
    /// <example>[ServiceFilter(typeof(ExceptionFilter))]</example>
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        #region ctor && private
        private readonly HelpersManager _helpersManager;
        public ExceptionFilter(HelpersManager helpersManager) => _helpersManager = helpersManager;
        #endregion
        #region public
        public async override Task OnExceptionAsync(ExceptionContext context)
        {
            //TODO: notify of error via signalr?
            await _helpersManager.Log.Fatal(context.Exception, $"Exception thrown! {context.Exception.Message}");
            throw context.Exception;
        }

        public static void Configure(IServiceCollection services) => services.AddScoped<ExceptionFilter>();
        #endregion
    }
}
