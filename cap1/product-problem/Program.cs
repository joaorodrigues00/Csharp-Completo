using System;


public class Exercise
{
    public static void Main(string[] args)
    {
        Product p;
        p = new Product();

        Console.WriteLine("Entre os dados do produto:");

        Console.Write("Nome: ");
        p.Name = Console.ReadLine();
        Console.Write("Preço: ");
        p.Price = double.Parse(Console.ReadLine());
        Console.Write("Quantidade no estoque: ");
        p.Quantity = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine($"Dados do produto: {p.ProductsInfo()}");

        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int qtde = int.Parse(Console.ReadLine());
        p.AddProducts(qtde);

        Console.WriteLine();

        Console.WriteLine($"Dados atualizados: {p.ProductsInfo()}");

        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser removido ao estoque: ");
        qtde = int.Parse(Console.ReadLine());
        p.RemoveProducts(qtde);

        Console.WriteLine();

        Console.WriteLine($"Dados atualizados: {p.ProductsInfo()}");

    }
}