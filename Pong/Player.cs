using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    public class Player
    {
        public bool isUpPressed, isDownPressed;

        public PictureBox paddle;
        Label scoreLabel;
        bool? wasGoingUpLastTick;
        int numberOfTicksGoingInTheSameDirection;

        // property example:
        // _score is a temp variable  
        int _score;
        public int score
        {
            // get the current score
            get
            {
                return _score;
            }
            // set the score to something
            set
            {
                _score = value;
                // also set the score label text to the current score
                scoreLabel.Text = score.ToString();
            }
        }
        
        public Player(PictureBox paddle, Label scoreLabel)
        {
            this.paddle = paddle;
            this.scoreLabel = scoreLabel;
        }

        internal void ProcessMove()
        {
            bool? goingUp = null;
            if (isUpPressed)
            {
                goingUp = true;
            }

            if (isDownPressed)
            {
                if (goingUp.HasValue)
                {
                    goingUp = null;
                }
                else
                {
                    goingUp = false;
                }
            }

            // Solving for acceleration
            if (wasGoingUpLastTick.HasValue)
            {
                // if goingUp is null
                if (!goingUp.HasValue)
                {
                    wasGoingUpLastTick = null;
                    numberOfTicksGoingInTheSameDirection = 0;
                }
                else if (wasGoingUpLastTick.Value == goingUp.Value)
                {
                    numberOfTicksGoingInTheSameDirection++;
                }
                else
                {
                    // just switched direction
                    wasGoingUpLastTick = goingUp;
                    numberOfTicksGoingInTheSameDirection = 1;
                }
            }
            else if (goingUp.HasValue)
            {
                wasGoingUpLastTick = goingUp;
                numberOfTicksGoingInTheSameDirection = 1;
            }

            Move(goingUp);
        }

        private void Move(bool? goingUp)
        {
            // check to see if goingUp is null
            if (goingUp.HasValue)
            {
                int speed = PongWorldInfo.movementSpeed * numberOfTicksGoingInTheSameDirection / 10;
                if (goingUp.Value)
                {
                    // need to decrease the Y value to go up the screen
                    speed *= -1;
                }
                // Math.Max() is making sure that there are no negitive Y values.
                // Math.Min() is making sure there are no Y values above max Y. 
                paddle.Location = new Point(paddle.Location.X,
                    Math.Max(PongWorldInfo.topOfWorld,
                    Math.Min(PongWorldInfo.bottomOfWorld - paddle.Height,
                    paddle.Location.Y + speed)));
            }
        }
    }
}
