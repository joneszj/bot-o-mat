﻿using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public interface IRobotService
    {
        Task<Robot> CreateRobot(string Name, RobotType robotType);
        Task<Robot> GetRobot(int Id);
        Task<IEnumerable<Robot>> GetRobotsBy(string Name, RobotType? Type, int Skip = 0);
        Task<Robot> ScrapRobot(int Id);
    }
}
