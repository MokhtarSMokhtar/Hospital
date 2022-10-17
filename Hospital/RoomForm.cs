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
using Hospital.Classes;

namespace Hospital
{
    public partial class RoomForm : Form
    {
        Context context;
        MainForm mainForm;
        DoctorForm doctorForm;
        PatiantForm patiantForm;
        NusreForm nurseForm;
        VisitsForm1 visitsForm1;
       // RoomForm roomForm;
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
        public RoomForm(Context _context, NusreForm _nurseForm)
        {
            context = _context;
            InitializeComponent();
             nurseForm= _nurseForm;
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

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }

        private void AddRoombtn_Click(object sender, EventArgs e)
        {
            try
            {
                var NurseRoomMangerID = Convert.ToInt32(MngrIDtxt.Text);
                var room = new Room
                {
                    ID = Convert.ToInt32(this.RID.Text),
                    Name = this.RoomNurse.Text,
                    NumberOfBeds = Convert.ToInt32(this.numberofbed.Text),
                    Type = this.roomtype.Text,
                    Manager = context.Nurses.Where(n => n.ID == NurseRoomMangerID).FirstOrDefault()
                };
                room.Manager.RoomManageId = room.ID;
                room.Manager.RoomId = room.ID;
                context.Rooms.Add(room);
                context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void UpdateRoombtn_Click(object sender, EventArgs e)
        {
            int roomId = Convert.ToInt32(this.RID.Text);
            var room = context.Rooms.Where(r => r.ID == roomId).FirstOrDefault();
            try
            {
                room.ID = Convert.ToInt32(this.RID.Text);
                room.Name = this.RoomNurse.Text;
                room.NumberOfBeds = Convert.ToInt32(this.numberofbed.Text);
                room.Type = this.roomtype.Text;

                room.Manager = context.Nurses.Where(n => n.ID == Convert.ToInt32(MngrIDtxt.Text)).FirstOrDefault();

                room.Manager.RoomManageId = room.ID;
                room.Manager.RoomId = room.ID;

                context.SaveChanges();
            }
            catch (Exception updateExc)
            {
                MessageBox.Show(updateExc.Message);
            }
        }

        private void DeleteRoombtn_Click(object sender, EventArgs e)
        {
            int roomId = Convert.ToInt32(this.RID.Text);
            var room = context.Rooms.Where(r => r.ID == roomId).FirstOrDefault();
            try
            {
                context.Rooms.Remove(room);
                context.SaveChanges();
            }
            catch (Exception updateExc)
            {
                MessageBox.Show(updateExc.Message);
            }
        }
        private void RoomPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
