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
			Amount = money1.Amount
		};

		if(money1.Currency.Id == money2.Currency.Id)
		{
			result.Amount += money2.Amount;
		}
		else
		{
			result.Amount += _moneyConverter.Convert(money2, result.Currency).Amount;
		}

		return result;
	}

	public MoneyData Subtract(MoneyData money1, MoneyData money2)
	{
		var result = new MoneyData
		{
			Currency = money1.Currency,
			Amount = money1.Amount
		};

		if(money1.Currency.Id == money2.Currency.Id)
		{
			result.Amount = money1.Amount - money2.Amount;
		}
		else
		{
			result.Amount -= _moneyConverter.Convert(money2, result.Currency).Amount;
		}

		return result;
	}
}
