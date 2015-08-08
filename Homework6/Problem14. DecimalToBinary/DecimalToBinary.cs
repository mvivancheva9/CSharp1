using System;
namespace Problem14.DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            /*Using loops write a program that converts an integer number to its binary representation.
             * The input is entered as long. The output should be a variable of type string.
             * Do not use the built-in .NET functionality.*/

            Console.Write("Enter a number:");//prompt the user to enter a number
            long decNum = long.Parse(Console.ReadLine());// store it in variable of type long

            string binNum = "";// create a variable to store the number in binary format
            char remainder;// create a variable for the remainder
            while (decNum >= 1)// while loop to pass through all of the divisions
            {
                
                if (decNum % 2 == 0)// is statement to check the remainder
                {
                     remainder = '0';
                }
                else
                {
                     remainder = '1';
                }
                decNum /= 2;// division of the number by 2
                binNum = remainder + binNum;// storing the remainder to the binary variable
            }
            Console.WriteLine("The binary representation of the number is: {0}", binNum);// printing
        }
    }
}
