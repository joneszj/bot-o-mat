using RedVentures.Bot_O_Mat.BLL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Interfaces
{
    public interface IGraveyardService
    {
        Task<IEnumerable<GraveyardDTO>> GetDestroyedActors();
    }
}
