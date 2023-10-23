using DeGuzman_LabAct.Models;
using Microsoft.EntityFrameworkCore;

namespace DeGuzman_LabAct.Data
{
    public class AppDbContext : DbContext

    {
        public DbSet<Student> Roster { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructor>().HasData(
            new Instructor()
            {
                Id = 1,
                FName = "Jason",
                LName = "Beltran",
                Rank = Rank.Instructor,
                HiringDate = DateTime.Parse("2022-08-26"),
                IsTenured = true
            },

            new Instructor()
            {
                Id = 2,
                FName = "Imran",
                LName = "Beltran",
                Rank = Rank.Instructor,
                HiringDate = DateTime.Parse("2023-08-26"),
                IsTenured = true
            });
        }

    }
}
