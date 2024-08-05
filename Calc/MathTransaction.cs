namespace Calc;

public abstract class MathTransaction
{
    public abstract decimal Calc(decimal number1, decimal number2);
}

public class AddTansaction : MathTransaction
{
    public override decimal Calc(decimal number1, decimal number2)
    {
        return number1 + number2;
    }
}

public class SubtractTransaction : MathTransaction
{
    public override decimal Calc(decimal number1, decimal number2)
    {
        return number1 - number2;
    }
}

public class MultiplyTransaction : MathTransaction
{
    public override decimal Calc(decimal number1, decimal number2)
    {
        return number1 * number2;
    }
}

public class DivideTransaction : MathTransaction
{
    public override decimal Calc(decimal number1, decimal number2)
    {
        return number1 / number2;
    }
}