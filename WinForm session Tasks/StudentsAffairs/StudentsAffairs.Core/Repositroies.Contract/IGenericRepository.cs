namespace StudentsAffairs.Core.Repositroies.Contract;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<IReadOnlyList<T>> GetAllAsync();

    Task<T?> GetAsync(int id);

    Task AddAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(int id);
    Task DeleteAllAsync();
}