namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.lblInput = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPlayer1F2 = new System.Windows.Forms.TextBox();
            this.txtPlayer2F2 = new System.Windows.Forms.TextBox();
            this.btnReady = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.ttReady = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(34, 54);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(192, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Please input the names of both players:";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(34, 100);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer1.TabIndex = 1;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(34, 142);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(45, 13);
            this.lblPlayer2.TabIndex = 2;
            this.lblPlayer2.Text = "Player 2";
            // 
            // txtPlayer1F2
            // 
            this.txtPlayer1F2.Location = new System.Drawing.Point(129, 93);
            this.txtPlayer1F2.Name = "txtPlayer1F2";
            this.txtPlayer1F2.Size = new System.Drawing.Size(123, 20);
            this.txtPlayer1F2.TabIndex = 0;
            // 
            // txtPlayer2F2
            // 
            this.txtPlayer2F2.Location = new System.Drawing.Point(129, 135);
            this.txtPlayer2F2.Name = "txtPlayer2F2";
            this.txtPlayer2F2.Size = new System.Drawing.Size(123, 20);
            this.txtPlayer2F2.TabIndex = 1;
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(37, 182);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(215, 23);
            this.btnReady.TabIndex = 2;
            this.btnReady.Text = "Ready";
            this.ttReady.SetToolTip(this.btnReady, "Click if you are ready to start the game.");
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(34, 28);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(116, 13);
            this.lblWelcome.TabIndex = 6;
            this.lblWelcome.Text = "Welcome to Connect 4";
            // 
            // ttReady
            // 
            this.ttReady.IsBalloon = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 245);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.txtPlayer2F2);
            this.Controls.Add(this.txtPlayer1F2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblInput);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect 4 Player Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtPlayer1F2;
        private System.Windows.Forms.TextBox txtPlayer2F2;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolTip ttReady;
    }
}