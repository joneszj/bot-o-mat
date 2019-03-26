using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System;
using System.Linq;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class CyborgViewModel
    {
        public CyborgViewModel() { }
        public CyborgViewModel(Cyborg cyborg)
        {
            Id = cyborg.Id;
            Name = cyborg.Name;
            ActorType = Enum.GetName(typeof(ActorType), cyborg.ActorType);
            Gender = cyborg.Gender;
            Errands = cyborg.Errands?.Select(e => new ErrandViewModel(e)).ToArray();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ActorType { get; }
        public Gender Gender { get; set; }
        public ErrandViewModel[] Errands { get; set; }
    }
}