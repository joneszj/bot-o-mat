using System.Linq;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Modles
{
    public class RobotViewModel
    {
        public RobotViewModel()
        {

        }
        public RobotViewModel(Robot robot)
        {
            Name = robot.Name;
            Errands = robot.Errands?.Select(e => new ErrandViewModel(e)).ToArray();
        }

        public string Name { get; set; }
        public RobotType Type { get; set; }
        public ErrandViewModel[] Errands { get; set; }
    }
}
