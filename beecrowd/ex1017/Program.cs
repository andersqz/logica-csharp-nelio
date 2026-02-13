using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int tempoGasto = Int32.Parse(Console.ReadLine()!);
        int velocidadeMedia = Int32.Parse(Console.ReadLine()!);

        int distancia = tempoGasto * velocidadeMedia;
        double litros = distancia / 12.0;

        System.Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));

    }
}