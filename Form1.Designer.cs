namespace Pong
{
    partial class Pong
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
            this.player = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerScoreboard = new System.Windows.Forms.Label();
            this.cpuScoreboard = new System.Windows.Forms.Label();
            this.ScoreDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.White;
            this.player.Location = new System.Drawing.Point(903, 219);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(13, 99);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.White;
            this.cpu.Location = new System.Drawing.Point(12, 219);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(13, 99);
            this.cpu.TabIndex = 1;
            this.cpu.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(458, 261);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(16, 16);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // playerScoreboard
            // 
            this.playerScoreboard.AutoSize = true;
            this.playerScoreboard.BackColor = System.Drawing.Color.Transparent;
            this.playerScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.playerScoreboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.playerScoreboard.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.playerScoreboard.Location = new System.Drawing.Point(728, 9);
            this.playerScoreboard.Name = "playerScoreboard";
            this.playerScoreboard.Size = new System.Drawing.Size(38, 26);
            this.playerScoreboard.TabIndex = 3;
            this.playerScoreboard.Text = "00";
            // 
            // cpuScoreboard
            // 
            this.cpuScoreboard.AutoSize = true;
            this.cpuScoreboard.BackColor = System.Drawing.Color.Transparent;
            this.cpuScoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.cpuScoreboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cpuScoreboard.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.cpuScoreboard.Location = new System.Drawing.Point(162, 9);
            this.cpuScoreboard.Name = "cpuScoreboard";
            this.cpuScoreboard.Size = new System.Drawing.Size(38, 26);
            this.cpuScoreboard.TabIndex = 4;
            this.cpuScoreboard.Text = "00";
            // 
            // ScoreDisplay
            // 
            this.ScoreDisplay.AutoSize = true;
            this.ScoreDisplay.BackColor = System.Drawing.Color.Transparent;
            this.ScoreDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ScoreDisplay.ForeColor = System.Drawing.Color.Lime;
            this.ScoreDisplay.Location = new System.Drawing.Point(393, 9);
            this.ScoreDisplay.Name = "ScoreDisplay";
            this.ScoreDisplay.Size = new System.Drawing.Size(0, 26);
            this.ScoreDisplay.TabIndex = 5;
            // 
            // Pong
            // 
            this.AccessibleName = "Pong";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.ScoreDisplay);
            this.Controls.Add(this.cpuScoreboard);
            this.Controls.Add(this.playerScoreboard);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.player);
            this.Name = "Pong";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerScoreboard;
        private System.Windows.Forms.Label cpuScoreboard;
        private System.Windows.Forms.Label ScoreDisplay;
    }
}

