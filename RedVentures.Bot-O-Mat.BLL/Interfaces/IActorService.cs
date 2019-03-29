using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.BLL.DTOs;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Interfaces
{
    public interface IActorService
    {
        Task CreateActor(ActorDTO errandActor);
        Task DestroyActor(int Id);
        Task<ActorDTO> GetActor(int Id);
    }
}