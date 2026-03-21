using System;

namespace MapaDeClasesComunidad.Models
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoGraduacion { get; set; }

        public void RecordarExperiencia()
        {
            Console.WriteLine($"{Nombre} se graduó en el año {AñoGraduacion}");
        }
    }
}