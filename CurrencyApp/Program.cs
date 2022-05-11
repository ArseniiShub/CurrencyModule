using CurrencyLib;
using CurrencyLib.Data;

var currency1 = new CurrencyData { Id = 1, Name = "US Dollar", ShortName = "USD" };
var currency2 = new CurrencyData { Id = 2, Name = "Рубль", ShortName = "RUB" };

var exchangeRateProvider = new ExchangeRateProvider(
	new List<ExchangeRate>
	{
		new() { FromCurrency = currency1, ToCurrency = currency2, Value = 70 },
		new() { FromCurrency = currency2, ToCurrency = currency1, Value = 0.014m }
	}
);
var currencyConverter = new MoneyConverter(exchangeRateProvider);
var moneyCalculator = new MoneyCalculator(currencyConverter);

//100 US Dollars
var moneyData1 = new MoneyData
{
	Currency = currency1,
	Value = 100
};

//1000 Russian Rubles
var moneyData2 = new MoneyData
{
	Currency = currency2,
	Value = 1000
};

var res1 = currencyConverter.ConvertMoney(moneyData1, currency2);
Console.WriteLine($"{moneyData1.Value} {moneyData1.Currency.Name} = {res1.Value} {res1.Currency.Name}");

var res2 = moneyCalculator.Subtract(moneyData1, moneyData2);
Console.WriteLine($"{moneyData1.Value} {moneyData1.Currency.Name} - {moneyData2.Value} {moneyData2.Currency.Name} = {res2.Value} {res2.Currency.Name}");
