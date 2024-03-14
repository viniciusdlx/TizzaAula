using Microsoft.EntityFrameworkCore;

namespace TizzaAula
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Pizzaria> Pizzaria { get; set; }
        public DbSet<Promover> Promover { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizzaria>().HasKey(p => p.Id);
            modelBuilder.Entity<Pizza>().HasKey(p => p.Id);
            modelBuilder.Entity<Promover>().HasKey(p => p.Id);
            modelBuilder.Entity<Promover>()
                .HasOne(p => p.Pizzaria)
                .WithMany()
                .HasForeignKey(p => p.CodigoPizzaria);

            base.OnModelCreating(modelBuilder);
        }

    }
}
