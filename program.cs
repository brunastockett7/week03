// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        // Test no-argument constructor
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());  // Output: 1/1
        Console.WriteLine(f1.GetDecimalValue());    // Output: 1

        // Test one-argument constructor
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());  // Output: 5/1
        Console.WriteLine(f2.GetDecimalValue());    // Output: 5

        // Test two-argument constructor
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());  // Output: 3/4
        Console.WriteLine(f3.GetDecimalValue());    // Output: 0.75

        // Test setters and getters
        f3.SetNumerator(1);
        f3.SetDenominator(3);
        Console.WriteLine(f3.GetFractionString());  // Output: 1/3
        Console.WriteLine(f3.GetDecimalValue());    // Output: ~0.3333
    }
}
