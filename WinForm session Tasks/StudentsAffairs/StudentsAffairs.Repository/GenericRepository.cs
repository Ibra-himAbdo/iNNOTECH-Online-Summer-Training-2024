using System.Linq.Expressions;

namespace StudentsAffairs.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task DeleteAllAsync()
        {
            var entities = await _context.Set<T>().ToListAsync();
            _context.Set<T>().RemoveRange(entities);

        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity is not null) 
            {
                _context.Set<T>().Remove(entity);
            } 
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            return Task.CompletedTask;
        }

        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate) 
            => await _context.Set<T>().AnyAsync(predicate);
    }
}
