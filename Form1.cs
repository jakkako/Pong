using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Pong : Form
    {
        bool goUp;
        bool goDown;
        int cpuSpeed = 5;
        int ballX = 5;
        int ballY = 5;
        int playerScore = 0;
        int cpuScore = 0;

        

        public Pong()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // when the Up key is actuated 
                // update global variable: "goUp" to true
                goUp = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                // when the Down key is actuated 
                // update global variable: "goDown" to true
                goDown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                // when the Up key is released/unactuated 
                // update global variable: "goUp" to false
                goUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                // when the Down key is released/unactuated 
                // update global variable: "goDown" to false
                goDown = false;
            }
        }

        private void timerTick(object sender, EventArgs e)
        {
            var cheerTimer = new Timer();
            cheerTimer.Interval = 3000;
            cheerTimer.Tick += (s, trigger) =>
            {
                ScoreDisplay.Hide();
                cheerTimer.Stop();
            };

            if (playerScore < 10)
            {
                playerScoreboard.Text = "0" + playerScore;
            } else
            {
                playerScoreboard.Text = "" + playerScore;
            }

            if (cpuScore < 10)
            {
                cpuScoreboard.Text = "0" + cpuScore;
            }
            else
            {
                cpuScoreboard.Text = "" + cpuScore;
            }

            ball.Top -= ballY;
            ball.Left -= ballX;

            cpu.Top += cpuSpeed;

           if (cpu.Top < 0 || cpu.Top + cpu.Height > ClientSize.Height)
            {
                cpuSpeed = -cpuSpeed;
            }

           if (goUp && player.Top > 0 && !goDown)
            {
                player.Top -= 8;
            }
           if (goDown && player.Top + player.Height < ClientSize.Height && !goUp)
            {
                player.Top += 8;
            }

           if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                ballY = -ballY;
            }

           if (ball.Left < 0)
            {
                ball.Left = this.Width / 2;
                ballX = -ballX;
                //ballX -= 2;
                playerScore++;
                ScoreDisplay.Text = "Player scores!";
                if (ScoreDisplay.Visible == true)
                {
                    cheerTimer.Stop();
                }
                else
                {
                    ScoreDisplay.Show();
                }
                cheerTimer.Start();
                
            }
           if (ball.Left > ClientSize.Width)
            {
                ball.Left = ClientSize.Width / 2;
                ballX = -ballX;
                //ballX += 2;
                cpuScore++;
                ScoreDisplay.Text = "CPU scores!";
                if (ScoreDisplay.Visible == true)
                {
                    cheerTimer.Stop();
                }
                else
                {
                    ScoreDisplay.Show();
                }
                cheerTimer.Start();
            }
            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballX = -ballX;
            }

            if (playerScore >= 10)
            {
                gameTimer.Stop();
                MessageBox.Show("Player wins");
            }
        }
    }
}
