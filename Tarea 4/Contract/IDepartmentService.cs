using School.Application.Core; // Esto quita el error de ServiceResult
using School.Application.Dtos.Department; // Esto quita el error de DepartmentSaveDto

namespace School.Application.Contract
{
    public interface IDepartmentService
    {
        Task<ServiceResult<List<DepartmentSaveDto>>> GetDepartments();
        Task<ServiceResult<bool>> Save(DepartmentSaveDto dto);
    }
}