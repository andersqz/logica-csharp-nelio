using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double num1, num2, num3, num4;
        double media;
        string[] vet = Console.ReadLine()!.Split(' ');
        double notaExame;
        double mediaRecalc;

        num1 = Double.Parse(vet[0], CultureInfo.InvariantCulture);
        num2 = Double.Parse(vet[1], CultureInfo.InvariantCulture);
        num3 = Double.Parse(vet[2], CultureInfo.InvariantCulture);
        num4 = Double.Parse(vet[3], CultureInfo.InvariantCulture);

        media = ((num1 * 2) + (num2 * 3) + (num3 * 4) + (num4 * 1)) / (2 + 3 + 4 + 1);

        System.Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");

        if (media >= 7.0) {
            System.Console.WriteLine("Aluno aprovado");
        }
        else {
            if(media < 5.0) {
            System.Console.WriteLine("Aluno reprovado");
            }
            else if (media >= 5.0 && media <= 6.9) {
                System.Console.WriteLine("aluno em exame");
                notaExame = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                System.Console.WriteLine($"Nota exame: {notaExame}");
                mediaRecalc = (media + notaExame) / 2;
                if (mediaRecalc > 5.0) {
                    System.Console.WriteLine("Aluno aprovado");
                    System.Console.WriteLine($"Media final: {mediaRecalc}");
                }
                else if (mediaRecalc <= 4.9) {
                    System.Console.WriteLine("Aluno reprovado");
                    System.Console.WriteLine($"Media final: {mediaRecalc}");
                }

            }
        }


    }
}