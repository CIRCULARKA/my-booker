namespace MyBooker.Core.Accounting.Entities;

/// <summary>
/// Describes flow of funds entity in a reloatinal storage
/// </summary>
public class ExpenseEntity : Entity
{
    public Guid CategoryID { get; set; }

    /// <summary>
    /// Category of the expense
    /// </summary>
    public ExpenseCategoryEntity Category { get; set; }

    /// <summary>
    /// For what exatrly the expense for
    /// </summary>
    public string ExpenseObject { get; set; }

    /// <summary>
    /// The amount of the <see cref="ExpenseObject"/>.
    /// It might be useful for a user to track what amount
    /// of the <see cref="ExpenseObject" /> was bought
    /// </summary>
    public float Amount { get; set; }

    /// <summary>
    /// Type of measurement of the <see cref="ExpenseObject"/>
    /// </summary>
    public MeasurementType MeasurementType { get; }

    /// <summary>
    /// Sum of the expense
    /// </summary>
    public decimal Sum { get; }

    /// <summary>
    /// Time of the expense
    /// </summary>
    public DateTimeOffset Time { get; }

    /// <summary>
    /// Comment for the expense
    /// </summary>
    public string Comment { get; }
}
