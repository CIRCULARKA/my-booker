namespace MyBooker.Infrastructure.Database.Configurations;

/// <summary>
/// A configuration for the expense entity
/// </summary>
public class ExpenseEntityConfiguration : EntityConfiguration<ExpenseEntity>
{
    public override void Configure(EntityTypeBuilder<ExpenseEntity> builder)
    {
        base.Configure(builder);

        builder.ToTable("expense");

        builder.Property(e => e.Sum).IsRequired();
        builder.Property(e => e.Time).IsRequired();
        builder.Property(e => e.CategoryID).IsRequired();
        builder.Property(e => e.ExpenseObject).IsRequired();
    }
}
