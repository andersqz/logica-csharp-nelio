using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[,] matriz = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(s[j]);
            }
        }


        int[] vet = new int[n];
        for (int i = 0; i < n; i++)
        {
            int soma = 0;
            for (int j = 0; j < n; j++)
            {
                soma = soma + matriz[i, j];
            }
            vet[i] = soma;
        }

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine(vet[i]);
        }
    }
}