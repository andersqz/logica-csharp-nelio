using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int number = Int32.Parse(Console.ReadLine()!);
        int hours = Int32.Parse(Console.ReadLine()!);
        double hourlyWage = Double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        double salary = hourlyWage * hours;
        System.Console.WriteLine($"Number = {number}");
        System.Console.WriteLine($"Salary = {salary.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}