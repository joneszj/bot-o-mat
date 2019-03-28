using CommonPatterns.Helpers;
using RedVentures.Bot_O_Mat.Web.DTOs;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class AppViewModel
    {
        public AppViewModel(LeaderBoardViewModelDTO leaderBoardDto, KillBoardViewModelDTO killboardBoardDto, GraveYardViewModelDTO graveYardViewModelDto, HelpersManager helpersManager)
        {
            APINavLinkUrls = new APINavLinkUrls(helpersManager);
            LeaderBoardViewModel = new LeaderBoardViewModel(leaderBoardDto);
            KillBoardViewModel = new KillBoardViewModel(killboardBoardDto);
            GraveyardViewModel = new GraveyardViewModel(graveYardViewModelDto);
        }

        public LeaderBoardViewModel LeaderBoardViewModel { get; set; }
        public KillBoardViewModel KillBoardViewModel { get; set; }
        public GraveyardViewModel GraveyardViewModel { get; set; }
        public APINavLinkUrls APINavLinkUrls { get; set; }

    }

    public class APINavLinkUrls
    {
        public APINavLinkUrls(HelpersManager helpersManager)
        {
            HealthCheckUIAPI = helpersManager.EnvironmentHelper.Configuration.GetSection("API-URIs")["Base"] + "healthchecks-ui";
            SwaggerAPI = helpersManager.EnvironmentHelper.Configuration.GetSection("API-URIs")["Base"] + "swagger";
            WhoIsAPI = helpersManager.EnvironmentHelper.Configuration.GetSection("API-URIs")["Base"] + "whois";
            LogsAPI = helpersManager.EnvironmentHelper.Configuration.GetSection("API-URIs")["Base"] + "logs";
        }
        public string HealthCheckUIAPI { get; }
        public string SwaggerAPI { get; }
        public string WhoIsAPI { get; }
        public string LogsAPI { get; }
    }
}
