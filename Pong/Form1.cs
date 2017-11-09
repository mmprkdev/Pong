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
    public partial class Form1 : Form
    {
        // NOTE: the '?' in after "bool" sets the modifier "nullable" for the bool value,
        // i.e null is a valid option along with true and false. By default  the value is null.
        //bool? isUpPressed, isDownPressed;

        // NOTE: "refactoring" is the process of reorganizing code without changing
        // any of the functionality. E.g., extracting a redundant section of code
        // into a method. 
        // Automatic refactoring using Visual Studio:
        // 1.) Create generic variables to replace the variables that get repeated
        // 2.) Select the section of redundant code
        // 3.) Right click and select "Quick actions and refactoring"
        // 4.) Click "Extract method"

        // NOTE: At 16 ms intervals and below there are noticable
        // graphical glitches, particularly when trying to draw the
        // ball while it's moving at high speed. Not sure if I can do
        // anything about this or if it's just a limitation of the
        // Windows Forum framework.

        Player player1, player2;
        Ball ball;

        int timeLeft = 3;
        bool beginning = true;

        public Form1()
        {
            InitializeComponent();

            player1 = new Player(paddle1, player1Score);
            player2 = new Player(paddle2, player2Score);
            ball = new Ball(ball1, player1, player2, timer2);
        }
        
        internal void timer1_Tick(object sender, EventArgs e)
        {
            // This conditional makes sure that the countdown
            // timer runs at the very beginning of the game.
            if (beginning)
            {
                timer2.Start();
                player1.ProcessMove();
                player2.ProcessMove();
            }
            else
            {
                player1.ProcessMove();
                player2.ProcessMove();
                ball.ProcessMove();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            CheckKeys(e, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            CheckKeys(e, false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // for the countdown timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                countdown.Text = timeLeft.ToString();
                countdown.Show();
                countdownText.Show();
                timeLeft--;
            }
            else
            {
                countdown.Hide();
                countdownText.Hide();
                timeLeft = 3;
                ball.ResetBall();
                beginning = false;
                timer2.Stop();
            }
        }

        private void CheckKeys(KeyEventArgs e, bool isDown)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    player1.isUpPressed = isDown;
                    break;
                case Keys.S:
                    player1.isDownPressed = isDown;
                    break;
                case Keys.Up:
                    player2.isUpPressed = isDown;
                    break;
                case Keys.Down:
                    player2.isDownPressed = isDown;
                    break;
            }
        }
    }
}
