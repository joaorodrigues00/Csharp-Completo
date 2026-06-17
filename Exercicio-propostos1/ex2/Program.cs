using System;
using System.Net.NetworkInformation;

public class Exercise2
{
    public static void Main(string[] args)
    {
        double pi = 3.14159;
        
        double radius = double.Parse(Console.ReadLine());

        double area = pi * (radius * radius);

        Console.WriteLine($"A={area:F4}");

    }
}