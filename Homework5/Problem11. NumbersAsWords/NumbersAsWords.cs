using System;

namespace Problem11.NumbersAsWords
{
    class NumbersAsWords
    {
        static void Main()
        {
            //Write a program that converts a number in the range [0…999] to words, 
            //corresponding to the English pronunciation.

            Console.Write("Enter a number in the range [0..999]: ");// prompt the use to enter a number
            int number = int.Parse(Console.ReadLine());// convert to integer

            //creating a string of the words, necessary for the units and hundreds
            string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            
            //creating a string of the words, necessary for the tens and the number < 20
            string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            
            string words = "";// string for the words
            if (number < 0 || number > 999)// check whether the entered number is out of range
            {
                Console.WriteLine("Not a valid number");// print the proper result
            }
            else if ((number / 100) > 0)// if it is whithin the range, check number > 100
            {


                words += units[number / 100] + " hundred ";//assigning words to the hundred part
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "")
                    words += "and ";// assign and if there are unit parts, if not assign it before the tens part


                if (number < 20)// checks numbre < 20 and assign the proper word
                    words += units[number];
                else
                {
                    words += tens[number / 10];// take the proper word from the tens string
                    if ((number % 10) > 0)
                        words += " " + units[number % 10];
                }
            }

            Console.WriteLine(words);// print the result
        }

    }
}
