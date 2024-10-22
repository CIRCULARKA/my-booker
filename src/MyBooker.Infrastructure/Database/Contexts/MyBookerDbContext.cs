namespace MyBooker.Infrastructure.Database.Contexts;

/// <summary>
/// Database context for the service
/// </summary>
public class MyBookerDbContext : DbContext
{
    public MyBookerDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
