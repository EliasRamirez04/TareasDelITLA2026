using School.Application.Core;
using School.Application.Dtos.Course;

namespace School.Application.Contract
{
    public interface ICourseService
    {
        Task<ServiceResult<IEnumerable<CourseSaveDto>>> GetCourses();
        Task<ServiceResult<bool>> SaveCourse(CourseSaveDto courseDto);
    }
}