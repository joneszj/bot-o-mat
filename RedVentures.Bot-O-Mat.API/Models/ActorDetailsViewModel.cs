using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Linq;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class ActorDetailsViewModel
    {
        public ActorDetailsViewModel() { }
        public ActorDetailsViewModel(Actor errandActor)
        {
            Id = errandActor.Id;
            if (errandActor.Image != null) Image = Convert.ToBase64String(errandActor.Image);
            Name = errandActor.Name;
            Active = errandActor.IsActive;
            CreatedDate = errandActor.CreatedDate.ToShortDateString();
            ModifiedDate = errandActor.ModifiedDate.ToShortDateString();
            KilledById = errandActor.DestroyedById;
            CompletedErrands = errandActor.Errands.Where(e => e.Status == ErrandStatus.Completed).Select(e => new ErrandViewModel(e)).ToArray();
            FailedErrands = errandActor.Errands.Where(e => e.Status == ErrandStatus.Failed).Select(e => new ErrandViewModel(e)).ToArray();
            Type = Enum.GetName(typeof(ActorType), errandActor.ActorType);
        }

        public int Id { get; }
        public string Image { get; }
        public string Name { get; }
        public bool Active { get; }
        public string CreatedDate { get; }
        public string ModifiedDate { get; }
        public int? KilledById { get; }
        public ErrandViewModel[] CompletedErrands { get; }
        public ErrandViewModel[] FailedErrands { get; }
        public string Type { get; }
    }
}
