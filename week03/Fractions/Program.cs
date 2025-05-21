using System;

class Program
{
    static void Main(string[] args)
    {
        // Test 1: Default constructor (1/1)
        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction: {f1.GetFractionString()}, Decimal: {f1.GetDecimalValue()}");

        // Test 2: One-parameter constructor (5/1)
        Fraction f2 = new Fraction(5);
        Console.WriteLine($"Fraction: {f2.GetFractionString()}, Decimal: {f2.GetDecimalValue()}");

        // Test 3: Two-parameter constructor (3/4)
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine($"Fraction: {f3.GetFractionString()}, Decimal: {f3.GetDecimalValue()}");

        // Test 4: Another fraction (1/3)
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine($"Fraction: {f4.GetFractionString()}, Decimal: {f4.GetDecimalValue()}");

        // Setters and Getters
        f4.SetTop(2);
        f4.SetBottom(5);
        Console.WriteLine($"Updated Fraction: {f4.GetFractionString()}, Decimal: {f4.GetDecimalValue()}");
    }
}