using System;

namespace MapaDeClasesComunidad.Models
{
    public class Docente : Empleado
    {
        public string Asignatura { get; set; } = string.Empty;

        public void ImpartirClase()
        {
            Console.WriteLine($"{Nombre} está impartiendo la asignatura {Asignatura}");
        }
    }
}