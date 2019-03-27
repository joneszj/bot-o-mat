using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public interface ICyborgService
    {
        Task<Cyborg> CreateCyborg(string Name, Gender Gender);
        Task<Cyborg> GetCyborg(int Id);
        Task<IEnumerable<Cyborg>> GetCyborgsBy(string Name, Gender? Gender, int Skip = 0);
        Task<Cyborg> ScrapCyborg(int Id);
    }
}
