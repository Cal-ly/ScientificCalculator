namespace CalculatorLibrary;

/// <summary>
/// Provides basic and advanced mathematical operations.
/// </summary>
public class Calculator
{
    /// <summary>
    /// Adds two numbers.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The sum of the two numbers.</returns>
    public double Add(double a, double b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts the second number from the first number.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The difference between the two numbers.</returns>
    public double Subtract(double a, double b)
    {
        return a - b;
    }

    /// <summary>
    /// Multiplies two numbers.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The product of the two numbers.</returns>
    public double Multiply(double a, double b)
    {
        return a * b;
    }

    /// <summary>
    /// Divides the first number by the second number.
    /// </summary>
    /// <param name="a">The first number.</param>
    /// <param name="b">The second number.</param>
    /// <returns>The quotient of the division.</returns>
    /// <exception cref="DivideByZeroException">Thrown when the second number is zero.</exception>
    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }

    /// <summary>
    /// Calculates the sine of an angle.
    /// </summary>
    /// <param name="angle">The angle in degrees.</param>
    /// <returns>The sine of the angle.</returns>
    public double Sin(double angle)
    {
        return Math.Sin(DegreeToRadian(angle));
    }

    /// <summary>
    /// Calculates the cosine of an angle.
    /// </summary>
    /// <param name="angle">The angle in degrees.</param>
    /// <returns>The cosine of the angle.</returns>
    public double Cos(double angle)
    {
        return Math.Cos(DegreeToRadian(angle));
    }

    /// <summary>
    /// Calculates the tangent of an angle.
    /// </summary>
    /// <param name="angle">The angle in degrees.</param>
    /// <returns>The tangent of the angle.</returns>
    public double Tan(double angle)
    {
        return Math.Tan(DegreeToRadian(angle));
    }

    /// <summary>
    /// Calculates the base-10 logarithm of a number.
    /// </summary>
    /// <param name="value">The number.</param>
    /// <returns>The base-10 logarithm of the number.</returns>
    public double Log(double value)
    {
        return Math.Log10(value);
    }

    /// <summary>
    /// Calculates the square root of a number.
    /// </summary>
    /// <param name="value">The number.</param>
    /// <returns>The square root of the number.</returns>
    public double Sqrt(double value)
    {
        return Math.Sqrt(value);
    }

    /// <summary>
    /// Raises a number to a specified power.
    /// </summary>
    /// <param name="baseValue">The base number.</param>
    /// <param name="exponent">The exponent.</param>
    /// <returns>The result of raising the base number to the specified power.</returns>
    public double Power(double baseValue, double exponent)
    {
        return Math.Pow(baseValue, exponent);
    }

    /// <summary>
    /// Converts an angle from degrees to radians.
    /// </summary>
    /// <param name="angle">The angle in degrees.</param>
    /// <returns>The angle in radians.</returns>
    private double DegreeToRadian(double angle)
    {
        return Math.PI * angle / 180.0;
    }
}
