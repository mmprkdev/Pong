using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Pong
{
    public class Ball
    {
        // NOTE: "Random is not possible for computers. When we are talking about random
        // in computers we are talking about a sudo random number generator. Which
        // means it's a pattern that seems random to the user. The way that it starts
        // random is it's seeded somehow. When you don't define a seed generally that
        // means, look at the current time and that's your seed. So everytime you use
        // the random number generator you are using it at a different time so it feels
        // new to the user. If you define a seed it will follow the same sequence every
        // time, and sometimes  that can be usefull."

        private PictureBox ball;
        
        Random rand = new Random();
        Stopwatch stopwatch = new Stopwatch();
        Player leftSidePlayer, rightSidePlayer;
        Timer timer2;
        int xSpeed, ySpeed;
        bool scored = false;

        public Ball(PictureBox ball, Player leftSidePlayer, Player rightSidePlayer,Timer timer2)
        {
            this.ball = ball;
            this.leftSidePlayer = leftSidePlayer;
            this.rightSidePlayer = rightSidePlayer;
            this.timer2 = timer2;
            xSpeed = 5;
            ySpeed = 10;
        }

        internal void ProcessMove()
        {
            ball.Show();
            Move();

            // bounce off of the y boundries
            var bottom = PongWorldInfo.bottomOfWorld - ball.Height;
            if (ball.Location.Y >= bottom || ball.Location.Y <= PongWorldInfo.topOfWorld)
            {
                // flip direction
                ySpeed *= -1;
            }

            // Score if the ball goes past the x boundries
            // NOTE: Added the "&& scored == false" logic in order to solve a problem
            // where continuous scoring was happening while countdown timer was
            // running.  
            if (ball.Location.X <= PongWorldInfo.leftOfWorld && scored == false)
            {
                Score(rightSidePlayer);
            }
            else if (ball.Location.X >= PongWorldInfo.rightOfWorld - ball.Width && scored == false)
            {
                Score(leftSidePlayer);
            }

            // NOTE: At some point the ball speed gets too high for this
            // collision system to work anymore and the balls phase through
            // the paddles. Best solution might be to put a max speed limit
            // on the ball.
            if (leftSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds) ||
                rightSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds))
            {
                // enforce a speed limit of 18
                if (Math.Abs(xSpeed) <= 18)
                {
                    xSpeed *= -2;
                }
                else
                {
                    xSpeed *= -1;
                }

                // prevents ball from getting stuck in the paddle
                while (leftSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds) ||
                rightSidePlayer.paddle.Bounds.IntersectsWith(ball.Bounds))
                {
                    Move();
                }
            }
        }

        private int Move()
        {
            var bottom = PongWorldInfo.bottomOfWorld - ball.Height;
            ball.Location = new System.Drawing.Point(ball.Location.X + xSpeed,
                Math.Max(PongWorldInfo.topOfWorld,
                Math.Min(bottom, ball.Location.Y + ySpeed)));
            return bottom;
        }

        private void Score(Player winningPlayer)
        {
            winningPlayer.score++;
            scored = true;
            timer2.Start();
        }

        public void ResetBall()
        {
            ball.Location = new Point((PongWorldInfo.leftOfWorld + PongWorldInfo.rightOfWorld) / 2,
                            (PongWorldInfo.topOfWorld + PongWorldInfo.bottomOfWorld) / 2);

            // Give xSpeed and ySpeed a random value between -10 and 10 until
            // the product of x and y speed become larger than sum. 
            do
            {
                xSpeed = rand.Next(-10, 10);
                ySpeed = rand.Next(-10, 10);
            } while (Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 10);

            scored = false;
        }
    }
}
