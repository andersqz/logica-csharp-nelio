using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string[] peca1 = Console.ReadLine()!.Split(' ');
        string[] peca2 = Console.ReadLine()!.Split(' ');

        int codigo1 = Int32.Parse(peca1[0]);
        int numero1 = Int32.Parse(peca1[1]);
        double valor1 = Double.Parse(peca1[2], CultureInfo.InvariantCulture);

        int codigo2 = Int32.Parse(peca2[0]);
        int numero2 = Int32.Parse(peca2[1]);
        double valor2 = Double.Parse(peca2[2], CultureInfo.InvariantCulture);

        double totalPecas = (numero1 * valor1) + (numero2 * valor2);

        System.Console.WriteLine($"VALOR A PAGAR: {totalPecas.ToString("F2", CultureInfo.InvariantCulture)}");
        

    }
}