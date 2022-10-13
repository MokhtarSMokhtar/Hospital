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
        DoctorForm doctorForm;
        PatiantForm patiantForm;
        RoomForm roomForm;

        public VisitsForm1(Context _context, MainForm _mainForm)
        {
            context = _context;
            InitializeComponent();
            mainForm = _mainForm;
            this.FormClosed += VisitsForm1_FormClosed;

        }
        public VisitsForm1(Context _context, DoctorForm _doctorForm)
        {
            context = _context;
            InitializeComponent();
            doctorForm = _doctorForm;
            this.FormClosed += VisitsForm1_FormClosed;

        }

        public VisitsForm1(Context _context, PatiantForm _patiantForm)
        {
            context = _context;
            InitializeComponent();
            patiantForm = _patiantForm;
            this.FormClosed += VisitsForm1_FormClosed;

        }

        public VisitsForm1(Context _context, RoomForm _roomForm)
        {
            context = _context;
            InitializeComponent();
            roomForm = _roomForm;
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
            doctorForm = new DoctorForm(this.context, this);
            doctorForm.Show();
            this.Visible = false;
        }

        private void MainBtn_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Hide();

        }
        private void VisitsForm1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainForm.Visible = true;

        }

        private void Patientbtn_Click(object sender, EventArgs e)
        {
            patiantForm = new PatiantForm(this.context, this);
            patiantForm.Show();
            this.Visible = false;
        }

        private void roomBtn_Click(object sender, EventArgs e)
        {
            roomForm = new RoomForm(this.context, this);
            roomForm.Show();
            this.Visible = false;
        }
    }
}
