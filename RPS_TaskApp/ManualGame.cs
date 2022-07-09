using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RPS_TaskApp
{
    public partial class ManualGame : Form
    {
        public ManualGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int selectedOption = Int32.Parse(textBox1.Text);
                string userChoice = Enum.GetName(typeof(Helper.Option), selectedOption);
                if (!string.IsNullOrEmpty(userChoice))
                {
                    PlayGame(userChoice);
                }                
            }           
        }


        public void PlayGame(string userChoice)
        {
            string computerChoice = Helper.GetRandomChoice();
            GameDetail gameDetail = new GameDetail();

            Helper.GetGameWinnner(1, gameDetail, userChoice.ToUpper(), computerChoice);

            label7.Text = gameDetail.Detail;
            label5.Text = "Computer Choice";
            label6.Text = computerChoice;
        }
    }
}
