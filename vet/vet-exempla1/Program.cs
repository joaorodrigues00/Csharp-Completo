using System;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());
        double[] arr = new double[qt];
        double avg = 0;

        for(int i = 0; i < qt; i++)
        {
            double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            arr[i] = height;
            avg += arr[i];
        }

        Console.WriteLine($"{(avg / qt).ToString("F2", CultureInfo.InvariantCulture)}");
    }
}