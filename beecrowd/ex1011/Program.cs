using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double raio;
        double volume;
        const double PI = 3.14159;

        raio = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        volume = (4 / 3.0) * PI * (Math.Pow(raio, 3));

        System.Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}