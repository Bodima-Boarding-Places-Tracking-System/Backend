using Microsoft.EntityFrameworkCore;
using user_mgt.Models.Domains;

namespace user_mgt.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<BoardingOwner> BoardingOwners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BoardingOwner>().HasData(new BoardingOwner
            {
                UserId = Guid.NewGuid(),
                FirstName = "Lahiru",
                LastName = "Nanayakkara",
                Email = "lahirunanayakkara@gmail.com",
                Phone = "0760944045",
                Password = "12345678",
                Role = "BoardingOwner",
                IsActive = true,
                IsAdmin = true,
                RegistrationDate = DateTime.Now,
                LastLogin = DateTime.Now,
            });

            modelBuilder.Entity<Student>().HasData(new Student
            { 
                UserId = Guid.NewGuid(),
                FirstName = "Lahiru",
                LastName = "Nanayakkara",
                Webmail = "example.21@uom.lk",
                Password = "+i7b14TZoXcFHDfIGw8b3g==;U5uWa6FpNeUamE6v5EVntc/nvlqGCDGe7tXLBlxz4t0=",
                Role = "Student",
                IsActive= true,
                IsAdmin = true,
                RegistrationDate = DateTime.Now,
                LastLogin = DateTime.Now,
            });
        }
    }
}
