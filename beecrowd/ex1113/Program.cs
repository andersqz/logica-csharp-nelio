using System;

class Program
{
    static void Main()
    {
        int x, y;

        string[] vet = Console.ReadLine()!.Split(' ');
        x = Int32.Parse(vet[0]);
        y = Int32.Parse(vet[1]);
        
        while (x != y)
        {
            if (x < y)
                System.Console.WriteLine("Crescente");
            else
            System.Console.WriteLine("Decrescente");

            vet = Console.ReadLine()!.Split(' ');
            x = Int32.Parse(vet[0]);
            y = Int32.Parse(vet[1]);

        }
    }
}