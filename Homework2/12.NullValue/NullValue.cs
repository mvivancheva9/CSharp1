using System;

namespace Problem12. NullValue
{
    class NullValue
    {
        static void Main()
        {
            int? iVariable = null;
            Console.WriteLine("Only the number = {0}", iVariable);
            double? dVariable = null;
            Console.WriteLine("Only the number = {0}", dVariable);
            
            int addValue = 5;
            iVariable = addValue;

            double dAddValue = 5.689;
            dVariable = dAddValue;
            
            Console.WriteLine("The whole number plus some addition = {0}", iVariable);
            Console.WriteLine("The double number plus some addition = {0}", dVariable);

            Console.WriteLine("The whole number plus null literal = {0}", iVariable + null);
            Console.WriteLine("The double number plus null literal = {0}", dVariable + null);
        }
    }
}
