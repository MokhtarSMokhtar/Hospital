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

        private void FromDoctorToRoom_Click(object sender, EventArgs e)
        {
           
        }
    }
}
