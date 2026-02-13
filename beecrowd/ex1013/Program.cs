using System;

class Program
{
    static void Main()
    {
        string[] valores = Console.ReadLine()!.Split(' ');

        int a = Int32.Parse(valores[0]);
        int b = Int32.Parse(valores[1]);
        int c = Int32.Parse(valores[2]);

        int maiorAB = (a + b + (Math.Abs(a - b))) / 2;
        int maiorABC = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

        System.Console.WriteLine(maiorABC + " eh o maior");
    }   
}