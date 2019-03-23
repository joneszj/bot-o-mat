using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System.Linq;

namespace RedVentures.Bot_O_Mat.API.Modles
{
    public class CyborgViewModel
    {
        public CyborgViewModel() { }
        public CyborgViewModel(Cyborg cyborg)
        {
            Name = cyborg.Name;
            Gender = cyborg.Gender;
            Errands = cyborg.Errands?.Select(e => new ErrandViewModel(e)).ToArray();
        }

        public string Name { get; set; }
        public Gender Gender { get; set; }
        public ErrandViewModel[] Errands { get; set; }
    }
}