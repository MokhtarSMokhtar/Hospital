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
        public RoomForm(Context _context, MainForm _mainForm)
        {
            context = _context;
            InitializeComponent();
            mainForm = _mainForm;
            this.FormClosed += RoomForm_FormClosed;

        }

        private void Doctor_Click(object sender, EventArgs e)
        {

        }
        private void RoomForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainForm.Visible = true;
        }

        private void Room_Back_Click(object sender, EventArgs e)
        {
            mainForm.Visible = true;
        }
    }
}
