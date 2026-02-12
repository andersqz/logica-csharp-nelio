using System;

class Program
{
    static void Main(string[] args)
    {
        int a = Int32.Parse(Console.ReadLine()!);
        int b = Int32.Parse(Console.ReadLine()!);

        int x = a + b;

        System.Console.WriteLine($"X = {x}");

    }
}
