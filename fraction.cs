
public class Fraction
{
    private int _numerator;
    private int _denominator;

    // No-argument constructor: 1/1
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // One-argument constructor: numerator / 1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    // Two-argument constructor: numerator / denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getter and setter for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Getter and setter for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // Returns string representation "numerator/denominator"
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Returns decimal value as double
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
