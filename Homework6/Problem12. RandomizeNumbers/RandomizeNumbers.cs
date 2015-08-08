using System;

namespace Problem12.RandomizeNumbers
{
    class RandomizeNumbers
    {
        static void Main()
        {
            //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

            Console.Write("Enter a whole number for N: ");//prompt the user to enter value for N
            int n = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[n];
            Random rnd = new Random();// set a variable of Random Class

            for (int i = 0; i < n; i++)// for loop to pass through each of the elements
            {
                arrayNumbers[i] = i + 1;//sets the indexes to start from 1 not 0
            }
            foreach (int i in arrayNumbers)
            {
                int randomNum = rnd.Next(1, n);// picks a random number in the desired range
                int temp = arrayNumbers[randomNum];//store the number in a variable
                arrayNumbers[randomNum] = arrayNumbers[0];//assign the first index to be with this nimber
                arrayNumbers[0] = temp;//set the value of the number
                
            }
            Console.WriteLine(String.Join(" ", arrayNumbers)); // print the list
            Console.WriteLine();
        }
    }
}
