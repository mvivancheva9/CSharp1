using System;

namespace Problem01.SumNumbers
{
    class SumNumbers
    {
        static void Main()
        {
            //Write a program that reads 3 real numbers from the console and prints their sum.

            // Prompting the user to enter the first real number
            Console.Write("Enter the first real number: "); 

            // Creating a variable where the first number, entered by the user will be stored
            double firstNum;

            //Checking whether the entered information is valid
            bool firstResult = double.TryParse(Console.ReadLine(), out firstNum);

            // if the information is invalid a proper message is displayed
            if (firstResult == false)
            {
                Console.WriteLine("Please enter a valid real number");
            }

            Console.Write("Enter the second real number: ");
            double secondNum;
            bool secondResult = double.TryParse(Console.ReadLine(), out secondNum);

            if (secondResult == false)
            {
                Console.WriteLine("Please enter a valid real number");
            }

            Console.Write("Enter the third real number: ");
            double thirdNum;
            bool thirdResult = double.TryParse(Console.ReadLine(), out thirdNum);
            if (thirdResult == false)
            {
                Console.WriteLine("Please enter a valid real number");
            }


            //Printing their sum
            Console.WriteLine("The sum of the entered valid numbers is: {0}", firstNum + secondNum + thirdNum);

        }
    }
}
