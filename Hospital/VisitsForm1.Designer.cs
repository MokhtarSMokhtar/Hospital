namespace Hospital
{
    partial class VisitsForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitsForm1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.RoomID = new System.Windows.Forms.Label();
            this.RoomIDComp = new System.Windows.Forms.ComboBox();
            this.PatientIDComp = new System.Windows.Forms.ComboBox();
            this.VisitorFemale = new System.Windows.Forms.CheckBox();
            this.VisitorMale = new System.Windows.Forms.CheckBox();
            this.roomBtn = new System.Windows.Forms.Button();
            this.Doctorbtn = new System.Windows.Forms.Button();
            this.Patientbtn = new System.Windows.Forms.Button();
            this.MainBtn = new System.Windows.Forms.Button();
            this.Visitor = new System.Windows.Forms.Label();
            this.Visitordeletebtn = new System.Windows.Forms.Button();
            this.VisitorADDbtn = new System.Windows.Forms.Button();
            this.VisitorUpdatebtn = new System.Windows.Forms.Button();
            this.VisitorPhoneText = new System.Windows.Forms.TextBox();
            this.VisitorIDText = new System.Windows.Forms.TextBox();
            this.VisitorNameText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Patient_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.RoomID);
            this.panel1.Controls.Add(this.RoomIDComp);
            this.panel1.Controls.Add(this.PatientIDComp);
            this.panel1.Controls.Add(this.VisitorFemale);
            this.panel1.Controls.Add(this.VisitorMale);
            this.panel1.Controls.Add(this.roomBtn);
            this.panel1.Controls.Add(this.Doctorbtn);
            this.panel1.Controls.Add(this.Patientbtn);
            this.panel1.Controls.Add(this.MainBtn);
            this.panel1.Controls.Add(this.Visitor);
            this.panel1.Controls.Add(this.Visitordeletebtn);
            this.panel1.Controls.Add(this.VisitorADDbtn);
            this.panel1.Controls.Add(this.VisitorUpdatebtn);
            this.panel1.Controls.Add(this.VisitorPhoneText);
            this.panel1.Controls.Add(this.VisitorIDText);
            this.panel1.Controls.Add(this.VisitorNameText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Patient_Name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RoomID
            // 
            this.RoomID.AutoSize = true;
            this.RoomID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomID.Location = new System.Drawing.Point(55, 220);
            this.RoomID.Name = "RoomID";
            this.RoomID.Size = new System.Drawing.Size(85, 19);
            this.RoomID.TabIndex = 25;
            this.RoomID.Text = "Room_ID";
            // 
            // RoomIDComp
            // 
            this.RoomIDComp.FormattingEnabled = true;
            this.RoomIDComp.Location = new System.Drawing.Point(199, 222);
            this.RoomIDComp.Name = "RoomIDComp";
            this.RoomIDComp.Size = new System.Drawing.Size(121, 21);
            this.RoomIDComp.TabIndex = 24;
            // 
            // PatientIDComp
            // 
            this.PatientIDComp.FormattingEnabled = true;
            this.PatientIDComp.Location = new System.Drawing.Point(199, 263);
            this.PatientIDComp.Name = "PatientIDComp";
            this.PatientIDComp.Size = new System.Drawing.Size(121, 21);
            this.PatientIDComp.TabIndex = 23;
            // 
            // VisitorFemale
            // 
            this.VisitorFemale.AutoSize = true;
            this.VisitorFemale.Location = new System.Drawing.Point(260, 319);
            this.VisitorFemale.Name = "VisitorFemale";
            this.VisitorFemale.Size = new System.Drawing.Size(60, 17);
            this.VisitorFemale.TabIndex = 22;
            this.VisitorFemale.Text = "Female";
            this.VisitorFemale.UseVisualStyleBackColor = true;
            // 
            // VisitorMale
            // 
            this.VisitorMale.AutoSize = true;
            this.VisitorMale.Location = new System.Drawing.Point(199, 319);
            this.VisitorMale.Name = "VisitorMale";
            this.VisitorMale.Size = new System.Drawing.Size(49, 17);
            this.VisitorMale.TabIndex = 21;
            this.VisitorMale.Text = "Male";
            this.VisitorMale.UseVisualStyleBackColor = true;
            // 
            // roomBtn
            // 
            this.roomBtn.Location = new System.Drawing.Point(493, 189);
            this.roomBtn.Name = "roomBtn";
            this.roomBtn.Size = new System.Drawing.Size(75, 40);
            this.roomBtn.TabIndex = 20;
            this.roomBtn.Text = "Room";
            this.roomBtn.UseVisualStyleBackColor = true;
            this.roomBtn.Click += new System.EventHandler(this.roomBtn_Click);
            // 
            // Doctorbtn
            // 
            this.Doctorbtn.Location = new System.Drawing.Point(493, 83);
            this.Doctorbtn.Name = "Doctorbtn";
            this.Doctorbtn.Size = new System.Drawing.Size(75, 39);
            this.Doctorbtn.TabIndex = 19;
            this.Doctorbtn.Text = "Doctor";
            this.Doctorbtn.UseVisualStyleBackColor = true;
            this.Doctorbtn.Click += new System.EventHandler(this.Doctorbtn_Click);
            // 
            // Patientbtn
            // 
            this.Patientbtn.Location = new System.Drawing.Point(493, 138);
            this.Patientbtn.Name = "Patientbtn";
            this.Patientbtn.Size = new System.Drawing.Size(75, 40);
            this.Patientbtn.TabIndex = 18;
            this.Patientbtn.Text = "Patient";
            this.Patientbtn.UseVisualStyleBackColor = true;
            this.Patientbtn.Click += new System.EventHandler(this.Patientbtn_Click);
            // 
            // MainBtn
            // 
            this.MainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainBtn.Location = new System.Drawing.Point(493, 247);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(75, 37);
            this.MainBtn.TabIndex = 17;
            this.MainBtn.Text = "Back";
            this.MainBtn.UseVisualStyleBackColor = true;
            this.MainBtn.Click += new System.EventHandler(this.MainBtn_Click);
            // 
            // Visitor
            // 
            this.Visitor.AutoSize = true;
            this.Visitor.BackColor = System.Drawing.SystemColors.Control;
            this.Visitor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visitor.Location = new System.Drawing.Point(27, 9);
            this.Visitor.Name = "Visitor";
            this.Visitor.Size = new System.Drawing.Size(62, 19);
            this.Visitor.TabIndex = 16;
            this.Visitor.Text = "Visitor";
            this.Visitor.Click += new System.EventHandler(this.label7_Click);
            // 
            // Visitordeletebtn
            // 
            this.Visitordeletebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Visitordeletebtn.CausesValidation = false;
            this.Visitordeletebtn.Location = new System.Drawing.Point(292, 400);
            this.Visitordeletebtn.Name = "Visitordeletebtn";
            this.Visitordeletebtn.Size = new System.Drawing.Size(75, 27);
            this.Visitordeletebtn.TabIndex = 15;
            this.Visitordeletebtn.Text = "Delete";
            this.Visitordeletebtn.UseVisualStyleBackColor = false;
            // 
            // VisitorADDbtn
            // 
            this.VisitorADDbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VisitorADDbtn.CausesValidation = false;
            this.VisitorADDbtn.Location = new System.Drawing.Point(116, 400);
            this.VisitorADDbtn.Name = "VisitorADDbtn";
            this.VisitorADDbtn.Size = new System.Drawing.Size(78, 27);
            this.VisitorADDbtn.TabIndex = 14;
            this.VisitorADDbtn.Text = "Add";
            this.VisitorADDbtn.UseVisualStyleBackColor = false;
            this.VisitorADDbtn.Click += new System.EventHandler(this.VisitorADDbtn_Click);
            // 
            // VisitorUpdatebtn
            // 
            this.VisitorUpdatebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.VisitorUpdatebtn.CausesValidation = false;
            this.VisitorUpdatebtn.Location = new System.Drawing.Point(211, 400);
            this.VisitorUpdatebtn.Name = "VisitorUpdatebtn";
            this.VisitorUpdatebtn.Size = new System.Drawing.Size(75, 27);
            this.VisitorUpdatebtn.TabIndex = 13;
            this.VisitorUpdatebtn.Text = "Update";
            this.VisitorUpdatebtn.UseVisualStyleBackColor = false;
            this.VisitorUpdatebtn.Click += new System.EventHandler(this.VisitorUpdatebtn_Click);
            // 
            // VisitorPhoneText
            // 
            this.VisitorPhoneText.Location = new System.Drawing.Point(199, 174);
            this.VisitorPhoneText.Name = "VisitorPhoneText";
            this.VisitorPhoneText.Size = new System.Drawing.Size(121, 20);
            this.VisitorPhoneText.TabIndex = 12;
            // 
            // VisitorIDText
            // 
            this.VisitorIDText.Location = new System.Drawing.Point(199, 126);
            this.VisitorIDText.Name = "VisitorIDText";
            this.VisitorIDText.Size = new System.Drawing.Size(121, 20);
            this.VisitorIDText.TabIndex = 7;
            // 
            // VisitorNameText
            // 
            this.VisitorNameText.Location = new System.Drawing.Point(199, 82);
            this.VisitorNameText.Name = "VisitorNameText";
            this.VisitorNameText.Size = new System.Drawing.Size(121, 20);
            this.VisitorNameText.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // Patient_Name
            // 
            this.Patient_Name.AutoSize = true;
            this.Patient_Name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_Name.Location = new System.Drawing.Point(27, 259);
            this.Patient_Name.Name = "Patient_Name";
            this.Patient_Name.Size = new System.Drawing.Size(126, 19);
            this.Patient_Name.TabIndex = 1;
            this.Patient_Name.Text = "Patient_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
            // 
            // VisitsForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "VisitsForm1";
            this.Text = "Visits";
            this.Load += new System.EventHandler(this.VisitsForm1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

      

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Patient_Name;
        private System.Windows.Forms.Label Visitor;
        private System.Windows.Forms.Button Visitordeletebtn;
        private System.Windows.Forms.Button VisitorADDbtn;
        private System.Windows.Forms.Button VisitorUpdatebtn;
        private System.Windows.Forms.TextBox VisitorPhoneText;
        private System.Windows.Forms.TextBox VisitorIDText;
        private System.Windows.Forms.TextBox VisitorNameText;
        private System.Windows.Forms.Button Doctorbtn;
        private System.Windows.Forms.Button Patientbtn;
        private System.Windows.Forms.Button MainBtn;
        private System.Windows.Forms.Button roomBtn;
        private System.Windows.Forms.CheckBox VisitorFemale;
        private System.Windows.Forms.CheckBox VisitorMale;
        private System.Windows.Forms.ComboBox PatientIDComp;
        private System.Windows.Forms.ComboBox RoomIDComp;
        private System.Windows.Forms.Label RoomID;
    }
}