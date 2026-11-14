using System;
namespace Fractions;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine($"Fraction 1: {f1.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {f1.GetDecimalValue()}");

        Fraction f2 = new Fraction(3);
        Console.WriteLine($"Fraction 2: {f2.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {f2.GetDecimalValue()}");

        Fraction f3 = new Fraction(2, 5);
        Console.WriteLine($"Fraction 3: {f3.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {f3.GetDecimalValue()}");

        // Test constructor 1: Default fraction (4/6)
        Fraction f4 = new Fraction(4, 6);

        Console.WriteLine("Fraction 4:");
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Test constructor 2: One parameter (5/1)
        Fraction f5 = new Fraction(5);

        Console.WriteLine("\nFraction 5:");
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());

        // Test constructor 3: Two parameters (3/4)
        Fraction f6 = new Fraction(3, 4);

        Console.WriteLine("\nFraction 6:");
        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetDecimalValue());

        // Test getters and setters
        Fraction f7 = new Fraction();

        f7.SetNumerator(1);
        f7.SetDenominator(3);

        Console.WriteLine("\nFraction 7:");
        Console.WriteLine($"Numerator: {f7.GetNumerator()}");
        Console.WriteLine($"Denominator: {f7.GetDenominator()}");
        Console.WriteLine(f7.GetFractionString());
        Console.WriteLine(f7.GetDecimalValue());
    }
}