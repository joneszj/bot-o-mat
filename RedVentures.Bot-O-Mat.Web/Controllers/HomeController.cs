using System.Diagnostics;
using System.Threading.Tasks;
using CommonPatterns.Filters;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.Web.DTOs;
using RedVentures.Bot_O_Mat.Web.Models;

namespace RedVentures.Bot_O_Mat.Web.Controllers
{
    [ServiceFilter(typeof(ExceptionFilter))]
    [ServiceFilter(typeof(RequestResponseFilter))]
    public class HomeController : Controller
    {
        private readonly HelpersManager _helpersManager;

        public HomeController(HelpersManager helpersManager)
        {
            _helpersManager = helpersManager;
        }

        public async Task<ActionResult<AppViewModel>> Index()
        {
            var leaderBoardDto = await _helpersManager.HttpHelper
                .Get<LeaderBoardViewModelDTO>($"{ _helpersManager.EnvironmentHelper.Configuration.GetSection("API-URIs")["StatisticsAPI"]}/LeaderBoard");
            var killboardBoardDto = await _helpersManager.HttpHelper
                .Get<KillBoardViewModelDTO>($"{ _helpersManager.EnvironmentHelper.Configuration.GetSection("API-URIs")["StatisticsAPI"]}/KillBoard");
            var graveYardViewModelDTO = await _helpersManager.HttpHelper
                .Get<GraveYardViewModelDTO>($"{ _helpersManager.EnvironmentHelper.Configuration.GetSection("API-URIs")["StatisticsAPI"]}/Graveyard");
            return View(new AppViewModel(leaderBoardDto, killboardBoardDto, graveYardViewModelDTO, _helpersManager));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
