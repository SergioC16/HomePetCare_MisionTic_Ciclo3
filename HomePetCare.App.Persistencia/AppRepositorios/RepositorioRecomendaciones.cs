using System.Linq;
using System.Collections.Generic;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioRecomendaciones : IRepositorioRecomendaciones
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
        
        public RepositorioRecomendaciones(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Recomendaciones IRepositorioRecomendaciones.AddRecomendaciones(Recomendaciones recomendaciones)
        {
            var recomendacionAdicionada = _appContext.Recomendaciones.Add(recomendaciones);
            _appContext.SaveChanges();
            return recomendacionAdicionada.Entity;
        }
        void IRepositorioRecomendaciones.DeleteRecomendaciones(int idRecomendaciones)
        {
            var recomendacionEncontrada = _appContext.Recomendaciones.FirstOrDefault(r => r.Id == idRecomendaciones);
            if (recomendacionEncontrada == null)
                return;
            _appContext.Recomendaciones.Remove(recomendacionEncontrada);
            _appContext.SaveChanges();
        }
        IEnumerable<Recomendaciones> IRepositorioRecomendaciones.GetAllRecomendaciones()
        {
            return _appContext.Recomendaciones;
        }
        Recomendaciones IRepositorioRecomendaciones.GetRecomendaciones(int idRecomendaciones)
        {
            return _appContext.Recomendaciones.FirstOrDefault(r => r.Id == idRecomendaciones);
        }
        Recomendaciones IRepositorioRecomendaciones.UpdateRecomendaciones(Recomendaciones recomendaciones)
        {
            var recomendacionEncontrada = _appContext.Recomendaciones.FirstOrDefault(r => r.Id == recomendaciones.Id);
            if (recomendacionEncontrada != null)
            {
                recomendacionEncontrada.Sugerencias = recomendaciones.Sugerencias;
                recomendacionEncontrada.Medicamentos = recomendaciones.Medicamentos;
                recomendacionEncontrada.Diagnostico = recomendaciones.Diagnostico;

                _appContext.SaveChanges();
            }
            return recomendacionEncontrada;
        }
    }
}