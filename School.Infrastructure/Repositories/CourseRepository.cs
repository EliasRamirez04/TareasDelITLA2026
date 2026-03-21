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

    // ERROR 1 SOLUCIONADO: Implementamos GetCourses que faltaba
    public async Task<IEnumerable<Course>> GetCourses()
    {
        return await _context.Courses.ToListAsync();
    }

    // ERROR 2 SOLUCIONADO: Corregimos las llaves del método Save
    public async Task Save(Course course)
    {
        _context.Courses.Add(course);
        await _context.SaveChangesAsync();
    }
}