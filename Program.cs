// Elias Emmanuel Ramirez Moya
// 2020-10431
using System;
using MapaDeClasesComunidad.Models;

class Program
{
    static void Main(string[] args)
    {
        // Crear un estudiante
        Estudiante estudiante = new Estudiante 
        { 
            Nombre = "Elías", 
            Email = "elias@itla.edu.do", 
            Carrera = "Software Development" 
        };
        estudiante.MostrarInformacion();
        estudiante.Matricular();

        // Crear un maestro
        Maestro maestro = new Maestro 
        { 
            Nombre = "Juan", 
            Email = "juan@itla.edu.do", 
            Asignatura = "POO" 
        };
        maestro.MostrarInformacion();
        maestro.ExplicarTema();

        // Crear un administrador
        Administrador admin = new Administrador 
        { 
            Nombre = "María", 
            Email = "maria@itla.edu.do", 
            Asignatura = "Gestión Académica" 
        };
        admin.MostrarInformacion();
        admin.GestionarRecursos();
    }
}