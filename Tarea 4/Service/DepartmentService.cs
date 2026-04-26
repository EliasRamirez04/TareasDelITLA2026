using School.Application.Contract;
using School.Application.Core;
using School.Application.Dtos.Department;
using School.Infrastructure.Interfaces; 
using School.Domain.Entities;          

namespace School.Application.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;

        // Inyectamos el repositorio de la Tarea 3
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<ServiceResult<bool>> Save(DepartmentSaveDto saveDto)
        {
            var result = new ServiceResult<bool>();
            try 
            {
                // Mapeo manual del DTO a la Entidad de Dominio
                var entity = new Department { 
                    Name = saveDto.Name,
                    Budget = saveDto.Budget
                };

                await _departmentRepository.Save(entity); 
                
                result.Data = true;
                result.Message = "Departamento guardado con éxito.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al guardar: " + ex.Message;
            }
            return result;
        }

        public async Task<ServiceResult<List<DepartmentSaveDto>>> GetDepartments()
        {
            var result = new ServiceResult<List<DepartmentSaveDto>>();
            
            try 
            {
                // ¡IMPORTANTE!: Usamos GetEntities() porque así se llama en tu IDepartmentRepository
                var departments = await _departmentRepository.GetEntities();
                
                // Convertimos la lista de Entidades a DTOs
                result.Data = departments.Select(d => new DepartmentSaveDto {
                    Id = d.Id, // Usamos .Id que viene de BaseEntity
                    Name = d.Name,
                    Budget = d.Budget
                }).ToList();

                result.Message = "Departamentos cargados correctamente.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al obtener datos: " + ex.Message;
                result.Data = new List<DepartmentSaveDto>();
            }

            return result;
        }
    }
}