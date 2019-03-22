using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;

namespace CommonPatterns.Helpers
{
    public interface IWhoIsHelper
    {
        Task<string> GetWhoIs(IHostingEnvironment host);
    }
}