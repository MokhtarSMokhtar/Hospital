﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Classes;
using Hospital;
using Hospital.Classes;

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
        private void VisitsForm1_Load(object sender, EventArgs e)
        {
            var room = context.Rooms;
            this.RoomIDComp.DisplayMember = "Name";
            this.RoomIDComp.ValueMember = "ID";
            foreach (var item in room)
            {
                RoomIDComp.Items.Add(item);
            }

           


        }
        private void VisitorADDbtn_Click(object sender, EventArgs e)
        {
            var patient = PatientIDComp.SelectedItem as Patient;

            var visits = new Visits
            {
                Name = this.VisitorNameText.Text,
                ID = Convert.ToInt32(this.VisitorIDText.Text),
                Phone = Convert.ToInt32(this.VisitorPhoneText.Text),
                gender = this.VisitorMale.Checked ? Gender.Male : Gender.Female,
                
            };

            var ptientvisitors = new PatientVisitors
            {
                Patient = patient,
                Visits = visits,
                Date = DateTime.Now,
            };
            visits.Patients = new List<PatientVisitors>()
            {
                ptientvisitors,
            };

            context.Visits.Add(visits);
            context.SaveChanges();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VisitorUpdatebtn_Click(object sender, EventArgs e)
        {
           // var patient = PatientIDComp.SelectedItem as Patient;

            int visitorid = Convert.ToInt32(this.VisitorIDText.Text);
            var visitor = context.Visits.Where(d => d.ID == visitorid).FirstOrDefault();
            try
            {
                visitor.Name = this.VisitorNameText.Text;
                visitor.ID = Convert.ToInt32(this.VisitorIDText.Text);
                visitor.Phone = Convert.ToInt32(this.VisitorPhoneText.Text);
                visitor.gender = this.VisitorMale.Checked ? Gender.Male : Gender.Female;

                context.SaveChanges();

                //    var ptientvisitors = new PatientVisitors
                //    {
                //        Patient = patient,
                //        Visits = visitorid,
                //    };
                //    visits.Patients = new List<PatientVisitors>()
                //{
                //    ptientvisitors,
                //};

                //context.Visits.Add(visits);

            }
            catch (Exception updateExc)
            {
                MessageBox.Show(updateExc.Message);
            }

        }

    
        private void Visitordeletebtn_Click(object sender, EventArgs e)
        {
            int visitorid = Convert.ToInt32(this.VisitorIDText.Text);
            var visitor = context.Doctors.Where(d => d.ID == visitorid).AsNoTracking().FirstOrDefault();

            try
            {
                context.Doctors.Remove(visitor);
                context.SaveChanges();
            }
            catch (Exception updateExc)
            {
                MessageBox.Show(updateExc.Message);
            }
        }

        private void RoomIDComp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var roomss = (Room)RoomIDComp.SelectedItem;
            var patient = context.Patients.Where(p => p.Room.ID == roomss.ID);

            this.PatientIDComp.DisplayMember = "Name";
            this.PatientIDComp.ValueMember = "ID";
            // PatientIDComp.DataSource = patient;

            foreach (var item in patient)
            {
                PatientIDComp.Items.Add(item);
            }
        }

        private void PatientIDComp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VisitorNameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
