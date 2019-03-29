using System;
using System.Collections.Generic;

namespace RedVentures.Bot_O_Mat.Web.DTOs
{
    public class GraveYardViewModelDTO
    {
        public IEnumerable<GraveYardRecord> GraveYardRecords { get; set; }
    }
    public class GraveYardRecord
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateFallen { get; set; }
        public ErrandActorViewModelDTO KilledBy { get; set; }
    }
}
