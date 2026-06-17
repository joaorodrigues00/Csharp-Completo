using System;
using System.Globalization;

public class Exercise
{
    public static void Main(string[] args)
    {
        string prod1 = "Computador";
        string prod2 = "Mesa de escritório";

        byte age = 30;
        int code = 5290;
        char sex = 'M';

        double price1 = 2100.0;
        double price2 = 650.50;
        double size = 53.234567;


        Console.WriteLine("Produtos:");
        Console.WriteLine($"{prod1}, cujo preço é $ {price1}");
        Console.WriteLine($"{prod2}, cujo preço é $ {price2}");

        Console.WriteLine();
        Console.WriteLine($"Registro: {age} anos de idade, código {code} e gênero: {sex}");
        Console.WriteLine();

        Console.WriteLine($"Medida com oito casas decimais: {size:F8}");
        Console.WriteLine($"Arredondado (três casas decimais): {size:F3}");
        Console.WriteLine($"Separador decimal invariant culture: {size:F3}", CultureInfo.InvariantCulture);
    }
}