using CurrencyLib.Data;

namespace CurrencyLib;

public interface IMoneyConverter
{
	/// <summary>
	/// Converts money to specified currency and returns new MoneyData object
	/// </summary>
	/// <param name="moneyData"></param>
	/// <param name="toCurrency"></param>
	/// <returns></returns>
	public MoneyData ConvertMoney(MoneyData moneyData, CurrencyData toCurrency);
}
