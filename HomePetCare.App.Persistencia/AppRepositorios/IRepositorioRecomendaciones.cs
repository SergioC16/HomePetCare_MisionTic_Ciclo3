using System.Collections.Generic;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioRecomendaciones
    {
        IEnumerable<Recomendaciones> GetAllRecomendaciones();
        Recomendaciones AddRecomendaciones(Recomendaciones recomendaciones);
        Recomendaciones UpdateRecomendaciones(Recomendaciones recomendaciones);
        void DeleteRecomendaciones(int idRecomendaciones);
        Recomendaciones GetRecomendaciones(int idRecomendaciones);
    }
}