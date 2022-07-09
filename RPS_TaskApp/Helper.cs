using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_TaskApp
{
    static class Helper
    {
        static string[] choices = new string[3] { "ROCK", "PAPER", "SCISSORS" };

        public enum Option 
        {
            ROCK = 1,
            PAPER = 2,
            SCISSORS = 3
        };
        
        public static string GetRandomChoice()
        {
            Random rnd = new Random();
            int n = rnd.Next(0, 3);

            return choices[n].ToString();
        }

        public static GameDetail GetGameWinnner(int gameId, GameDetail g, string userChoice, string computerChoice)
        {
            g.GameId = gameId;
            if ((userChoice == "ROCK" || userChoice == "STONE") && computerChoice == "SCISSORS")
            {
                g.Detail = "User wins";
                g.IsUserWin = true;
                //g.TotalUserWin += 1;
            }
            else if ((userChoice == "ROCK" || userChoice == "STONE") && computerChoice == "PAPER")
            {
                g.Detail = "Computer wins";
                g.IsComputerWin = true;
                //g.TotalComputerWin += 1;
            }
            else if (userChoice == "PAPER" && (computerChoice == "ROCK" || computerChoice == "STONE"))
            {
                g.Detail = "User wins";
                g.IsUserWin = true;
                //g.TotalUserWin += 1;
            }
            else if (userChoice == "PAPER" && computerChoice == "SCISSORS")
            {
                g.Detail = "Computer Wins";
                g.IsComputerWin = true;
                //g.TotalComputerWin += 1;
            }
            else if (userChoice == "SCISSORS" && (computerChoice == "ROCK" || computerChoice == "STONE"))
            {
                g.Detail = "Computer Wins";
                g.IsComputerWin = true;
                //g.TotalComputerWin += 1;
            }
            else if (userChoice == "SCISSORS" && computerChoice == "PAPER")
            {
                g.Detail = "User wins";
                g.IsUserWin = true;
                //g.TotalUserWin += 1;
            }
            else
            {
                g.Detail = "Match Tie";
                g.IsTie = true;
               // g.TotalMatchTie += 1;
            }

            return g;
        }
        

    }
}
