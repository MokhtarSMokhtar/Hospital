namespace Hospital
{
    partial class DepartmentForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentForm1));
            this.Deptpanal = new System.Windows.Forms.Panel();
            this.ViewPanal = new System.Windows.Forms.Panel();
            this.radioButtonNurse = new System.Windows.Forms.RadioButton();
            this.radioButtonDoctor = new System.Windows.Forms.RadioButton();
            this.Backbtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeptInfoCompo = new System.Windows.Forms.ComboBox();
            this.ViewDeptbtn = new System.Windows.Forms.Button();
            this.DeleteDeptBtn = new System.Windows.Forms.Button();
            this.UpdateDeptBtn = new System.Windows.Forms.Button();
            this.AddDeptbtn = new System.Windows.Forms.Button();
            this.DeptIdTextbox = new System.Windows.Forms.TextBox();
            this.DeptManagerTextbox = new System.Windows.Forms.TextBox();
            this.DeptNameTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label1name = new System.Windows.Forms.Label();
            this.Deptlable = new System.Windows.Forms.Label();
            this.Deptpanal.SuspendLayout();
            this.ViewPanal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Deptpanal
            // 
            this.Deptpanal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Deptpanal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Deptpanal.BackgroundImage")));
            this.Deptpanal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Deptpanal.Controls.Add(this.ViewPanal);
            this.Deptpanal.Controls.Add(this.ViewDeptbtn);
            this.Deptpanal.Controls.Add(this.DeleteDeptBtn);
            this.Deptpanal.Controls.Add(this.UpdateDeptBtn);
            this.Deptpanal.Controls.Add(this.AddDeptbtn);
            this.Deptpanal.Controls.Add(this.DeptIdTextbox);
            this.Deptpanal.Controls.Add(this.DeptManagerTextbox);
            this.Deptpanal.Controls.Add(this.DeptNameTextbox);
            this.Deptpanal.Controls.Add(this.label2);
            this.Deptpanal.Controls.Add(this.label1);
            this.Deptpanal.Controls.Add(this.label1name);
            this.Deptpanal.Controls.Add(this.Deptlable);
            this.Deptpanal.Location = new System.Drawing.Point(0, 0);
            this.Deptpanal.Name = "Deptpanal";
            this.Deptpanal.Size = new System.Drawing.Size(799, 448);
            this.Deptpanal.TabIndex = 0;
            // 
            // ViewPanal
            // 
            this.ViewPanal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewPanal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ViewPanal.Controls.Add(this.radioButtonNurse);
            this.ViewPanal.Controls.Add(this.radioButtonDoctor);
            this.ViewPanal.Controls.Add(this.Backbtn);
            this.ViewPanal.Controls.Add(this.listView1);
            this.ViewPanal.Controls.Add(this.DeptInfoCompo);
            this.ViewPanal.Location = new System.Drawing.Point(0, 3);
            this.ViewPanal.Name = "ViewPanal";
            this.ViewPanal.Size = new System.Drawing.Size(799, 445);
            this.ViewPanal.TabIndex = 12;
            // 
            // radioButtonNurse
            // 
            this.radioButtonNurse.AutoSize = true;
            this.radioButtonNurse.Location = new System.Drawing.Point(129, 130);
            this.radioButtonNurse.Name = "radioButtonNurse";
            this.radioButtonNurse.Size = new System.Drawing.Size(53, 17);
            this.radioButtonNurse.TabIndex = 4;
            this.radioButtonNurse.TabStop = true;
            this.radioButtonNurse.Text = "Nurse";
            this.radioButtonNurse.UseVisualStyleBackColor = true;
            this.radioButtonNurse.CheckedChanged += new System.EventHandler(this.radioButtonDoctor_CheckedChanged);
            // 
            // radioButtonDoctor
            // 
            this.radioButtonDoctor.AutoSize = true;
            this.radioButtonDoctor.Location = new System.Drawing.Point(27, 130);
            this.radioButtonDoctor.Name = "radioButtonDoctor";
            this.radioButtonDoctor.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDoctor.TabIndex = 3;
            this.radioButtonDoctor.TabStop = true;
            this.radioButtonDoctor.Text = "Doctor";
            this.radioButtonDoctor.UseVisualStyleBackColor = true;
            this.radioButtonDoctor.CheckedChanged += new System.EventHandler(this.radioButtonDoctor_CheckedChanged);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Backbtn.Location = new System.Drawing.Point(12, 379);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(75, 37);
            this.Backbtn.TabIndex = 2;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NameValue,
            this.Phone});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(322, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(477, 439);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 117;
            // 
            // NameValue
            // 
            this.NameValue.Text = "Name";
            this.NameValue.Width = 206;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 342;
            // 
            // DeptInfoCompo
            // 
            this.DeptInfoCompo.FormattingEnabled = true;
            this.DeptInfoCompo.Location = new System.Drawing.Point(12, 28);
            this.DeptInfoCompo.Name = "DeptInfoCompo";
            this.DeptInfoCompo.Size = new System.Drawing.Size(152, 21);
            this.DeptInfoCompo.TabIndex = 0;
            this.DeptInfoCompo.SelectedIndexChanged += new System.EventHandler(this.DeptInfoCompo_SelectedIndexChanged);
            // 
            // ViewDeptbtn
            // 
            this.ViewDeptbtn.Location = new System.Drawing.Point(27, 350);
            this.ViewDeptbtn.Name = "ViewDeptbtn";
            this.ViewDeptbtn.Size = new System.Drawing.Size(117, 23);
            this.ViewDeptbtn.TabIndex = 11;
            this.ViewDeptbtn.Text = "View";
            this.ViewDeptbtn.UseVisualStyleBackColor = true;
            this.ViewDeptbtn.Click += new System.EventHandler(this.ViewDeptbtn_Click);
            // 
            // DeleteDeptBtn
            // 
            this.DeleteDeptBtn.Location = new System.Drawing.Point(486, 350);
            this.DeleteDeptBtn.Name = "DeleteDeptBtn";
            this.DeleteDeptBtn.Size = new System.Drawing.Size(117, 23);
            this.DeleteDeptBtn.TabIndex = 10;
            this.DeleteDeptBtn.Text = "Delete Department";
            this.DeleteDeptBtn.UseVisualStyleBackColor = true;
            this.DeleteDeptBtn.Click += new System.EventHandler(this.DeleteDeptBtn_Click);
            // 
            // UpdateDeptBtn
            // 
            this.UpdateDeptBtn.Location = new System.Drawing.Point(332, 350);
            this.UpdateDeptBtn.Name = "UpdateDeptBtn";
            this.UpdateDeptBtn.Size = new System.Drawing.Size(117, 23);
            this.UpdateDeptBtn.TabIndex = 9;
            this.UpdateDeptBtn.Text = "Update Department";
            this.UpdateDeptBtn.UseVisualStyleBackColor = true;
            this.UpdateDeptBtn.Click += new System.EventHandler(this.UpdateDeptBtn_Click);
            // 
            // AddDeptbtn
            // 
            this.AddDeptbtn.Location = new System.Drawing.Point(180, 350);
            this.AddDeptbtn.Name = "AddDeptbtn";
            this.AddDeptbtn.Size = new System.Drawing.Size(117, 23);
            this.AddDeptbtn.TabIndex = 8;
            this.AddDeptbtn.Text = "Add Department";
            this.AddDeptbtn.UseVisualStyleBackColor = true;
            this.AddDeptbtn.Click += new System.EventHandler(this.AddDeptbtn_Click);
            // 
            // DeptIdTextbox
            // 
            this.DeptIdTextbox.Location = new System.Drawing.Point(260, 165);
            this.DeptIdTextbox.Name = "DeptIdTextbox";
            this.DeptIdTextbox.Size = new System.Drawing.Size(138, 20);
            this.DeptIdTextbox.TabIndex = 6;
            // 
            // DeptManagerTextbox
            // 
            this.DeptManagerTextbox.Location = new System.Drawing.Point(260, 239);
            this.DeptManagerTextbox.Name = "DeptManagerTextbox";
            this.DeptManagerTextbox.Size = new System.Drawing.Size(138, 20);
            this.DeptManagerTextbox.TabIndex = 5;
            // 
            // DeptNameTextbox
            // 
            this.DeptNameTextbox.Location = new System.Drawing.Point(260, 73);
            this.DeptNameTextbox.Name = "DeptNameTextbox";
            this.DeptNameTextbox.Size = new System.Drawing.Size(138, 20);
            this.DeptNameTextbox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Department ID";
            // 
            // label1name
            // 
            this.label1name.AutoSize = true;
            this.label1name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1name.Location = new System.Drawing.Point(23, 74);
            this.label1name.Name = "label1name";
            this.label1name.Size = new System.Drawing.Size(159, 19);
            this.label1name.TabIndex = 1;
            this.label1name.Text = "Department Name";
            // 
            // Deptlable
            // 
            this.Deptlable.AutoSize = true;
            this.Deptlable.Dock = System.Windows.Forms.DockStyle.Left;
            this.Deptlable.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deptlable.Location = new System.Drawing.Point(0, 0);
            this.Deptlable.Name = "Deptlable";
            this.Deptlable.Size = new System.Drawing.Size(149, 25);
            this.Deptlable.TabIndex = 0;
            this.Deptlable.Text = "Departments";
            // 
            // DepartmentForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Deptpanal);
            this.Name = "DepartmentForm1";
            this.Text = "DepartmentForm";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.Deptpanal.ResumeLayout(false);
            this.Deptpanal.PerformLayout();
            this.ViewPanal.ResumeLayout(false);
            this.ViewPanal.PerformLayout();
            this.ResumeLayout(false);

        }

      



        #endregion

        private System.Windows.Forms.Panel Deptpanal;
        private System.Windows.Forms.TextBox DeptIdTextbox;
        private System.Windows.Forms.TextBox DeptManagerTextbox;
        private System.Windows.Forms.TextBox DeptNameTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label1name;
        private System.Windows.Forms.Label Deptlable;
        private System.Windows.Forms.Panel ViewPanal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NameValue;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ComboBox DeptInfoCompo;
        private System.Windows.Forms.Button ViewDeptbtn;
        private System.Windows.Forms.Button DeleteDeptBtn;
        private System.Windows.Forms.Button UpdateDeptBtn;
        private System.Windows.Forms.Button AddDeptbtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.RadioButton radioButtonNurse;
        private System.Windows.Forms.RadioButton radioButtonDoctor;
    }
}