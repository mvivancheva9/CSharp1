using System;

namespace Problem01.NumbersToN
{
    class NumbersToN
    {
        static void Main()
        {
            //Write a program that enters from the console a positive integer n and prints all 
            //the numbers from 1 to n, on a single line, separated by a space.

            Console.Write("Enter a number: ");//prompts the user to enter a number
            int n = int.Parse(Console.ReadLine());// convert to integer

            for (int i = 1; i <=n; i++)//for loop to pass through all the numbers from 1 to n
            {
                Console.Write("{0} ", i);// print them in the desired format
            }
        }
    }
}
