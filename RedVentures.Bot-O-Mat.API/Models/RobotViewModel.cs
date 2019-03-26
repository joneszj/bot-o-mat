using System;
using System.Linq;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class RobotViewModel
    {
        public RobotViewModel() { }
        public RobotViewModel(Robot robot)
        {
            Id = robot.Id;
            Name = robot.Name;
            Type = robot.Type;
            ActorType = Enum.GetName(typeof(ActorType), robot.ActorType);
            Errands = robot.Errands?.Select(e => new ErrandViewModel(e)).ToArray();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public RobotType Type { get; set; }
        public string ActorType { get; }
        public ErrandViewModel[] Errands { get; set; }
    }
}
