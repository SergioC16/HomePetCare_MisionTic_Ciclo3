namespace HomePetCare.App.Dominio
{
    public class Recomendaciones
    {
        // Identificador único de la recomendacion
        public int Id { get; set; }
        // Recomendaciones del cuidado
        public String Sugerencias { get; set; }
        //Medicamentos formulados
        public String Medicamentos { get; set; }      
        public String Diagnostico {get; set;}  
    }
}