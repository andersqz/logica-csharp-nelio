using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double a, b, c, delta;
        double r1, r2;

        string[] vet = Console.ReadLine()!.Split(' ');

        a = Double.Parse(vet[0], CultureInfo.InvariantCulture);
        b = Double.Parse(vet[1], CultureInfo.InvariantCulture);
        c = Double.Parse(vet[2], CultureInfo.InvariantCulture);

        delta = Math.Pow(b, 2.0) - 4 * a * c;

        if (a == 0 || delta < 0.00) 
            System.Console.WriteLine("Impossivel calcular");
        else {
            r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            System.Console.WriteLine($" R1 = {r1.ToString("F5", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($" R1 = {r2.ToString("F5", CultureInfo.InvariantCulture)}");
        }
        
        Console.ReadLine();

    }
}