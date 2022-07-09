using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_TaskApp
{
    public class GameDataViewModel
    {
        public int GameId { get; set; }
        public bool PlayerAWon { get; set; }
        public bool PlayerBWon { get; set; }
        public bool MatchTie { get; set; }
        public string Details { get; set; }
        public int TotalPlayerAWon { get; set; }
        public int TotalPlayerBWon { get; set; }

    }
}
