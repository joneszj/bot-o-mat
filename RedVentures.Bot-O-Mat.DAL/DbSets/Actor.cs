using RedVentures.Bot_O_Mat.API.Data.Enums;
using System.Collections.Generic;

namespace RedVentures.Bot_O_Mat.API.Data.DbSets
{
    public class Actor : Base
    {
        public string Name { get; set; }
        public ICollection<Errand> Errands { get; set; }
        public ActorType ActorType { get; set; }
        public Actor DestroyedBy { get; set; }
        public int? DestroyedById { get; set; }
        public byte[] Image { get; set; }
    }
}
