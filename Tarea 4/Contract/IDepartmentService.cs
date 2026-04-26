using School.Application.Core; 
using School.Application.Dtos.Department; 

namespace School.Application.Contract
{
    public interface IDepartmentService
    {
        Task<ServiceResult<List<DepartmentSaveDto>>> GetDepartments();
        Task<ServiceResult<bool>> Save(DepartmentSaveDto dto);
    }
}