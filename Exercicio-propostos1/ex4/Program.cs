using System;
using System.Globalization;

public class Exercise4
{
    public static void Main(string[] args)
    {
        int empNumber = int.Parse(Console.ReadLine());
        int empWorkedHours = int.Parse(Console.ReadLine());
        double empSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine($"NUMBER = {empNumber}");
        Console.WriteLine($"SALARY = U$ {empWorkedHours * empSalary:F2}", CultureInfo.InvariantCulture);
    }
}