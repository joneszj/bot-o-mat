using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BotGenerator
{
    /// <summary>
    /// intention: simulate other users and/or rogue bots
    /// botGenerator creates a bot and passes to errand generator to create random errands for created bot via the api layer to ensure signalr notifications
    /// </summary>
    class Program
    {
        static async Task Main(string[] args)
        {
            var _random = new Random();
            var _httpClient = new HttpClient();
            var _botGenerator = new BotGenerator(_random, _httpClient);
            while (true)
            {
                Thread.Sleep(_random.Next(5_000, 20_000));
                Parallel.For(_random.Next(0), 2, async (i) =>
                {
                    if (_botGenerator.GetRandomActorType() == ActorType.Robot) await new ErrandGenerator(await _botGenerator.CreatRobot(), _random, _httpClient).DoRandomThingsRobot();
                    else await new ErrandGenerator(await _botGenerator.CreatCyborg(), _random, _httpClient).DoRandomThingsCyborg();
                });
            }
        }
    }
}
