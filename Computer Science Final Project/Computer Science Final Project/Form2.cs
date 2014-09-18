using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        // two public string variables are declared
        public string Player1F2, Player2F2;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            // Focuses on txtPlayer1F2 textbox
            txtPlayer1F2.Focus();
            // Input the Player 1's namefrom txtPlayer1F2 textbox
            Player1F2 = txtPlayer1F2.Text;
            // Input the Player 2's namefrom txtPlayer2F2 textbox
            Player2F2 = txtPlayer2F2.Text;

            // If txtPlayer1F2.Text is empty, Player 1's name is automatically Player 1
            if (Player1F2 == "")
            {
                Player1F2 = "Player 1";
            }

            // If txtPlayer2F2.Text is empty, Player 2's name is automatically Player 2
            if (Player2F2 == "")
            {
                Player2F2 = "Player 2";
            }

            this.Close();
        }
    }
}
