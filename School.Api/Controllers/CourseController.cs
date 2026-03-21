using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Domain.Entities;
using School.Infrastructure.Interfaces;

namespace School.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CourseController : ControllerBase
{
    private readonly ICourseRepository _repository;

    public CourseController(ICourseRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await _repository.GetCourses());

    [HttpPost]
    public async Task<IActionResult> Create(Course course)
    {
        
        await _repository.Save(course); 
        return Ok(new { message = "Curso creado con éxito", data = course });
    }
}