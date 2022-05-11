using CurrencyLib;
using CurrencyLib.Data;

var currency1 = new CurrencyData { Id = 1, Name = "US Dollar", ShortName = "USD" };
var currency2 = new CurrencyData { Id = 2, Name = "Рубль", ShortName = "RUB" };

var exchangeRateProvider = new ExchangeRateProvider(
	new List<ExchangeRate>
	{
		new() { FromCurrency = currency1, ToCurrency = currency2, Ratio = 70 },
		new() { FromCurrency = currency2, ToCurrency = currency1, Ratio = 0.014m }
	}
);
var currencyConverter = new MoneyConverter(exchangeRateProvider);
var moneyCalculator = new MoneyCalculator(currencyConverter);

//100 US Dollars
var moneyData1 = new MoneyData
{
	Currency = currency1,
	Amount = 100
};

//1000 Russian Rubles
var moneyData2 = new MoneyData
{
	Currency = currency2,
	Amount = 1000
};

var res1 = currencyConverter.Convert(moneyData1, currency2);
Console.WriteLine($"{moneyData1.Amount} {moneyData1.Currency.Name} = {res1.Amount} {res1.Currency.Name}");

var res2 = moneyCalculator.Subtract(moneyData1, moneyData2);
Console.WriteLine($"{moneyData1.Amount} {moneyData1.Currency.Name} - {moneyData2.Amount} {moneyData2.Currency.Name} = {res2.Amount} {res2.Currency.Name}");
