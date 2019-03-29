using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.BLL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Services
{
    public class RobotService : ActorService, IRobotService
    {
        #region constructor && private members
        private readonly BotOMatContext _botOMatContext;
        public RobotService(BotOMatContext botOMatContext) => _botOMatContext = botOMatContext;
        #endregion

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
