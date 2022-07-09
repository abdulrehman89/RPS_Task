using System;
using System.Collections.Generic;
using System.Text;

namespace RPS_TaskApp
{
    public class GameDetail
    {
        public int GameId { get; set; }
        public bool IsUserWin { get; set; }
        public bool IsComputerWin { get; set; }
        public bool IsTie { get; set; }
        //public int TotalUserWin { get; set; }
        //public int TotalComputerWin { get; set; }
        public string Detail { get; set; }
        //public int TotalMatchTie { get; set; }
    }
}
