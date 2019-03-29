using Microsoft.EntityFrameworkCore;
using RedVentures.Bot_O_Mat.API.Data;
using RedVentures.Bot_O_Mat.DAL.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace RedVentures.Bot_O_Mat.DAL.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        public readonly BotOMatContext _dbContext;

        public GenericRepository(BotOMatContext dbContext) => _dbContext = dbContext;

        public IQueryable<TEntity> GetAll(bool ignoreFilters = false)
        {
            if (ignoreFilters) return _dbContext.Set<TEntity>().IgnoreQueryFilters().AsNoTracking();
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await _dbContext.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(int id, TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
