namespace TypeRacer
{
    partial class ChooseRaceLevel
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
            this.cmboxChooseLevel = new System.Windows.Forms.ComboBox();
            this.lblChooseLevel = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.listviewHighscores = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WordsPerMinute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CompleteTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MapNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRanking = new System.Windows.Forms.Label();
            this.lblHelloUser = new System.Windows.Forms.Label();
            this.lblReachedScore = new System.Windows.Forms.Label();
            this.lblPlayedGames = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmboxChooseLevel
            // 
            this.cmboxChooseLevel.FormattingEnabled = true;
            this.cmboxChooseLevel.Location = new System.Drawing.Point(89, 55);
            this.cmboxChooseLevel.Name = "cmboxChooseLevel";
            this.cmboxChooseLevel.Size = new System.Drawing.Size(155, 21);
            this.cmboxChooseLevel.TabIndex = 0;
            // 
            // lblChooseLevel
            // 
            this.lblChooseLevel.AutoSize = true;
            this.lblChooseLevel.Location = new System.Drawing.Point(12, 58);
            this.lblChooseLevel.Name = "lblChooseLevel";
            this.lblChooseLevel.Size = new System.Drawing.Size(71, 13);
            this.lblChooseLevel.TabIndex = 1;
            this.lblChooseLevel.Text = "Choose level:";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(250, 53);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // listviewHighscores
            // 
            this.listviewHighscores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Player,
            this.WordsPerMinute,
            this.CompleteTime,
            this.MapNumber});
            this.listviewHighscores.Location = new System.Drawing.Point(15, 110);
            this.listviewHighscores.Name = "listviewHighscores";
            this.listviewHighscores.Size = new System.Drawing.Size(310, 186);
            this.listviewHighscores.TabIndex = 4;
            this.listviewHighscores.UseCompatibleStateImageBehavior = false;
            this.listviewHighscores.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No.";
            this.No.Width = 46;
            // 
            // Player
            // 
            this.Player.Text = "Player";
            this.Player.Width = 105;
            // 
            // WordsPerMinute
            // 
            this.WordsPerMinute.Text = "Words/Min";
            this.WordsPerMinute.Width = 67;
            // 
            // CompleteTime
            // 
            this.CompleteTime.Text = "Time";
            this.CompleteTime.Width = 46;
            // 
            // MapNumber
            // 
            this.MapNumber.Text = "Map";
            this.MapNumber.Width = 39;
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Location = new System.Drawing.Point(12, 86);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(63, 13);
            this.lblRanking.TabIndex = 5;
            this.lblRanking.Text = "Highscores:";
            // 
            // lblHelloUser
            // 
            this.lblHelloUser.AutoSize = true;
            this.lblHelloUser.Location = new System.Drawing.Point(10, 9);
            this.lblHelloUser.Name = "lblHelloUser";
            this.lblHelloUser.Size = new System.Drawing.Size(65, 13);
            this.lblHelloUser.TabIndex = 6;
            this.lblHelloUser.Text = "Hello {user}!";
            // 
            // lblReachedScore
            // 
            this.lblReachedScore.AutoSize = true;
            this.lblReachedScore.Location = new System.Drawing.Point(12, 34);
            this.lblReachedScore.Name = "lblReachedScore";
            this.lblReachedScore.Size = new System.Drawing.Size(0, 13);
            this.lblReachedScore.TabIndex = 7;
            // 
            // lblPlayedGames
            // 
            this.lblPlayedGames.AutoSize = true;
            this.lblPlayedGames.Location = new System.Drawing.Point(211, 9);
            this.lblPlayedGames.Name = "lblPlayedGames";
            this.lblPlayedGames.Size = new System.Drawing.Size(114, 13);
            this.lblPlayedGames.TabIndex = 8;
            this.lblPlayedGames.Text = "Played games: {count}";
            // 
            // ChooseRaceLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 308);
            this.Controls.Add(this.lblPlayedGames);
            this.Controls.Add(this.lblReachedScore);
            this.Controls.Add(this.lblHelloUser);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.listviewHighscores);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblChooseLevel);
            this.Controls.Add(this.cmboxChooseLevel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(353, 347);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(353, 347);
            this.Name = "ChooseRaceLevel";
            this.Text = "ChooseRaceLevel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboxChooseLevel;
        private System.Windows.Forms.Label lblChooseLevel;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ListView listviewHighscores;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.ColumnHeader WordsPerMinute;
        private System.Windows.Forms.ColumnHeader CompleteTime;
        private System.Windows.Forms.Label lblHelloUser;
        private System.Windows.Forms.ColumnHeader MapNumber;
        private System.Windows.Forms.Label lblReachedScore;
        private System.Windows.Forms.Label lblPlayedGames;
    }
}