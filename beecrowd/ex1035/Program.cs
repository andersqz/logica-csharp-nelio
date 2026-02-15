using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main()
    {
        int a, b, c, d;

        string[] vet = Console.ReadLine()!.Split(' ');
        a = Int32.Parse(vet[0]);
        b = Int32.Parse(vet[1]);
        c = Int32.Parse(vet[2]);
        d = Int32.Parse(vet[3]);

        if (b > c && d > a && (c + d) > (a + b) && (c > 0 && d > 0) && (a % 2 == 0))
        {
            System.Console.WriteLine("Valores aceitos");
        }
        else
        {
            System.Console.WriteLine("Valores nao aceitos");
        }

        Console.ReadLine();
        
    }
}