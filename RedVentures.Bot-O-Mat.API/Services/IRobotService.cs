using RedVentures.Bot_O_Mat.API.Data.DbSets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Services
{
    interface IRobotService
    {
        Task<Robot> GetRobot();
        Task<IEnumerable<Robot>> GetRobots();
        Task<Robot> UpdateRobot();
        Task DeleteRobot(int Id);
    }
}
