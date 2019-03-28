using Microsoft.Extensions.Configuration;
using System;

namespace CommonPatterns.Helpers
{
    /// <summary>
    /// Environment helper methods. Useful for identifying current executing environment.
    /// </summary>
    public class EnvironmentHelperMock : IEnvironmentHelper
    {
        public bool IsLocal { get; }

        public bool IsProduction { get; }

        public bool IsDevelopment { get; }

        public Guid CorrelationId { get; }

        public IConfiguration Configuration { get; }
    }
}