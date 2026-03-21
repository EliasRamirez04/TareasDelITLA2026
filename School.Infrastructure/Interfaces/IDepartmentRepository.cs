using School.Domain.Entities;

namespace School.Infrastructure.Interfaces;

public interface IDepartmentRepository
{
    
    Task Save(Department department);
    Task<List<Department>> GetEntities();
}