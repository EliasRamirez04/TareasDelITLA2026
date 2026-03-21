using Microsoft.EntityFrameworkCore;
// Usings de la Tarea 3 (Infraestructura y Dominio)
using School.Infrastructure.Context;
using School.Infrastructure.Interfaces;
using School.Infrastructure.Repositories;
// Usings de la Tarea 4 (Aplicación)
using School.Application.Contract;
using School.Application.Service;

var builder = WebApplication.CreateBuilder(args);

// --- 1. CONFIGURACIÓN DE SERVICIOS BASE ---
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 

// --- 2. CONFIGURACIÓN DE LA BASE DE DATOS (Tarea 3) ---
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseInMemoryDatabase("SchoolDb"));

// --- 3. REGISTRO DE REPOSITORIOS (Tarea 3) ---
// Es vital que estos estén aquí para que los Servicios puedan usarlos
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>(); // <-- ACTIVA ESTA LÍNEA

// --- 4. REGISTRO DE SERVICIOS DE APLICACIÓN (Tarea 4) ---
// Aquí conectamos las interfaces con sus implementaciones reales
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IDepartmentService, DepartmentService>();

var app = builder.Build();

// --- 5. CONFIGURACIÓN DEL PIPELINE HTTP ---
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // Esto te permitirá probar los métodos en el navegador
}

app.UseAuthorization();
app.MapControllers();

app.Run();