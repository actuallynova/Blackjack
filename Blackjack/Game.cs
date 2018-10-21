using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Blackjack
{
    public class Game
    {
        public static void Start()
        {
            Console.WriteLine("Game Started!");
            while (Variables.playerPoints < 21 && Variables.botPoints < 21)
            {
                Console.ResetColor();
                Random cardDraw = new Random();
                int drawPlayer = cardDraw.Next(1, 9);
                int drawBot = cardDraw.Next(1, 9);

                Console.WriteLine(Messages.cardSelect);
                Console.WriteLine("| " + drawPlayer + " |    | ? |");
                Console.WriteLine("Type 1 for " + drawPlayer + " points or 2 for random points (1-9)");
                string pointChoice = Console.ReadLine();
                //need to add invalid input check
                if(pointChoice == "1")
                {
                    Variables.playerPoints = Variables.playerPoints + drawPlayer;
                    Variables.botPoints = Variables.botPoints + drawBot;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Console.WriteLine("Your choice " + drawPlayer + " - " + drawBot + " Bot choice");
                    Console.WriteLine("Your Points " + Variables.playerPoints + "-" + Variables.botPoints + " Bot Points");
                    Console.ResetColor();
                }
                if(pointChoice == "2")
                {
                    Random newCard = new Random();
                    int newDraw = newCard.Next(1, 9);
                    Variables.playerPoints = Variables.playerPoints + newDraw;
                    Variables.botPoints = Variables.botPoints + drawBot;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Clear();
                    Console.WriteLine("Your choice ? (" + newDraw + ") - " + drawBot + " Bot choice");
                    Console.WriteLine("Your Points " + Variables.playerPoints + "-" + Variables.botPoints + " Bot Points");
                    Console.ResetColor();
                }
                //check for tie
                if((Variables.playerPoints > 21 && Variables.botPoints > 21) || (Variables.playerPoints == 21 && Variables.botPoints == 21))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(Messages.gameTie);
                    Console.ResetColor();
                    string resetGame = Console.ReadLine();
                    if (string.IsNullOrEmpty(resetGame) || !string.IsNullOrEmpty(resetGame))
                    {
                        Variables.botPoints = 0;
                        Variables.playerPoints = 0;
                        Game.Start();
                    }
                }
                //Win with 21 points
                if(Variables.playerPoints == 21)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Messages.gameWin + Messages.gameWinAlt2);
                    Console.ResetColor();
                    string resetGame = Console.ReadLine();
                    if (string.IsNullOrEmpty(resetGame) || !string.IsNullOrEmpty(resetGame))
                    {
                        Variables.botPoints = 0;
                        Variables.playerPoints = 0;
                        Game.Start();
                    }
                }
                //Win with bot over 21 points
                if(Variables.botPoints > 21)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Messages.gameWin + Messages.gameWinAlt1);
                    string resetGame = Console.ReadLine();
                    if(string.IsNullOrEmpty(resetGame) || !string.IsNullOrEmpty(resetGame))
                    {
                        Variables.botPoints = 0;
                        Variables.playerPoints = 0;
                        Game.Start();
                    }
                }
                //Loss by bot 21 points
                if(Variables.botPoints == 21)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Messages.gameLoss + Messages.gameLossAlt1);
                    string resetGame = Console.ReadLine();
                    if (string.IsNullOrEmpty(resetGame) || !string.IsNullOrEmpty(resetGame))
                    {
                        Variables.botPoints = 0;
                        Variables.playerPoints = 0;
                        Game.Start();
                    }
                }
                //Loss by bot self over 21 points
                if(Variables.playerPoints > 21)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Messages.gameLoss + Messages.gameLossAlt2);
                    Console.WriteLine("Type in anything to continue.");
                    string resetGame = Console.ReadLine();
                    if (string.IsNullOrEmpty(resetGame) || !string.IsNullOrEmpty(resetGame))
                    {
                        Variables.botPoints = 0;
                        Variables.playerPoints = 0;
                        Game.Start();
                    }
                }
            }
        }
    }
}
