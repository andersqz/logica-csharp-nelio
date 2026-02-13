using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        int valor = (int)(n * 100);

        int nota100 = valor / 10000;
        valor = valor % 10000;

        int nota50 = valor / 5000;
        valor = valor % 5000;

        int nota20 = valor / 2000;
        valor = valor % 2000;

        int nota10 = valor / 1000;
        valor = valor % 1000;

        int nota5 = valor / 500;
        valor = valor % 500;

        int nota2 = valor / 200;
        valor = valor % 200;

        int moeda1 = valor / 100;
        valor = valor % 100;

        int moeda050 = valor / 50;
        valor = valor % 50;

        int moeda025 = valor / 25;
        valor = valor % 25;

        int moeda010 = valor / 10;
        valor = valor % 10;

        int moeda005 = valor / 5;
        valor = valor % 5;

        int moeda001 = valor;

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
        Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
        Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
        Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
        Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
        Console.WriteLine($"{nota2} nota(s) de R$ 2.00");

        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
        Console.WriteLine($"{moeda050} moeda(s) de R$ 0.50");
        Console.WriteLine($"{moeda025} moeda(s) de R$ 0.25");
        Console.WriteLine($"{moeda010} moeda(s) de R$ 0.10");
        Console.WriteLine($"{moeda005} moeda(s) de R$ 0.05");
        Console.WriteLine($"{moeda001} moeda(s) de R$ 0.01");
    }
}
