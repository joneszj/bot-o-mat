using System.Collections.Generic;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.BLL.Interfaces;

namespace RedVentures.Bot_O_Mat.BLL.DTOs
{
    public class ActorDTO : ICanPerformErrand
    {
        public int Id { get; set; }
        public ICollection<Errand> Errands { get; set; }
        public ActorType ActorType { get; set; }
        public string Name { get; set; }
    }
}