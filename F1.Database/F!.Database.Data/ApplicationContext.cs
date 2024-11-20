using F1.Database.Domain;
using Microsoft.EntityFrameworkCore;

namespace F1.Database.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        

        public ApplicationContext()
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;initial catalog=F1Data;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>(opt =>
            {
                opt.HasKey(k => k.ID);

                opt.OwnsOne(o => o.Address);
                //.WithOwner(a => a.)
            });

            modelBuilder.Entity<Car>(opt =>
            {
                opt.HasKey(k => k.ID);
            });

            modelBuilder.Entity<Personnel>(opt =>
            {
                opt.HasKey(k => k.ID);
            });

        }
    }
}
