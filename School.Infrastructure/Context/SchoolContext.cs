using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;

namespace School.Infrastructure.Context;

public class SchoolContext : DbContext
{
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Department> Departments { get; set; } = null!;
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Instructor> Instructors { get; set; } = null!;
}