using Newtonsoft.Json;
using RedVentures.Bot_O_Mat.Web.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.Web.Services
{
    public class LeaderBoardService
    {
        private readonly HttpClient _httpClient;

        public LeaderBoardService(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        public async Task<LeaderBoard> GetLeaderBoardRecords()
        {
            var response = await _httpClient.GetStringAsync("https://localhost:44308/api/robot");
            var robots = JsonConvert.DeserializeObject<RobotViewModel[]>(response);
            return new LeaderBoard { RobotViewModels = robots };
        }
    }
}
