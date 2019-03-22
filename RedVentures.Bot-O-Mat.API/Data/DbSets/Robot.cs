using RedVentures.Bot_O_Mat.API.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace RedVentures.Bot_O_Mat.API.Data.DbSets
{
    public class Robot : Base
    {
        [Required, MaxLength(50), MinLength(3)]
        public string Name { get; set; }
        [Required]
        public RobotType Type { get; set; }
    }
}
