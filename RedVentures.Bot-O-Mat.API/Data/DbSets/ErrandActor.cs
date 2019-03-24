using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedVentures.Bot_O_Mat.API.Data.DbSets
{
    public abstract class ErrandActor : Base, ICanPerformErrand
    {
        [Required, MaxLength(50), MinLength(3)]
        public string Name { get; set; }
        public ICollection<Errand> Errands { get; set; }
        public ActorType ActorType { get; set; }
        //public ErrandActor KilledBy { get; set; }
        public int? KilledById { get; set; }
    }
}
