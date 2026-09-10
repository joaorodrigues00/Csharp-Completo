using System;
using System.Globalization;

public class Student
{
    public string Name;

    public double N1;
    public double N2;
    public double N3;

    public double FinalNote()
    {
        return N1 + N2 + N3;
    }

    public double FinalNoteFailed()
    {
        return 60.00 - FinalNote();
    }

    public void StudentStatus()
    {
        Console.WriteLine($"NOTA FINAL = {FinalNote().ToString("F2", CultureInfo.InvariantCulture)}");

        if (FinalNote() > 60.00)
        {
            Console.WriteLine("APROVADO");
        } else
        {
            Console.WriteLine("REPROVADO");
            Console.WriteLine($"FALTARAM {FinalNoteFailed().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
        }
    }
}