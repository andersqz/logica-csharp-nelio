using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int distancia = Int32.Parse(Console.ReadLine()!);
        double gas = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double consumo = distancia / gas;

        System.Console.WriteLine($"{consumo.ToString("F3", CultureInfo.InvariantCulture)} km/l");


    }
}