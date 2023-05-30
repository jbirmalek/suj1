using Microsoft.EntityFrameworkCore;

namespace suj1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Enseignant> Enseignants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure les relations et les contraintes des entités
            modelBuilder.Entity<Enseignant>()
                .HasOne(e => e.Departement)
                .WithMany(d => d.Enseignants)
                .HasForeignKey(e => e.DepartementId);
        }
    }
}
