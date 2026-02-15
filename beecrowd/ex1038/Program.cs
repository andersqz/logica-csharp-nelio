using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int x, y; 
        double preco;
        string[] vet = Console.ReadLine()!.Split(' ');

        x = Int32.Parse(vet[0]);
        y = Int32.Parse(vet[1]);

        switch (x)
        {
            case 1:
                preco = y * 4.00;
                System.Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");
                break;
            case 2:
                preco = y * 4.50;
                System.Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");
                break;
            case 3:
                preco = y * 5.00;
                System.Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");
                break;
            case 4:
                preco = y * 2.00;
                System.Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");
                break;
            case 5:
                preco = y * 1.50;
                System.Console.WriteLine($"Total: R$ {preco.ToString("F2", CultureInfo.InvariantCulture)}");
                break;
            default:
                System.Console.WriteLine("VALOR INVALIDO");
                break;
        }
    }
}