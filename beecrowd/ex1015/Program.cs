using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string[] plano1 = Console.ReadLine()!.Split(' ');
        string[] plano2 = Console.ReadLine()!.Split(' ');

        float x1 = float.Parse(plano1[0], CultureInfo.InvariantCulture);
        float y1 = float.Parse(plano1[1], CultureInfo.InvariantCulture);

        float x2 = float.Parse(plano2[0], CultureInfo.InvariantCulture);
        float y2 = float.Parse(plano2[1], CultureInfo.InvariantCulture);

        float distancia = (float) Math.Sqrt( Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) );

        System.Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));

    }
}