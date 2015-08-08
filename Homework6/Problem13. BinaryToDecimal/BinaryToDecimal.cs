using System;
using System.Numerics;

namespace Problem13.BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            long sum = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                // we start with the least significant digit, and work our way to the left
                if (binary[binary.Length - i - 1] == '0') continue;
                sum += (int)Math.Pow(2, i);
            }
            Console.WriteLine(sum);
        }
    }
}
