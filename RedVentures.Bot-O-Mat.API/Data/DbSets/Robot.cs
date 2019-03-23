using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedVentures.Bot_O_Mat.API.Data.DbSets
{
    public class Robot : ErrandActor
    {
        [Required]
        public RobotType Type { get; set; }

        public Robot Scrap()
        {
            IsActive = false;
            ModifiedDate = DateTime.Now;

            return this;
        }
    }
}
