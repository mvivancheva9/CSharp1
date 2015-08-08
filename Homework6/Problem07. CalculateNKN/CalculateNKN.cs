using System;

namespace Problem07.CalculateNKN
{
    class CalculateNKN
    {
        static void Main()
        {
            /*In combinatorics, the number of ways to choose k different members out of a group of n different elements 
             *(also known as the number of combinations) is calculated by the following formula: formula For example, 
             *there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
             *Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
             *Try to use only two loops.*/

            Console.Write("Enter a whole number for N: ");//prompt the user to enter value for N
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter a whole number for K: ");// prompt the user to enter value for K
            int k = int.Parse(Console.ReadLine());

            double factorielN = 1;//set a variable to store N factoriel
            double factorielK = 1;// set variable to store K faktoriel
            double factorielNK = 1;// set a variable to store N-K factoriel
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
                for (int i = 1; i <=(n-k); i++)
                {
                    factorielNK *= i;//calculate N-K factoriel
                }
                division = factorielN / (factorielK * factorielNK);//calculte the division
                Console.WriteLine(division);//print
            }
            else
            {
                Console.WriteLine("Enter valid numbers k < n and n < 100");
            }
        }
    }
}