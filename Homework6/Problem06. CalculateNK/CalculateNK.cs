using System;

namespace Problem06.CalculateNK
{
    class CalculateNK
    {
        static void Main()
        {
            /*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
             * Use only one loop.*/

            Console.Write("Enter a whole number for N: ");//prompt the user to enter value for N
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter a whole number for K: ");// prompt the user to enter value for K
            int k = int.Parse(Console.ReadLine());

            double factorielN = 1;//set a variable to store N factoriel
            double factorielK = 1;// set variable to store K faktoriel
            double division = 1;// set the division = 1
            int j = 1;// counter for K
            if (k < n && n < 100)
            {
                for (int i = 1; i <= n; i++)// for loop to pass through all n numbers
                {
                    if (j <= k)// if statement to check whether the couter is less than k
                    {

                        factorielN *= i;//calculate n factoriel
                        factorielK *= j;//calculate k factoriel
                        j++;// increase the counter with one

                    }
                    else
                    {
                        factorielN *= i;// if the counter is bigger than K, calculate only N factoriel
                    }
                }
                division = factorielN / factorielK;//calculte the division
                Console.WriteLine(division);//print
            }
            else
            {
                Console.WriteLine("Enter valid numbers k < n and n < 100");
            }
        }
    }
}
