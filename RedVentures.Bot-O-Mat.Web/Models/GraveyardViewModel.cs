using RedVentures.Bot_O_Mat.Web.DTOs;
using System;

namespace RedVentures.Bot_O_Mat.Web.Models
{
    public class GraveyardViewModel
    {
        public GraveyardViewModel(GraveYardRecord graveYardRecord)
        {
            Id = graveYardRecord.Id;
            Name = graveYardRecord.Name;
            DeathDate = graveYardRecord.DateFallen;
            KilledById = graveYardRecord.KilledBy.Id;
            KilledByName = graveYardRecord.KilledBy.Name;
            KilledByType = graveYardRecord.KilledBy.ActorType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DeathDate { get; set; }
        public string KilledByName { get; set; }
        public int KilledById { get; set; }
        public string KilledByType { get; set; }
    }
}