namespace StudentsAffairs.Core.Repositroies.Contract;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Student> Students { get; }
    Task<int> CompleteAsync();
}
