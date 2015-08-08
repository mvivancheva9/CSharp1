using System;

namespace Problem04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            /*
             * Write a program that shows the sign (+, - or 0) 
             * of the product of three real numbers, without calculating it.
             * Use a sequence of if operators.
             */
            Console.Write("Enter the first number: ");//prompting the user to enter three real numbers
            double firstNum = double.Parse(Console.ReadLine());// converting to type double

            Console.Write("Enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double thirdNum = double.Parse(Console.ReadLine());
            if (firstNum == 0 || secondNum == 0 || thirdNum == 0)// chech whether any of them == 0
            {
                Console.WriteLine("0");
            }
            else if (firstNum > 0)// if none, check whether the first one > 0
            {
                if (secondNum > 0)// if the first one > 0, check whether the second one > 0
                {
                    if (thirdNum > 0)// if the seconf one > 0 too, check whether the third one > 0
                    {
                        Console.WriteLine("+");//print + when all are > 0
                    }
                    else
                    {
                        Console.WriteLine("-");//print -, when the third number is < 0
                    }
                }
                else if (thirdNum > 0)//checks the third num, when the second < 0
                {
                    Console.WriteLine("-");// print -, when the third > 0
                }
                else
                {
                    Console.WriteLine("+");// print +, when the third < 0
                }
            }
            else if (secondNum > 0)//checks the second when first < 0
            {
                if (thirdNum > 0)//checks the third when the first < 0 and second > 0
                {
                    Console.WriteLine("-");//print -, when the third > 0
                }
                else
                {
                    Console.WriteLine("+");// print +, when the third < 0
                }
            }
            else if (thirdNum > 0)// checks the third when the first < 0 and second < 0
            {
                Console.WriteLine("+");// print + when the third > 0
            }
            else
            {
                Console.WriteLine("-");//print - when the third < 0
            }
        }
    }
}
