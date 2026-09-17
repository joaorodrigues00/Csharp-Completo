using System;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        Account acc;
        Console.Write("Entre o número da conta: ");
        int accNumber = int.Parse(Console.ReadLine());

        Console.Write("Entre o titular da conta: ");
        string accName = Console.ReadLine();

        Console.Write("Haverá depósito inicial (s/n) ? ");
        char option = char.Parse(Console.ReadLine());

        Console.WriteLine();

        if (option == 's')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double accBalanceAmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            acc = new Account(accNumber, accName, accBalanceAmount);
        } else
        {
            acc = new Account(accNumber, accName);
        }

        Console.WriteLine();

        Console.Write("Dados da Conta");
        Console.WriteLine($"Conta {acc.getAccountNumber()}, Titular: {acc.getAccountName()}, Saldo: $ {acc.getAccountBalance().ToString("F2", CultureInfo.InvariantCulture)}");

        Console.Write("Entre um valor para depósito: ");
        double accNewDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        acc.accountDeposit(accNewDeposit);

        Console.WriteLine();
        
        Console.Write("Dados Atualizados da Conta");
        Console.WriteLine($"Conta {acc.getAccountNumber()}, Titular: {acc.getAccountName()}, Saldo: $ {acc.getAccountBalance().ToString("F2", CultureInfo.InvariantCulture)}");

        Console.Write("Entre um valor para saque: ");
        double accNewwithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        acc.accountWithdraw(accNewwithdraw);

        Console.WriteLine();

        Console.Write("Dados Atualizados da Conta");
        Console.WriteLine($"Conta {acc.getAccountNumber()}, Titular: {acc.getAccountName()}, Saldo: $ {acc.getAccountBalance().ToString("F2", CultureInfo.InvariantCulture)}");
    }
}