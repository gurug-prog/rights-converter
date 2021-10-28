using System;

class Program
{
    static void Main(string[] args)
    {
        // rw(Ssx)rw(Ssx)rw(Ttx)
        ArgumentProcessor.ValidateArguments(args.Length);

        var rightsExpr = args[0];
        var rightsFormat = RightsConverter.GetFormat();
        ArgumentProcessor.ValidateRights(rightsExpr, rightsFormat);


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
