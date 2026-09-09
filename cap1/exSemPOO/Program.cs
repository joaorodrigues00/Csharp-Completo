using System;

public class ExemploSemPOO
{
    public static void Main(string[] args)
    {
        // EXEMPLO FEITO SEM POO
        /*string greaterArea;
        Console.WriteLine("Entre com as medidas do triângulo X:");
        double a1 = double.Parse(Console.ReadLine());
        double b1 = double.Parse(Console.ReadLine());
        double c1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Entre com as medidas do triângulo Y:");
        double a2 = double.Parse(Console.ReadLine());
        double b2 = double.Parse(Console.ReadLine());
        double c2 = double.Parse(Console.ReadLine());

        double p1 = (a1 + b1 + c1) / 2;
        double p2 = (a2 + b2 + c2) / 2;

        double area1Calc = p1 * (p1 - a1) * (p1 - b1) * (p1 - c1);
        double area2Calc = p2 * (p2 - a2) * (p2 - b2) * (p2 - c2);

        double area1 = Math.Sqrt(area1Calc);
        double area2 = Math.Sqrt(area2Calc);

        if (area1 > area2)
        {
            greaterArea = "X";
        } else
        {
            greaterArea = "Y";
        }

        Console.WriteLine($"Área de X = {area1:F4}");
        Console.WriteLine($"Área de Y = {area2:F4}");
        Console.WriteLine($"Maior área: {greaterArea}");
        */

        // COM POO
        string greaterArea;
        Triangle x, y;
        x = new Triangle();
        y = new Triangle();

        Console.WriteLine("Entre com as medidas do triângulo X:");
        x.A = double.Parse(Console.ReadLine());
        x.B = double.Parse(Console.ReadLine());
        x.C = double.Parse(Console.ReadLine());

        Console.WriteLine("Entre com as medidas do triângulo Y:");
        y.A = double.Parse(Console.ReadLine());
        y.B = double.Parse(Console.ReadLine());
        y.C = double.Parse(Console.ReadLine());

        double area1 = x.CalculateArea();
        double area2 = y.CalculateArea();

        if (area1 > area2)
        {
            greaterArea = "X";
        } else
        {
            greaterArea = "Y";
        }

        Console.WriteLine($"Área de X = {area1:F4}");
        Console.WriteLine($"Área de Y = {area2:F4}");
        Console.WriteLine($"Maior área: {greaterArea}");
        
    }
}