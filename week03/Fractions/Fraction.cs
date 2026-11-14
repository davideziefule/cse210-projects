namespace Fractions;
public class Fraction
{
    // private fields
    private int numerator;
    private int denominator;

    // constructors
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }
    public Fraction(int topValue)
    {
        numerator = topValue;
        denominator = 1;
    }
    public Fraction(int topValue, int bottomValue)
    {
        numerator = topValue;
        denominator = bottomValue;
    }

    // getters and setters
    // Getter for numerator
    public int GetNumerator()
    {
        return numerator;
    }

    // Setter for numerator
    public void SetNumerator(int topValue)
    {
        numerator = topValue;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return denominator;
    }

    // Setter for denominator
    public void SetDenominator(int bottomValue)
    {
        denominator = bottomValue;
    }

    // method to display the fraction
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // method to display the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}