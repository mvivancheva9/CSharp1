using System;

namespace Problem14.ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            Console.Write("Enter integer for position: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Enter a whole number: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter value [0 or 1]: ");
            int value = int.Parse(Console.ReadLine());

            if (value == 1)
            {
                int maskOne = 1 << p;
                int nAndMaskOne = n | maskOne;
                Console.WriteLine(nAndMaskOne);
            }
            else
            {
                int maskZero = ~(1 << p);
                int nAndMaskZero = n & maskZero;
                Console.WriteLine(nAndMaskZero);
            }
        }
    }
}
