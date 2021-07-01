using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using Alquiler.Domain;
using System.Collections.Generic;
using System.Reflection.Emit;
using Alquiler.Persistence.Databse.Configuration;

namespace Alquiler.Persistence.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
)
: base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Database schema
            builder.HasDefaultSchema("Alquiler");

            // Model Contraints
            ModelConfig(builder);
        }

        public DbSet<Pista> Pistas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new PistaConfiguration(modelBuilder.Entity<Pista>());
            new ReservaConfiguration(modelBuilder.Entity<Reserva>());
        }
    }
}