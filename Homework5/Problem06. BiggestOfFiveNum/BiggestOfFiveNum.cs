using System;

namespace Problem06.BiggestOfFiveNum
{
    class BiggestOfFiveNum
    {
        static void Main()
        {
            //Write a program that finds the biggest of five numbers by using only five if statements.

            Console.Write("Enter the first number: ");//prompting the user to enter five real numbers
            double firstNum = double.Parse(Console.ReadLine());// converting to type double

            Console.Write("Enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            double thirdNum = double.Parse(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            double fourthNum = double.Parse(Console.ReadLine());

            Console.Write("Enter the fifth number: ");
            double fifthNum = double.Parse(Console.ReadLine());

            if (firstNum > secondNum && firstNum > thirdNum && firstNum > fourthNum && firstNum > fifthNum)// check whether the first number is the biggest one
            {
                Console.WriteLine("The biggest number is: {0}", firstNum);// print it, it it is
            }
            else if (secondNum > firstNum && secondNum > thirdNum && secondNum > fourthNum && secondNum > fifthNum)//check whether the second one is the biggest, if the first one is proved not to be
            {
                Console.WriteLine("The biggest number is: {0}", secondNum);//print the second, if it is the biggest
            }
            else if (thirdNum> firstNum && thirdNum > secondNum && thirdNum > fourthNum && thirdNum > fifthNum)//check whether the third one is the biggest, if the first and the second are proved not to be
            {
                Console.WriteLine("The biggest number is: {0}", thirdNum);// print the third if it is the biggest
            }
            else if (fourthNum > firstNum && fourthNum > secondNum && fourthNum > thirdNum && fourthNum > fifthNum)//check whether the fourth one is the biggest, if the prevo=ious three proved not to be
            {
                Console.WriteLine("The biggest number is: {0}", fourthNum);// print the fourth, if it is the biggest
            }
            else if (fifthNum > firstNum && fifthNum > secondNum && fifthNum > thirdNum && fifthNum > fourthNum)//check whether the fifth one is the biggest, if the previous four proved not to be
            {
                Console.WriteLine("The biggest number is: {0}", fifthNum);// print the fifth, if it is the biggest
            }
        }
    }
}
