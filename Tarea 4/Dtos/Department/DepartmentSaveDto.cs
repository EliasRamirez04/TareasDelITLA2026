using System.ComponentModel.DataAnnotations;

namespace School.Application.Dtos.Department
{
    public class DepartmentSaveDto : DtoBase
    {
        [Required(ErrorMessage = "El nombre del departamento es requerido.")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "El presupuesto es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El presupuesto debe ser mayor a 0.")]
        public decimal Budget { get; set; }

        public DateTime StartDate { get; set; }

        // Si el departamento requiere un Administrador (Instructor)
        public int? InstructorID { get; set; }
    }
}