using System;

namespace LongSequence
{
    class LongSequence
    {
        static void Main()
        {
            int firstNum = 0;
            int secondNum = -1;

            for (int i = 0; i < 1000; i += 2)
            {
                Console.WriteLine("{0}, {1}, ", firstNum += 2, secondNum -= 2);
            }
        }
    }
}
