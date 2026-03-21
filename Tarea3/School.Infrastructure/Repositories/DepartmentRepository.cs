using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using School.Infrastructure.Context;
using School.Infrastructure.Core;
using School.Infrastructure.Interfaces;

namespace School.Infrastructure.Repositories;

public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
{
    // El constructor pasa el context al BaseRepository
    public DepartmentRepository(SchoolContext context) : base(context)
    {
    }

    // Implementación del método Save
    public async Task Save(Department department)
    {
        await _context.Departments.AddAsync(department);
        await _context.SaveChangesAsync();
    }

    // Implementación del método GetEntities
    public async Task<List<Department>> GetEntities()
    {
        return await _context.Departments.ToListAsync();
    }
}
