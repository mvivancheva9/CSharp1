using System;

namespace Problem5.ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            Console.Write("Enter a whole number: ");
            string number = Console.ReadLine();
            if (number.Length < 3)
            {
                return;
            }
            char digit = number[number.Length - 3];
            
            bool isSeven = digit == '7';

            if (isSeven == true)
            {
                Console.WriteLine("The Third digit from right-to-left is 7");
            }
            else
            {
                Console.WriteLine("The Third digit from right-to-left is not 7");
            }
        }
    }
}
