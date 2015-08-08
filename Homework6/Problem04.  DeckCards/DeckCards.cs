using System;

namespace Problem04.DeckCards
{
    class DeckCards
    {
        static void Main()
        {
            /*Write a program that generates and prints all possible cards 
             * from a standard deck of 52 cards (without the jokers). 
             * The cards should be printed using the classical notation 
             * (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
             * The card faces should start from 2 to A. Print each card face in its four possible suits: 
             * clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.*/

            string clubs = "clubs"; // storing string variables for the cards
            string diamonds = "diamonds";
            string hearts = "hearts";
            string spades = "spades";
            for (int i = 2; i < 15; i++)// for loop to pass through all different cards in the deck
            {
                if (i <=10)// check whether the card is number 
                {
                    Console.WriteLine("{0} of {1}, {0} of {2}, {0} of {3}, {0} of {4}", i, clubs, diamonds, hearts, spades);
                }
                else
                {
                    for (int j = i; j < i + 1; j++)// for loop to pass trough the rest of the cards
                    {
                        switch(i)//swich to print the symbol of the rest of the cards
                        {
                            case 11: Console.WriteLine("J of {0}, J of {1}, J of {2}, J of {3}", clubs, diamonds, hearts, spades); break;
                            case 12: Console.WriteLine("D of {0}, D of {1}, D of {2}, D of {3}", clubs, diamonds, hearts, spades); break;
                            case 13: Console.WriteLine("K of {0}, K of {1}, K of {2}, K of {3}", clubs, diamonds, hearts, spades); break;
                            case 14: Console.WriteLine("A of {0}, A of {1}, A of {2}, A of {3}", clubs, diamonds, hearts, spades); break;
                        }
                    }
                }
            }
        }
    }
}
