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

        }

        private void AddDoctorbtn_Click(object sender, EventArgs e)
        {


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
