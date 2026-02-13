using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine() ?? "";
        double salarioFixo = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        double totalVendas = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double totalAreceber = salarioFixo + (totalVendas * 0.15);

        System.Console.WriteLine($"TOTAL = {totalAreceber.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}