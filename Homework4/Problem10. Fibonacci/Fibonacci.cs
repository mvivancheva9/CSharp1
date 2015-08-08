using System;

namespace Problem10.Fibonacci
{
    class Fibonacci
    {
        static void Main()
        {
            //Write a program that reads a number n and prints on the console the first 
            //n members of the Fibonacci sequence (at a single line, separated by comma and space - ,)
            //: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 

            Console.Write("Enter a number for the end of the Fibonacci sequence: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            Console.Write(a);
            // using for loop to create and print the fibonacci sequence
            for (int i = 0; i < n-1; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                Console.Write(", {0}",a);
            }
            Console.WriteLine("");
        }
    }
}
