using System;

class Program
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine()!);

        int nota100 = number / 100;
        int resto100 = number % 100;

        int nota50 = resto100 / 50;
        int resto50 = resto100 % 50;

        int nota20 = resto50 / 20;
        int resto20 = resto50 % 20;

        int nota10 = resto20 / 10;
        int resto10 = resto20 % 10;

        int nota5 = resto10 / 5;
        int resto5 = resto10 % 5;

        int nota2 = resto5 / 2;
        int resto2 = resto5 % 2;

        int moeda1 = resto2 / 1;
        int resto1 = resto2 % 1;

        System.Console.WriteLine($"{nota100} notas de R$ 100,00");
        System.Console.WriteLine($"{nota50} notas de R$ 50,00");
        System.Console.WriteLine($"{nota20} notas de R$ 20,00");
        System.Console.WriteLine($"{nota10} notas de R$ 10,00");
        System.Console.WriteLine($"{nota5} notas de R$ 5,00");
        System.Console.WriteLine($"{nota2} notas de R$ 2,00");
        System.Console.WriteLine($"{moeda1} moedas de R$ 1,00");




    }
}