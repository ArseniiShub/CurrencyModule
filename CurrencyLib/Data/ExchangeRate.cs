namespace CurrencyLib.Data;

public class ExchangeRate
{
	public CurrencyData FromCurrency { get; set; } = null!;
	public CurrencyData ToCurrency { get; set; } = null!;

	/// <summary>
	/// Money conversion multiplier. Use to convert money from currency <see cref="FromCurrency"/> to <see cref="ToCurrency"/>
	/// </summary>
	public decimal Value { get; set; }
}
