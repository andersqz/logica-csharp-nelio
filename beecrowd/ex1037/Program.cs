using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double number;

        number = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        if (number >= 0 && number <= 25)
            System.Console.WriteLine("Intervalo [0,25]");
        else if (number > 25 && number <= 50)
            System.Console.WriteLine("Intervalo [25,50]");
        else if (number > 50 && number <= 75)
            System.Console.WriteLine($"Intervalo [50,75]");
        else if (number > 75 && number <= 100)
            System.Console.WriteLine("Intervalo [75,100]");
    }   
}