using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Dalangin
{
    public partial class TicTacToeLabel : Form
    {
        public TicTacToeLabel()
        {
            InitializeComponent();
        }

        String[] keyPad = new string[9];
        int currentPlayer = 0;

        public String backSymbol(int turn)
        {
            if(turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void ButtonA1_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[0] = backSymbol(currentPlayer);
            ButtonA1.Text = keyPad[0];
        }

        private void ButtonA2_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[1] = backSymbol(currentPlayer);
            ButtonA2.Text = keyPad[1];
        }

        private void ButtonA3_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[2] = backSymbol(currentPlayer);
            ButtonA3.Text = keyPad[2];
        }

        private void ButtonB1_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[3] = backSymbol(currentPlayer);
            ButtonB1.Text = keyPad[3];
        }

        private void ButtonB2_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[4] = backSymbol(currentPlayer);
            ButtonB2.Text = keyPad[4];
        }

        private void ButtonB3_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[5] = backSymbol(currentPlayer);
            ButtonB3.Text = keyPad[5];
        }

        private void ButtonC1_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[6] = backSymbol(currentPlayer);
            ButtonC1.Text = keyPad[6];
        }

        private void ButtonC2_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[7] = backSymbol(currentPlayer);
            ButtonC2.Text = keyPad[7];
        }

        private void ButtonC3_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[8] = backSymbol(currentPlayer);
            ButtonC3.Text = keyPad[8];
        }
    }
}
