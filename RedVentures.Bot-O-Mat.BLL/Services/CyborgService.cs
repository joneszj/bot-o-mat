using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;
using RedVentures.Bot_O_Mat.BLL.DTOs;
using RedVentures.Bot_O_Mat.BLL.Interfaces;
using RedVentures.Bot_O_Mat.DAL.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.BLL.Services
{
    public class CyborgService : ActorService, ICyborgService
    {
        #region constructor && private members
        private readonly ICyborgRepository _cyborgRepository;
        public CyborgService(ICyborgRepository cyborgRepository, IActorRepository actorRepository) : base(actorRepository) => _cyborgRepository = cyborgRepository;
        #endregion

        #region public
        public async Task CreateCyborg(CyborgDTO errandActor) => await CreateActor(new CyborgDTO { Gender = errandActor.Gender, Name = errandActor.Name });

        public async Task<IEnumerable<CyborgDTO>> GetCyborgsBy(string Name, Gender? Gender, int Skip = 0)
        {
            var filter = _cyborgRepository.GetAll(ignorFilters: false);
            filter = FilterByName(Name, filter);
            filter = FilterByGender(Gender, filter);
            return await filter
                .OrderByDescending(cyborg => cyborg.Errands.Where(errand => errand.Status == ErrandStatus.Completed).Count())
                .Include(e => e.Errands)
                .Skip(Skip).Take(20)
                .Select(e=> new CyborgDTO { })
                //TODO: remove dependancy on EF in BLL
                .ToListAsync();
        } 
        #endregion

        #region helpers
        private static IQueryable<Cyborg> FilterByGender(Gender? Gender, IQueryable<Cyborg> filter)
        {
            if (Gender != null) filter = filter.Where(e => e.Gender == Gender);
            return filter;
        }

        private static IQueryable<Cyborg> FilterByName(string Name, IQueryable<Cyborg> filter)
        {
            if (!string.IsNullOrEmpty(Name)) filter = filter.Where(e => e.Name.Contains(Name));
            return filter;
        } 
        #endregion
    }
}
