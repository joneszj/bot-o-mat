using CommonPatterns.Helpers;
using Newtonsoft.Json;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.API.Models;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BotGenerator
{
    class ErrandGenerator
    {
        private readonly Random _random;
        private readonly HttpClient _httpClient;
        private RobotViewModel _robot;
        private CyborgViewModel _cyborg;
        private Array _errands;

        public ErrandGenerator(Random random, HttpClient httpClient)
        {
            _random = random;
            _httpClient = httpClient;
            _errands = Enum.GetValues(typeof(ErrandType));
        }

        public ErrandGenerator(RobotViewModel robotViewModel, Random random, HttpClient httpClient) : this(random, httpClient) => _robot = robotViewModel;

        public ErrandGenerator(CyborgViewModel cyborgViewModel, Random random, HttpClient httpClient) : this(random, httpClient) => _cyborg = cyborgViewModel;

        public async Task DoRandomThingsRobot()
        {
            var randomCount = _random.Next(_errands.Length);
            for (int i = 0; i < randomCount; i++)
            {
                var randomErrand = (ErrandType)_errands.GetValue(_random.Next(_errands.Length));
                await _httpClient.PostAsync("https://localhost:44308/api/errand", new StringContent(JsonConvert.SerializeObject(new PerformErrandViewModel { ActorId = _robot.Id, ErrandType = randomErrand }), Encoding.UTF8, ContentTypes.Json));
            }
        }

        public async Task DoRandomThingsCyborg()
        {
            var randomCount = _random.Next(_errands.Length);
            for (int i = 0; i < randomCount; i++)
            {
                var randomErrand = (ErrandType)_errands.GetValue(_random.Next(_errands.Length));
                await _httpClient.PostAsync("https://localhost:44308/api/errand", new StringContent(JsonConvert.SerializeObject(new PerformErrandViewModel { ActorId = _cyborg.Id, ErrandType = randomErrand }), Encoding.UTF8, ContentTypes.Json));
            }
        }
    }
}
