using System;

public class MoneyConverter
{
    static double Iof = 6.0;

    public static double Convert(double cotation, double amount)
    {
        double totalValue = cotation * amount;
        return totalValue + (totalValue * Iof / 100);
    }
}