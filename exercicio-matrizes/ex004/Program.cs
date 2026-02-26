using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[,] matriz = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(s[j]);
            }
        }


        int acumulador = 0;
        for (int i = 0; i < n; i++)
        {
            int soma = 0;
            for (int j = 0; j < n; j++)
            {
                    if (j > i)
                {
                    acumulador += matriz[i, j];
                }
            }
            System.Console.WriteLine(acumulador);
        }
    }
}