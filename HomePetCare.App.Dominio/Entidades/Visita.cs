namespace HomePetCare.App.Dominio
{
    public class Visita
    {        
        //Identificador único de la Visita
        public int Id { get; set; }
        //Temperatura gato resgistrada
        public String Temperatura {get; set;}
        //Peso gato registrado
        public String Peso {get; set;}
        //Frecuencia Res. Gato registrada
        public String FrecuenciaRespiratoria {get; set;}
        //Frecuencia Car. Gato registada
        public String FrecuenciaCardiaca {get; set;}
        //Estado Animo registrado
        public String EstadoAnimo {get; set;}
        //Fecha de la visita
        public DateTime Fecha {get; set;}
        //Recomendaciones para la mascota
        public List<Recomendaciones> Recomendaciones { get; set; }
    }
}