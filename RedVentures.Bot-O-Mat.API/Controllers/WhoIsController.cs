using System.Threading.Tasks;
using CommonPatterns.Filters;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace CommonPatterns.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    [Route("[controller]")]
    [ApiController]
    public class WhoIsController : ControllerBase
    {
        private IWhoIsHelper _whoIsHelper;
        private readonly IHostingEnvironment _hostingEnvironment;

        public WhoIsController(IWhoIsHelper whoIsHelper, IHostingEnvironment hostingEnvironment)
        {
            _whoIsHelper = whoIsHelper;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public async Task<ActionResult<WhoIsModel>> Index()
        {
            return Ok(await _whoIsHelper.GetWhoIs(_hostingEnvironment));
        }
    }
}