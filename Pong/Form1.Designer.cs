namespace Pong
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paddle1 = new System.Windows.Forms.PictureBox();
            this.paddle2 = new System.Windows.Forms.PictureBox();
            this.ball1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreTitle = new System.Windows.Forms.Label();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.countdown = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.countdownText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).BeginInit();
            this.SuspendLayout();
            // 
            // paddle1
            // 
            this.paddle1.Image = ((System.Drawing.Image)(resources.GetObject("paddle1.Image")));
            this.paddle1.Location = new System.Drawing.Point(12, 197);
            this.paddle1.Name = "paddle1";
            this.paddle1.Size = new System.Drawing.Size(23, 198);
            this.paddle1.TabIndex = 0;
            this.paddle1.TabStop = false;
            // 
            // paddle2
            // 
            this.paddle2.Image = ((System.Drawing.Image)(resources.GetObject("paddle2.Image")));
            this.paddle2.Location = new System.Drawing.Point(1029, 197);
            this.paddle2.Name = "paddle2";
            this.paddle2.Size = new System.Drawing.Size(23, 198);
            this.paddle2.TabIndex = 2;
            this.paddle2.TabStop = false;
            // 
            // ball1
            // 
            this.ball1.Image = ((System.Drawing.Image)(resources.GetObject("ball1.Image")));
            this.ball1.Location = new System.Drawing.Point(413, 294);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(23, 21);
            this.ball1.TabIndex = 3;
            this.ball1.TabStop = false;
            this.ball1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreTitle
            // 
            this.scoreTitle.AutoSize = true;
            this.scoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.scoreTitle.Location = new System.Drawing.Point(490, 9);
            this.scoreTitle.Name = "scoreTitle";
            this.scoreTitle.Size = new System.Drawing.Size(85, 31);
            this.scoreTitle.TabIndex = 4;
            this.scoreTitle.Text = "Score";
            this.scoreTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // player1Score
            // 
            this.player1Score.AutoSize = true;
            this.player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.player1Score.Location = new System.Drawing.Point(455, 38);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(29, 31);
            this.player1Score.TabIndex = 5;
            this.player1Score.Text = "0";
            // 
            // player2Score
            // 
            this.player2Score.AutoSize = true;
            this.player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.player2Score.Location = new System.Drawing.Point(581, 38);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(29, 31);
            this.player2Score.TabIndex = 6;
            this.player2Score.Text = "0";
            // 
            // divider
            // 
            this.divider.AutoSize = true;
            this.divider.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.divider.Location = new System.Drawing.Point(522, 38);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(21, 31);
            this.divider.TabIndex = 7;
            this.divider.Text = "|";
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.countdown.Location = new System.Drawing.Point(478, 237);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(98, 108);
            this.countdown.TabIndex = 8;
            this.countdown.Text = "3";
            this.countdown.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // countdownText
            // 
            this.countdownText.AutoSize = true;
            this.countdownText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.countdownText.Location = new System.Drawing.Point(421, 213);
            this.countdownText.Name = "countdownText";
            this.countdownText.Size = new System.Drawing.Size(201, 24);
            this.countdownText.TabIndex = 9;
            this.countdownText.Text = "spawning new ball...";
            this.countdownText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1064, 606);
            this.Controls.Add(this.countdownText);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.player2Score);
            this.Controls.Add(this.player1Score);
            this.Controls.Add(this.scoreTitle);
            this.Controls.Add(this.ball1);
            this.Controls.Add(this.paddle2);
            this.Controls.Add(this.paddle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.paddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paddle1;
        private System.Windows.Forms.PictureBox paddle2;
        private System.Windows.Forms.PictureBox ball1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreTitle;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label countdownText;
    }
}

