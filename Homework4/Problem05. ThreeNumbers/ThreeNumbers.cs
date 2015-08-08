using System;

namespace Problem05.ThreeNumbers
{
    class ThreeNumbers
    {
        static void Main()
        {
            // Write a program that reads 3 numbers:
            //integer a (0 <= a <= 500)
            //floating-point b
            //floating-point c
            //The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
            //The number a should be printed in hexadecimal, left aligned
            //Then the number a should be printed in binary form, padded with zeroes
            //The number b should be printed with 2 digits after the decimal point, right aligned
            //The number c should be printed with 3 digits after the decimal point, left aligned.

            Console.Write("Enter a whole number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter a real number: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter a second real number: ");
            double c = double.Parse(Console.ReadLine());

            //checking wheter the entered whole number is whithin the desired interval
            if (a >= 0 && a <= 500)
            {
                //storing the converted a in variable
                string convertA = Convert.ToString(a, 2).PadLeft(10, '0');

                //Printing the numbers
                Console.WriteLine("{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}", a, convertA, b, c);
            }
            else
            {
                Console.WriteLine("You should write a whole number between 0 and 500 including");
            }
        }
    }
}
