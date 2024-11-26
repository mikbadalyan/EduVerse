using Microsoft.EntityFrameworkCore;

namespace EduVerse.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define your DbSets (tables) here
        public DbSet<NewEntity> NewEntities { get; set; }
        public DbSet<User> Users { get; set; } // New DbSet for Users
        public DbSet<DefaultSubject> DefaultSubjects { get; set; } // New DbSet for DefaultSubjects
    }

    public class NewEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Topic { get; set; }
        public int Lesson { get; set; }
        public int Coin { get; set; }
        public required string LessonType { get; set; } // CM, TD, etc.
        public DateTime Date { get; set; }
        public required string PathName { get; set; }
        public required string Status { get; set; }
        public required string Color { get; set; } // New property for color
        public required string UserId { get; set; } // New property for user ID
    }

    public class User
    {
        public int Id { get; set; }
        public required string UserId { get; set; }
        public int Coin { get; set; }

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
}
