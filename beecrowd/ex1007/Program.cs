using System;

class Program
{
    static void Main()
    {
        int a = Int32.Parse(Console.ReadLine()!);
        int b = Int32.Parse(Console.ReadLine()!);
        int c = Int32.Parse(Console.ReadLine()!);
        int d = Int32.Parse(Console.ReadLine()!);

        int diferenca = (a * b) - (c * d);

        System.Console.WriteLine($"DIFERENCA = {diferenca}");
    }
}