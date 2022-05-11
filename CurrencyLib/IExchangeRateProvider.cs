using CurrencyLib.Data;

namespace CurrencyLib;

public interface IExchangeRateProvider
{
	/// <summary>
	/// Provides <see cref="ExchangeRate"/> for specified <see cref="from"/> and <see cref="to"/> currencies
	/// </summary>
	ExchangeRate GetExchangeRate(CurrencyData from, CurrencyData to);
}
