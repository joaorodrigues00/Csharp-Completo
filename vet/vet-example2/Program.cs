using System;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        
        int qtdeProd = int.Parse(Console.ReadLine());

        Product[] arr = new Product[qtdeProd];

        double avgPrice = 0.0;

        for(int i = 0; i < qtdeProd; i++)
        {
            Product prod = new Product();

            prod.Name = Console.ReadLine();

            prod.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            arr[i] = prod;
        }

        Console.WriteLine("PRODS");

        for(int i = 0; i < qtdeProd; i++)
        {
            avgPrice += arr[i].Price;
        }

        Console.WriteLine($"AVERAGE PRICE = {(avgPrice / qtdeProd).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}