using CurrencyLib.Data;

namespace CurrencyLib;

public class MoneyCalculator : IMoneyCalculator
{
	private readonly IMoneyConverter _moneyConverter;

	public MoneyCalculator(IMoneyConverter moneyConverter)
	{
		_moneyConverter = moneyConverter;
	}

	public MoneyData Add(MoneyData money1, MoneyData money2)
	{
		var result = new MoneyData
		{
			Currency = money1.Currency,
			Value = money1.Value
		};

		if(money1.Currency.Id == money2.Currency.Id)
		{
			result.Value += money2.Value;
		}
		else
		{
			result.Value += _moneyConverter.ConvertMoney(money2, result.Currency).Value;
		}

		return result;
	}

	public MoneyData Subtract(MoneyData money1, MoneyData money2)
	{
		var result = new MoneyData
		{
			Currency = money1.Currency,
			Value = money1.Value
		};

		if(money1.Currency.Id == money2.Currency.Id)
		{
			result.Value = money1.Value - money2.Value;
		}
		else
		{
			result.Value -= _moneyConverter.ConvertMoney(money2, result.Currency).Value;
		}

		return result;
	}
}
