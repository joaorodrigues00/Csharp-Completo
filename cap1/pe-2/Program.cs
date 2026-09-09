using System;

class Exercise2
{
    public static void Main(string[] args)
    {
        Employee e1, e2;
        e1 = new Employee();
        e2 = new Employee();

        Console.WriteLine("Dados do primeiro funcionário");
        e1.Name = Console.ReadLine();
        e1.Salary = double.Parse(Console.ReadLine());

        Console.WriteLine("Dados do segundo funcionário");
        e2.Name = Console.ReadLine();
        e2.Salary = double.Parse(Console.ReadLine());

        Console.WriteLine($"Salário médio = {(e1.Salary + e2.Salary) / 2:F2}");
    }
}