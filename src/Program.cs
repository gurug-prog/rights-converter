using System;

class Program
{
    static void Main(string[] args)
    {
        // rw(Ssx)rw(Ssx)rw(Ttx)
        if (args.Length != 1)
        {
            throw new ArgumentException("You have entered too many or less than needed arguments.");
        }

        var rightsExpr = args[0];
        var rightsFormat = RightsConverter.GetFormat();
        var isRightsCorrect = RightsConverter.ValidateRights(rightsExpr, rightsFormat);

        if (!isRightsCorrect)
        {
            throw new FormatException("Invalid rights format.");
        }

        var rightsConverted = new Object();
        if (rightsFormat == RightsFormat.Numeric)
        {
            rightsConverted = RightsConverter.ConvertToAlphabetic();
        }
        else
        {
            rightsConverted = RightsConverter.ConvertToNumeric();
        }

        var a = rightsConverted as string;

        Console.WriteLine(rightsConverted);
    }
}
