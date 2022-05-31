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

        public void theWinner()
        {
            for(int i=0; i<8; i++)
            {
                String combination = "";

                switch(i)
                {
                    case 0:
                        combination = keyPad[2] + keyPad[4] + keyPad[6];
                        break;
                    case 1:
                        combination = keyPad[0] + keyPad[4] + keyPad[8];
                        break;
                    case 2:
                        combination = keyPad[0] + keyPad[1] + keyPad[2];
                        break;
                    case 3:
                        combination = keyPad[3] + keyPad[4] + keyPad[5];
                        break;
                    case 4:
                        combination = keyPad[6] + keyPad[7] + keyPad[8];
                        break;
                    case 5:
                        combination = keyPad[2] + keyPad[5] + keyPad[8];
                        break;
                    case 6:
                        combination = keyPad[1] + keyPad[4] + keyPad[7];
                        break;
                    case 7:
                        combination = keyPad[0] + keyPad[3] + keyPad[6];
                        break;
                }

                if(combination.Equals("OOO"))
                {
                    reset();
                    MessageBox.Show("Player O has won the game!", "We have a winner!", MessageBoxButtons.OK);
                }
                else if(combination.Equals("XXX"))
                {
                    reset();
                    MessageBox.Show("Player X has won the game!", "We have a winner!", MessageBoxButtons.OK);
                }

                else tieBreaker();
            }
        }

        public void reset()
        {
            ButtonA1.Text = "";
            ButtonA2.Text = "";
            ButtonA3.Text = "";
            ButtonB1.Text = "";
            ButtonB2.Text = "";
            ButtonB3.Text = "";
            ButtonC1.Text = "";
            ButtonC2.Text = "";
            ButtonC3.Text = "";
            keyPad = new string[9];
            currentPlayer = 0;
        }

        public void tieBreaker()
        {
            int counter = 0;
            for(int i=0; i<keyPad.Length; i++)
            {
                if(keyPad[i] != null) {counter++;}

                if(counter==9)
                {
                    reset();
                    MessageBox.Show("That's a draw!", "No winner", MessageBoxButtons.OK);
                }
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
            theWinner();
        }

        private void ButtonA2_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[1] = backSymbol(currentPlayer);
            ButtonA2.Text = keyPad[1];
            theWinner();
        }

        private void ButtonA3_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[2] = backSymbol(currentPlayer);
            ButtonA3.Text = keyPad[2];
            theWinner();
        }

        private void ButtonB1_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[3] = backSymbol(currentPlayer);
            ButtonB1.Text = keyPad[3];
            theWinner();
        }

        private void ButtonB2_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[4] = backSymbol(currentPlayer);
            ButtonB2.Text = keyPad[4];
            theWinner();
        }

        private void ButtonB3_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[5] = backSymbol(currentPlayer);
            ButtonB3.Text = keyPad[5];
            theWinner();
        }

        private void ButtonC1_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[6] = backSymbol(currentPlayer);
            ButtonC1.Text = keyPad[6];
            theWinner();
        }

        private void ButtonC2_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[7] = backSymbol(currentPlayer);
            ButtonC2.Text = keyPad[7];
            theWinner();
        }

        private void ButtonC3_Click(object sender, EventArgs e)
        {
            currentPlayer++;
            keyPad[8] = backSymbol(currentPlayer);
            ButtonC3.Text = keyPad[8];
            theWinner();
        }

        private void playerInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The object of Tic Tac Toe is to get three in a row. You play on a three by three game board. The first player is known as X and the second is O. Players alternate placing Xs and Os on the game board until either opponent has three in a row or all nine squares are filled. X always goes first, and in the event that no one has three in a row, the stalemate is called a tie game.");
        }
    }
}
