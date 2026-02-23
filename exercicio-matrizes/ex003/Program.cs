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



        for (int i = 0; i < n; i++)
        {
            int maior = matriz[0, 0];
            for (int j = 0; j < n; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
            System.Console.WriteLine(maior);
        }

    }
}