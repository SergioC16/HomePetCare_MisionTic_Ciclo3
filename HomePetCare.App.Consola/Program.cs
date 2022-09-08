using System;
using HomePetCare.App.Dominio;
using HomePetCare.App.Persistencia;

namespace HomePetCare.App.Consola
{
    class Program
    {
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        static void Main(String[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            AddPersona();
            // BuscarPersona(1);
        }
        private static void AddPersona()
        {
            var persona = new Persona 
            {                
                Identificacion = "1012412312",                 
                Nombre = "Pepe",
                Apellidos = "Perez",
                Telefono = "3214444444" 
            };
            _repoPersona.AddPersona(persona);
        }
        private static void BuscarPersona(int idPersona)
        {
            var persona = _repoPersona.GetPersona(idPersona);
            Console.WriteLine(persona.Nombre + " " + persona.Apellidos);
        }
    }
}