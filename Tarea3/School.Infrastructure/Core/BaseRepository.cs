using School.Infrastructure.Context;

namespace School.Infrastructure.Core;

public abstract class BaseRepository<TEntity> where TEntity : class
{
    protected readonly SchoolContext _context;

    protected BaseRepository(SchoolContext context)
    {
        _context = context;
    }
    
}