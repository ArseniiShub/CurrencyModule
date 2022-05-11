using CurrencyLib.Data;

namespace CurrencyLib;

public class MoneyConverter : IMoneyConverter
{
	private readonly IExchangeRateProvider _exchangeRateProvider;

	public MoneyConverter(IExchangeRateProvider exchangeRateProvider)
	{
		_exchangeRateProvider = exchangeRateProvider;
	}

	public MoneyData ConvertMoney(MoneyData moneyData, CurrencyData toCurrency)
	{
		var exchangeRate = _exchangeRateProvider.GetExchangeRate(moneyData.Currency, toCurrency);

		return new MoneyData
		{
			Currency = toCurrency,
			Value = exchangeRate.Value * moneyData.Value
		};
	}
}
