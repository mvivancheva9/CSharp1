using System;

namespace Problem09.Matrix
{
    class Matrix
    {
        static void Main()
        {
           /* Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
            * and prints a matrix like in the examples below. Use two nested loops.*/

            Console.Write("Enter a whole number for N: ");//prompt the user to enter value for N
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 20)
            {
                for (int row = 1; row <= n; row++)//for loop to pass through every n
                {
                    for (int col = row; col < n + row; col++)//for to construct evely column
                    {
                        Console.Write("{0} ", col);//printing
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Enter a number in the range [1..20] including");
            }

        }
    }
}
