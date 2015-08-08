using System;

namespace Problem17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            /*Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
             * Use the Euclidean algorithm (find it in Internet).*/

            Console.Write("Enter a whole number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter a second whole number: ");
            int b = int.Parse(Console.ReadLine());

            int bigger = 0;// used to store the bigger of the two numbers
            int tempNum = 0;// variable used for calculation
            int delta = 0;// variable used for calculation
            int remainder = 0;// variable to store the remainder

            if (a > b)//check which of the two integers is bigger
            {
                bigger = a;
                delta = b;
            }
            else if (b > a)
            {
                bigger = b;
                delta = a;
            }
            else
            {
                bigger = delta = a;
            }
            remainder = bigger  % delta;//calculate the first remainder
            while (remainder > 0)// while loop until the remainder > 0
            {
                tempNum = remainder;
                remainder = delta % tempNum;
                delta = tempNum;
            }
            Console.WriteLine("The greatest common divisor of {0} and {1} is {2}", a , b, delta);// print
        }
    }
}
