using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Services
{
    //TODO: we can refactor to use the base ErrandActor
    public class RobotService : IRobotService
    {
        #region constructor && private members
        private readonly BotOMatContext _botOMatContext;
        public RobotService(BotOMatContext botOMatContext) => _botOMatContext = botOMatContext;
        #endregion

        public async Task<Robot> CreateRobot(string Name, RobotType robotType)
        {
            var newRobot = _botOMatContext.Robots.Add(new Robot { Name = Name, Type = robotType });
            await _botOMatContext.SaveChangesAsync();
            return newRobot.Entity;
        }

        public async Task<Robot> ScrapRobot(int Id)
        {
            var robot = await GetRobot(Id);
            robot.Scrap();
            await _botOMatContext.SaveChangesAsync();
            return robot;
        }

        public async Task<Robot> GetRobot(int Id) => await _botOMatContext.Robots.FirstOrDefaultAsync(e=>e.Id == Id);

        public async Task<IEnumerable<Robot>> GetRobotsBy(string Name, RobotType? Type, int Skip = 0)
        {
            var filter = _botOMatContext.Robots.AsQueryable();
            filter = FilterByName(Name, filter);
            filter = FilterByType(Type, filter);
            return await filter
                .OrderByDescending(robot => robot.Errands.Where(errand => errand.Status == ErrandStatus.Completed).Count())
                .Include(e => e.Errands)
                .Skip(Skip).Take(20)
                .ToListAsync();
        }

        #region helpers
        private static IQueryable<Robot> FilterByType(RobotType? Type, IQueryable<Robot> filter)
        {
            if (Type != null) filter = filter.Where(e => e.Type == Type).AsQueryable();
            return filter;
        }

        private static IQueryable<Robot> FilterByName(string Name, IQueryable<Robot> filter)
        {
            if (!string.IsNullOrEmpty(Name)) filter = filter.Where(e => e.Name.Contains(Name)).AsQueryable();
            return filter;
        } 
        #endregion
    }
}
