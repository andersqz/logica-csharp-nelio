using System;

class Program
{
    static void Main()
    {
        int a = Int32.Parse(Console.ReadLine()!);
        int b = Int32.Parse(Console.ReadLine()!);

        int soma = a + b;

        System.Console.WriteLine($"SOMA = {soma}");
    }
}