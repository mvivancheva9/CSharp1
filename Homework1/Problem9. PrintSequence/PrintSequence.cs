using System;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {
            int firstNum = 0;
            int secondNum = -1;

            for (int i = 0; i<10; i+=2)
            {
                Console.Write("{0}, {1}, ", firstNum+=2, secondNum-=2);
            }
        }
    }
}
