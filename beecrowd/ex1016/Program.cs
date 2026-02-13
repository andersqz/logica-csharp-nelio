using System;

class Program
{
    static void Main()
    {
        int km = Int32.Parse(Console.ReadLine()!);

        int minutos = km * 2;

        System.Console.WriteLine($"{minutos} minutos");
    }
}