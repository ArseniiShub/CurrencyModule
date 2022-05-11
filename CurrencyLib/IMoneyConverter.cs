using CurrencyLib.Data;

namespace CurrencyLib;

public interface IMoneyConverter
{
	/// <summary>
	/// Converts money to specified currency and returns new MoneyData object
	/// </summary>
	public MoneyData Convert(MoneyData moneyData, CurrencyData toCurrency);
}
