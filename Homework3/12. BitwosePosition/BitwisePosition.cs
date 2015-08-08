using System;

namespace Problem12.BitwisePosition
{
    class BitwisePosition
    {
        static void Main()
        {
            Console.Write("Enter integer for position: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Enter a whole number: ");
            uint n = uint.Parse(Console.ReadLine());

            int mask = 1 << p;
            long nAndMask = n & mask;

            if (nAndMask == 0)
            {
                Console.WriteLine("The bit on position {0} is 0", p);
            }
            else
            {
                Console.WriteLine("The bit on position {0} is 1", p);
            }
        }
    }
}

