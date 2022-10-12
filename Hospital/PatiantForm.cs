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
    public partial class PatiantForm : Form
    {

        Context context;
        MainForm mainForm;
        public PatiantForm(Context _context, MainForm _mainForm)
        {
            context = _context;
            InitializeComponent();
            this.mainForm = _mainForm;
            this.FormClosed += PatiantForm_FormClosed1;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void Patiant_Load(object sender, EventArgs e)
        {

        }

        private void Doctor_Click(object sender, EventArgs e)
        {

        }
        private void PatiantForm_FormClosed1(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void Patient_Back_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Hide();

        }
    }
}
