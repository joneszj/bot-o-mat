using RedVentures.Bot_O_Mat.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Models
{
    public class PerformErrandResult
    {
        public ICanPerformErrand PerformingActor { get; set; }
        public ICanPerformErrand TerminatedActor { get; set; }
    }
}
