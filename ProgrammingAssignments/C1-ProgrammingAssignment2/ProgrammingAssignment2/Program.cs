using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome to the game.");
            Console.WriteLine();

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();
            //Console.WriteLine("Below is the shuffled order of cards :");
            //deck.Print();
            //Console.WriteLine();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card player1_c1 = deck.TakeTopCard();
            Card player2_c1 = deck.TakeTopCard();
            Card player3_c1 = deck.TakeTopCard();

            Card player1_c2 = deck.TakeTopCard();
            Card player2_c2 = deck.TakeTopCard();
            Card player3_c2 = deck.TakeTopCard();

            // flip all the cards over
            player1_c1.FlipOver();
            player2_c1.FlipOver();
            player3_c1.FlipOver();
            player1_c2.FlipOver();
            player2_c2.FlipOver();
            player3_c2.FlipOver();

            // print the cards for player 1
            Console.WriteLine("Below are the cards in First Players hand :");
            Console.WriteLine(player1_c1.Rank + " of " + player1_c1.Suit);
            Console.WriteLine(player1_c2.Rank + " of " + player1_c2.Suit);
            Console.WriteLine();

            // print the cards for player 2
            Console.WriteLine("Below are the cards in First Players hand :");
            Console.WriteLine(player2_c1.Rank + " of " + player2_c1.Suit);
            Console.WriteLine(player2_c2.Rank + " of " + player2_c2.Suit);
            Console.WriteLine();

            // print the cards for player 3
            Console.WriteLine("Below are the cards in First Players hand :");
            Console.WriteLine(player3_c1.Rank + " of " + player3_c1.Suit);
            Console.WriteLine(player3_c2.Rank + " of " + player3_c2.Suit);
            Console.WriteLine();

            Console.WriteLine();
        }
    }
}
