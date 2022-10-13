using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Classes;
using Hospital.Data;
namespace Hospital
{
    public partial class DoctorForm : Form
    {
        Context context;
        MainForm mainForm;
        RoomForm roomForm;
        PatiantForm patiantForm;
        VisitsForm1 visitsForm1;

        
 
        public DoctorForm( Context _context, MainForm _mainForm)
        {
            context = _context;
            InitializeComponent();
            this.mainForm = _mainForm;
            this.FormClosed += showMain;
            var dEP = context.Departments.ToArray();
            DoctorDeptCompo.DataSource = dEP;
            DoctorDeptCompo.DisplayMember = "Name";
            DoctorDeptCompo.ValueMember = "ID";

        }

        public DoctorForm(Context _context, PatiantForm _patiantForm)
        {
            context = _context;
            InitializeComponent();
            this.patiantForm = _patiantForm;
            this.FormClosed += showMain;

        }

        public DoctorForm(Context _context, RoomForm _roomForm)
        {
            context = _context;
            InitializeComponent();
            this.roomForm = _roomForm;
            this.FormClosed += showMain;

        }

        public DoctorForm(Context _context, VisitsForm1 _visitsForm1)
        {
            context = _context;
            InitializeComponent();
            this.visitsForm1 = _visitsForm1;
            this.FormClosed += showMain;

        }


        private void AddDoctorbtn_Click(object sender, EventArgs e)
        {
            var doctor = new Doctor
            {
                ID = Convert.ToInt32(this.DoctorIDText.Text),
                Name = this.DoctorNameText.Text,
                Phone = Convert.ToInt32(this.DoctorPhoneText.Text),
                Address = this.DoctorAddressText.Text,
                Age = Convert.ToInt32(this.DoctorAgetext.Text),
                Spacial = this.DoctorSpicia.Text,
                gender = this.Malechek.Checked ? Gender.Male : Gender.Female,
                WorkDepartment = (Department)DoctorDeptCompo.SelectedItem

            };
         
            context.Doctors.Add(doctor);
            context.SaveChanges();

        }
        private void showMain(object sender, EventArgs e)
        {
            mainForm.Visible = true;
        }

        private void FromDoctorToMain_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;

            this.Hide();
 
        }

        private void DoctorForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            roomForm.Visible = true;
            this.Hide();
        }

        private void FromDoctorToRoom_Click1(object sender, System.EventArgs e)
        {
            roomForm = new RoomForm(this.context, this);
            roomForm.Show();
            this.Visible = false;

        }

        private void FromDoctorToVisite_Click(object sender, EventArgs e)
        {
            visitsForm1 = new VisitsForm1(this.context, this);
            visitsForm1.Show();
            this.Visible = false;
        }

        private void FromDoctorToPAtiant_Click(object sender, EventArgs e)
        {
            patiantForm = new PatiantForm(this.context, this);
            patiantForm.Show();
            this.Visible = false;
        }
    }
}
