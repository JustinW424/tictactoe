
namespace ConnectFourApp
{
    partial class ConnectFourBoard
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
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnResetGame = new System.Windows.Forms.Button();
            this.btnMusicToggle = new System.Windows.Forms.Button();
            this.btnEffectsToggle = new System.Windows.Forms.Button();
            this.lblTurnPlayer = new System.Windows.Forms.Label();
            this.lblScoreRed = new System.Windows.Forms.Label();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblScoreYellow = new System.Windows.Forms.Label();
            this.lblTurnColour = new System.Windows.Forms.Label();
            this.lblScoreNumRed = new System.Windows.Forms.Label();
            this.lblScoreNumYellow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGameTitle.Location = new System.Drawing.Point(288, 23);
            this.lblGameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(212, 37);
            this.lblGameTitle.TabIndex = 0;
            this.lblGameTitle.Text = "Connect Four";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel.Location = new System.Drawing.Point(39, 122);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(700, 420);
            this.panel.TabIndex = 1;
            // 
            // btnResetGame
            // 
            this.btnResetGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetGame.Location = new System.Drawing.Point(63, 567);
            this.btnResetGame.Name = "btnResetGame";
            this.btnResetGame.Size = new System.Drawing.Size(140, 35);
            this.btnResetGame.TabIndex = 2;
            this.btnResetGame.Text = "Reset Game";
            this.btnResetGame.UseVisualStyleBackColor = true;
            this.btnResetGame.Click += new System.EventHandler(this.btnResetGame_Click);
            // 
            // btnMusicToggle
            // 
            this.btnMusicToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMusicToggle.Location = new System.Drawing.Point(567, 567);
            this.btnMusicToggle.Name = "btnMusicToggle";
            this.btnMusicToggle.Size = new System.Drawing.Size(140, 35);
            this.btnMusicToggle.TabIndex = 3;
            this.btnMusicToggle.Text = "Music Toggle";
            this.btnMusicToggle.UseVisualStyleBackColor = true;
            this.btnMusicToggle.Click += new System.EventHandler(this.btnMusicToggle_Click);
            // 
            // btnEffectsToggle
            // 
            this.btnEffectsToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffectsToggle.Location = new System.Drawing.Point(318, 567);
            this.btnEffectsToggle.Name = "btnEffectsToggle";
            this.btnEffectsToggle.Size = new System.Drawing.Size(140, 35);
            this.btnEffectsToggle.TabIndex = 4;
            this.btnEffectsToggle.Text = "Sound Effects";
            this.btnEffectsToggle.UseVisualStyleBackColor = true;
            this.btnEffectsToggle.Click += new System.EventHandler(this.btnEffectsToggle_Click);
            // 
            // lblTurnPlayer
            // 
            this.lblTurnPlayer.AutoSize = true;
            this.lblTurnPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTurnPlayer.Location = new System.Drawing.Point(40, 84);
            this.lblTurnPlayer.Name = "lblTurnPlayer";
            this.lblTurnPlayer.Size = new System.Drawing.Size(135, 25);
            this.lblTurnPlayer.TabIndex = 5;
            this.lblTurnPlayer.Text = "Player Turn :";
            // 
            // lblScoreRed
            // 
            this.lblScoreRed.AutoSize = true;
            this.lblScoreRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreRed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScoreRed.Location = new System.Drawing.Point(637, 61);
            this.lblScoreRed.Name = "lblScoreRed";
            this.lblScoreRed.Size = new System.Drawing.Size(63, 25);
            this.lblScoreRed.TabIndex = 6;
            this.lblScoreRed.Text = "Red :";
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.AutoSize = true;
            this.lblScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScoreTitle.Location = new System.Drawing.Point(608, 23);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(135, 25);
            this.lblScoreTitle.TabIndex = 7;
            this.lblScoreTitle.Text = "Player Score";
            // 
            // lblScoreYellow
            // 
            this.lblScoreYellow.AutoSize = true;
            this.lblScoreYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreYellow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScoreYellow.Location = new System.Drawing.Point(608, 90);
            this.lblScoreYellow.Name = "lblScoreYellow";
            this.lblScoreYellow.Size = new System.Drawing.Size(88, 25);
            this.lblScoreYellow.TabIndex = 8;
            this.lblScoreYellow.Text = "Yellow :";
            // 
            // lblTurnColour
            // 
            this.lblTurnColour.AutoSize = true;
            this.lblTurnColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnColour.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTurnColour.Location = new System.Drawing.Point(174, 84);
            this.lblTurnColour.Name = "lblTurnColour";
            this.lblTurnColour.Size = new System.Drawing.Size(51, 25);
            this.lblTurnColour.TabIndex = 9;
            this.lblTurnColour.Text = "Red";
            // 
            // lblScoreNumRed
            // 
            this.lblScoreNumRed.AutoSize = true;
            this.lblScoreNumRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreNumRed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScoreNumRed.Location = new System.Drawing.Point(713, 61);
            this.lblScoreNumRed.Name = "lblScoreNumRed";
            this.lblScoreNumRed.Size = new System.Drawing.Size(24, 25);
            this.lblScoreNumRed.TabIndex = 10;
            this.lblScoreNumRed.Text = "0";
            // 
            // lblScoreNumYellow
            // 
            this.lblScoreNumYellow.AutoSize = true;
            this.lblScoreNumYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreNumYellow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblScoreNumYellow.Location = new System.Drawing.Point(713, 90);
            this.lblScoreNumYellow.Name = "lblScoreNumYellow";
            this.lblScoreNumYellow.Size = new System.Drawing.Size(24, 25);
            this.lblScoreNumYellow.TabIndex = 11;
            this.lblScoreNumYellow.Text = "0";
            // 
            // ConnectFourBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(775, 615);
            this.Controls.Add(this.btnResetGame);
            this.Controls.Add(this.btnEffectsToggle);
            this.Controls.Add(this.lblScoreNumYellow);
            this.Controls.Add(this.lblScoreNumRed);
            this.Controls.Add(this.lblTurnColour);
            this.Controls.Add(this.lblScoreYellow);
            this.Controls.Add(this.lblScoreTitle);
            this.Controls.Add(this.lblScoreRed);
            this.Controls.Add(this.lblTurnPlayer);
            this.Controls.Add(this.btnMusicToggle);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblGameTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(791, 654);
            this.MinimumSize = new System.Drawing.Size(791, 654);
            this.Name = "ConnectFourBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectFour";
            this.Load += new System.EventHandler(this.ConnectFourBoard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnResetGame;
        private System.Windows.Forms.Button btnMusicToggle;
        private System.Windows.Forms.Button btnEffectsToggle;
        private System.Windows.Forms.Label lblTurnPlayer;
        private System.Windows.Forms.Label lblScoreRed;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblScoreYellow;
        private System.Windows.Forms.Label lblTurnColour;
        private System.Windows.Forms.Label lblScoreNumRed;
        private System.Windows.Forms.Label lblScoreNumYellow;
    }
}

