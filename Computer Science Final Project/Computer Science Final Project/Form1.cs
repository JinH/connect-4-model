using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication1
{
    //Programmed by Hao.J, Chris.C, and Ben.S
    public partial class Connect4 : Form
    {
        static int[,] Connect4Array = new int[6, 7];//-1: empty, 1: Red, 0: Blue
        int iTurn = 0;// 0: Red, 1: Blue
        bool FinishGame = false;
        int iCounter; 

        // Opens Form2
        Form2 GetNameDialog = new Form2();

        public Connect4()
        {
            InitializeComponent();

            // Displays a message in the groupbox TURN STATUS that tells the user which player's turn is it
            lblTurn.Text = "Blue's Turn";  

            // F2 stands for Form2 

            GetNameDialog.ShowDialog();
            // Player1F2 is converted back to a string and is displayed in txtPlayer1 textbox 
            txtPlayer1.Text = GetNameDialog.Player1F2;
            // Player2F2 is converted back to a string and is displayed in txtPlayer2 textbox 
            txtPlayer2.Text = GetNameDialog.Player2F2;

            // Disables the following textboxes 
            txtPlayer1.Enabled = false;
            txtPlayer2.Enabled = false;

            // Loops the program and assigns all spots the value of -1.
            for (int x = 0; x < 6; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    Connect4Array[x, y] = -1;
                }
            }
        }

        // This method returns the next empty row location in a column "col"
        // it return -1 if there is no spot available
        public int GetRow(int col)
        {
            int Row;

            Row = -1;

            for (int i = 5; i >= 0; i--)
            {
                if (Connect4Array[i, col] == -1) //empty spot
                {
                    Row = i;
                    break;
                }
            }
            return Row;
        }

        // Reset board method 
        public void ResetBoard()
        {
            Graphics g = Graphics.FromHwnd(pbConnect4.Handle);
            SolidBrush myBeigebrush = new SolidBrush(Color.Beige);

            // Loops the program and produces a beige layer. 
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    {

                        g.FillRectangle(myBeigebrush, i, j, 420, 360);

                        // Sets the borders 
                        NewGame();
                        iCounter = 0;

                        FinishGame = false;
                    }
                }
            }
        }

        // Diagonal win from top-left to bottom-right direction 
        public int WinDiagonal(int Row, int Col)
        {

            //Declares rhe following variables
            int Offset, col1, col2, col3, col4, row1, row2, row3, row4, WinStatus = -1;

            //Counter
            for (Offset = -3; Offset <= 0; Offset++)
            {
                //Going through the four squares
                col1 = Col + Offset;
                col2 = col1 + 1;
                col3 = col2 + 1;
                col4 = col3 + 1;

                //Going through the four squares
                row1 = Row - Offset;
                row2 = row1 - 1;
                row3 = row2 - 1;
                row4 = row3 - 1;

                //Making sure that the search doesn't exceed the boundaries of the array
                if (col1 >= 0 && col1 <= 6 && col2 >= 0 && col2 <= 6 && col3 >= 0 && col3 <= 6 && col4 >= 0 && col4 <= 6 && row1 >= 0 && row1 <= 5 && row2 >= 0 && row2 <= 5 && row3 >= 0 && row3 <= 5 && row4 >= 0 && row4 <= 5)
                {
                    //Blue wins
                    if (Connect4Array[row1, col1] == 0 && Connect4Array[row2, col2] == 0 && Connect4Array[row3, col3] == 0 && Connect4Array[row4, col4] == 0)
                    {
                        WinStatus = 0;
                        break;
                    }
                    //Red wins
                    else if (Connect4Array[row1, col1] == 1 && Connect4Array[row2, col2] == 1 && Connect4Array[row3, col3] == 1 && Connect4Array[row4, col4] == 1)
                    {
                        WinStatus = 1;
                        break;
                    }
                }
            }
            //Return the result
            return WinStatus;
        }

        // Diagonal win from top-right to bottom-left direction  
        public int WinDiagonal2(int Row, int Col)
        {
            //Declares the following variables
            int Offset, col1, col2, col3, col4, row1, row2, row3, row4, WinStatus = -1;
            //Counter
            for (Offset = -3; Offset <= 0; Offset++)
            {
                //Going through the four squares
                col1 = Col - Offset;
                col2 = col1 - 1;
                col3 = col2 - 1;
                col4 = col3 - 1;

                //Going through the four squares
                row1 = Row - Offset;
                row2 = row1 - 1;
                row3 = row2 - 1;
                row4 = row3 - 1;

                //Making sure that the search doesn't exceed the boundaries of the array
                if (col1 >= 0 && col1 <= 6 && col2 >= 0 && col2 <= 6 && col3 >= 0 && col3 <= 6 && col4 >= 0 && col4 <= 6 && row1 >= 0 && row1 <= 5 && row2 >= 0 && row2 <= 5 && row3 >= 0 && row3 <= 5 && row4 >= 0 && row4 <= 5)
                {
                    //Blue wins
                    if (Connect4Array[row1, col1] == 0 && Connect4Array[row2, col2] == 0 && Connect4Array[row3, col3] == 0 && Connect4Array[row4, col4] == 0)
                    {
                        WinStatus = 0;
                        break;
                    }
                    //Red wins
                    else if (Connect4Array[row1, col1] == 1 && Connect4Array[row2, col2] == 1 && Connect4Array[row3, col3] == 1 && Connect4Array[row4, col4] == 1)
                    {
                        WinStatus = 1;
                        break;
                    }
                }
            }

            //Return the result
            return WinStatus;
        }

        // Winning horizontally 
        public int WinHorizontal(int Row, int Col)
        {
            //Declare variables
            int Offset, col1, col2, col3, col4, WinStatus = -1;
            //Counter
            for (Offset = -3; Offset <= 0; Offset++)
            {
                //Going through the four squares
                col1 = Col + Offset;
                col2 = col1 + 1;
                col3 = col2 + 1;
                col4 = col3 + 1;

                //Making sure that the search doesn't go out of the array
                if (col1 >= 0 && col1 <= 6 && col2 >= 0 && col2 <= 6 && col3 >= 0 && col3 <= 6 && col4 >= 0 && col4 <= 6)
                {
                    //Blue wins
                    if (Connect4Array[Row, col1] == 0 && Connect4Array[Row, col2] == 0 && Connect4Array[Row, col3] == 0 && Connect4Array[Row, col4] == 0)
                    {
                        WinStatus = 0;
                        break;
                    }
                    //Red wins
                    else if (Connect4Array[Row, col1] == 1 && Connect4Array[Row, col2] == 1 && Connect4Array[Row, col3] == 1 && Connect4Array[Row, col4] == 1)
                    {
                        WinStatus = 1;
                        break;
                    }
                }
            }

            //Return the result
            return WinStatus;
        }

        // Winning Vertically 
        public int WinVertical(int Row, int Col)
        {
            //Declare the variables
            int Offset, Row1, Row2, Row3, Row4, WinStatus = -1;
            //Counter
            for (Offset = -3; Offset <= 0; Offset++)
            {
                //Going through the four squares
                Row1 = Row + Offset;
                Row2 = Row1 + 1;
                Row3 = Row2 + 1;
                Row4 = Row3 + 1;

                if (Row1 >= 0 && Row1 <= 2)
                {
                    //Blue Wins
                    if (Connect4Array[Row1, Col] == 0 && Connect4Array[Row2, Col] == 0 && Connect4Array[Row3, Col] == 0 && Connect4Array[Row4, Col] == 0)
                    {
                        WinStatus = 0;
                        break;
                    }
                    //Red Wins
                    else if (Connect4Array[Row1, Col] == 1 && Connect4Array[Row2, Col] == 1 && Connect4Array[Row3, Col] == 1 && Connect4Array[Row4, Col] == 1)
                    {
                        WinStatus = 1;
                        break;
                    }
                }
            }
            //Return the Result
            return WinStatus;
        }

        // New game method 
        public void NewGame()
        {
            //Starts a new game
            Graphics g = Graphics.FromHwnd(pbConnect4.Handle);

            int i, j;

            // Loops the program and assigns all spot a value of -1
            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Connect4Array[i, j] = -1;
                }
            }

            Pen myPen = new Pen(Color.Blue, 3);

            // Creates the border 
            g.DrawLine(myPen, 0, 0, 0, 420);
            g.DrawLine(myPen, 0, 420, 360, 420);
            g.DrawLine(myPen, 360, 420, 360, 0);
            g.DrawLine(myPen, 420, 0, 0, 0);

            // Creates the vertical lines
            g.DrawLine(myPen, 60, 0, 60, 420);
            g.DrawLine(myPen, 120, 0, 120, 420);
            g.DrawLine(myPen, 180, 0, 180, 420);
            g.DrawLine(myPen, 240, 0, 240, 420);
            g.DrawLine(myPen, 300, 0, 300, 420);
            g.DrawLine(myPen, 360, 0, 360, 420);
            g.DrawLine(myPen, 420, 0, 420, 420);

            // Creates the horizontal lines 
            g.DrawLine(myPen, 0, 60, 420, 60);
            g.DrawLine(myPen, 0, 120, 420, 120);
            g.DrawLine(myPen, 0, 180, 420, 180);
            g.DrawLine(myPen, 0, 240, 420, 240);
            g.DrawLine(myPen, 0, 300, 420, 300);
            g.DrawLine(myPen, 0, 360, 420, 360);

        }

        // Resets the game 
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Messagebox appears asking user if he/she wants to start a new game 
            DialogResult NewGameMB2 = MessageBox.Show("Are you sure you want to start a new game?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (NewGameMB2)
            {
                // If yes is selected, a new game starts 
                case DialogResult.Yes:
                    {
                        // Game Board is reset
                        ResetBoard();
                        break;
                    }

                // If no is selected, current game is continued 
                case DialogResult.No:
                    break;
            }

        }

        // Prevents changes to the interface of the program from other programs or messageboxes 
        private void pbConnect4_Paint(object sender, PaintEventArgs e)
        {
            int i, j;
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Blue, 3);

            // Creates the border 
            g.DrawLine(myPen, 0, 0, 0, 420);
            g.DrawLine(myPen, 0, 420, 360, 420);
            g.DrawLine(myPen, 360, 420, 360, 0);
            g.DrawLine(myPen, 420, 0, 0, 0);

            // Creates the vertical lines 
            g.DrawLine(myPen, 60, 0, 60, 420);
            g.DrawLine(myPen, 120, 0, 120, 420);
            g.DrawLine(myPen, 180, 0, 180, 420);
            g.DrawLine(myPen, 240, 0, 240, 420);
            g.DrawLine(myPen, 300, 0, 300, 420);
            g.DrawLine(myPen, 360, 0, 360, 420);
            g.DrawLine(myPen, 420, 0, 420, 420);

            // Creates the horizontal lines 
            g.DrawLine(myPen, 0, 60, 420, 60);
            g.DrawLine(myPen, 0, 120, 420, 120);
            g.DrawLine(myPen, 0, 180, 420, 180);
            g.DrawLine(myPen, 0, 240, 420, 240);
            g.DrawLine(myPen, 0, 300, 420, 300);
            g.DrawLine(myPen, 0, 360, 420, 360);

            for (i = 0; i < 6; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    if (Connect4Array[i, j] == 0) //Draw a Blue peg
                    {
                        g.FillEllipse(blueBrush, j * 60, i * 60, 60, 60);
                    }
                    else if (Connect4Array[i, j] == 1) //Draw a red peg
                    {
                        g.FillEllipse(redBrush, j * 60, i * 60, 60, 60);
                    }
                }
            }
        }

        private void pbConnect4_MouseClick(object sender, MouseEventArgs e)
        {
            //Declaring variables
            int Col = 0, Row = 0;
            int MouseX, MouseY;
            MouseX = e.X;
            MouseY = e.Y;

            //Decalres the graphics
            Graphics g = Graphics.FromHwnd(pbConnect4.Handle);
            SolidBrush myBrush = new SolidBrush(Color.Black);
            myBrush.Color = Color.Red;

            MouseX = e.X;

            if (FinishGame == false)
            {
                //Detects the location of the mouse 
                if (MouseX < 60)
                    Col = 0;

                else if (MouseX < 120)
                    Col = 1;

                else if (MouseX < 180)
                    Col = 2;

                else if (MouseX < 240)
                    Col = 3;

                else if (MouseX < 300)
                    Col = 4;

                else if (MouseX < 360)
                    Col = 5;

                else if (MouseX < 420)
                    Col = 6;

                Row = GetRow(Col);

                //No room in column
                if (Row == -1)
                {
                    // Messagebox appears when there is no room in the column 
                    MessageBox.Show("The column you selected is full. Please reconsider your options.", "Invalid Move", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                else
                {
                    Connect4Array[Row, Col] = iTurn;

                    if (iTurn == 0) //switch turns
                    {
                        iTurn = 1;
                        iCounter++;
                        // Displays a message in the groupbox TURN STATUS that tells the user which player's turn is it
                        lblTurn.Text = "Red's Turn";

                    }
                    else
                    {
                        iTurn = 0;
                        iCounter++;
                        // Displays a message in the groupbox TURN STATUS that tells the user which player's turn is it
                        lblTurn.Text = "Blue's Turn";
                    }

                    pbConnect4.Invalidate();

                    // If red wins
                    if (WinHorizontal(Row, Col) == 1 || WinVertical(Row, Col) == 1 || WinDiagonal(Row, Col) == 1 || WinDiagonal2(Row, Col) == 1)
                    {
                        //Messagebox appears when red wins
                        MessageBox.Show("Red Wins!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FinishGame = true;
                    }

                        // If blue wins
                    else if (WinHorizontal(Row, Col) == 0 || WinVertical(Row, Col) == 0 || WinDiagonal(Row, Col) == 0 || WinDiagonal2(Row, Col) == 0)
                    {
                        //Messagebox appears when blue wins
                        MessageBox.Show("Blue Wins!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FinishGame = true;
                    }

                    // If a the current round ends in a draw
                    if (iCounter == 42 && FinishGame == false)
                    {
                        // Messagebox appears telling the user that the game has ended in a draw and asks if he/she wants to start a new game 
                        DialogResult CatsGame = MessageBox.Show("The game has concluded with no winner. Would you like to start a new game?", "Draw", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        switch (CatsGame)
                        {
                            // If Yes is selected, a new game starts  
                            case DialogResult.Yes:
                                {
                                    ResetBoard();
                                    break;
                                }

                            // If No is selected, a new game does not start 
                            case DialogResult.No:
                                break;

                        }
                    }

                    // If a winner is decided, the game is stopped. 
                    if (FinishGame == true)
                    {
                        // Messagebox appears asking user if he/she wants to start a new game 
                        DialogResult NewGameMB = MessageBox.Show("Would you like to start a new game?", "New Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        switch (NewGameMB)
                        {
                            // If Yes is selected, a new game starts  
                            case DialogResult.Yes:
                                {
                                    ResetBoard();
                                    break;
                                }
                            // If No is selected, a new game does not start 
                            case DialogResult.No:
                                break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("The round has reached its conclusion. Press NEW GAME to start a new game.", "Match Ended", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exits the application 
            Application.Exit();
        }

        // Background Music 
        private void BackgroundMusic()
        {

           // SoundPlayer Connect4Music = new SoundPlayer(@"E:\Connect_Four.wav");// Locates location of song 
            // Plays and loops located music 
            //Connect4Music.PlayLooping();
        }

        // private void Form1
        private void Connect4_Load(object sender, EventArgs e)
        {
            BackgroundMusic();
        }

        private void btnNameChange_Click(object sender, EventArgs e)
        {
            GetNameDialog.ShowDialog();
            // Player1F2 is converted back to a string and is displayed in txtPlayer1 textbox 
            txtPlayer1.Text = GetNameDialog.Player1F2;
            // Player2F2 is converted back to a string and is displayed in txtPlayer2 textbox 
            txtPlayer2.Text = GetNameDialog.Player2F2;
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instructions messagebox
            MessageBox.Show("Hello user, welcome to Connect 4. Please read the following instructions to learn how to pilot the program." + "\n" + "" + "\n" + "1. Blue selects the placement of his/her first piece. (Whoever goes first alternates each round)" + "\n" + "2. Red selects the placement of his/her first piece.(Whoever goes first alternates each round)" + "\n" + "3. Each player takes turns placing pieces in desired columns and tries to get four pieces of one's color in a row, column, or a diagonal." + "\n" + "4. To start a new game click the button labelled NEW GAME or if some one desires to change their game name, click the button labelled CHANGE PLAYERS' NAMES." + "\n" + "5. If someone is confused on who's turn is it, direction attention to the group box labelled PLAYERS' TURN STATUS." + "\n" + "" + "\n" + "Enjoy!", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }

        private void tipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Tips Messagebox
            MessageBox.Show("Stuck? Use the following tips to help you." + "\n" + "" + "\n" + "- The player who is going first should attempt on placing their piece in the middle column allowing room for the prevention of constructing rows, columns, diagonals on both sids." + "\n" + "- Try to construct seperate rows, columns, or diagonals at different places of the game, resulting in your opponent focusing on one instead of the others." + "\n" + "- Stay on your toes and keep an eye on your opponent's moves. He/she might get the best of you!", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        }
    }
}











