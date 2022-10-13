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
    public partial class RoomForm : Form
    {
        Context context;
        MainForm mainForm;
        DoctorForm doctorForm;
        PatiantForm patiantForm;
        NusreForm nusreForm;
        VisitsForm1 visitsForm1;
        RoomForm roomForm;
        public RoomForm(Context _context, MainForm _mainForm)
        {
            context = _context;
            InitializeComponent();
            mainForm = _mainForm;
            this.FormClosed += RoomForm_FormClosed;

        }

        public RoomForm(Context _context,DoctorForm _doctorForm)
        {
            context = _context;
            InitializeComponent();
            doctorForm = _doctorForm;
            //this.FormClosed += RoomForm_FormClosed;
        }
        public RoomForm(Context _context, PatiantForm _patiantForm)
        {
            context = _context;
            InitializeComponent();
            patiantForm = _patiantForm;
            //this.FormClosed += RoomForm_FormClosed;
        }
        public RoomForm(Context _context, NusreForm _nusreForm)
        {
            context = _context;
            InitializeComponent();
            nusreForm = _nusreForm;
            //this.FormClosed += RoomForm_FormClosed;
        }
        public RoomForm(Context _context, VisitsForm1 _visitsForm1)
        {
            context = _context;
            InitializeComponent();
            visitsForm1 = _visitsForm1;
            //this.FormClosed += RoomForm_FormClosed;
        }

        private void Doctor_Click(object sender, EventArgs e)
        {
            doctorForm = new DoctorForm(this.context, this);
            doctorForm.Show();
            this.Visible = false;
        }
        private void RoomForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void Room_Back_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Hide();
        }

        private void Room_Visits_Click(object sender, EventArgs e)
        {
            visitsForm1 = new VisitsForm1(this.context, this);
            visitsForm1.Show();
            this.Visible = false;
        }

        private void Room_patient_Click(object sender, EventArgs e)
        {

            patiantForm = new PatiantForm(this.context, this);
            patiantForm.Show();
            this.Visible = false;
        }
    }
}
