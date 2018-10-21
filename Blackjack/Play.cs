using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public class Play
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Messages.welcome + Messages.welcomeSelect);
            string ruleChoice = Console.ReadLine();
            if (ruleChoice == "2")
            {
                Console.WriteLine(Messages.ruleSelect);
                Console.WriteLine(Messages.askReady);
                string playReady = Console.ReadLine();
                if(string.IsNullOrEmpty(playReady) || !string.IsNullOrEmpty(playReady))
                {
                    Game.Start();
                }
            }
            if (ruleChoice == "1")
            {
                Game.Start();
            }
        }
    }
}
