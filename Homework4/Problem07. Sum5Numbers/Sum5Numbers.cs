using System;

namespace Problem07.Sum5Numbers
{
    class Sum5Numbers
    {
        static void Main()
        {
            //Write a program that enters 5 numbers 
            //(given in a single line, separated by a space), calculates and prints their sum.

            Console.Write("Enter 5 numbers, separated by SPACE: ");
            string[] input = Console.ReadLine().Split();
            //converting each of the separated elements from the above to double variable
            double a = Convert.ToDouble(input[0]);
            double b = Convert.ToDouble(input[1]);
            double c = Convert.ToDouble(input[2]);
            double d = Convert.ToDouble(input[3]);
            double e = Convert.ToDouble(input[4]);
            //printing the sum
            Console.WriteLine("The sum of the numbers is: {0}", a + b + c + d + e);
        }
    }
}
