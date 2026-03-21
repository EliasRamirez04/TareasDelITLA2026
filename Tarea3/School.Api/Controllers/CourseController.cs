using Microsoft.AspNetCore.Mvc;
using School.Application.Contract;       // Nueva referencia
using School.Application.Dtos.Course;    // Nueva referencia
using System.Threading.Tasks;

namespace School.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CourseController : ControllerBase
{
    // CAMBIO: Ahora inyectamos el SERVICIO, no el repositorio
    private readonly ICourseService _courseService;

    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var result = await _courseService.GetCourses();
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CourseSaveDto courseDto)
    {
        // El API valida automáticamente los DataAnnotations del DTO ([Required], [Range], etc.)
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // Llamamos al servicio de la Capa de Aplicación
        var result = await _courseService.SaveCourse(courseDto);

        if (!result.Success)
        {
            return BadRequest(result);
        }

        return Ok(result);
    }
}