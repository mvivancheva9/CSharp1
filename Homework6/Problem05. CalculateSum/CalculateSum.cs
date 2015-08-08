using System;

namespace Problem05.CalculateSum
{
    class CalculateSum
    {
        static void Main()
        {
            /*Write a program that, for a given two integer numbers n and x,
             *calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
             *Use only one loop. Print the result with 5 digits after the decimal point.*/

            Console.Write("Enter a whole number for N: ");//prompt the user to enter value for N
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter a whole number for X: ");// prompt the user to enter value for X
            int x = int.Parse(Console.ReadLine());
            double factoriel = 1;// setting a variable to store the factoriel
            double power = 1;// setting a value to store the x to the power of N
            double sum = 1;// set the sum = 1

            for (int i = 1; i <= n; i++)// for toop to pass through all N
            {
                factoriel *= i;// calculate the factoriel
                power *= x;// calculate x to the power of n
                sum += factoriel / power;// calculate sum, accroding to the formula
                
                
            }
            Console.WriteLine("The sum according to the formula is: {0:F5}", sum);//print
        }
    }
}
