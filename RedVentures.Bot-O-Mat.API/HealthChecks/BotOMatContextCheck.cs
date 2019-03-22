using Microsoft.Extensions.Diagnostics.HealthChecks;
using RedVentures.Bot_O_Mat.API.Data;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CommonPatterns.HealthChecks
{
    /// <summary>
    /// Replace DbContext with instance DbContext
    /// </summary>
    public class BotOMatContextCheck : IHealthCheck
    {
        private BotOMatContext _context;

        public BotOMatContextCheck(BotOMatContext Context) => _context = Context;

        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                var check = _context.Database.CanConnect();
                return await Task.FromResult(HealthCheckResult.Healthy("Can connect to bot-o-mat context"));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(HealthCheckResult.Unhealthy("Cannot connect to bot-o-mat context", ex));
            }
        }
    }
}
