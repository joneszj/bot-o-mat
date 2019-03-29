using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.BLL.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Interfaces
{
    public interface ICyborgService : IActorService
    {
        Task CreateCyborg(CyborgDTO cyborgViewModel);
        Task<IEnumerable<CyborgDTO>> GetCyborgsBy(string Name, Gender? Gender, int Skip = 0);
    }
}
