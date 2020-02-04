using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OldHouse_Backend.Models;
using System;

namespace OldHouse_Backend.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Initialize Roles

            builder.Entity<IdentityRole>().HasData(
                new { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new { Id = "2", Name = "Patient", NormalizedName = "PATIENT" }
                );

            //Initialize Alert Levels

            builder.Entity<AlertLevel>().HasData(
                new { Id = 1, Level = "Critical", Color = "#ff0000" },
                new { Id = 2, Level = "Important", Color = "#ff8000" },
                new { Id = 3, Level = "Warning", Color = "#ffff00" }
                );

            builder.Entity<AppUser>(u =>
            {
                u.Property<DateTime>("Birthday")
                       .HasColumnType("date");
                u.HasOne(u => u.CurrentState).WithOne(r => r.Patient).OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<UsersRelatives>()
                .HasKey(l => new { l.PatientId, l.RelativeId });


        }

        public DbSet<Alert> Alerts { get; set; }
        public DbSet<Relative> Relatives { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<AlertLevel> AlertLevels { get; set; }
        public DbSet<UsersRelatives> UsersRelatives { get; set; }

    }
}
