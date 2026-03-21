using System;

namespace MapaDeClasesComunidad.Models
{
    public class Maestro : Docente
    {
        public void ExplicarTema()
        {
            Console.WriteLine($"{Nombre} está explicando un tema.");
        }
    }
}