using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace CommonPatterns.Filters
{
    /// <summary>
    /// Will run during request/response pipeline on attributed controller/actions
    /// </summary>
    /// <example>[ServiceFilter(typeof(RequestResponseFilter))]</example>
    public class RequestResponseFilter : ActionFilterAttribute
    {
        #region ctor && private
        private readonly HelpersManager _helpersManager;
        private string UserName;
        public RequestResponseFilter(HelpersManager helpersManager) => _helpersManager = helpersManager;
        #endregion
        #region public
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.User?.Identity?.Name != null)
            {
                UserName = context.HttpContext.User.Identity.Name;
                _helpersManager.Log.Information($"Hello from {context.Controller.ToString()}/{context.ActionDescriptor.DisplayName}, User: {UserName}");
            }
            else
            {
                _helpersManager.Log.Information($"Hello from {context.Controller.ToString()}/{context.ActionDescriptor.DisplayName}");
            }
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.HttpContext.User?.Identity?.Name != null)
            {
                UserName = context.HttpContext.User.Identity.Name;
                _helpersManager.Log.Information($"Goodbye from {context.Controller.ToString()}/{context.ActionDescriptor.DisplayName}, User: {UserName}");
            }
            else
            {
                _helpersManager.Log.Information($"Goodbye from {context.Controller.ToString()}/{context.ActionDescriptor.DisplayName}");
            }
        }

        public static void Configure(IServiceCollection services) => services.AddScoped<RequestResponseFilter>();
        #endregion
    }
}
