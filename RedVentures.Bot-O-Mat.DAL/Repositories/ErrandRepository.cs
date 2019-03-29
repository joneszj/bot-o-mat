using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.DAL.Interfaces;

namespace RedVentures.Bot_O_Mat.DAL.Repositories
{
    public class ErrandRepository : GenericRepository<Errand>, IErrandRepository
    {
        public ErrandRepository(BotOMatContext dbContext) : base(dbContext)
        {

        }
    }
}
