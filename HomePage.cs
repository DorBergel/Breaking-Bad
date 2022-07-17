using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrakingBad
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        //when the project is loading it will automatically open on maximum size
        private void HomePage_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }
        // when the "Start" button clicked, the player will move to the game page
        private void button1_Click(object sender, EventArgs e)
        {
            surface Check = new surface();
            Check.Show();
            Hide();
        }

        // when the "Exit" button clicked, the player will exit the game
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
