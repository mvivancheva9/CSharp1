using System;

namespace Problem10.OddEvenProduct
{
    class OddEvenProduct
    {
        static void Main()
        {
            /*You are given n integers (given in a single line, separated by a space).
             * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
             * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.*/

            Console.Write("Enter n integers, separateg by SPACE: ");// prompt the user to enter sequence of integers, separated b SPACE
            string[] sequence = Console.ReadLine().Split(' ');//stores the entered valuse and remove the spaces

            int productOdd = 1;//set variable to store the product of the odd numbers
            int productEven = 1;// set variable to store the product of the even numbers
            for (int position = 0; position < sequence.Length; position++)// for loop to pass through each of the numbers
            {
                int number = int.Parse(sequence[position]);// converts the entered numbers to integer type
                if (position == 0 || position % 2 == 0)// check the position of the number
                {
                    productEven *= number;//calculates the product of the numbers on even positions
                }
                else
                {
                    productOdd *= number;// calculates the product of the numbers on odd positions
                }
                
            }
            bool isEqual = productEven == productOdd;// set a boolean variable to check whether the two products are equal
            if (isEqual == true)// check the boolean variable
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("The product of the odd numbers is: {0}", productOdd);
                Console.WriteLine("The produt of the even numbers is: {0}", productEven);
            }
        }
    }
}
