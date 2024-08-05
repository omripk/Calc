Problem:

Create a calculator, ensuring it is developed in compliance with the SOLID principles. Write it along with unit tests.

Base Code:

```csharp
public static void Main()
{
    var result = Calculate(10, 20, "-"); // -10
    Console.WriteLine(result);
}

private static decimal Calculate(decimal n1, decimal n2, string operation)
{
    throw new NotImplementedException();
}
