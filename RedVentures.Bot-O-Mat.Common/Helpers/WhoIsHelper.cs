using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CommonPatterns.Helpers
{
    public class WhoIsHelper : IWhoIsHelper
    {
        #region public
        public async Task<string> GetWhoIs(IHostingEnvironment host)
        {
            var ipAddresses = await Dns.GetHostAddressesAsync(Dns.GetHostName());
            return JsonConvert.SerializeObject(new WhoIsModel
            {
                ApplicationName = host.ApplicationName,
                ContentRootPath = host.ContentRootPath,
                EnvironmentName = host.EnvironmentName,
                HostName = Dns.GetHostName(),
                IPAddresses = ipAddresses.Select(e => e.ToString())
            }, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        public static void Configure(IServiceCollection services) => services.AddSingleton<IWhoIsHelper>(e => new WhoIsHelper());
        #endregion
    }

    public class WhoIsModel
    {
        public string ApplicationName { get; set; }
        public string HostName { get; set; }
        public string EnvironmentName { get; set; }
        public string ContentRootPath { get; set; }
        public IEnumerable<string> IPAddresses { get; set; }
    }
}
