using System;

public class Account
{
    public int AccountNumber { get; private set; }
    public string AccountName { get; set; }
    private double AccountBalance { get; set; }

    public Account(int accNumber, string accName, double balanceAmount)
    {
        AccountNumber = accNumber;
        AccountName = accName;
        AccountBalance = balanceAmount;
    }

    public Account(int accNumber, string accName)
    {
        AccountNumber = accNumber;
        AccountName = accName;
    }

    public double getAccountNumber()
    {
        return AccountNumber;
    }

    public string getAccountName()
    {
        return AccountName;
    }

    public double getAccountBalance()
    {
        return AccountBalance;
    }

    public void accountDeposit(double amount)
    {
        AccountBalance += amount;
    }

    public void accountWithdraw(double amount)
    {
        AccountBalance = AccountBalance - 5 - amount;
    }
}