using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int m, n;
        int[,] a;
        int[,] b;

        string[] s = Console.ReadLine()!.Split(' ');
        m = int.Parse(s[0]);
        n = int.Parse(s[1]);
        a = new int[m, n];
        b = new int[m, n];

        // leitura da matriz a
        for (int i = 0; i < m; i++)
        {
            string[] vet = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
            {
                a[i, j] = int.Parse(vet[j]);
            }
        }

        // leitura da matriz b
        for (int i = 0; i < m; i++)
        {
            string[] vet = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
            {
                b[i, j] = int.Parse(vet[j]);
            }
        }


        // leitura da matriz c inserindo a soma de a[,] + b[,] 
        int[,] c = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                c[i, j] = a[i, j] + b[i, j];
            }
        }

        // exibi a matriz c
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                System.Console.Write(c[i, j] + " ");
            }
            System.Console.WriteLine();
        }


    }
}