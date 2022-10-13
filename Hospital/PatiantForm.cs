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
        DoctorForm doctorForm;
        RoomForm roomForm;
        VisitsForm1 visitsForm1;
        NusreForm NusreForm;
        PatiantForm patiantForm;
        public PatiantForm(Context _context, MainForm _mainForm)
        {
            context = _context;
            InitializeComponent();
            this.mainForm = _mainForm;
            this.FormClosed += PatiantForm_FormClosed1;

        }

        public PatiantForm(Context _context, DoctorForm _doctorForm)
        {
            context = _context;
            InitializeComponent();
            this.doctorForm = _doctorForm;
            this.FormClosed += PatiantForm_FormClosed1;

        }

        public PatiantForm(Context _context, NusreForm _nusreForm)
        {
            context = _context;
            InitializeComponent();
            this.NusreForm = _nusreForm;
            this.FormClosed += PatiantForm_FormClosed1;

        }

        public PatiantForm(Context _context,RoomForm _roomForm)
        {
            context = _context;
            InitializeComponent();
            this.roomForm = _roomForm;
            this.FormClosed += PatiantForm_FormClosed1;

        }

        public PatiantForm(Context _context, VisitsForm1 _visitsForm1)
        {
            context = _context;
            InitializeComponent();
            this.visitsForm1 = _visitsForm1;
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
            doctorForm = new DoctorForm(this.context, this);
            doctorForm.Show();
            this.Visible = false;
        }
        private void PatiantForm_FormClosed1(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void Patient_Back_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Hide();

            //doctorForm.Visible=true;
            //this.Hide();

        }

        private void patient_Room_Click(object sender, EventArgs e)
        {
            roomForm = new RoomForm(this.context, this);
            roomForm.Show();
            this.Visible = false;
        }

        private void Patient_Visits_Click(object sender, EventArgs e)
        {
            visitsForm1 = new VisitsForm1(this.context, this);
            visitsForm1.Show();
            this.Visible = false;
 
            
            
 
        }
    }
}
