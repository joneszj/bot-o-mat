using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Interfaces
{
    public interface IRobotService
    {
        Task<IEnumerable<Robot>> GetRobotsBy(string Name, RobotType? Type, int Skip = 0);
    }
}
