namespace Calc.Tests;

public class MathFactoryTests
{
    private readonly MathFactory _mathFactory;

    public MathFactoryTests()
    {
        _mathFactory = new MathFactory();
    }

    [Theory]
    [InlineData(1, 2, "+", 3)]
    [InlineData(5, 3, "-", 2)]
    [InlineData(4, 2, "*", 8)]
    [InlineData(10, 2, "/", 5)]
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
        decimal number2 = 2;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => _mathFactory.Calc(number1, number2, operation));
    }
}