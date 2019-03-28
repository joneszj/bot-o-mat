using System.Diagnostics;
using System.Net.Http;
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
        #region ctor && private
        private readonly HttpClient _httpClient;
        private readonly HelpersManager _helpersManager;

        public HomeController(HelpersManager helpersManager, IHttpClientFactory httpClientFactory)
        {
            _helpersManager = helpersManager;
            _httpClient = httpClientFactory.CreateClient();
        } 
        #endregion

        public async Task<ActionResult<AppViewModel>> Index()
        {
            #region Task.WhenAll leaderBoard, killBoard, graveyard
            var leaderBoardRequest = _httpClient.GetAsync($"{ _helpersManager.EnvironmentHelper.Configuration.GetSection("API-URIs")["StatisticsAPI"]}/LeaderBoard");
            var killBoardRequest = _httpClient.GetAsync($"{ _helpersManager.EnvironmentHelper.Configuration.GetSection("API-URIs")["StatisticsAPI"]}/KillBoard");
            var graveyardRequest = _httpClient.GetAsync($"{ _helpersManager.EnvironmentHelper.Configuration.GetSection("API-URIs")["StatisticsAPI"]}/Graveyard");
            await Task.WhenAll(leaderBoardRequest, killBoardRequest, graveyardRequest);
            var leaderBoardResponse = await leaderBoardRequest;
            var killboardBoardResponse = await killBoardRequest;
            var graveyardResponse = await graveyardRequest; 
            #endregion

            return View(new AppViewModel(await leaderBoardResponse.Content.ReadAsAsync<LeaderBoardViewModelDTO>(),
                await killboardBoardResponse.Content.ReadAsAsync<KillBoardViewModelDTO>(),
                await graveyardResponse.Content.ReadAsAsync<GraveYardViewModelDTO>(), 
                _helpersManager));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
