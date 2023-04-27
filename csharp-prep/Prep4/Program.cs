using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        List<double> numbers = new List<double>();
        double num;
        
        do {
            Console.Write("Enter number: ");
            num = Convert.ToDouble(Console.ReadLine());
            if (num != 0) {
                numbers.Add(num);
            }
        } while (num != 0);

        double sum = numbers.Sum();
        double avg = numbers.Average();
        double max = numbers.Max();

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + avg);
        Console.WriteLine("The largest number is: " + max);

        // Stretch Challenge
        List<double> positiveNumbers = numbers.Where(n => n > 0).ToList();
        double minPositive = positiveNumbers.Min(n => Math.Abs(n));
        Console.WriteLine("The smallest positive number is: " + minPositive);

        List<double> sortedNumbers = numbers.OrderBy(n => n).ToList();
        Console.WriteLine("The sorted list is: ");
        foreach (double number in sortedNumbers) {
            Console.WriteLine(number);
        }
    }
}
