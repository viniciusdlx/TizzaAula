using Microsoft.EntityFrameworkCore;

namespace TizzaAula
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Pizzaria> Pizzaria {get; set;} 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizzaria>().HasKey(p => p.Id);
            modelBuilder.Entity<Pizza>().HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }

    }
}
