using School.Domain.Entities;
using School.Infrastructure.Context;
using School.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace School.Infrastructure.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly SchoolContext _context;

    public CourseRepository(SchoolContext context)
    {
        _context = context;
    }

    
    public async Task<IEnumerable<Course>> GetCourses()
    {
        return await _context.Courses.ToListAsync();
    }

    
    public async Task Save(Course course)
    {
        _context.Courses.Add(course);
        await _context.SaveChangesAsync();
    }
}