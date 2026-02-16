using System;

class Program {
    static void Main() {

        int x, y, min, max; 
        int soma = 0;

        x = int.Parse(Console.ReadLine()!);
        y = int.Parse(Console.ReadLine()!);

        if (x < y) {
            min = x;
            max = y;
        } else {
            min = y;
            max = x;
        }

        for ( int i = min + 1; i < max; i++ ) {
            if (i % 2 != 0) {
                soma = soma + i;
            }
        }

        System.Console.WriteLine(soma);
    }
    
}