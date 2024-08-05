using System.ComponentModel;

namespace Calc;

public class MathFactory
{
    public decimal Calc(decimal number1, decimal number2, string operation)
    {
        var operationObject = GetMathTransactions(operation);
        return operationObject.Calc(number1, number2);
    }

    private MathTransaction GetMathTransactions(string operation)
    {
        var operationType = OperationTypeConverter.GetOperationTypeFromDescription(operation);
        return operationType switch
        {
            OperationType.Add => new AddTansaction(),
            OperationType.Subtract => new SubtractTransaction(),
            OperationType.Multiply => new MultiplyTransaction(),
            OperationType.Divide => new DivideTransaction(),
            _ => throw new ArgumentOutOfRangeException(nameof(operationType), operationType, null)
        };
    }
}

public enum OperationType
{
    [Description("+")] Add = 0,
    [Description("-")] Subtract = 1,
    [Description("*")] Multiply = 2,
    [Description("/")] Divide = 3
}