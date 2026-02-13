/*Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, 
e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.*/
using System;

class Program
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine()!);

        int horas = n / 3600;
        int resto = n % 3600;
        int minutos = resto / 60;
        int segundos = resto % 60;

        System.Console.WriteLine($"{horas}:{minutos}:{segundos}"); 

    }
}