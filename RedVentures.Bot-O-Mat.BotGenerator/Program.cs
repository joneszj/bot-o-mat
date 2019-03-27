using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Collections.Generic;
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
                if (_random.Next(3) != 1) await Asynchronously(_random, _httpClient, _botGenerator);
                else InParallel(_random, _httpClient, _botGenerator);
            }
        }

        private static void InParallel(Random _random, HttpClient _httpClient, BotGenerator _botGenerator)
        {
            Parallel.For(_random.Next(0), 2, async (i) =>
            {
                if (_botGenerator.GetRandomActorType() == ActorType.Robot) await new ErrandGenerator(await _botGenerator.CreatRobot(), _random, _httpClient).DoRandomThingsRobot();
                else await new ErrandGenerator(await _botGenerator.CreatCyborg(), _random, _httpClient).DoRandomThingsCyborg();
            });
        }

        /// <summary>
        /// for some randomness lets randomly simulate an influx of bot creations by creating them inparallel
        /// </summary>
        /// <param name="_random"></param>
        /// <param name="_httpClient"></param>
        /// <param name="_botGenerator"></param>
        /// <returns></returns>
        private static async Task Asynchronously(Random _random, HttpClient _httpClient, BotGenerator _botGenerator)
        {
            var tasks = new List<Task>();
            for (int i = 0; i < _random.Next(2); i++)
            {
                if (_botGenerator.GetRandomActorType() == ActorType.Robot) tasks.Add(new ErrandGenerator(await _botGenerator.CreatRobot(), _random, _httpClient).DoRandomThingsRobot());
                else tasks.Add(new ErrandGenerator(await _botGenerator.CreatCyborg(), _random, _httpClient).DoRandomThingsCyborg());
            }
            await Task.WhenAll(tasks);
        }
    }
}
