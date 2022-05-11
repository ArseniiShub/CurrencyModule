using CurrencyLib.Data;

namespace CurrencyLib;

public class ExchangeRateProvider : IExchangeRateProvider
{
	private readonly IList<ExchangeRate> _exchangeRates;

	public ExchangeRateProvider(IList<ExchangeRate> exchangeRates)
	{
		_exchangeRates = exchangeRates;
	}

	public ExchangeRate GetExchangeRate(CurrencyData from, CurrencyData to)
	{
		return _exchangeRates.First(er => er.FromCurrency.Id == from.Id && er.ToCurrency.Id == to.Id);
	}
}
