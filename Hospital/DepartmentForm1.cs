using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class DepartmentForm1 : Form
    {
        MainForm mainForm;
        public DepartmentForm1(MainForm main)
        {
            this.mainForm = main;   
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            //this.Deptpanal.Visible = true;
            //this.ViewPanal.Visible = false;
        }
        private void DepartmentForm1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainForm.Visible = true;
            
        }

        private void ViewDeptbtn_Click(object sender, EventArgs e)
        {

            this.ViewPanal.Visible = true;
            this.Deptpanal.Visible = false;
        }

        private void AddDeptbtn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDeptBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteDeptBtn_Click(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.ViewPanal.Visible = false;
            this.Deptpanal.Visible = true;
        }
    }
}
