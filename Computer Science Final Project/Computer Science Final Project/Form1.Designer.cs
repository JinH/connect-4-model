namespace WindowsFormsApplication1
{
    partial class Connect4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbPlayers = new System.Windows.Forms.GroupBox();
            this.pbBluePieceDisplay = new System.Windows.Forms.PictureBox();
            this.pbRedPieceDisplay = new System.Windows.Forms.PictureBox();
            this.btnNameChange = new System.Windows.Forms.Button();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbConnect4 = new System.Windows.Forms.PictureBox();
            this.ttNewGame = new System.Windows.Forms.ToolTip(this.components);
            this.ttNameChange = new System.Windows.Forms.ToolTip(this.components);
            this.lblTurn = new System.Windows.Forms.Label();
            this.gbTurnStatus = new System.Windows.Forms.GroupBox();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluePieceDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPieceDisplay)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnect4)).BeginInit();
            this.gbTurnStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPlayers
            // 
            this.gbPlayers.Controls.Add(this.pbBluePieceDisplay);
            this.gbPlayers.Controls.Add(this.pbRedPieceDisplay);
            this.gbPlayers.Controls.Add(this.btnNameChange);
            this.gbPlayers.Controls.Add(this.txtPlayer2);
            this.gbPlayers.Controls.Add(this.txtPlayer1);
            this.gbPlayers.Location = new System.Drawing.Point(443, 44);
            this.gbPlayers.Name = "gbPlayers";
            this.gbPlayers.Size = new System.Drawing.Size(167, 175);
            this.gbPlayers.TabIndex = 1;
            this.gbPlayers.TabStop = false;
            this.gbPlayers.Text = "Players";
            // 
            // pbBluePieceDisplay
            // 
            this.pbBluePieceDisplay.BackColor = System.Drawing.Color.Blue;
            this.pbBluePieceDisplay.Location = new System.Drawing.Point(11, 61);
            this.pbBluePieceDisplay.Name = "pbBluePieceDisplay";
            this.pbBluePieceDisplay.Size = new System.Drawing.Size(60, 60);
            this.pbBluePieceDisplay.TabIndex = 7;
            this.pbBluePieceDisplay.TabStop = false;
            // 
            // pbRedPieceDisplay
            // 
            this.pbRedPieceDisplay.BackColor = System.Drawing.Color.Red;
            this.pbRedPieceDisplay.Location = new System.Drawing.Point(97, 61);
            this.pbRedPieceDisplay.Name = "pbRedPieceDisplay";
            this.pbRedPieceDisplay.Size = new System.Drawing.Size(60, 60);
            this.pbRedPieceDisplay.TabIndex = 7;
            this.pbRedPieceDisplay.TabStop = false;
            // 
            // btnNameChange
            // 
            this.btnNameChange.Location = new System.Drawing.Point(6, 129);
            this.btnNameChange.Name = "btnNameChange";
            this.btnNameChange.Size = new System.Drawing.Size(155, 23);
            this.btnNameChange.TabIndex = 0;
            this.btnNameChange.Text = "Change Players\' Names";
            this.ttNameChange.SetToolTip(this.btnNameChange, "Click to change the name(s) of one or both players.");
            this.btnNameChange.UseVisualStyleBackColor = true;
            this.btnNameChange.Click += new System.EventHandler(this.btnNameChange_Click);
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(93, 30);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(68, 20);
            this.txtPlayer2.TabIndex = 1;
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(6, 30);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(68, 20);
            this.txtPlayer1.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(449, 309);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(155, 23);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.ttNewGame.SetToolTip(this.btnNewGame, "Click to start a new game.");
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(622, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem,
            this.tipsToolStripMenuItem});
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.manualToolStripMenuItem.Text = "Manual";
            // 
            // pbConnect4
            // 
            this.pbConnect4.Location = new System.Drawing.Point(12, 44);
            this.pbConnect4.Name = "pbConnect4";
            this.pbConnect4.Size = new System.Drawing.Size(420, 360);
            this.pbConnect4.TabIndex = 6;
            this.pbConnect4.TabStop = false;
            this.pbConnect4.Paint += new System.Windows.Forms.PaintEventHandler(this.pbConnect4_Paint);
            this.pbConnect4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbConnect4_MouseClick);
            // 
            // ttNewGame
            // 
            this.ttNewGame.IsBalloon = true;
            // 
            // ttNameChange
            // 
            this.ttNameChange.IsBalloon = true;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(7, 35);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(0, 33);
            this.lblTurn.TabIndex = 7;
            // 
            // gbTurnStatus
            // 
            this.gbTurnStatus.Controls.Add(this.lblTurn);
            this.gbTurnStatus.Location = new System.Drawing.Point(443, 225);
            this.gbTurnStatus.Name = "gbTurnStatus";
            this.gbTurnStatus.Size = new System.Drawing.Size(167, 78);
            this.gbTurnStatus.TabIndex = 8;
            this.gbTurnStatus.TabStop = false;
            this.gbTurnStatus.Text = "Players\' Turn Status";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // tipsToolStripMenuItem
            // 
            this.tipsToolStripMenuItem.Name = "tipsToolStripMenuItem";
            this.tipsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tipsToolStripMenuItem.Text = "Tips";
            this.tipsToolStripMenuItem.Click += new System.EventHandler(this.tipsToolStripMenuItem_Click);
            // 
            // Connect4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 420);
            this.Controls.Add(this.gbTurnStatus);
            this.Controls.Add(this.pbConnect4);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.gbPlayers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Connect4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect 4";
            this.Load += new System.EventHandler(this.Connect4_Load);
            this.gbPlayers.ResumeLayout(false);
            this.gbPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBluePieceDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedPieceDisplay)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnect4)).EndInit();
            this.gbTurnStatus.ResumeLayout(false);
            this.gbTurnStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPlayers;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.PictureBox pbConnect4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip ttNewGame;
        private System.Windows.Forms.Button btnNameChange;
        private System.Windows.Forms.ToolTip ttNameChange;
        private System.Windows.Forms.PictureBox pbBluePieceDisplay;
        private System.Windows.Forms.PictureBox pbRedPieceDisplay;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.GroupBox gbTurnStatus;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipsToolStripMenuItem;
    }
}

