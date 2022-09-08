using System;
namespace HomePetCare.App.Dominio
{
    public class Persona
    {
        //Datos principales
        public int Id {get; set;}
        public String Identificacion {get; set;}
        public String Nombre {get; set;}
        public String Apellidos {get; set;}
        public String Telefono {get; set;}
        //Relaciones herencia
        public Veterinario Veterinario {get; set;}
        public Propietario Propietario {get; set;}
    }
}