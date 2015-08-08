using System;

namespace Problem11.DivisionBy5
{
    class DivisionBy5
    {
        static void Main()
        {
            //Write a program that reads two positive integer numbers and 
            //prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            // setting a variable that is counting the number divisible by 5
            int p = 0;
            // for loop statemnet to pass trough every element in the range
            for (int i = a; i <= b; i++)
            {
                //if statement to check which of the numbers are divisible by 5
                if (i % 5 == 0)
                {
                    p++;

                }
            }
            Console.WriteLine("There are {0} numbers divisible by 5 in the range", p);
        }
    }
}
