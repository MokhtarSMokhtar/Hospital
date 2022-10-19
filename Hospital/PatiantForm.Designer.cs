namespace Hospital
{
    partial class PatiantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatiantForm));
            this.patients = new System.Windows.Forms.Label();
            this.p_id = new System.Windows.Forms.TextBox();
            this.p_name = new System.Windows.Forms.TextBox();
            this.p_address = new System.Windows.Forms.TextBox();
            this.p_phone = new System.Windows.Forms.TextBox();
            this.p_age = new System.Windows.Forms.TextBox();
            this.p_case = new System.Windows.Forms.TextBox();
            this.PID = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.Label();
            this.PAddress = new System.Windows.Forms.Label();
            this.PPhone = new System.Windows.Forms.Label();
            this.PAge = new System.Windows.Forms.Label();
            this.PCase = new System.Windows.Forms.Label();
            this.PGender = new System.Windows.Forms.Label();
            this.Patient_Doctor = new System.Windows.Forms.Button();
            this.patient_Room = new System.Windows.Forms.Button();
            this.Patient_Visits = new System.Windows.Forms.Button();
            this.Patient_Back = new System.Windows.Forms.Button();
            this.PatientMale = new System.Windows.Forms.CheckBox();
            this.PatientFemale = new System.Windows.Forms.CheckBox();
            this.PatientAddBtn = new System.Windows.Forms.Button();
            this.PatientUpdateBtn = new System.Windows.Forms.Button();
            this.PatientDeleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NurseCombo = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PmChecked = new System.Windows.Forms.CheckBox();
            this.AmChecked = new System.Windows.Forms.CheckBox();
            this.DrageTextBox = new System.Windows.Forms.TextBox();
            this.comfirmbtn = new System.Windows.Forms.Button();
            this.deptRoomCombo = new System.Windows.Forms.ComboBox();
            this.Roomcombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patients
            // 
            this.patients.AutoSize = true;
            this.patients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.patients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patients.Location = new System.Drawing.Point(33, 9);
            this.patients.Name = "patients";
            this.patients.Size = new System.Drawing.Size(83, 24);
            this.patients.TabIndex = 0;
            this.patients.Text = "Patients";
            this.patients.Click += new System.EventHandler(this.label1_Click);
            // 
            // p_id
            // 
            this.p_id.Location = new System.Drawing.Point(165, 55);
            this.p_id.Name = "p_id";
            this.p_id.Size = new System.Drawing.Size(114, 20);
            this.p_id.TabIndex = 1;
            this.p_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // p_name
            // 
            this.p_name.Location = new System.Drawing.Point(165, 89);
            this.p_name.Name = "p_name";
            this.p_name.Size = new System.Drawing.Size(114, 20);
            this.p_name.TabIndex = 2;
            // 
            // p_address
            // 
            this.p_address.Location = new System.Drawing.Point(165, 125);
            this.p_address.Name = "p_address";
            this.p_address.Size = new System.Drawing.Size(114, 20);
            this.p_address.TabIndex = 3;
            // 
            // p_phone
            // 
            this.p_phone.Location = new System.Drawing.Point(165, 164);
            this.p_phone.Name = "p_phone";
            this.p_phone.Size = new System.Drawing.Size(114, 20);
            this.p_phone.TabIndex = 4;
            // 
            // p_age
            // 
            this.p_age.Location = new System.Drawing.Point(165, 190);
            this.p_age.Name = "p_age";
            this.p_age.Size = new System.Drawing.Size(114, 20);
            this.p_age.TabIndex = 5;
            // 
            // p_case
            // 
            this.p_case.Location = new System.Drawing.Point(165, 215);
            this.p_case.Name = "p_case";
            this.p_case.Size = new System.Drawing.Size(114, 20);
            this.p_case.TabIndex = 6;
            // 
            // PID
            // 
            this.PID.AutoSize = true;
            this.PID.Location = new System.Drawing.Point(77, 62);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(18, 13);
            this.PID.TabIndex = 8;
            this.PID.Text = "ID";
            this.PID.Click += new System.EventHandler(this.ID_Click);
            // 
            // PName
            // 
            this.PName.AutoSize = true;
            this.PName.Location = new System.Drawing.Point(68, 96);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(35, 13);
            this.PName.TabIndex = 9;
            this.PName.Text = "Name";
            this.PName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PAddress
            // 
            this.PAddress.AutoSize = true;
            this.PAddress.Location = new System.Drawing.Point(68, 132);
            this.PAddress.Name = "PAddress";
            this.PAddress.Size = new System.Drawing.Size(45, 13);
            this.PAddress.TabIndex = 10;
            this.PAddress.Text = "Address";
            // 
            // PPhone
            // 
            this.PPhone.AutoSize = true;
            this.PPhone.Location = new System.Drawing.Point(71, 170);
            this.PPhone.Name = "PPhone";
            this.PPhone.Size = new System.Drawing.Size(38, 13);
            this.PPhone.TabIndex = 11;
            this.PPhone.Text = "Phone";
            // 
            // PAge
            // 
            this.PAge.AutoSize = true;
            this.PAge.Location = new System.Drawing.Point(76, 197);
            this.PAge.Name = "PAge";
            this.PAge.Size = new System.Drawing.Size(26, 13);
            this.PAge.TabIndex = 12;
            this.PAge.Text = "Age";
            // 
            // PCase
            // 
            this.PCase.AutoSize = true;
            this.PCase.Location = new System.Drawing.Point(71, 224);
            this.PCase.Name = "PCase";
            this.PCase.Size = new System.Drawing.Size(31, 13);
            this.PCase.TabIndex = 13;
            this.PCase.Text = "Case";
            // 
            // PGender
            // 
            this.PGender.AutoSize = true;
            this.PGender.Location = new System.Drawing.Point(68, 329);
            this.PGender.Name = "PGender";
            this.PGender.Size = new System.Drawing.Size(42, 13);
            this.PGender.TabIndex = 14;
            this.PGender.Text = "Gender";
            // 
            // Patient_Doctor
            // 
            this.Patient_Doctor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Patient_Doctor.Location = new System.Drawing.Point(481, 55);
            this.Patient_Doctor.Name = "Patient_Doctor";
            this.Patient_Doctor.Size = new System.Drawing.Size(94, 35);
            this.Patient_Doctor.TabIndex = 15;
            this.Patient_Doctor.Text = "Doctor";
            this.Patient_Doctor.UseVisualStyleBackColor = false;
            this.Patient_Doctor.Click += new System.EventHandler(this.Doctor_Click);
            // 
            // patient_Room
            // 
            this.patient_Room.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.patient_Room.Location = new System.Drawing.Point(481, 96);
            this.patient_Room.Name = "patient_Room";
            this.patient_Room.Size = new System.Drawing.Size(94, 41);
            this.patient_Room.TabIndex = 16;
            this.patient_Room.Text = "Room";
            this.patient_Room.UseVisualStyleBackColor = false;
            this.patient_Room.Click += new System.EventHandler(this.patient_Room_Click);
            // 
            // Patient_Visits
            // 
            this.Patient_Visits.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Patient_Visits.Location = new System.Drawing.Point(481, 143);
            this.Patient_Visits.Name = "Patient_Visits";
            this.Patient_Visits.Size = new System.Drawing.Size(94, 41);
            this.Patient_Visits.TabIndex = 17;
            this.Patient_Visits.Text = "Visits";
            this.Patient_Visits.UseVisualStyleBackColor = false;
            this.Patient_Visits.Click += new System.EventHandler(this.Patient_Visits_Click);
            // 
            // Patient_Back
            // 
            this.Patient_Back.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Patient_Back.Location = new System.Drawing.Point(481, 215);
            this.Patient_Back.Name = "Patient_Back";
            this.Patient_Back.Size = new System.Drawing.Size(94, 45);
            this.Patient_Back.TabIndex = 18;
            this.Patient_Back.Text = "Back";
            this.Patient_Back.UseVisualStyleBackColor = false;
            this.Patient_Back.Click += new System.EventHandler(this.Patient_Back_Click);
            // 
            // PatientMale
            // 
            this.PatientMale.AutoSize = true;
            this.PatientMale.Location = new System.Drawing.Point(165, 329);
            this.PatientMale.Name = "PatientMale";
            this.PatientMale.Size = new System.Drawing.Size(49, 17);
            this.PatientMale.TabIndex = 21;
            this.PatientMale.Text = "Male";
            this.PatientMale.UseVisualStyleBackColor = true;
            // 
            // PatientFemale
            // 
            this.PatientFemale.AutoSize = true;
            this.PatientFemale.Location = new System.Drawing.Point(235, 329);
            this.PatientFemale.Name = "PatientFemale";
            this.PatientFemale.Size = new System.Drawing.Size(60, 17);
            this.PatientFemale.TabIndex = 22;
            this.PatientFemale.Text = "Female";
            this.PatientFemale.UseVisualStyleBackColor = true;
            // 
            // PatientAddBtn
            // 
            this.PatientAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientAddBtn.Location = new System.Drawing.Point(235, 352);
            this.PatientAddBtn.Name = "PatientAddBtn";
            this.PatientAddBtn.Size = new System.Drawing.Size(75, 23);
            this.PatientAddBtn.TabIndex = 23;
            this.PatientAddBtn.Text = "Add";
            this.PatientAddBtn.UseVisualStyleBackColor = true;
            this.PatientAddBtn.Click += new System.EventHandler(this.PatientAddBtn_Click);
            // 
            // PatientUpdateBtn
            // 
            this.PatientUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientUpdateBtn.Location = new System.Drawing.Point(405, 352);
            this.PatientUpdateBtn.Name = "PatientUpdateBtn";
            this.PatientUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.PatientUpdateBtn.TabIndex = 24;
            this.PatientUpdateBtn.Text = "Update";
            this.PatientUpdateBtn.UseVisualStyleBackColor = true;
            this.PatientUpdateBtn.Click += new System.EventHandler(this.PatientUpdateBtn_Click);
            // 
            // PatientDeleteBtn
            // 
            this.PatientDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDeleteBtn.Location = new System.Drawing.Point(500, 352);
            this.PatientDeleteBtn.Name = "PatientDeleteBtn";
            this.PatientDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.PatientDeleteBtn.TabIndex = 25;
            this.PatientDeleteBtn.Text = "Delete";
            this.PatientDeleteBtn.UseVisualStyleBackColor = true;
            this.PatientDeleteBtn.Click += new System.EventHandler(this.PatientDeleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NurseCombo);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.PmChecked);
            this.panel1.Controls.Add(this.AmChecked);
            this.panel1.Controls.Add(this.DrageTextBox);
            this.panel1.Controls.Add(this.comfirmbtn);
            this.panel1.Location = new System.Drawing.Point(3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 396);
            this.panel1.TabIndex = 26;
            // 
            // NurseCombo
            // 
            this.NurseCombo.FormattingEnabled = true;
            this.NurseCombo.Location = new System.Drawing.Point(165, 82);
            this.NurseCombo.Name = "NurseCombo";
            this.NurseCombo.Size = new System.Drawing.Size(130, 21);
            this.NurseCombo.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(165, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // PmChecked
            // 
            this.PmChecked.AutoSize = true;
            this.PmChecked.Location = new System.Drawing.Point(317, 59);
            this.PmChecked.Name = "PmChecked";
            this.PmChecked.Size = new System.Drawing.Size(41, 17);
            this.PmChecked.TabIndex = 4;
            this.PmChecked.Text = "Pm";
            this.PmChecked.UseVisualStyleBackColor = true;
            this.PmChecked.CheckedChanged += new System.EventHandler(this.PmChecked_CheckedChanged);
            // 
            // AmChecked
            // 
            this.AmChecked.AutoSize = true;
            this.AmChecked.Location = new System.Drawing.Point(367, 59);
            this.AmChecked.Name = "AmChecked";
            this.AmChecked.Size = new System.Drawing.Size(41, 17);
            this.AmChecked.TabIndex = 3;
            this.AmChecked.Text = "Am";
            this.AmChecked.UseVisualStyleBackColor = true;
            this.AmChecked.CursorChanged += new System.EventHandler(this.PmChecked_CheckedChanged);
            // 
            // DrageTextBox
            // 
            this.DrageTextBox.Location = new System.Drawing.Point(165, 30);
            this.DrageTextBox.Name = "DrageTextBox";
            this.DrageTextBox.Size = new System.Drawing.Size(130, 20);
            this.DrageTextBox.TabIndex = 2;
            // 
            // comfirmbtn
            // 
            this.comfirmbtn.Location = new System.Drawing.Point(174, 152);
            this.comfirmbtn.Name = "comfirmbtn";
            this.comfirmbtn.Size = new System.Drawing.Size(75, 23);
            this.comfirmbtn.TabIndex = 1;
            this.comfirmbtn.Text = "Confirm";
            this.comfirmbtn.UseVisualStyleBackColor = true;
            this.comfirmbtn.Click += new System.EventHandler(this.comfirmbtn_Click);
            // 
            // deptRoomCombo
            // 
            this.deptRoomCombo.FormattingEnabled = true;
            this.deptRoomCombo.Location = new System.Drawing.Point(165, 252);
            this.deptRoomCombo.Name = "deptRoomCombo";
            this.deptRoomCombo.Size = new System.Drawing.Size(121, 21);
            this.deptRoomCombo.TabIndex = 27;
            this.deptRoomCombo.SelectedIndexChanged += new System.EventHandler(this.deptRoomCombo_SelectedIndexChanged);
            // 
            // Roomcombo
            // 
            this.Roomcombo.FormattingEnabled = true;
            this.Roomcombo.Location = new System.Drawing.Point(165, 292);
            this.Roomcombo.Name = "Roomcombo";
            this.Roomcombo.Size = new System.Drawing.Size(121, 21);
            this.Roomcombo.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Room";
            // 
            // PatiantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Roomcombo);
            this.Controls.Add(this.deptRoomCombo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PatientDeleteBtn);
            this.Controls.Add(this.PatientUpdateBtn);
            this.Controls.Add(this.PatientAddBtn);
            this.Controls.Add(this.PatientFemale);
            this.Controls.Add(this.PatientMale);
            this.Controls.Add(this.Patient_Back);
            this.Controls.Add(this.Patient_Visits);
            this.Controls.Add(this.patient_Room);
            this.Controls.Add(this.Patient_Doctor);
            this.Controls.Add(this.PGender);
            this.Controls.Add(this.PCase);
            this.Controls.Add(this.PAge);
            this.Controls.Add(this.PPhone);
            this.Controls.Add(this.PAddress);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.PID);
            this.Controls.Add(this.p_case);
            this.Controls.Add(this.p_age);
            this.Controls.Add(this.p_phone);
            this.Controls.Add(this.p_address);
            this.Controls.Add(this.p_name);
            this.Controls.Add(this.p_id);
            this.Controls.Add(this.patients);
            this.DoubleBuffered = true;
            this.Name = "PatiantForm";
            this.Text = "Patiant";
            this.Load += new System.EventHandler(this.Patiant_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

   





        #endregion

        private System.Windows.Forms.Label patients;
        private System.Windows.Forms.TextBox p_id;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.TextBox p_address;
        private System.Windows.Forms.TextBox p_phone;
        private System.Windows.Forms.TextBox p_age;
        private System.Windows.Forms.TextBox p_case;
        private System.Windows.Forms.Label PID;
        private System.Windows.Forms.Label PName;
        private System.Windows.Forms.Label PAddress;
        private System.Windows.Forms.Label PPhone;
        private System.Windows.Forms.Label PAge;
        private System.Windows.Forms.Label PCase;
        private System.Windows.Forms.Label PGender;
        private System.Windows.Forms.Button Patient_Doctor;
        private System.Windows.Forms.Button patient_Room;
        private System.Windows.Forms.Button Patient_Visits;
        private System.Windows.Forms.Button Patient_Back;
        private System.Windows.Forms.CheckBox PatientMale;
        private System.Windows.Forms.CheckBox PatientFemale;
        private System.Windows.Forms.Button PatientAddBtn;
        private System.Windows.Forms.Button PatientUpdateBtn;
        private System.Windows.Forms.Button PatientDeleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox PmChecked;
        private System.Windows.Forms.CheckBox AmChecked;
        private System.Windows.Forms.TextBox DrageTextBox;
        private System.Windows.Forms.Button comfirmbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox NurseCombo;
        private System.Windows.Forms.ComboBox deptRoomCombo;
        private System.Windows.Forms.ComboBox Roomcombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}