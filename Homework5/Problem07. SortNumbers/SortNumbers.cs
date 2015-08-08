using System;

namespace Problem07.SortNumbers
{
    class SortNumbers
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");//prompting the user to enter three real numbers
            double firstNum = double.Parse(Console.ReadLine());// converting to type double

            Console.Write("Enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum && firstNum > thirdNum)//check if the first > second and first > third
            {
                if (secondNum > thirdNum)// if it is bigger check secong > third
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", firstNum, secondNum, thirdNum);// print first,second, third
                }
                else
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", firstNum, thirdNum, secondNum);// print the first, third and second
                }
            }
            else if (secondNum > thirdNum)//check second > third, when first < second
            {
                if (firstNum > thirdNum)
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", secondNum, firstNum, thirdNum);// print second, first, third
                }
                else
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", secondNum, thirdNum, firstNum);//print second, third, first
                }
            }
            else
            {
                if (firstNum > secondNum)
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", thirdNum, firstNum, secondNum); // print third, first, second
                }
                else
                {
                    Console.WriteLine("The numbers in descending order are: {0} {1} {2}", thirdNum, secondNum, firstNum);// print third, second, first
                }
            }
        }
    }
}