using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class CreateActorViewModel
    {
        public string Name { get; set; }
        public Gender? Gender { get; set; }
        public RobotType? RobotType { get; set; }
    }
}
