using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Classes;
using Hospital;
using Hospital.Classes;

namespace Hospital
{
    public partial class NusreForm : Form
    {
        Context context;
        MainForm mainForm;
        RoomForm roomForm;
        PatiantForm patiantForm;
        public NusreForm(Context _context, MainForm _mainForm)
        {
            context = _context;
            InitializeComponent();
            mainForm = _mainForm;
            this.FormClosed += NusreForm_FormClosed;
    

        }

        private void Nusre_Load(object sender, EventArgs e)
        {

            var dEP = context.Departments.ToList();
            NurseDeptCompo.DataSource = dEP;
            NurseDeptCompo.DisplayMember = "Name";
            NurseDeptCompo.ValueMember = "ID";



        }

        private void Doctor_Click(object sender, EventArgs e)
        {

        }

        private void Nurse_Room_Click(object sender, EventArgs e)
        {
            roomForm = new RoomForm(this.context, this);
            roomForm.Show();
            this.Visible = false;
        }

        private void Nurse_Back_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
            this.Hide();

        }
        private void NusreForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void Nurse_patient_Click(object sender, EventArgs e)
        {
            patiantForm = new PatiantForm(this.context, this);
            patiantForm.Show();
            this.Visible = false;
        }


        private void NurseAddBtn_Click(object sender, EventArgs e)
        {
            var nurse = new Nurse
            {
                ID = Convert.ToInt32(this.n_id.Text),
                Name = this.n_name.Text,
                Address = this.n_address.Text,
                Age = Convert.ToInt32(this.n_age.Text),
                Phone = Convert.ToInt32(this.n_phone.Text),
                gender = this.NurseMale.Checked ? Gender.Male : Gender.Female,
                Room = (Room)ComboRoom.SelectedItem,
                shift = this.AmChecked.Checked ? Shift.Am : Shift.Pm,
            };

            context.Nurses.Add(nurse);
            context.SaveChanges();
        }

        private void NurseUpdateBtn_Click(object sender, EventArgs e)
        {
            int nurseid = Convert.ToInt32(this.n_id.Text);
            var nurse = context.Nurses.Where(d => d.ID == nurseid).FirstOrDefault();


            try
            {
                nurse.ID = Convert.ToInt32(this.n_id.Text);
                nurse.Name = this.n_name.Text;
                nurse.Address = this.n_address.Text;
                nurse.Age = Convert.ToInt32(this.n_age.Text);
                nurse.Phone = Convert.ToInt32(this.n_phone.Text);
                nurse.gender = this.NurseMale.Checked ? Gender.Male : Gender.Female;
                nurse.Room = (Room)ComboRoom.SelectedItem;
                nurse.RoomId = nurse.Room.ID;
                nurse.medicineTimes = (ICollection<DrageTime>)(DrageTime)DargelistCom.SelectedItem;
                context.SaveChanges();
                nurse.RoomId = nurse.Room.ID;
            }
            catch (Exception updateExc)
            {
                MessageBox.Show(updateExc.Message);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int nurseid = Convert.ToInt32(this.n_id.Text);
            var nurse = context.Nurses.Where(d => d.ID == nurseid).FirstOrDefault();
            try
            {
                context.Nurses.Remove(nurse);
                context.SaveChanges();
            }
            catch (Exception updateExc)
            {
                MessageBox.Show(updateExc.Message);
            }
        }

        private void NurseDeptCompo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dEP =(Department) NurseDeptCompo.SelectedItem;
                this.ComboRoom.Items.Clear();
                var Rooms = context.Rooms.Where(d => d.Department.ID == dEP.ID).Select(r =>r).ToList();
                foreach (var room in Rooms)
                {
             
                    this.ComboRoom.Items.Add(room);

                }
            
        }

        private void DargelistCom_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            var Drage1 = new DrageTime
            {
                DrageName = this.DargelistCom.Text,
            
            };

            var drage = (DrageTime)DargelistCom.SelectedItem;

            //foreach (var item in drage)
            //{
            //    this.DargelistCom.Items.Add(item);
            //}
        }
    }
}
