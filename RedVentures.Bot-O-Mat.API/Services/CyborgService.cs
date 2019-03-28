using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Services
{
    //TODO: we can refactor to use the base ErrandActor
    public class CyborgService : ICyborgService
    {
        #region constructor && private members
        private readonly BotOMatContext _botOMatContext;

        public CyborgService(BotOMatContext botOMatContext) => _botOMatContext = botOMatContext;
        #endregion

        #region public
        public async Task<Cyborg> CreateCyborg(string Name, Gender Gender)
        {
            var newCyborg = _botOMatContext.Cyborgs.Add(new Cyborg { Name = Name, Gender = Gender });
            await _botOMatContext.SaveChangesAsync();
            return newCyborg.Entity;
        }

        public async Task<Cyborg> ScrapCyborg(int Id)
        {
            var cyborg = await GetCyborg(Id);
            cyborg.Scrap();
            await _botOMatContext.SaveChangesAsync();
            return cyborg;
        }

        public async Task<Cyborg> GetCyborg(int Id) => await _botOMatContext.Cyborgs.FindAsync(Id);

        public async Task<IEnumerable<Cyborg>> GetCyborgsBy(string Name, Gender? Gender, int Skip = 0)
        {
            var filter = _botOMatContext.Cyborgs.AsQueryable();
            filter = FilterByName(Name, filter);
            filter = FilterByGender(Gender, filter);
            return await filter
                .OrderByDescending(cyborg => cyborg.Errands.Where(errand => errand.Status == ErrandStatus.Completed).Count())
                .Include(e => e.Errands)
                .Skip(Skip).Take(100)
                .ToListAsync();
        } 
        #endregion

        #region helpers
        private static IQueryable<Cyborg> FilterByGender(Gender? Gender, IQueryable<Cyborg> filter)
        {
            if (Gender != null) filter = filter.Where(e => e.Gender == Gender).AsQueryable();
            return filter;
        }

        private static IQueryable<Cyborg> FilterByName(string Name, IQueryable<Cyborg> filter)
        {
            if (!string.IsNullOrEmpty(Name)) filter = filter.Where(e => e.Name.Contains(Name)).AsQueryable();
            return filter;
        } 
        #endregion
    }
}
