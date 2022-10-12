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
    public partial class Form1 : Form
    {
        DoctorForm doctorForm;
        Context context;
        public Form1()
        {
            InitializeComponent();
            context = new Context();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MainPanal.Visible = true;
 
           // this.DoctorPanal.Visible = false;
 
 
        }

        private void label1Label_Click(object sender, EventArgs e)
        {

        }

        private void DoctorBtn_Click(object sender, EventArgs e)
        {
            doctorForm = new DoctorForm(this.context);

        }
    }
}
