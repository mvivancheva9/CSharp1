using System;

namespace Problem15.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        static void Main()
        {
            /*Using loops write a program that converts a hexadecimal integer number to its decimal form.
             * The input is entered as string. The output should be a variable of type long.
             * Do not use the built-in .NET functionality.*/

            Console.Write("Enter a number in hexadecimal format: ");//prompt the user to enter haxadecimal number
            string hexNum = Console.ReadLine();// store the number in string format

            long decNum = 0;// set a value for the decimal representation
            int temp = 0;// ititialize a variable for the character representation
            for (int i = 0; i < hexNum.Length; i++)// for loop to pass through all of the elements in the string
            {
                char symbol = hexNum[hexNum.Length - 1 - i];// taking the symbols from the string one by one, beginning with the last one
                switch (symbol)// switch operation to store the taken symbol in integer type
                {
                    case '0': temp = 0; break;
                    case '1': temp = 1; break;
                    case '2': temp = 2; break;
                    case '3': temp = 3; break;
                    case '4': temp = 4; break;
                    case '5': temp = 5; break;
                    case '6': temp = 6; break;
                    case '7': temp = 7; break;
                    case '8': temp = 8; break;
                    case '9': temp = 9; break;
                    case 'A': temp = 10; break;
                    case 'B': temp = 11; break;
                    case 'C': temp = 12; break;
                    case 'D': temp = 13; break;
                    case 'E': temp = 14; break;
                    case 'F': temp = 15; break;
                    default: Console.WriteLine("Not a valid hexadecimal Number"); break;
                }
                decNum += temp * (int)Math.Pow(16, i);//calculate the number in decimal format
            }
            Console.WriteLine("The number in ddecimal format is: {0}", decNum);//printing
        }
    }
}
