using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double a = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        double b = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        double c = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double media = ((a * 2) + (b * 3) + (c * 5)) / (2 + 3 + 5);

        System.Console.WriteLine($"MEDIA = {media.ToString("F1", CultureInfo.InvariantCulture)}");
    }
}