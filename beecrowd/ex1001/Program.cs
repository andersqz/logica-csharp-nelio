using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //inicializei uma variavel validando a entrada do usuario
        int a = Int32.Parse(Console.ReadLine()!);
        int b = Int32.Parse(Console.ReadLine()!);

        //atribui à variável x o resultado da soma de a + b 
        int x = a + b;

        //saida de dados: exibi o conteúdo da variável x no console
        System.Console.WriteLine($"X = {x}");

    }
}
