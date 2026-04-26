namespace School.Application.Dtos.Department
{
    public class DepartmentViewDto : DtoBase
    {
        public string? Name { get; set; }
        public string? BudgetDisplay { get; set; } // Ejemplo: "$10,000.00"
        public string? AdministratorName { get; set; }
    }
}