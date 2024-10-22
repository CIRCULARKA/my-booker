namespace MyBooker.Infrastructure.Database.Configurations;

/// <summary>
/// A configuration for an entity
/// </summary>
public class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T : Entity
{
    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.HasKey(e => e.ID);
    }
}
