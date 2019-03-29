using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.BLL.DTOs;
using RedVentures.Bot_O_Mat.BLL.Interfaces;
using RedVentures.Bot_O_Mat.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Services
{
    public class GraveyardService : IGraveyardService
    {
        #region ctor && private
        private readonly IActorRepository _actorRepository;
        public GraveyardService(IActorRepository actorRepository) => _actorRepository = actorRepository;
        #endregion

        public async Task<IEnumerable<GraveyardDTO>> GetDestroyedActors()
        {
            return await _actorRepository.GetAll(ignorFilters: true).Where(e => e.DestroyedById != null).Select(e => new GraveyardDTO
            {
                DestroyedActor = new ActorDTO { },
                DestroyedByActor = new ActorDTO { }
            }).ToListAsync();
        }
    }
}
