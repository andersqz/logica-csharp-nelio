using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        //atribuicão e inicialização de variáveis (const eh conhecimento previo)
        double area;
        double raio;
        const double PI = 3.14159;

        //validei a entrada do usuario e atribui seu conteúdo dentro da variável raio
        raio = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        //area recebe o valor de PI multiplicado pelo resultado da expressao que eleva o valor de raio ao quadrado
        area = PI * (Math.Pow(raio, 2));

        System.Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");

        
    }
}