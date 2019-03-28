using CommonPatterns.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommonPatterns.Helpers.Mocks
{
    public class EnvironmentHelperMock : IEnvironmentHelper
    {
        public bool IsLocal { get; }

        public bool IsProduction { get; }

        public bool IsDevelopment { get; }

        public Guid CorrelationId { get; }

        public IConfiguration Configuration { get; }
    }
}
