using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02._2_CoinTossin02
{
    public partial class FrmCoinTossing02 : Form
    {
        public FrmCoinTossing02()
        {
            InitializeComponent();
        }

        //Write a VB program that simulates 15 rolls of a dice and then 
        //prints out the number of times each number is generated.
        private void BtnExercise_Click(object sender, EventArgs e)
        {
            LstView.Clear();
            int[] dice = new int[7];

            for(int i = 0; i < 15; i++)
            {
                Random r = new Random();
                int diceNumber = r.Next(1, 7);
                dice[diceNumber] += 1;
            }

            for (int x = 0; x < dice.Length-1; x++)
            {
                if (dice[x] != 0)
                {
                    LstView.Items.Add(x.ToString() + " \t " + dice[x]);
                }
            }
        }
    }
}
