using System;

/* Problem 11, Lecture 6:
 * Write a program that prints all possible cards from a standard deck
 * of 52 cards (without jokers). The cards should be printed with their
 * English names. Use nested for loops and switch-case. */


class CardsOfDeck
{
    static void Main()
    {
        string nameOfCard = "";

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 2: nameOfCard = "Two of "; break;
                    case 3: nameOfCard = "Three of "; break;
                    case 4: nameOfCard = "Four of "; break;
                    case 5: nameOfCard = "Five of "; break;
                    case 6: nameOfCard = "Six of "; break;
                    case 7: nameOfCard = "Seven of "; break;
                    case 8: nameOfCard = "Eight of "; break;
                    case 9: nameOfCard = "Nine of "; break;
                    case 10: nameOfCard = "Ten of "; break;
                    case 11: nameOfCard = "Jack of "; break;
                    case 12: nameOfCard = "Queen of "; break;
                    case 13: nameOfCard = "King of "; break;
                    case 14: nameOfCard = "Ace of "; break;

                    default:
                        break;
                }
                switch (j)
                {
                    case 1: nameOfCard += "Clubs"; break;
                    case 2: nameOfCard += "Diamonds"; break;
                    case 3: nameOfCard += "Hearts"; break;
                    case 4: nameOfCard += "Spades"; break;

                    default:
                        break;
                }
                Console.Write("{0}    ", nameOfCard);
            }
            Console.WriteLine();
        }
    }
}

