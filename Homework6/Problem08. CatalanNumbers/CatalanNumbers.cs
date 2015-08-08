using System;

namespace Problem08.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            //In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
            //Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

            Console.Write("Enter a whole number for N: ");//prompt the user to enter value for N
            int n = int.Parse(Console.ReadLine());
            double factorielNPlus = 1;
            double factoriel2N = 1;
            double factorielN = 1;

            for (int i = 1; i <= n * 2; i++)// for loop for each of the elements of the formula
            {
                factoriel2N *= i;
            }
            for (int i = 1; i <=n+1; i++)
            {
                factorielNPlus *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
            }
            Console.WriteLine("{0}", (factoriel2N)/(factorielNPlus * factorielN));// printing
        }
    }
}
