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
    public partial class MainForm : Form
    {
        DepartmentForm1 departmentForm;
        DoctorForm doctorForm;
        Context context;
        public MainForm()
        {
            InitializeComponent();
            context = new Context();

            PatiantForm patiant = new PatiantForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MainPanal.Visible = true;
 
        }

        private void label1Label_Click(object sender, EventArgs e)
        {

        }

        private void DoctorBtn_Click(object sender, EventArgs e)
        {
            doctorForm = new DoctorForm(this.context ,this);
            doctorForm.Show();
            this.Visible = false;   
        }

        private void DeptBtn_Click(object sender, EventArgs e)
        {
            departmentForm = new DepartmentForm1(this);
            departmentForm.Show();
            this.Visible = false;

        }
        private void PatientBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
