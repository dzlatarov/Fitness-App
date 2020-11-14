using Fitness_App.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness_App.Persistence
{
    public class Fitness_AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public Fitness_AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<FitnessProgram> FitnessPrograms { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FitnessProgram>()
                .HasKey(fp => fp.Id);

            builder.Entity<FitnessProgram>()
                .HasMany(fp => fp.Users)
                .WithOne(u => u.FitnessProgram)
                .HasForeignKey(fp => fp.FitnessProgramId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<FitnessProgram>()
                .HasMany(fp => fp.Exercises)
                .WithOne(e => e.FitnessProgram)
                .HasForeignKey(fp => fp.FitnessProgramId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }
    }
}
