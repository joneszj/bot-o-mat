using CommonPatterns.Helpers;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CommonPatterns.HealthChecks
{
    public class LoggerHealthCheck : IHealthCheck
    {
        #region ctor && private
        private readonly ILoggerWrapper _logger;
        public LoggerHealthCheck(ILoggerWrapper logger) => _logger = logger; 
        #endregion
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.Information($"HealthCheck {DateTime.Now}");
                return Task.FromResult(HealthCheckResult.Healthy("Succesfully wrote to console and file log"));
            }
            catch (Exception ex)
            {
                return Task.FromResult(HealthCheckResult.Unhealthy("Failed to write log", ex));
            }
        }
    }
}
