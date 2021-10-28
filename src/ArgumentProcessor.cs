using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public static class ArgumentProcessor
{
    private static readonly IList<char> rightChars =
    new ReadOnlyCollection<char>(new List<char> { 'r', 'w', 'x', 's', 't' });

    public static void ValidateArguments(int argsLength)
    {
        if (argsLength > 1)
        {
            throw new ArgumentException("You have entered too many arguments.");
        }
        else if (argsLength < 1)
        {
            throw new ArgumentException("You have entered too less argument.");
        }
    }

    public static void ValidateRights(string rightsExpr, RightsFormat rightsFormat)
    {
        if (rightsFormat == RightsFormat.Numeric)
        {
            ValidateNumeric(rightsExpr);
        }
        else
        {
            ValidateAlphabetic(rightsExpr);
        }
    }

    private static void ValidateNumeric(string rightsExpr)
    {
        foreach (var bitChar in rightsExpr)
        {
            var bitNumber = Convert.ToByte(bitChar);
            if (bitNumber < 0 || bitNumber > 7)
            {
                throw new FormatException("Invalid Numeric rights format.");
            }
        }
    }

    private static void ValidateAlphabetic(string rightsExpr)
    {
        foreach (var bit in rightsExpr)
        {
            if (!rightChars.Contains(Char.ToLower(bit)))
            {
                throw new FormatException("Invalid Alphabetic rights format.");
            }
        }
    }
}
