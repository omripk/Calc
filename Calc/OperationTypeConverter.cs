using System.ComponentModel;

namespace Calc;

public class OperationTypeConverter
{
    public static OperationType? GetOperationTypeFromDescription(string description)
    {
        foreach (OperationType operation in Enum.GetValues(typeof(OperationType)))
        {
            var fieldInfo = operation.GetType().GetField(operation.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0 && attributes[0].Description == description)
            {
                return operation;
            }
        }
        return null; // Or throw an exception if you prefer
    }
}