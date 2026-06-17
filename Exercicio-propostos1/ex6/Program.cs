using System;

public class Exercise6
{
    public static void Main(string[] args)
    {
        string[] vet = Console.ReadLine().Split(' ');

        double A = double.Parse(vet[0]);
        double B = double.Parse(vet[1]);
        double C = double.Parse(vet[2]);

        double pi = 3.14159;

        double triangle = A * C / 2;
        double circle = pi * Math.Pow(C, 2);
        double trap = (A + B) * C / 2;
        double square = B * B;
        double ret = A * B;

        Console.WriteLine($"TRIANGULO: {triangle:F3}");
        Console.WriteLine($"CIRCULO: {circle:F3}");
        Console.WriteLine($"TRAPEZIO: {trap:F3}");
        Console.WriteLine($"QUADRADO: {square:F3}");
        Console.WriteLine($"RETANGULO: {ret:F3}");
    }
}