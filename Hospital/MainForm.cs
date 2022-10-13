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
        PatiantForm patiantForm;
        NusreForm nusreForm;
        RoomForm roomForm;
        VisitsForm1 visitsForm1;
       
        
        public MainForm()
        {
            InitializeComponent();
            context = new Context();
            

           
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
            departmentForm = new DepartmentForm1(this.context ,this);
            departmentForm.Show();
            this.Visible = false;

        }
        private void PatientBtn_Click(object sender, EventArgs e)
        {
            patiantForm = new PatiantForm(this.context, this);
            patiantForm.Show();
            this.Visible = false;
        }

        private void NurseBtn_Click(object sender, EventArgs e)
        {
            nusreForm = new NusreForm(this.context, this);
            nusreForm.Show();
            this.Visible = false;
        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            roomForm = new RoomForm(this.context, this);
            roomForm.Show();
            this.Visible = false;
        }

        private void VisitBtn_Click(object sender, EventArgs e)
        {
            visitsForm1 = new VisitsForm1(this.context, this);
            visitsForm1.Show();
            this.Visible = false;
        }
    }
}
