using System;

namespace Problem04.NumberComparer
{
    class NumbeerComparer
    {
        static void Main()
        {
            //Write a program that gets two numbers from the console and prints the greater of them.
            //Try to implement this without if statements.

            //Prompting the user to enter information
            Console.Write("Enter a number: ");
            double firstNum = double.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            //Checking which is the greater number
            double greater = (firstNum > secondNum) ? firstNum : secondNum;
            Console.WriteLine(greater);
            }
    }
}
