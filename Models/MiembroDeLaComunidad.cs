using System;

namespace MapaDeClasesComunidad.Models
{
    public class MiembroDeLaComunidad
    {
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Email: {Email}");
        }
    }
}