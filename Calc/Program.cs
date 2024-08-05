using Calc;

var add = Calculate(10, 20, "+"); //-10
Console.WriteLine($"+: {add}");

var subtract = Calculate(10, 20, "-");
Console.WriteLine($"-: {subtract}");

var multiply = Calculate(10, 20, "*");
Console.WriteLine($"*: {multiply}");

var devide = Calculate(10, 20, "/");
Console.WriteLine($"/: {multiply}");

static decimal Calculate(decimal n1, decimal n2, string operation)
{
    var factory = new MathFactory();
    return factory.Calc(n1, n2, operation);
}