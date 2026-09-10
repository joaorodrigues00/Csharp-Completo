using System;
using System.Globalization;

public class Exercise3
{
    public static void Main(string[] args)
    {
        Student s;
        s =  new Student();

        Console.Write("Nome do Aluno:");
        s.Name = Console.ReadLine();

        Console.WriteLine("Digite as três notas do aluno:");
        s.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        s.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        s.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        s.StudentStatus();
    }
}