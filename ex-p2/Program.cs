using System;
using System.Globalization;

public class Exercise2
{
    public static void Main(string[] args)
    {
        Employee e;
        e = new Employee();
        double percentage;

        Console.Write("Nome: ");
        e.Name = Console.ReadLine();
        
        Console.Write("Salário bruto: ");
        e.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Imposto: ");
        e.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();

        Console.WriteLine($"Funcionário: {e.Name}, $ {e.RealSalary().ToString("F2", CultureInfo.InvariantCulture)}");

        Console.WriteLine();

        Console.Write("Digite a porcentagem para aumentar o salário: ");
        percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        e.IncreaseSalary(percentage);

        Console.WriteLine();

        Console.WriteLine($"Dados Atualizados: {e.Name}, $ {e.RealSalary().ToString("F2", CultureInfo.InvariantCulture)}");
    }
}