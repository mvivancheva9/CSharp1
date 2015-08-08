using System;

namespace Problem03.MinMax
{
    class MinMax
    {
        static void Main()
        {
            /*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
             * the maximal number, the sum and the average of all numbers 
             * (displayed with 2 digits after the decimal point).
             * The input starts by the number n (alone in a line) followed by n lines, 
             * each holding an integer number.*/

            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;// st the sum to be 0
            double average = 0;// set the avr to be 0
            int numMin = int.MaxValue;// set the min value to be max possible
            int numMax = int.MinValue;//set the max to be the min possible
            for (int i = 1; i <= n; i++)// fot loop to pass through all of the numbers
            {
                Console.Write("Enter a whole number: ");//propmt the user to enter value for the numbers
                int a = int.Parse(Console.ReadLine());// convert to integer
                sum += a;// set the sum to add every entered value
                numMin = Math.Min(numMin, a);// reaches the minimum value between max and a
                numMax = Math.Max(numMax, a);// reaches the maximum value between min and a
            }
            average = sum / n;// calculates average
            Console.WriteLine("min = {0}", numMin);// print
            Console.WriteLine("max = {0}", numMax);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avr = {0:F2}", average);
        }
    }
}
