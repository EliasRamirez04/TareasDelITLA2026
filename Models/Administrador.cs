using System;

namespace MapaDeClasesComunidad.Models
{
    public class Administrador : Docente
    {
        public void GestionarRecursos()
        {
            Console.WriteLine($"{Nombre} está gestionando recursos.");
        }
    }
}