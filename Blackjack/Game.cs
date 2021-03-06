﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Game
    {
        public int numberOfPlayers;

        public void Welcome()
        {
            Console.WriteLine("Welcome to Blackjack!");
            Console.WriteLine("A team one production.");
            Rules rules = new Rules();
            rules.DisplayRules();
        }
        public void GetPlayers()
        {
            bool chosen = false;
            while (!chosen)
            {
                Console.WriteLine("How many players? (1-8)");
                string players = Console.ReadLine();
                switch (players)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                        Console.WriteLine("Setting to {0} players.", players);
                        chosen = true;
                        numberOfPlayers = Convert.ToInt32(players);
                        break;
                    default:
                        Console.WriteLine("Please enter a number between 1 and 8.");
                        break;
                }

            }

        }

        public void MakePlayers()
        {
            Player[] PlayerArray = new Player[numberOfPlayers];
            for (int i = 0; i < numberOfPlayers; i++)
            {
                PlayerArray[i] = new Player();
                Console.WriteLine("Player {0}, what is your name?",i+1);
                PlayerArray[i].Name = Console.ReadLine();
            }
        }

}
}
