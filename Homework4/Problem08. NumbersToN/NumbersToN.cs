using System;

namespace Problem08.NumbersToN
{
    class NumbersToN
    {
        static void Main()
        {
            //Write a program that reads an integer number n from the console and 
            //prints all the numbers in the interval [1..n], each on a single line.

            //Prompting the user to ente a whole number
            Console.Write("Enter a whole number: ");
            //storing the value into a variable
            int n = int.Parse(Console.ReadLine());

            // creating a for loop to print the numbers in the sequence
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
