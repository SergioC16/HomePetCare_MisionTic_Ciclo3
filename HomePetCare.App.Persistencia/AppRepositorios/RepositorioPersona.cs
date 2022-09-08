using System.Linq;
using System.Collections.Generic;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
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
        
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionado = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionado.Entity;
        }
        void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            if (personaEncontrada == null)
                return;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }
        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }
        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
        }
        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if (personaEncontrada != null)
            {
                personaEncontrada.Identificacion = persona.Identificacion;
                personaEncontrada.Nombre = persona.Nombre;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.Telefono = persona.Telefono;
                personaEncontrada.Propietario = persona.Propietario;
                personaEncontrada.Veterinario = persona.Veterinario;

                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
    }
}