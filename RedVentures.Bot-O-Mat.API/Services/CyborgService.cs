using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.API.Data.Enums;

namespace RedVentures.Bot_O_Mat.API.Services
{
    public class CyborgService : ICyborgService
    {
        #region constructor && private members
        private readonly BotOMatContext _botOMatContext;
        private readonly IErrandService _errandService;

        public CyborgService(BotOMatContext botOMatContext, IErrandService errandService)
        {
            _botOMatContext = botOMatContext;
            _errandService = errandService;
        }
        #endregion

        public async Task<Cyborg> CreateCyborg(string Name, Gender Gender)
        {
            var newCyborg = _botOMatContext.Cyborgs.Add(new Cyborg { Name = Name, Gender = Gender });
            await _botOMatContext.SaveChangesAsync();
            return newCyborg.Entity;
        }

        public async Task ScrapCyborg(int Id)
        {
            var cyborg = await GetCyborg(Id);
            cyborg.Scrap();
            await _botOMatContext.SaveChangesAsync();
        }

        public async Task<Cyborg> GetCyborg(int Id) => await _botOMatContext.Cyborgs.FindAsync(Id);

        public async Task<IEnumerable<Cyborg>> GetCyborgsBy(string Name, Gender? Gender, int Skip = 0)
        {
            var filter = _botOMatContext.Cyborgs.AsQueryable();
            if (!string.IsNullOrEmpty(Name)) filter = filter.Where(e => e.Name.Contains(Name)).AsQueryable();
            if (Gender != null) filter = filter.Where(e => e.Gender == Gender).AsQueryable();
            return await filter
                .OrderByDescending(cyborg => cyborg.Errands.Where(errand => errand.Status == ErrandStatus.Completed).Count())
                .Skip(Skip).Take(100)
                .ToListAsync();
        }

        public async Task<Cyborg> PerformErrand(Cyborg cyborg, ErrandType errandType)
        {
            await _errandService.PerformErrand(cyborg, errandType);
            return cyborg;
        }
    }
}
