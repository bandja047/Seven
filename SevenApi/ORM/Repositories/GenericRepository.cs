using Microsoft.EntityFrameworkCore;
using SevenApi.ContextDb;
using System.Linq.Expressions;

namespace SevenApi.ORM.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private readonly SevenContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(SevenContext context)
        {
             _context = context?? throw new ArgumentNullException(nameof(context));   
            _dbSet = _context.Set<TEntity>();
        }

        public virtual async Task AddAsync(TEntity entity )
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));

            await _dbSet.AddAsync(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<TEntity>GetByIdAsync(object id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            return await _dbSet.FindAsync(id);

        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            return await _dbSet.Where(predicate).ToListAsync();
        }

        public async Task<int> MaxAsync(Expression<Func<TEntity, int?>> predicate)
        {
            return await _dbSet.MaxAsync(predicate) ?? 0;
        }
        public async Task<TEntity> FindOneAsync(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            if(entity==null) throw new ArgumentNullException(nameof(entity));

            _dbSet.Update(entity);

           
                await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(Object id )
        {
            if (id == null) throw new ArgumentNullException(nameof(id));


            var entity = await GetByIdAsync(id);

            if (entity == null) return false;

            _dbSet.Remove(entity);

            
            int result =  await _context.SaveChangesAsync();

            return result > 0;
        }
    }
}
