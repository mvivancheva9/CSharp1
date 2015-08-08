using System;
using System.Numerics;

namespace Problem18.TrailingZeros
{
    class TrailingZeros
    {
        static void Main()
        {
            /*Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
             * Your program should work well for very big numbers, e.g. n=100000.*/

            Console.Write("Enter a number: ");// prompt the user to enter a number
            int n = int.Parse(Console.ReadLine());// store the number in initeger type
            BigInteger division = 0;// variable for the division by 10
            BigInteger factorielN = 1;// variable for factoriel of n
            BigInteger counter = 0;// variable to store the number of Zeros

            for (int i = 1; i <=n; i++)// for loop to calculate the factoriel
            {
                factorielN *= i;
            }
            Console.WriteLine(factorielN);
            division = factorielN;// set the value of variable division
            while (division % 10 == 0)// while loop the check the remainder
            {
                counter++;
                division = division / 10;
            }
            Console.WriteLine("The number of Zeros in the factoriel is: {0}", counter);// printing
        }
    }
}
