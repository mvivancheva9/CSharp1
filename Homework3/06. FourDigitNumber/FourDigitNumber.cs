using System;

namespace Problem6.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter four digit number: ");
            int number = int.Parse(Console.ReadLine());

            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;

            Console.WriteLine("The sum of the digits is: {0}", a + b + c + d);
            Console.WriteLine("The number in reversed order: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit - first place {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Exchanged second and third digit: {0}{1}{2}{3}", a, c, b, d);

        }
    }
}
