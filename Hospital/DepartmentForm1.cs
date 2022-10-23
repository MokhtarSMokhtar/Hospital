using Hospital.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity;

namespace Hospital
{
    public partial class DepartmentForm1 : Form
    {
        MainForm mainForm;
        Context context;
      
        public DepartmentForm1(Context _context,MainForm main )
        {
            this.mainForm = main;   
            context = _context; 
            InitializeComponent();
            this.FormClosed += DepartmentForm1_FormClosed;

        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            this.Deptpanal.Visible = true;
            this.ViewPanal.Visible = false;
            DeptInfoCompo.DisplayMember = "Name";
            DeptInfoCompo.ValueMember = "ID";
            var dEP = context.Departments.ToArray();
            DeptInfoCompo.Items.AddRange(dEP);


        }
        private void DepartmentForm1_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            mainForm.Visible = true;
            
        }

        private void ViewDeptbtn_Click(object sender, EventArgs e)
        {

            this.ViewPanal.Visible = true;

          
            //DeptInfoCompo.DisplayMember = "Name";
            //DeptInfoCompo.ValueMember = "ID";
            //DeptInfoCompo.DataSource = dEP;
         

        }

        private void AddDeptbtn_Click(object sender, EventArgs e)
        {

            
            try
            {
                var DoctorId = Convert.ToInt32(DeptManagerTextbox.Text);
                var Dept = new Department
                {
                    Name = this.DeptNameTextbox.Text,
                    ID = Convert.ToInt32(DeptIdTextbox.Text),
                    Manager = context.Doctors.Where(d => d.ID == DoctorId).FirstOrDefault(),

                };
                Dept.Manager.DepartmentManageId = Dept.ID;
                Dept.Manager.DepartmentWorkId = Dept.ID;
          
                context.Departments.Add(Dept);
                context.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void AddDeptLissToCompo()
        {
            var dept = (Department)DeptInfoCompo.SelectedItem;
           // ListViewItem listView = new ListViewItem();
           
            if (this.radioButtonDoctor.Checked == true)
            {
                listView1.Items.Clear();
                foreach (var item in dept.Doctors)
                {
                    ListViewItem listView = new ListViewItem(item.ID.ToString());
                    listView.SubItems.Add(item.Name);
                    listView.SubItems.Add(item.Phone.ToString());
                    this.listView1.Items.Add(listView);
                }
           
            }
            else if (this.radioButtonNurse.Checked == true)
            {
                listView1.Items.Clear();

                var nurses = context.Rooms.Where(r => r.Department.ID == dept.ID).Select(n => n.Nurses);
                foreach (var item in nurses)
                {
                    foreach (var nurse in item)
                    {
                        ListViewItem listView = new ListViewItem(nurse.ID.ToString());
                        listView.SubItems.Add(nurse.Name);
                        listView.SubItems.Add(nurse.Phone.ToString());
                        this.listView1.Items.Add(listView);

                    }
                }

            }
        }

        private void UpdateDeptBtn_Click(object sender, EventArgs e)
        {
            var DoctorId = Convert.ToInt32(DeptManagerTextbox.Text);
            int departmentid = Convert.ToInt32(this.DeptIdTextbox.Text);
            var department = context.Departments.Where(d=> d.ID == departmentid).FirstOrDefault();
            try
            {
                department.ID = Convert.ToInt32(this.DeptIdTextbox.Text);
                department.Name = this.DeptNameTextbox.Text;
                department.Manager = context.Doctors.Where(d => d.ID == DoctorId).FirstOrDefault();
                department.Manager.DepartmentManageId = department.ID;
                department.Manager.DepartmentWorkId = department.ID;
                 

                context.SaveChanges();

            }
            catch (Exception updateExc)
            {
                MessageBox.Show(updateExc.Message);
            }

        }

        private void DeleteDeptBtn_Click(object sender, EventArgs e)
        {
            int departmentid = Convert.ToInt32(this.DeptIdTextbox.Text);
            var department = context.Doctors.Where(d => d.ID == departmentid).AsNoTracking().FirstOrDefault();
            try
            {
                context.Doctors.Remove(department);
                context.SaveChanges();
            }
            catch (Exception updateExc)
            {
                MessageBox.Show(updateExc.Message);
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.ViewPanal.Visible = false;
        }

        private void radioButtonDoctor_CheckedChanged(object sender, EventArgs e)
        {
            AddDeptLissToCompo();
        }

        private void DeptInfoCompo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
