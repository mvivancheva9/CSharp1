using System;

namespace Problem09.SumNumbersN
{
    class SumNumbersN
    {
        static void Main()
        {
            //Write a program that enters a number n and after that 
            //enters more n numbers and calculates and prints their sum. 
            //Note: You may need to use a for-loop.

            Console.Write("Enter how many numbers you want to sum: ");
            int n = int.Parse(Console.ReadLine());

            //set the sum to be 0
            double sum = 0;
            //setting a for loop statement which prompts the use to enter numbers
            for (int i = 1; i <= n; i++)
            {
                Console.Write("number {0} = ", i);
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            //printing the sum
            Console.WriteLine("The sum of the entered numbers is: {0}", sum);
        }
    }
}
