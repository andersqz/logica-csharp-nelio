using System;
using System.Globalization;
using System.Runtime.CompilerServices;

class Program
{
    static void Main()
    {
        const double PI = 3.14159;
        string[] valores = Console.ReadLine()!.Split(' ');
        double a = Double.Parse(valores[0], CultureInfo.InvariantCulture);
        double b = Double.Parse(valores[1], CultureInfo.InvariantCulture);
        double c = Double.Parse(valores[2], CultureInfo.InvariantCulture);

        double areaTriangulo = (a * c) / 2;
        double areaCirculo = PI * (Math.Pow(c, 2));
        double areaTrapezio = ((a + b) * c) / 2;
        double areaQuadrado = Math.Pow(b, 2);
        double areaRetangulo = a * b;

        System.Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");


    }
}