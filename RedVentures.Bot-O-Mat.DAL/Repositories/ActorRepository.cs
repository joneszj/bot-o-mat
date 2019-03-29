using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.API.Data.DbSets;
using RedVentures.Bot_O_Mat.DAL.Interfaces;

namespace RedVentures.Bot_O_Mat.DAL.Repositories
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(BotOMatContext dbContext) : base(dbContext)
        {

        }
    }
}
