namespace MyBooker.Infrastructure.Database.Configurations;

/// <summary>
/// A configuration for the expense category entity
/// </summary>
public class ExpenseCategoryEntityConfiguration : EntityConfiguration<ExpenseCategoryEntity>
{
    public override void Configure(EntityTypeBuilder<ExpenseCategoryEntity> builder)
    {
        base.Configure(builder);

        builder.ToTable("expense_category");

        builder.HasIndex(e => e.Name).IsUnique();

        builder.Property(e => e.Name).IsRequired();
    }
}
