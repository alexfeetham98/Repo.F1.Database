using F1.Database.Domain;
using Microsoft.EntityFrameworkCore;

namespace F1.Database.Data
{
    public class AppContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        

        public AppContext(DbContextOptions<AppContext> options) 
            : base(options)
        {            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\MSSQLLocalDB;initial catalog=F1Data;Trusted_Connection=true;MultipleActiveResultSets=True)");
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
