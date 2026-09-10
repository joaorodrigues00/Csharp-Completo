using System;

public class Employee
{
    public string Name;
    public double Salary;
    public double Tax;

    public double RealSalary()
    {
        return Salary - Tax;
    }

    public void IncreaseSalary(double percentageIncrease)
    {
        Salary  += Salary * percentageIncrease / 100.00;
    }

}