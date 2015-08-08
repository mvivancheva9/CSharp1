using System;

namespace Problem15.BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            long number = long.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));


            int p1 = 3;
            int p2 = 24;

            for (int i = 0; i < 3; i++)
            {
                long maskOne = (number & (1 << p1)) >> p1;
                long maskTwo = (number & (1 << p2)) >> p2;

                if (maskOne == 0)
                {
                    number = number & (~(1 << p2));
                }
                else if (maskOne == 1)
                {
                    number = number | (1 << p2);
                }

                //mask two
                if (maskTwo == 0)
                {
                    number = number & (~(1 << p1));
                }
                else if (maskTwo == 1)
                {
                    number = number | (1 << p1);
                }

                p1++;
                p2++;
            }

            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine(number);
        }
    }
}

