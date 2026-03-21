using Microsoft.AspNetCore.Mvc;
using School.Application.Contract;
using School.Application.Dtos.Department;

namespace School.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _departmentService.GetDepartments();
            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(result.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DepartmentSaveDto dto)
        {
            var result = await _departmentService.Save(dto);
            if (!result.Success)
                return BadRequest(result.Message);

            return Ok(result);
        }
    }
}