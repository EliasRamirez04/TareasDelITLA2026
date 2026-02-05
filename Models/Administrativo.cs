using System;

namespace MapaDeClasesComunidad.Models
{
    public class Administrativo : Empleado
    {
        public void ProcesarDocumentos()
        {
            Console.WriteLine($"{Nombre} está procesando documentos.");
        }
    }
}