namespace Calc.Tests;

public class OperationTypeTests
{
    [Theory]
    [InlineData("+", OperationType.Add)]
    [InlineData("-", OperationType.Subtract)]
    [InlineData("*", OperationType.Multiply)]
    [InlineData("/", OperationType.Divide)]
    public void GetOperationTypeFromDescription_ValidDescriptions_ShouldReturnCorrectEnum(string description, OperationType expected)
    {
        // Act
        var result = OperationTypeConverter.GetOperationTypeFromDescription(description);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("x")]
    [InlineData("add")]
    [InlineData(null)]
    public void GetOperationTypeFromDescription_InvalidDescriptions_ShouldReturnNull(string description)
    {
        // Act
        var result = OperationTypeConverter.GetOperationTypeFromDescription(description);

        // Assert
        Assert.Null(result);
    }
}