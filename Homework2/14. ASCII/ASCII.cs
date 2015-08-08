using System;
using System.Text;

namespace Problem14.ASCII
{
    class ASCII
    {
        static void Main()
        {          

            for (int i = 0; i <= 255; i++)
            {
                char value = (char)i;
                Console.WriteLine("The symbol on position {0} = {1}", i, value);
            }
        }
    }
}
