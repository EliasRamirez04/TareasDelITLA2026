using System.ComponentModel.DataAnnotations;

namespace School.Application.Dtos.Course
{
    public class CourseSaveDto : DtoBase
    {
        [Required(ErrorMessage = "El título del curso es requerido.")]
        [StringLength(100, ErrorMessage = "El título es demasiado largo.")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Los créditos son obligatorios.")]
        [Range(1, 5, ErrorMessage = "Un curso debe tener entre 1 y 5 créditos.")]
        public int Credits { get; set; }

        [Required(ErrorMessage = "Debe asignar el curso a un departamento.")]
        public int DepartmentID { get; set; }
    }
}