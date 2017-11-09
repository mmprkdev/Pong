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
    public partial class MainMenu : Form
    {
        Form1 form1 = new Form1();

        public MainMenu()
        {
            InitializeComponent();
        }

        // Start the game
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
        
        // Exit applicaiton
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
