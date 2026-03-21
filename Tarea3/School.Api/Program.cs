using Microsoft.EntityFrameworkCore;
using School.Infrastructure.Context;
using School.Infrastructure.Interfaces;
using School.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Elias Emmanuel Ramirez Moya 2020-10431
//1. Configuración de Servicios (Inyección de Dependencias)
builder.Services.AddControllers();
builder.Services.AddOpenApi(); 

// 2. Configuración de la Base de Datos en Memoria
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseInMemoryDatabase("SchoolDb"));

// 3. Registro de Repositorios
builder.Services.AddScoped<ICourseRepository, CourseRepository>();

var app = builder.Build();

// 4. Configuración del Pipeline de HTTP
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); 
}

app.UseAuthorization();
app.MapControllers();


app.Run();