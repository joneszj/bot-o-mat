using RedVentures.Bot_O_Mat.API.Data.DbSets;
using System.Collections.Generic;

namespace RedVentures.Bot_O_Mat.API.Data
{
    /// <summary>
    /// we can use this interface to mark other entities as being able to perform errans, not just robots, perhaps cyborgs!
    /// </summary>
    public interface ICanPerformErrand
    {
        ICollection<Errand> Errands { get; set; }
    }
}