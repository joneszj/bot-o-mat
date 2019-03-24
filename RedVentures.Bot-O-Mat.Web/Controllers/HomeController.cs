using System.Diagnostics;
using System.Threading.Tasks;
using CommonPatterns.Helpers;
using Microsoft.AspNetCore.Mvc;
using RedVentures.Bot_O_Mat.Web.DTOs;
using RedVentures.Bot_O_Mat.Web.Models;

namespace RedVentures.Bot_O_Mat.Web.Controllers
{
    public class HomeController : Controller
    {
        private HelpersManager _helpersManager;

        public HomeController(HelpersManager helpersManager)
        {
            _helpersManager = helpersManager;
        }

        public async Task<ActionResult<AppViewModel>> Index()
        {
            var leaderBoardDto = await _helpersManager.HttpHelper.Get<LeaderBoardViewModelDTO>(_helpersManager.EnvironmentHelper.Configuration.GetSection("API-URIs")["LeaderboardAPI"]);
            return View(new AppViewModel(leaderBoardDto));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
