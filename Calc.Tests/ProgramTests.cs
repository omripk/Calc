namespace Calc.Tests;

public class ProgramTests
{
    private readonly MathFactory _mathFactory;

    public ProgramTests()
    {
        _mathFactory = new MathFactory();
    }

    [Theory]
    [InlineData(10, 20, "+", 30)]
    [InlineData(10, 20, "-", -10)]
    [InlineData(10, 20, "*", 200)]
    [InlineData(10, 20, "/", 0.5)]
    public void Calc_ValidOperations_ShouldReturnExpectedResult(decimal number1, decimal number2, string operation,
        decimal expected)
    {
        // Act
        var result = _mathFactory.Calc(number1, number2, operation);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Calc_DivideByZero_ShouldThrowDivideByZeroException()
    {
        // Arrange
        decimal number1 = 10;
        decimal number2 = 0;
        string operation = "/";

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _mathFactory.Calc(number1, number2, operation));
    }

    [Theory]
    [InlineData("x")]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData(null)]
    public void Calc_InvalidOperation_ShouldThrowArgumentOutOfRangeException(string operation)
    {
        // Arrange
        decimal number1 = 10;
        decimal number2 = 20;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => _mathFactory.Calc(number1, number2, operation));
    }
}