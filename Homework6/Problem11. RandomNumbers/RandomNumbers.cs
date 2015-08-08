using System;

namespace Problem11.RandomNumbers
{
    class RandomNumbers
    {
        static void Main()
        {
            //Write a program that enters 3 integers n, min and max (min != max) 
            //and prints n random numbers in the range [min...max].

            Console.Write("Enter a whole number for N: ");//prompt the user to enter value for N
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter a whole number for min: ");// prompt the user to enter value for min
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter a whole number for max: ");//prompt the user to enter value for max
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();// set a variable of Random Class
            for (int i = 1; i <= n; i++)// for loop to pass through each of the elements
            {
                
                int randomNum = rnd.Next(min, max+1);// picks a random number in the desired range
                Console.Write("{0} ", randomNum);// print the number
            }
            Console.WriteLine();
            
        }
    }
}
