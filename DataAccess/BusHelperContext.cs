using dotnet.DataAccess.Model;
using Microsoft.EntityFrameworkCore;

namespace dotnet.DataAccess
{
    public class BusHelperContext : DbContext
    {
        public BusHelperContext(DbContextOptions<BusHelperContext> options) : base(options)
        {
        }

        public DbSet<Veiculo> veiculos { get; set; }
        public DbSet<Sensor> sensores { get; set; }
        public DbSet<HistoricoSensor> historicoSensores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>().ToTable("veiculos");
            modelBuilder.Entity<Sensor>().ToTable("sensores");
            modelBuilder.Entity<HistoricoSensor>().ToTable("historicoSensores");
        }
    }
}