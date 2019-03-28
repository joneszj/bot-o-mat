using RedVentures.Bot_O_Mat.API.Data.DbSets;
using System;
using System.Collections.Generic;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class GraveyardViewModel
    {
        public IEnumerable<GraveyardRecord> GraveyardRecords { get; set; }
    }
    public class GraveyardRecord
    {
        public GraveyardRecord(ErrandActor actor, ErrandActor killerActor)
        {
            Id = actor.Id;
            Name = actor.Name;
            DateFallen = actor.ModifiedDate;
            KilledBy = new ErrandActorViewModel(killerActor);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateFallen { get; set; }
        public ErrandActorViewModel KilledBy { get; set; }
    }
}
