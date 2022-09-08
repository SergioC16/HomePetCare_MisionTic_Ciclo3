using System.Collections.Generic;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioGato
    {
        IEnumerable<Gato> GetAllGatos();
        Gato AddGato(Gato gato);
        Gato UpdateGato(Gato gato);
        void DeleteGato(int idGato);
        Gato GetGato(int idGato);
    }
}