namespace CalculatorLibrary;

public class Calculator
{
    // Basic Operations
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }

    // Scientific Functions
    public double Sin(double angle)
    {
        return Math.Sin(DegreeToRadian(angle));
    }

    public double Cos(double angle)
    {
        return Math.Cos(DegreeToRadian(angle));
    }

    public double Tan(double angle)
    {
        return Math.Tan(DegreeToRadian(angle));
    }

    public double Log(double value)
    {
        return Math.Log10(value);
    }

    public double Sqrt(double value)
    {
        return Math.Sqrt(value);
    }

    public double Power(double baseValue, double exponent)
    {
        return Math.Pow(baseValue, exponent);
    }

    // Helper Method: Convert degrees to radians
    private double DegreeToRadian(double angle)
    {
        return Math.PI * angle / 180.0;
    }
}