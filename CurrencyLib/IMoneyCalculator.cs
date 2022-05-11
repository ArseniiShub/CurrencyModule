using CurrencyLib.Data;

namespace CurrencyLib;

public interface IMoneyCalculator
{
	/// <summary>
	/// Sums 2 money values. Converts money2 currency to money1 currency automatically if needed
	/// </summary>
	MoneyData Add(MoneyData money1, MoneyData money2);

	/// <summary>
	/// Subtracts 2 money values. Converts second currency to first automatically if needed
	/// </summary>
	MoneyData Subtract(MoneyData money1, MoneyData money2);
}
