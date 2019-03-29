using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System.Collections.Generic;

namespace RedVentures.Bot_O_Mat.BLL.Interfaces
{
    /// <summary>
    /// we can use this interface to mark other entities as being able to perform errans, not just robots, perhaps cyborgs!
    /// </summary>
    public interface ICanPerformErrand
    {
        int Id { get; set; }
        ICollection<Errand> Errands { get; set; }
        ActorType ActorType { get; set; }
        string Name { get; set; }
    }
}