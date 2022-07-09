using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RPS_TaskApp
{
    public partial class SimulatedGame : Form
    {
        public SimulatedGame()
        {
            InitializeComponent();
        }

        private void SimulatedGame_Load(object sender, EventArgs e)
        {
            int totalGames = 100;
            string userChoice = "STONE";
            List<GameDetail> gameDetails = new List<GameDetail>();
            for (int i = 1; i <= totalGames; i++)
            {
                string computerChoice = Helper.GetRandomChoice();
                GameDetail g = new GameDetail();
                Helper.GetGameWinnner(i, g, userChoice, computerChoice);
                gameDetails.Add(g);
            }
            BuildData(totalGames, gameDetails);
        }

        private void BuildData(int totalGames, List<GameDetail> gameDetails)
        {
            if (gameDetails.Count > 0)
            {
                label7.Text = totalGames.ToString();
                label10.Text = gameDetails.Where(x => x.IsUserWin).ToList().Count.ToString();
                label8.Text = gameDetails.Where(x => x.IsComputerWin).ToList().Count.ToString();
                label9.Text = gameDetails.Count(x => x.IsTie).ToString();
                dataGridView1.DataSource = gameDetails;
            }           
        }
        
    }
}
