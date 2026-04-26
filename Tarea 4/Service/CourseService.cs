using School.Application.Contract;
using School.Application.Core;
using School.Application.Dtos.Course;
using School.Infrastructure.Interfaces;
using School.Domain.Entities; // Donde vive tu clase Course : BaseEntity

namespace School.Application.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task<ServiceResult<IEnumerable<CourseSaveDto>>> GetCourses()
        {
            var result = new ServiceResult<IEnumerable<CourseSaveDto>>();
            
            // Traemos los cursos desde el repositorio de la Tarea 3
            var courses = await _courseRepository.GetCourses();
            
            // Mapeamos a DTO
            result.Data = courses.Select(c => new CourseSaveDto {
                // AQUÍ ESTABA EL ERROR: Usamos .Id porque viene de BaseEntity
                Id = c.Id, 
                Title = c.Title,
                Credits = c.Credits
            });
            
            result.Message = "Cursos obtenidos con éxito.";
            return result;
        }

        public async Task<ServiceResult<bool>> SaveCourse(CourseSaveDto courseDto)
        {
            var result = new ServiceResult<bool>();

            try 
            {
                // Creamos la entidad de Dominio para que el repositorio la acepte
                var entity = new Course {
                    Title = courseDto.Title,
                    Credits = courseDto.Credits
                };

                // Guardamos usando el repositorio de la Tarea 3
                await _courseRepository.Save(entity);
                
                result.Data = true;
                result.Message = "Curso guardado correctamente en la base de datos.";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error al guardar: " + ex.Message;
            }

            return result;
        }
    }
}