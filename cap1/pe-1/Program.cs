using System;

class Exercise1
{
    public static void Main(string[] args)
    {
        People p1, p2;
        p1 = new People();
        p2 = new People();

        Console.WriteLine("Dados da primeira pessoa");
        p1.Name = Console.ReadLine();
        p1.Age = int.Parse(Console.ReadLine());

        Console.WriteLine("Dados da segunda pessoa");
        p2.Name = Console.ReadLine();
        p2.Age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Pessoa mais velha: {(p1.Age > p2.Age ? p1.Name : p2.Name)}");
    }
}