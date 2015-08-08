using System;

namespace Problem3.Division
{
    class Division
    {
        static void Main()
        {
            Console.Write("Enter a whole number: ");
            int wholeNum = int.Parse(Console.ReadLine());

            bool isDivisible = (wholeNum % 7 == 0) && (wholeNum % 5 == 0);

            if (isDivisible == true)
            {
                Console.WriteLine("The number you entered is divisible by both 5 and 7");
            }
            else
            {
                Console.WriteLine("The number you entered is not divisible by both 5 and 7");
            }
        }
    }
}
