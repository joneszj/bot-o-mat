using CommonPatterns.HealthChecks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace CommonPatterns.Helpers
{
    /// <summary>
    /// Custom HealthCheck ResponseWriter
    /// </summary>
    public class HealthCheckHelper
    {
        #region public
        public static void Configure(IServiceCollection services)
        {
            services.AddHealthChecks()
                .AddCheck<LoggerHealthCheck>("logger wrapper")
                .AddCheck<CacheHealthCheck>("cache helper");
        }

        public static void Setup(IApplicationBuilder app) => app.UseHealthChecks("/health-custom-response", new HealthCheckOptions { ResponseWriter = WriteResponse });
        #endregion
        #region helpers
        /// <summary>
        /// Format HealthCheck Response https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/health-checks?view=aspnetcore-2.2#customize-output
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="reports"></param>
        /// <returns></returns>
        private static Task WriteResponse(HttpContext httpContext, HealthReport reports)
        {
            httpContext.Response.ContentType = ContentTypes.Json;

            var reportsJson = new
            {
                status = reports.Status.ToString(),
                results = reports.Entries.Select(report => new
                {
                    description = report.Value.Description,
                    status = report.Value.Status.ToString(),
                    exception = report.Value.Exception?.Message ?? string.Empty,
                    data = report.Value.Data.Select(e=> new { key = e.Key, value = e.Value })
                })
            };

            return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(reportsJson, Formatting.Indented));
        }
        #endregion
    }
}
