using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public class RobotService : IRobotService
    {
        #region constructor && private members
        private BotOMatContext _botOMatContext;
        private Random _randomGenerator;

        public RobotService(BotOMatContext botOMatContext)
        {
            _botOMatContext = botOMatContext;
            _randomGenerator = new Random();
        } 
        #endregion

        public async Task<Robot> CreateRobot(string Name, RobotType robotType)
        {
            var newRobot = _botOMatContext.Robots.Add(new Robot { Name = Name, Type = robotType });
            await _botOMatContext.SaveChangesAsync();
            return newRobot.Entity;
        }

        public async Task ScrapRobot(int Id)
        {
            var robot = await _botOMatContext.Robots.FindAsync(Id);
            robot.Scrap();
            await _botOMatContext.SaveChangesAsync();
        }

        public async Task<Robot> GetRobot(int Id)
        {
            return await _botOMatContext.Robots.FindAsync(Id);
        }

        public async Task<IEnumerable<Robot>> GetRobotsBy(string Name, RobotType? Type, int Skip = 0)
        {
            var filter = _botOMatContext.Robots.AsQueryable();
            if (!string.IsNullOrEmpty(Name)) filter = filter.Where(e => e.Name.Contains(Name)).AsQueryable();
            if (Type != null) filter = filter.Where(e => e.Type == Type).AsQueryable();
            return await filter.Skip(Skip).Take(100).ToListAsync();
        }

        /// <summary>
        /// Note: should errands be passed to robots to perform, or robots passed to an errand service to perform?
        /// because errands belong to (are composed in) robots, I felt it best to have an errand passed to the robot (ICanPerformErrand)
        /// </summary>
        /// <param name="errandType"></param>
        /// <returns></returns>
        public async Task<Robot> PerformErrand(Robot robot, ErrandType errandType)
        {
            var errand = new Errand(robot, errandType);
            errand.Status = ErrandStatus.In_Progress;

            //TODO: calculate weighted augmentation preferences on robot type
            foreach (var item in Enumerable.Range(0, (int)robot.Type))
            {
                Thread.Sleep((int)errandType / (int)robot.Type);
                //TODO: add chance to fail (perhaps on robot type?)
                if (_randomGenerator.Next(100) < 10)
                {
                    //robot destroyed the errand task!!!!
                    errand.Status = ErrandStatus.Failed;
                    break;
                }
            }

            if (errand.Status != ErrandStatus.Failed) errand.Status = ErrandStatus.Completed;
            await _botOMatContext.SaveChangesAsync();
            return robot;
        }
    }
}
