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
            this.Doctorbtn = new System.Windows.Forms.Button();
            this.Patientbtn = new System.Windows.Forms.Button();
            this.MainBtn = new System.Windows.Forms.Button();
            this.Visitor = new System.Windows.Forms.Label();
            this.Visitordeletebtn = new System.Windows.Forms.Button();
            this.VisitorADDbtn = new System.Windows.Forms.Button();
            this.VisitorUpdatebtn = new System.Windows.Forms.Button();
            this.VisitorPhoneText = new System.Windows.Forms.TextBox();
            this.VisitorGenderText = new System.Windows.Forms.TextBox();
            this.VisitorPatientNameText = new System.Windows.Forms.TextBox();
            this.VisitorPatientroomText = new System.Windows.Forms.TextBox();
            this.VisitorIDText = new System.Windows.Forms.TextBox();
            this.VisitorNameText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.roomBtn);
            this.panel1.Controls.Add(this.Doctorbtn);
            this.panel1.Controls.Add(this.Patientbtn);
            this.panel1.Controls.Add(this.MainBtn);
            this.panel1.Controls.Add(this.Visitor);
            this.panel1.Controls.Add(this.Visitordeletebtn);
            this.panel1.Controls.Add(this.VisitorADDbtn);
            this.panel1.Controls.Add(this.VisitorUpdatebtn);
            this.panel1.Controls.Add(this.VisitorPhoneText);
            this.panel1.Controls.Add(this.VisitorGenderText);
            this.panel1.Controls.Add(this.VisitorPatientNameText);
            this.panel1.Controls.Add(this.VisitorPatientroomText);
            this.panel1.Controls.Add(this.VisitorIDText);
            this.panel1.Controls.Add(this.VisitorNameText);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 450);
            this.panel1.TabIndex = 0;
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
            this.Visitordeletebtn.CausesValidation = false;
            this.Visitordeletebtn.Location = new System.Drawing.Point(325, 400);
            this.Visitordeletebtn.Name = "Visitordeletebtn";
            this.Visitordeletebtn.Size = new System.Drawing.Size(75, 23);
            this.Visitordeletebtn.TabIndex = 15;
            this.Visitordeletebtn.Text = "Delete";
            this.Visitordeletebtn.UseVisualStyleBackColor = true;
            // 
            // VisitorADDbtn
            // 
            this.VisitorADDbtn.CausesValidation = false;
            this.VisitorADDbtn.Location = new System.Drawing.Point(224, 400);
            this.VisitorADDbtn.Name = "VisitorADDbtn";
            this.VisitorADDbtn.Size = new System.Drawing.Size(75, 23);
            this.VisitorADDbtn.TabIndex = 14;
            this.VisitorADDbtn.Text = "Add";
            this.VisitorADDbtn.UseVisualStyleBackColor = true;
            this.VisitorADDbtn.Click += new System.EventHandler(this.VisitorADDbtn_Click);
            // 
            // VisitorUpdatebtn
            // 
            this.VisitorUpdatebtn.CausesValidation = false;
            this.VisitorUpdatebtn.Location = new System.Drawing.Point(118, 400);
            this.VisitorUpdatebtn.Name = "VisitorUpdatebtn";
            this.VisitorUpdatebtn.Size = new System.Drawing.Size(75, 23);
            this.VisitorUpdatebtn.TabIndex = 13;
            this.VisitorUpdatebtn.Text = "Update";
            this.VisitorUpdatebtn.UseVisualStyleBackColor = true;
            // 
            // VisitorPhoneText
            // 
            this.VisitorPhoneText.Location = new System.Drawing.Point(199, 183);
            this.VisitorPhoneText.Name = "VisitorPhoneText";
            this.VisitorPhoneText.Size = new System.Drawing.Size(100, 20);
            this.VisitorPhoneText.TabIndex = 12;
            // 
            // VisitorGenderText
            // 
            this.VisitorGenderText.Location = new System.Drawing.Point(199, 235);
            this.VisitorGenderText.Name = "VisitorGenderText";
            this.VisitorGenderText.Size = new System.Drawing.Size(100, 20);
            this.VisitorGenderText.TabIndex = 11;
            // 
            // VisitorPatientNameText
            // 
            this.VisitorPatientNameText.Location = new System.Drawing.Point(199, 300);
            this.VisitorPatientNameText.Name = "VisitorPatientNameText";
            this.VisitorPatientNameText.Size = new System.Drawing.Size(100, 20);
            this.VisitorPatientNameText.TabIndex = 10;
            // 
            // VisitorPatientroomText
            // 
            this.VisitorPatientroomText.Location = new System.Drawing.Point(199, 352);
            this.VisitorPatientroomText.Name = "VisitorPatientroomText";
            this.VisitorPatientroomText.Size = new System.Drawing.Size(100, 20);
            this.VisitorPatientroomText.TabIndex = 9;
            // 
            // VisitorIDText
            // 
            this.VisitorIDText.Location = new System.Drawing.Point(199, 126);
            this.VisitorIDText.Name = "VisitorIDText";
            this.VisitorIDText.Size = new System.Drawing.Size(100, 20);
            this.VisitorIDText.TabIndex = 7;
            // 
            // VisitorNameText
            // 
            this.VisitorNameText.Location = new System.Drawing.Point(199, 82);
            this.VisitorNameText.Name = "VisitorNameText";
            this.VisitorNameText.Size = new System.Drawing.Size(100, 20);
            this.VisitorNameText.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Patient Room";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name ";
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
            // VisitsForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "VisitsForm1";
            this.Text = "Visits";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Visitor;
        private System.Windows.Forms.Button Visitordeletebtn;
        private System.Windows.Forms.Button VisitorADDbtn;
        private System.Windows.Forms.Button VisitorUpdatebtn;
        private System.Windows.Forms.TextBox VisitorPhoneText;
        private System.Windows.Forms.TextBox VisitorGenderText;
        private System.Windows.Forms.TextBox VisitorPatientNameText;
        private System.Windows.Forms.TextBox VisitorPatientroomText;
        private System.Windows.Forms.TextBox VisitorIDText;
        private System.Windows.Forms.TextBox VisitorNameText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Doctorbtn;
        private System.Windows.Forms.Button Patientbtn;
        private System.Windows.Forms.Button MainBtn;
        private System.Windows.Forms.Button roomBtn;
    }
}