using CurrencyLib.Data;

namespace CurrencyLib;

public interface IMoneyCalculator
{
	/// <summary>
	/// Sums two money values. Converts second currency to first automatically if needed
	/// </summary>
	MoneyData Add(MoneyData money1, MoneyData money2);

	/// <summary>
	/// Subtracts two money values. Converts second currency to first automatically if needed
	/// </summary>
	MoneyData Subtract(MoneyData money1, MoneyData money2);
}
