using System;

namespace Problem01.ExchangeGreater
{
    class ExchangeGreater
    {
        static void Main()
        {
            //Write an if-statement that takes two double variables a and b and exchanges their values if the first 
            //one is greater than the second one. As a result print the values a and b, separated by a space.

            //Prompting the user to enter the deisred information
            Console.Write("Enter a number a: ");
            double a = double.Parse(Console.ReadLine());//converting the entered info to double type

            Console.Write("Enter another number b: ");
            double b = double.Parse(Console.ReadLine());

            bool isBigger = a > b;
            if (isBigger == true)// if statement to check the bool variable and make the exchange of values
            {
                double convertNum = a;
                a = b;
                b = convertNum;
            }
            Console.WriteLine("The values of a and b are as follow: {0} {1}", a, b);

        }
    }
}
