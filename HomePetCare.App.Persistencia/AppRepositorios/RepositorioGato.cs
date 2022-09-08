using System.Linq;
using System.Collections.Generic;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioGato : IRepositorioGato
    {
        /// <summary>
        /// Referencia al contexto del Paciente
        /// </summary>
        private readonly AppContext _appContext;
        ///<summary>
        /// Metodo Constructor  Utiliza
        /// Inyeccion de dependencias para iniciar el contexto a utilizar
        /// </summary>
        ///  <param name="appContext"></param>//
        
        public RepositorioGato(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Gato IRepositorioGato.AddGato(Gato gato)
        {
            var gatoAdicionado = _appContext.Gatos.Add(gato);
            _appContext.SaveChanges();
            return gatoAdicionado.Entity;
        }
        void IRepositorioGato.DeleteGato(int idGato)
        {
            var gatoEncontrado = _appContext.Gatos.FirstOrDefault(g => g.Id == idGato);
            if (gatoEncontrado == null)
                return;
            _appContext.Gatos.Remove(gatoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Gato> IRepositorioGato.GetAllGatos()
        {
            return _appContext.Gatos;
        }
        Gato IRepositorioGato.GetGato(int idGato)
        {
            return _appContext.Gatos.FirstOrDefault(g => g.Id == idGato);
        }
        Gato IRepositorioGato.UpdateGato(Gato gato)
        {
            var gatoEncontrado = _appContext.Gatos.FirstOrDefault(g => g.Id == gato.Id);
            if (gatoEncontrado != null)
            {
                gatoEncontrado.NombreGato = gato.NombreGato;
                gatoEncontrado.Raza = gato.Raza;
                gatoEncontrado.Color = gato.Color;
                gatoEncontrado.Propietario = gato.Propietario;
                gatoEncontrado.Veterinario = gato.Veterinario;
                gatoEncontrado.Visita = gato.Visita;

                _appContext.SaveChanges();
            }
            return gatoEncontrado;
        }
    }
}