using System;

class Program
{
    static void Main()
    {
        int n;

        n = Int32.Parse(Console.ReadLine()!);

        for ( int i = 1; i <= 10; i++ ) {
            Console.WriteLine($"{i} X {n} = {i * n}");
        }
    }
}