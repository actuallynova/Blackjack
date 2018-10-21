using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public class Variables
    {
        public static int playerPoints;
        public static int botPoints;
        //public static int[] DrawCards;
        public static void TextColors()
        {
            if(Console.ForegroundColor != ConsoleColor.Green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }
    }
    public class Messages
    {
        public static string welcome = "Welcome, have you played before or would you like to see the rules?";
        public static string welcomeSelect = "\nType 1 if you have played, type 2 if you wish to see the rules.";
        public static string youDraw = "\nYour draws";
        public static string botDraw = "Bots draws";
        public static string gameWin = "\nYou won the game because ";
        public static string gameWinAlt1 = "the bot had more than 21 points!";
        public static string gameWinAlt2 = "you had exactly 21 points!";
        public static string gameLoss = "\nYou lost the game because ";
        public static string gameLossAlt1 = "the bot had exactly 21 points.";
        public static string gameLossAlt2 = "you had more than 21 points.";
        public static string ruleSelect = "You will be shown 2 cards, 1 with a number and one mystery card marked with ''?''. \nYou select either card by typing in their assigned number (1 and 2).";
        public static string cardSelect = "Which card would you like?";
        public static string askReady = "\nPress any key to start the game!";
        public static string gameTie = "\nThe game ended in a tie!";
    }

}
