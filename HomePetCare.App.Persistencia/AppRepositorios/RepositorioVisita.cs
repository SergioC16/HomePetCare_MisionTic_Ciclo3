using System.Linq;
using System.Collections.Generic;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioVisita : IRepositorioVisita
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
        
        public RepositorioVisita(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Visita IRepositorioVisita.AddVisita(Visita visita)
        {
            var visitaAdicionado = _appContext.Visitas.Add(visita);
            _appContext.SaveChanges();
            return visitaAdicionado.Entity;
        }
        void IRepositorioVisita.DeleteVisita(int idVisita)
        {
            var visitaEncontrada = _appContext.Visitas.FirstOrDefault(v => v.Id == idVisita);
            if (visitaEncontrada == null)
                return;
            _appContext.Visitas.Remove(visitaEncontrada);
            _appContext.SaveChanges();
        }
        IEnumerable<Visita> IRepositorioVisita.GetAllVisitas()
        {
            return _appContext.Visitas;
        }
        Visita IRepositorioVisita.GetVisita(int idVisita)
        {
            return _appContext.Visitas.FirstOrDefault(v => v.Id == idVisita);
        }        
    }
}