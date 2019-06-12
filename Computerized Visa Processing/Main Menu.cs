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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About now = new About();
            now.Show();
            this.Hide();
        }

        private void businessEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewBiz now = new viewBiz();
            now.Show();
            this.Hide();
        }

        private void fianceeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewFiancee now = new viewFiancee();
            now.Show();
            this.Hide();
        }

        private void journalistEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewJournalist now = new viewJournalist();
            now.Show();
            this.Hide();
        }

        private void relaxationEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewRelax now = new viewRelax();
            now.Show();
            this.Hide();
        }

        private void studentEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewStudent now = new viewStudent();
            now.Show();
            this.Hide();
        }

        private void workersEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewWorker now = new viewWorker();
            now.Show();
            this.Hide();
        }

        private void businessToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            searchbiz now = new searchbiz();
            now.Show();
            this.Hide();
        }

        private void fianceeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            searchFiancee now = new searchFiancee();
            now.Show();
            this.Hide();
        }

        private void relaxationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            searchJournalist now = new searchJournalist();
            now.Show();
            this.Hide();

        }

        private void relaxationToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            searchRelax now = new searchRelax();
            now.Show();
            this.Hide();
        }

        private void studentVisaEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchStudent now = new searchStudent();
            now.Show();
            this.Hide();
        }

        private void workersVisaEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchWorker now = new searchWorker();
            now.Show();
            this.Hide();
        }

        private void businessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Business_Visa_Form now = new Business_Visa_Form();
            now.Show();
            this.Hide();
        }

        private void fianceeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fiancee_Visa_Form now = new Fiancee_Visa_Form();
            now.Show();
            this.Hide();
        }

        private void journalistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Journalist_Visa_Form now = new Journalist_Visa_Form();
            now.Show();
            this.Hide();
        }

        private void relaxationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relaxation_Visa_Form now = new Relaxation_Visa_Form();
            now.Show();
            this.Hide();
        }

        private void studentVisaFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VISA_form now = new VISA_form();
            now.Show();
            this.Hide();
        }

        private void workerVisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worker_Visa_Form now = new Worker_Visa_Form();
            now.Show();
            this.Hide();
        }
    }
}
