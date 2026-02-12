using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double area;
        double raio;
        const double PI = 3.14159;

        raio = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        area = PI * (Math.Pow(raio, 2));

        System.Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");

        
    }
}