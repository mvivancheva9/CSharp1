using System;

namespace Problem8.Prime
{
    class Prime
    {
        static void Main()
        {
            Console.Write("Enter a positive integer: ");
            int num = int.Parse(Console.ReadLine());

            bool isPositive = num > 0;
            int numDivisions = 0;
            if (isPositive == true && num != 1 && num<=100)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        numDivisions++;
                    }
                }

                if (numDivisions > 2)
                {
                    Console.WriteLine("{0} is not a prime number!", num);
                }
                else
                {
                    Console.WriteLine("{0} is prime number!", num);
                } 
            }
            else
            {
                Console.WriteLine("You should enter a positive whole number, smaller or equal to 100, \ndifferent from 1");
            }
        }
    }
}

