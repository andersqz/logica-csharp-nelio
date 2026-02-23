using System;

class Program
{
    static void Main()
    {
        int m, n;
        int[,] matriz;

        string[] input = Console.ReadLine()!.Split(' ');
        m = int.Parse(input[0]);
        n = int.Parse(input[1]);
        matriz = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            string[] s = Console.ReadLine()!.Split(' ');
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(s[j]);
            }
        }


        System.Console.WriteLine("VALORES NEGATIVOS: ");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j< n; j++)
            {
                if (matriz[i, j] < 0)
                {
                    System.Console.WriteLine(matriz[i, j]);
                }
            }
        }


        
    }
}