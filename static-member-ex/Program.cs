using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Qual é a cotação do dólar ?");
        double c1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Quantos dólares você vai comprar ?");
        double c2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"Valor a ser pago em reais = {MoneyConverter.Convert(c1, c2).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}