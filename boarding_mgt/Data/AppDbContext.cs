using boarding_mgt.Models;
using Microsoft.EntityFrameworkCore;

namespace boarding_mgt.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        public DbSet<Boarding> Boarding {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Boarding>().HasData(new Boarding
            {
                Id = 1,
                Name = "Devi",
                Description="for girls",
                Type="flat"
            }
                );
        }
    }
}
