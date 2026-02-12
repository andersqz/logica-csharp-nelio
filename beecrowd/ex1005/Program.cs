using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double a = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        double b = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double media = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);

        System.Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}");
    }
}