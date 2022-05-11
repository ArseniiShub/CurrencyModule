namespace CurrencyLib.Data;

/// <summary>
/// Amount of money in specific currency
/// </summary>
public class MoneyData
{
	public CurrencyData Currency { get; set; } = null!;
	public decimal Amount { get; set; }
}
