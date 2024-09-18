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
                FullName = "Lahiru Nanayakkara",
                Email = "lahirunanayakkara@gmail.com",
                Phone = "0760944045",
                Password = "12345678",
                Role = "BoardingOwner",
                IsActive = true,
                RegistrationDate = DateTime.Now,
                LastLogin = DateTime.Now,
            });

            modelBuilder.Entity<Student>().HasData(new Student
            { 
                UserId = Guid.NewGuid(),
                FullName = "Nanayakkara omll",
                Webmail = "nanayakkaraomll.21@uom.lk",
                Password = "Lahiru#1",
                Role = "Student",
                IsActive= true,
                RegistrationDate = DateTime.Now,
                LastLogin = DateTime.Now,
            });
        }
    }
}
