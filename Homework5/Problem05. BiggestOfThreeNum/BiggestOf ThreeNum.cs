using System;

namespace Problem05.BiggestOfThreeNum
{
    class Program
    {
        static void Main()
        {
            //Write a program that finds the biggest of three numbers.

            Console.Write("Enter the first number: ");//prompting the user to enter three real numbers
            double firstNum = double.Parse(Console.ReadLine());// converting to type double

            Console.Write("Enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum)//check if the first > second
            {
                if (firstNum > thirdNum)// if it is bigger, check first > third
                {
                    Console.WriteLine("The biggest number is: {0}", firstNum);// print first, if it is bigger
                }
                else
                {
                    Console.WriteLine("The biggest number is: {0}", thirdNum);// print third if it is bigger
                }
            }
            else if (secondNum > thirdNum)//check second > third, if when first < second
            {
                Console.WriteLine("The biggest number is: {0}", secondNum);// print second, if it is bigger
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", thirdNum);// print third if it is bigger
            }
        }
    }
}
