using Parcial1_PWA.Models;
using Microsoft.EntityFrameworkCore;

namespace Parcial1_PWA.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet para la entidad Subjets
        public DbSet<Subjects> Subject { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones adicionales del modelo (opcional)
            modelBuilder.Entity<Subjects>().Property(t => t.Created).HasDefaultValueSql("GETUTCDATE()");
        }
    }
}
