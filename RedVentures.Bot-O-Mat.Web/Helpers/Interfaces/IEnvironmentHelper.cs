using Microsoft.Extensions.Configuration;
using System;

namespace CommonPatterns.Helpers
{
    public interface IEnvironmentHelper
    {
        bool IsLocal { get; }
        bool IsProduction { get; }
        bool IsDevelopment { get; }
        Guid CorrelationId { get; }
        IConfiguration Configuration { get; }
    }
}