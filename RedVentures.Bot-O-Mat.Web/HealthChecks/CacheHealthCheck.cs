using CommonPatterns.Helpers;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CommonPatterns.HealthChecks
{
    public class CacheHealthCheck : IHealthCheck
    {
        #region ctor && private
        private readonly ICacheHelper _cacheHelper;
        public CacheHealthCheck(ICacheHelper cacheHelper) => _cacheHelper = cacheHelper; 
        #endregion
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                var testGuid = Guid.NewGuid();
                _cacheHelper.Set(testGuid, "cached write test");
                _cacheHelper.TryGet<Guid, string>(testGuid, out bool IsFound);
                if (!IsFound) throw new Exception("cache failure");
                return Task.FromResult(HealthCheckResult.Healthy("Succesfully wrote and read from cache"));
            }
            catch (Exception ex)
            {
                return Task.FromResult(HealthCheckResult.Unhealthy("Failed to write or read from cache", ex));
            }
        }
    }
}
