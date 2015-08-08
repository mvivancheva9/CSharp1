using System;

namespace Problem7.QuoteStrings
{
    class QuoteStrings
    {
        static void Main()
        {
            string variable1 = "The \"use\" of quotations causes difficulties.";
            string verbatim = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(variable1);
            Console.WriteLine(verbatim);
        }
    }
}
