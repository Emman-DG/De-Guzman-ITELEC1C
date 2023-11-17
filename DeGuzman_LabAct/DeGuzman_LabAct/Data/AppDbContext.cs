using DeGuzman_LabAct.Models;
using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DeGuzman_LabAct.Data
{
    public class AppDbContext : IdentityDbContext<User>

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
                IsTenured = true,
                PhoneNumber = "111-222-3333",
                EmailAddress = "JasonBeltran.cics@ust.edu.ph",
                Url = "google.com",
                UnusedPassword = "12345"
            },

            new Instructor()
            {
                Id = 2,
                FName = "Imran",
                LName = "Beltran",
                Rank = Rank.Instructor,
                HiringDate = DateTime.Parse("2023-08-26"),
                IsTenured = true,
                PhoneNumber = "111-222-4444",
                EmailAddress = "ImranBeltran.cics@ust.edu.ph",
                Url = "facebook.com",
                UnusedPassword = "1234567"
            });
        }

    }
}
