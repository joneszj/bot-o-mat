using CommonPatterns.Helpers;
using Microsoft.Extensions.Configuration;
using RedVentures.Bot_O_Mat.Web.DTOs;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class AppViewModel
    {
        public AppViewModel(LeaderBoardViewModelDTO leaderBoardDto, KillBoardViewModelDTO killboardBoardDto, GraveYardViewModelDTO graveYardViewModelDto, IConfiguration configuration)
        {
            APINavLinkUrls = new APINavLinkUrls(configuration);
            //APINavLinkUrls = new APINavLinkUrls(helpersManager);
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
        public APINavLinkUrls(IConfiguration configuration)
        {
            HealthCheckUIAPI = configuration.GetSection("API-URIs")["Base"] + "healthchecks-ui";
            SwaggerAPI = configuration.GetSection("API-URIs")["Base"] + "swagger";
            WhoIsAPI = configuration.GetSection("API-URIs")["Base"] + "whois";
            LogsAPI = configuration.GetSection("API-URIs")["Base"] + "logs";
        }

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
