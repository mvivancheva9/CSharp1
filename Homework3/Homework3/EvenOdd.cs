using System;

namespace Problem1. EvenOdd
{
    class EvenOdd
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if ( number % 2 == 1)
            {
                Console.WriteLine("The number you entered is odd");
            }
            else
            {
                Console.WriteLine("The number you entered is even");
            }
        }
    }
}
