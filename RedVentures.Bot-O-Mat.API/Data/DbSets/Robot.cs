using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedVentures.Bot_O_Mat.API.Data.DbSets
{
    public class Robot : Base, ICanPerformErrand
    {
        [Required, MaxLength(50), MinLength(3)]
        public string Name { get; set; }
        [Required]
        public RobotType Type { get; set; }
        public ICollection<Errand> Errands { get; set; }

        public Robot Scrap()
        {
            IsActive = false;
            ModifiedDate = DateTime.Now;

            return this;
        }
    }
}
