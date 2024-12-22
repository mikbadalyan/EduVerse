using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<AccountSettings> AccountSettings { get; set; }
    public DbSet<LanguageAndTimeSettings> LanguageAndTimeSettings { get; set; }
    public DbSet<NotificationSettings> NotificationSettings { get; set; }
    public DbSet<PrivacyAndDataSettings> PrivacyAndDataSettings { get; set; }

}
