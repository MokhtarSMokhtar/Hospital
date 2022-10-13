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
    }
}
