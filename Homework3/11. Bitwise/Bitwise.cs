using System;

namespace Problem11.Bitwise
{
    class Bitwise
    {
        static void Main()
        {
            int p = 3;
            Console.Write("Enter a whole number: ");
            uint n = uint.Parse(Console.ReadLine());

            int mask = 1 << p;
            long nAndMask = n & mask;

            if (nAndMask == 0)
            {
                Console.WriteLine("The third bit is 0");
            }
            else
            {
                Console.WriteLine("The third bit is 1");
            }
        }
    }
}
