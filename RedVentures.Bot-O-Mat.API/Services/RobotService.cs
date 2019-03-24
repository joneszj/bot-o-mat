using System.Collections.Generic;
using System.Linq;
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
        private readonly BotOMatContext _botOMatContext;
        private readonly IErrandService _errandService;

        public RobotService(BotOMatContext botOMatContext, IErrandService errandService)
        {
            _botOMatContext = botOMatContext;
            _errandService = errandService;
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
            var robot = await GetRobot(Id);
            robot.Scrap();
            await _botOMatContext.SaveChangesAsync();
        }

        public async Task<Robot> GetRobot(int Id) => await _botOMatContext.Robots.FindAsync(Id);

        public async Task<IEnumerable<Robot>> GetRobotsBy(string Name, RobotType? Type, int Skip = 0)
        {
            var filter = _botOMatContext.Robots.AsQueryable();
            if (!string.IsNullOrEmpty(Name)) filter = filter.Where(e => e.Name.Contains(Name)).AsQueryable();
            if (Type != null) filter = filter.Where(e => e.Type == Type).AsQueryable();
            return await filter
                .OrderByDescending(robot => robot.Errands.Where(errand => errand.Status == ErrandStatus.Completed).Count())
                .Include(e=>e.Errands)
                .Skip(Skip).Take(100)
                .ToListAsync();
        }

        /// <summary>
        /// Note: should errands be passed to robots to perform, or robots passed to an errand service to perform?
        /// because errands belong to (are composed in) robots, I felt it best to have an errand passed to the robot (ICanPerformErrand)
        /// </summary>
        /// <param name="errandType"></param>
        /// <returns></returns>
        public async Task<Robot> PerformErrand(Robot robot, ErrandType errandType)
        {
            await _errandService.PerformErrand(robot, errandType);
            return robot;
        }
    }
}
