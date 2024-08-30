using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorLibraryTest;

[TestClass]
public class CalculatorTests
{
    private Calculator _calculator = null!;

    [TestInitialize]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [TestMethod]
    public void Add_ShouldReturnCorrectSum()
    {
        double result = _calculator.Add(2, 3);
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        double result = _calculator.Subtract(5, 3);
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        double result = _calculator.Multiply(2, 3);
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void Divide_ByZero_ShouldThrowException()
    {
        _calculator.Divide(5, 0);
    }

    [TestMethod]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        double result = _calculator.Divide(6, 3);
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void Sin_ShouldReturnCorrectValue()
    {
        double result = _calculator.Sin(30);
        Assert.AreEqual(0.5, result, 0.0001);
    }

    [TestMethod]
    public void Cos_ShouldReturnCorrectValue()
    {
        double result = _calculator.Cos(60);
        Assert.AreEqual(0.5, result, 0.0001);
    }

    [TestMethod]
    public void Tan_ShouldReturnCorrectValue()
    {
        double result = _calculator.Tan(45);
        Assert.AreEqual(1, result, 0.0001);
    }

    [TestMethod]
    public void Log_ShouldReturnCorrectValue()
    {
        double result = _calculator.Log(100);
        Assert.AreEqual(2, result, 0.0001);
    }

    [TestMethod]
    public void Sqrt_ShouldReturnCorrectValue()
    {
        double result = _calculator.Sqrt(16);
        Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Power_ShouldReturnCorrectValue()
    {
        double result = _calculator.Power(2, 3);
        Assert.AreEqual(8, result);
    }
}
