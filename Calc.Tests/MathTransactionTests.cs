namespace Calc.Tests;

public class MathTransactionTests
{
    [Fact]
    public void AddTransaction_Calc_ShouldReturnSum()
    {
        // Arrange
        var transaction = new AddTansaction();
        decimal number1 = 5;
        decimal number2 = 3;
        decimal expected = 8;

        // Act
        decimal result = transaction.Calc(number1, number2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void SubtractTransaction_Calc_ShouldReturnDifference()
    {
        // Arrange
        var transaction = new SubtractTransaction();
        decimal number1 = 5;
        decimal number2 = 3;
        decimal expected = 2;

        // Act
        decimal result = transaction.Calc(number1, number2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void MultiplyTransaction_Calc_ShouldReturnProduct()
    {
        // Arrange
        var transaction = new MultiplyTransaction();
        decimal number1 = 5;
        decimal number2 = 3;
        decimal expected = 15;

        // Act
        decimal result = transaction.Calc(number1, number2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DivideTransaction_Calc_ShouldReturnQuotient()
    {
        // Arrange
        var transaction = new DivideTransaction();
        decimal number1 = 6;
        decimal number2 = 3;
        decimal expected = 2;

        // Act
        decimal result = transaction.Calc(number1, number2);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DivideTransaction_Calc_DivideByZero_ShouldThrowDivideByZeroException()
    {
        // Arrange
        var transaction = new DivideTransaction();
        decimal number1 = 5;
        decimal number2 = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => transaction.Calc(number1, number2));
    }
}
