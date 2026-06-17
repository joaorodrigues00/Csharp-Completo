using System;

public class Exercise5
{
    public static void Main(string[] args)
    {
        
        string[] vet1 = Console.ReadLine().Split(' ');

        string[] vet2 = Console.ReadLine().Split(' ');

        int p1Code = int.Parse(vet1[0]);
        int p1Amount = int.Parse(vet1[1]);
        double p1UnitPrice = double.Parse(vet1[2]);

        int p2Code = int.Parse(vet2[0]);
        int p2Amount = int.Parse(vet2[1]);
        double p2UnitPrice = double.Parse(vet2[2]);

        double totalAmount = (p1Amount * p1UnitPrice) + (p2Amount * p2UnitPrice);

        Console.WriteLine($"VALOR A PAGAR: R$ {totalAmount:F2}");
    }
}