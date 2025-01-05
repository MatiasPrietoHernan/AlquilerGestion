using Microsoft.EntityFrameworkCore;
using DataLayer.Models;

namespace DataLayer
{
    public class AppDbContext : DbContext
    {
        // Esto configura el DbContext
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //Aquí irían los DbSets o las tablas
        public DbSet<Departamentos> Departamento { get; set; }
        public DbSet<Inquilinos> Inquilino { get; set; }
        public DbSet<HistorialAlquiler> HitorialAlquilers { get; set; }
        public DbSet<Pago> Pagos { get; set; }



        //Configuración de la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=MalvinasDB.sqlite");
            }
        }
    }
}
