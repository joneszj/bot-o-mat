using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.BLL.DTOs;
using RedVentures.Bot_O_Mat.BLL.Interfaces;
using RedVentures.Bot_O_Mat.DAL.Interfaces;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Services
{
    public class ActorService : IActorService
    {
        #region constructor && private members
        private readonly IActorRepository _actorRepository;
        public ActorService(IActorRepository actorRepository) => _actorRepository = actorRepository;
        #endregion
        public async Task CreateActor(ActorDTO errandActor) => await _actorRepository.Create(new Actor { });

        public async Task DestroyActor(int Id) => await _actorRepository.Delete(Id);

        public async Task<ActorDTO> GetActor(int Id)
        {
            var actor = await _actorRepository.GetById(Id);
            return new ActorDTO();
        }
    }
}
