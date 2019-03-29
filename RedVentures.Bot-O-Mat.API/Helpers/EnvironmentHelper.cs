using Microsoft.Extensions.Configuration;
using System;

namespace CommonPatterns.Helpers
{
    /// <summary>
    /// Environment helper methods. Useful for identifying current executing environment.
    /// </summary>
    public class EnvironmentHelper : IEnvironmentHelper
    {
        #region ctor
        public EnvironmentHelper(Guid correlationId, IConfiguration configuration)
        {
            Configuration = configuration;
            IsProduction = Configuration["ASPNETCORE_ENVIRONMENT"].ToLower() == "production";
            IsLocal = Configuration["ASPNETCORE_ENVIRONMENT"].ToLower() == "local";
            IsDevelopment = Configuration["ASPNETCORE_ENVIRONMENT"].ToLower() == "development";
            CorrelationId = correlationId;
        }
        #endregion
        #region public
        public bool IsProduction { get; }
        public bool IsLocal { get; }
        public bool IsDevelopment { get; }
        public Guid CorrelationId { get; }
        public IConfiguration Configuration { get; }
        #endregion
    }
}