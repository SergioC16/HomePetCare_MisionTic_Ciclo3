using Microsoft.EntityFrameworkCore;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public class AppContext : DbContext 
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Gato> Gatos  {get; set;}
        public DbSet<Propietario> Propietarios  {get; set;}
        public DbSet<Recomendaciones> Recomendaciones  {get; set;}
        public DbSet<Veterinario> Veterinarios {get; set;}
        public DbSet<Visita> Visitas  {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HomePetCareData");
            }
        }
    }
}