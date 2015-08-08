using System;

namespace Problem16.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        static void Main()
        {
            /*Using loops write a program that converts an integer number to its hexadecimal representation.
             * The input is entered as long. The output should be a variable of type string.
             * Do not use the built-in .NET functionality.*/

            Console.Write("Enter a number in decimal format: ");// prompt the use to enter a number
            long decNum = long.Parse(Console.ReadLine());//store the number in type long
            string hexNum = "";// set a variable to store the hexadecimal number
            long power = 1;//initialize power for the counter
            int n = 0;//initialize a counter
            while ((power*=16)<decNum)//loop until 16 to the of n < entered number
            {
                n++;// increase the power by one
            }
            long tempNum = 0;//set a temporar variable to transfer the number in char
            long delta = decNum;// variable used for calculation
            char symbol = ' ';// variable to store the symbol of the number
            for (int i = n; i >= 0; i--)// for loop to pass through all the powers
            {
                tempNum = delta / (int)Math.Pow(16, i);// formula for calculation of the temporary variable
                switch (tempNum)// switch operation to tranfer the integer to char symbol
                {
                    case 0: symbol = '0'; break;
                    case 1: symbol = '1'; break;
                    case 2: symbol = '2'; break;
                    case 3: symbol = '3'; break;
                    case 4: symbol = '4'; break;
                    case 5: symbol = '5'; break;
                    case 6: symbol = '6'; break;
                    case 7: symbol = '7'; break;
                    case 8: symbol = '8'; break;
                    case 9: symbol = '9'; break;
                    case 10: symbol = 'A'; break;
                    case 11: symbol = 'B'; break;
                    case 12: symbol = 'C'; break;
                    case 13: symbol = 'D'; break;
                    case 14: symbol = 'E'; break;
                    case 15: symbol = 'F'; break;
                    default: Console.WriteLine("Not a valid hexadecimal Number"); break;
                }
                hexNum += symbol;//storing to the sring variable for the hexadecimal number
                delta = delta - tempNum * (int)Math.Pow(16, i);// formula for calculation
            }
            Console.WriteLine("The number in hexadecimal format is: {0}", hexNum);// printing
        }
    }
}
