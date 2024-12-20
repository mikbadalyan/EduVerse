using Microsoft.EntityFrameworkCore;

namespace EduVerse.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Define your DbSets (tables) here
        public DbSet<NewEntity> NewEntities { get; set; }
        public DbSet<User> Users { get; set; } // DbSet for Users
        public DbSet<DefaultSubject> DefaultSubjects { get; set; } // DbSet for DefaultSubjects
        public DbSet<Dependency> Dependencies { get; set; } // DbSet for Dependencies

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Additional configuration if needed
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


