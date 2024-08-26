namespace StudentsAffairs.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationContext _context;
    private GenericRepository<Student>? _students;

    public UnitOfWork(ApplicationContext context)
    {
        _context = context;
    }
    public IGenericRepository<Student> Students
    {
        get { return _students ??= new GenericRepository<Student>(_context); }
    }

    public async Task<int> CompleteAsync() 
        => await _context.SaveChangesAsync();

    public void Dispose()
    {
        _context.Dispose();
    }
}
