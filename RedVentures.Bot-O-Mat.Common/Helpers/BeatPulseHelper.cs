using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CommonPatterns.Helpers
{
    /// <summary>
    /// Beatpulse https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks
    /// note settings in appsettings
    /// useful for system/app monitoring, webhooks as well as a healcheck ui
    /// </summary>
    /// Install-Package BeatPulse
    /// Install-Package AspNetCore.HealthChecks.System (Disk Storage, Memory)
    /// Install-Package AspNetCore.HealthChecks.Network (Tcp, Ftp, Sftp, Imap, Smtp, Dns resolve)
    /// Install-Package AspNetCore.HealthChecks.SqlServer
    /// Install-Package AspNetCore.HealthChecks.Sqlite
    /// Install-Package AspNetCore.HealthChecks.UI
    public class BeatPulseHelper
    {
        #region public
        /// <example>https://github.com/aspnet/Docs/tree/master/aspnetcore/host-and-deploy/health-checks/samples/2.x/HealthChecksSample</example>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void Configure(IServiceCollection services, IConfiguration configuration)
        {
            services.AddHealthChecksUI();

            var uri = new Uri(configuration["HealthChecks-UI:HealthChecks:0:Uri"]);
            services.AddHealthChecks()  
                .AddTcpHealthCheck(e => e.AddHost(uri.Host, uri.Port))
                .AddPingHealthCheck(e => e.AddHost(uri.Host, uri.Port));
        }

        public static void Setup(IApplicationBuilder app)
        {
            /// ~/healthchecks-ui
            /// ~/healthchecks-api
            app.UseHealthChecksUI();
            app.UseHealthChecks("/healthz", new HealthCheckOptions()
            {
                Predicate = _ => true,
                ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });
        } 
        #endregion
    }
}
