using System;
using System.Globalization;

public class Exercise1
{
    public static void Main(string[] args)
    {
        Rectangle r;
        r =  new Rectangle();

        Console.WriteLine("Entre a largura e altura do retângulo");
        r.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        r.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"{r.RectArea().ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"{r.RectPerimeter().ToString("F2", CultureInfo.InvariantCulture)}", CultureInfo.InvariantCulture);
        Console.WriteLine($"{r.RectDiagonal().ToString("F2", CultureInfo.InvariantCulture)}", CultureInfo.InvariantCulture);
    }
}