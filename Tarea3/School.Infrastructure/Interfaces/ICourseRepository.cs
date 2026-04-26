using School.Domain.Entities;

namespace School.Infrastructure.Interfaces;

public interface ICourseRepository
{
    Task<IEnumerable<Course>> GetCourses();
    Task Save(Course course); 
}