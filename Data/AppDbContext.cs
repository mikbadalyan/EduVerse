﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace EduVerse.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define your DbSets (tables) here
        public DbSet<NewEntity> NewEntities { get; set; }
        public DbSet<DefaultSubject> DefaultSubjects { get; set; } // DbSet for DefaultSubjects
        public DbSet<Dependency> Dependencies { get; set; } // DbSet for Dependencies

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=tcp:eduverseserver.database.windows.net,1433;Initial Catalog=EduVersedb;Persist Security Info=False;User ID=eduverseadm;Password=EduVerse24;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;",
                    sqlServerOptionsAction: sqlOptions =>
                    {
                        sqlOptions.EnableRetryOnFailure(
                            maxRetryCount: 5, // The maximum number of retry attempts
                            maxRetryDelay: TimeSpan.FromSeconds(30), // The maximum delay between retries
                            errorNumbersToAdd: null); // Additional error numbers to consider transient
                    });
            }
        }

    }

    public class NewEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Topic { get; set; }
        public int Lesson { get; set; }
        public int Coin { get; set; }
        public required string LessonType { get; set; }
        public DateTime Date { get; set; }
        public required string PathName { get; set; }
        public required string Status { get; set; }
        public required string Color { get; set; }
        public required string UserId { get; set; }
        public int? SubjectId { get; set; } // New column
    }

    public class User : IdentityUser
    {
        public string? UserId { get; set; }
        public int Coin { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
    }

    public class DefaultSubject
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Topic { get; set; }
        public int Lesson { get; set; }
        public int Coin { get; set; }
        public required string LessonType { get; set; }
        public required string PathName { get; set; }
        public required string Status { get; set; }
        public required string Color { get; set; }
    }

    public class Dependency
    {
        public int Id { get; set; }
        public required int SubjectId { get; set; }
        public int? Depend1 { get; set; }
        public int? Depend2 { get; set; }
        public int? Depend3 { get; set; }
        public int? Depend4 { get; set; }
        public int? Depend5 { get; set; }
    }

}
