using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Data;

namespace Hospital
{
    public partial class VisitsForm1 : Form
    {
        Context context;
        MainForm mainForm;
        public VisitsForm1(Context _context, MainForm _mainForm)
        {
            context = _context;
            InitializeComponent();
            mainForm = _mainForm;
            this.FormClosed += VisitsForm1_FormClosed;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void VisitorADDbtn_Click(object sender, EventArgs e)
        {

        }

        private void Doctorbtn_Click(object sender, EventArgs e)
        {

        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
        }
        private void VisitsForm1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }
    }
}
