using CurrencyLib.Data;

namespace CurrencyLib;

public interface IExchangeRateProvider
{
	/// <summary>
	/// Provides <see cref="ExchangeRate"/> for specified from and to currencies
	/// </summary>
	ExchangeRate GetExchangeRate(CurrencyData from, CurrencyData to);
}
