namespace MyBooker.Core.Accounting.Models;

/// <summary>
/// Describes flow of funds
/// </summary>
public class Expense
{
    /// <summary>
    /// Category of the expense
    /// </summary>
    public ExpenseCategory Category { get; }

    /// <summary>
    /// For what exactly the expense for.
    /// For example, if <see cref="Category"/> is named like "Food", then it can be something
    /// like "Burger" or a "Milk cartoon"
    /// </summary>
    public string ExpenseObject { get; }

    /// <summary>
    /// The amount of the <see cref="ExpenseObject"/>.
    /// It might be useful for a user to track what amount
    /// of the <see cref="ExpenseObject" /> was bought
    /// </summary>
    public float Amount { get; }

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
