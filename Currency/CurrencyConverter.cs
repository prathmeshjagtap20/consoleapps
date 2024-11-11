namespace Currency;

public class CurrencyConverter
{
    public decimal ConvertINRtoUSD(decimal amount)
    {
        return amount/85.50m;
        
    }


    public decimal ConvertINRtoEUR(decimal amount)
    {
        return amount/95.00m;
    }

    public decimal ConvertUSDtoINR(decimal amount)
    {
        return amount*85.00m;
    }

}
