using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Computerized_Visa_Processing
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 5;
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                Main_Menu now = new Main_Menu();
                now.Show();
            }
        }
               
    }
}
