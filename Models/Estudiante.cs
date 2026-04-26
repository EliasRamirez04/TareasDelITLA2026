using System;

namespace MapaDeClasesComunidad.Models
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; } = string.Empty;

        public void Matricular()
        {
            Console.WriteLine($"{Nombre} se ha matriculado en {Carrera}");
        }
    }
}