using System;

namespace Problem13.BitwisePositionCheck
{
    class BitwisePositionCheck
    {
        static void Main()
        {
            Console.Write("Enter integer for position: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Enter a whole number: ");
            int n = int.Parse(Console.ReadLine());

            int mask = n >> p;
            int nAndMask = 1 & mask;
            bool isOne = nAndMask == 1;
            if (isOne == true)
            {
                Console.WriteLine("{0}. The bit on position {1} is 1", isOne,p);
            }
            else
            {
                Console.WriteLine("{0}. The bit on position {1} is 0", isOne, p);
            }
        }
    }
}
