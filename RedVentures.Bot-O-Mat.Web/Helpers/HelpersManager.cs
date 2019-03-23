using CommonPatterns.Helpers.Mocks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;

namespace CommonPatterns.Helpers
{
    /// <summary>
    /// Container for helper classes
    /// </summary>
    /// <example>
    /// <code>
    /// services.AddScoped<IEmailHelper>(service => new EmailHelper(Configuration));
    /// services.AddScoped<IEnvironmentHelper>(service => new EnvironmentHelper(Configuration["ASPNETCORE_ENVIRONMENT"]));
    /// services.AddScoped<IHttpHelper>(service => new HttpHelper(_serviceProvider.GetService<IHttpClientFactory>()));
    /// services.AddScoped<ILoggerWrapper>(service => new SeriLogger(Guid.NewGuid().ToString()));
    /// services.AddScoped<HelpersManager>();
    /// </code>
    /// </example>
    public class HelpersManager
    {
        #region ctor && private
        private static ServiceProvider _serviceProvider;
        public HelpersManager(IEmailHelper emailHelper, IEnvironmentHelper environmentHelper, IHttpHelper httpHelper, ILoggerWrapper loggerWrapper, ICacheHelper cacheHelper)
        {
            EmailHelper = emailHelper;
            EnvironmentHelper = environmentHelper;
            HttpHelper = httpHelper;
            Log = loggerWrapper;
            Cache = cacheHelper;
        }
        #endregion
        #region public
        public IEmailHelper EmailHelper;
        public IEnvironmentHelper EnvironmentHelper;
        public IHttpHelper HttpHelper;
        public ILoggerWrapper Log;
        public ICacheHelper Cache;

        public static void Configure(Guid correlationId, IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IEnvironmentHelper>(service => new EnvironmentHelper(correlationId, configuration));
            services.AddScoped<IEmailHelper>(service => new EmailHelperMock(configuration));
            services.AddSingleton<ICacheHelper>(service => new CacheHelper(_serviceProvider.GetService<IMemoryCache>()));
            services.AddScoped<IHttpHelper>(service => new HttpHelper(correlationId, _serviceProvider.GetService<IHttpClientFactory>()));
            _serviceProvider = services.BuildServiceProvider();
            services.AddScoped<ILoggerWrapper>(service => new SeriLogger(correlationId, _serviceProvider.GetService<IEmailHelper>(), _serviceProvider.GetService<IHttpHelper>(), configuration));
            services.AddScoped<HelpersManager>();
        }
        #endregion
    }
}
