using School.Domain.Core;

namespace School.Domain.Entities;

public class Instructor : Person
{
    public DateTime HireDate { get; set; }
}