using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class ErrandActorViewModel
    {
        public ErrandActorViewModel(ErrandActor actor)
        {
            Id = actor.Id;
            Name = actor.Name;
            ActorType = actor.ActorType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ActorType ActorType { get; set; }
    }
}
