namespace HomePetCare.App.Dominio
{
    public class Gato
    {        
        //Datos gato
        public int Id {get; set;}
        public String NombreGato {get; set;}
        public String Raza {get; set;}
        public String Color {get; set;}
        //Relaciones
        public Propietario Propietario {get; set;}        
        public Veterinario Veterinario {get; set;}
        public Visita Visita {get; set;}

    }
}