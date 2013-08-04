/*
 * Lecture 6 : Loops
 * Problem 11: Write a program that prints all possible 
 *              cards from a standard deck of 52 cards 
 *              (without jokers). The cards should be 
 *              printed with their English names. 
 */
using System;

class DeckOfCards
{
    static void Main()
    {
        string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        string[] cards = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        foreach (string suit in suits)
        {
            foreach (string card in cards)
            {
                Console.WriteLine(card + " of " + suit);
            }
        }
    }
}

