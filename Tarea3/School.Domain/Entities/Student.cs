using School.Domain.Core;

namespace School.Domain.Entities;

public class Student : Person
{
    public DateTime EnrollmentDate { get; set; }
}