using System;

namespace Problem03.PayCard
{
    class PayCard
    {
        static void Main()
        {
            /*
             * Classical play cards use the following signs to designate the card face: 
             * `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints
             * “yes” if it is a valid card sign or “no” otherwise. 
             */
            Console.Write("Enter a card sign: ");
            string cardSign = Console.ReadLine();

            switch (cardSign)// switch statement to sheck the entered info and print the corresponding result
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "A":
                case "J":
                case "K":
                case "Q": Console.WriteLine("yes");
                    break;
                default: Console.WriteLine("no");
                    break;
            }
        }
    }
}
