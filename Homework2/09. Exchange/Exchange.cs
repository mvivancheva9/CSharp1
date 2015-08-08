using System;

namespace Problem9.Exchange
{
    class Exchange
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            int exchangeNum;

            Console.WriteLine("Before the exchanging the first number = {0}", a);
            Console.WriteLine("Before the exchanging the second number = {0}", b);

            exchangeNum = a;
            a = b;
            b = exchangeNum;

            Console.WriteLine("After the exchanging the first number = {0}", a);
            Console.WriteLine("After the exchanging the second number = {0}", b);
        }
    }
}
