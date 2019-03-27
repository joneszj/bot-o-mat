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
    class BotGenerator
    {
        private readonly Random _random;
        private readonly HttpClient _httpClient;
        private Array _actorTypes;

        public BotGenerator(Random random, HttpClient httpClient)
        {
            _random = random;
            _httpClient = httpClient;
        }

        public ActorType GetRandomActorType()
        {
            _actorTypes = Enum.GetValues(typeof(ActorType));
            return (ActorType)_actorTypes.GetValue(_random.Next(_actorTypes.Length));
        }

        public async Task<RobotViewModel> CreatRobot()
        {
            var robotTypes = Enum.GetValues(typeof(RobotType));
            var randomRobotType = (RobotType)robotTypes.GetValue(_random.Next(robotTypes.Length));

            var response = await _httpClient.PostAsync("https://localhost:44308/api/robot", new StringContent(JsonConvert.SerializeObject(new RobotViewModel { Name = Faker.Name.FullName(), Type = randomRobotType }), Encoding.UTF8, ContentTypes.Json));
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<RobotViewModel>(data);
        }

        public async Task<CyborgViewModel> CreatCyborg()
        {
            var genderTypes = Enum.GetValues(typeof(Gender));
            var randomGenderType = (Gender)genderTypes.GetValue(_random.Next(genderTypes.Length));

            var response = await _httpClient.PostAsync("https://localhost:44308/api/cyborg", new StringContent(JsonConvert.SerializeObject(new CyborgViewModel { Name = Faker.Name.FullName(), Gender = randomGenderType }), Encoding.UTF8, ContentTypes.Json));
            var data = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<CyborgViewModel>(data);
        }
    }
}
