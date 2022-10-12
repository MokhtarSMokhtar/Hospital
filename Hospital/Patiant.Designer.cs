namespace Hospital
{
    partial class Patiant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patiant));
            this.patients = new System.Windows.Forms.Label();
            this.p_id = new System.Windows.Forms.TextBox();
            this.p_name = new System.Windows.Forms.TextBox();
            this.p_adress = new System.Windows.Forms.TextBox();
            this.p_phone = new System.Windows.Forms.TextBox();
            this.p_age = new System.Windows.Forms.TextBox();
            this.p_case = new System.Windows.Forms.TextBox();
            this.p_gender = new System.Windows.Forms.TextBox();
            this.PID = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.Label();
            this.PAddress = new System.Windows.Forms.Label();
            this.PPhone = new System.Windows.Forms.Label();
            this.PAge = new System.Windows.Forms.Label();
            this.PCase = new System.Windows.Forms.Label();
            this.PGender = new System.Windows.Forms.Label();
            this.Doctor = new System.Windows.Forms.Button();
            this.Room = new System.Windows.Forms.Button();
            this.Visits = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.moveleft = new System.Windows.Forms.Button();
            this.moveright = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patients
            // 
            this.patients.AutoSize = true;
            this.patients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.patients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patients.Location = new System.Drawing.Point(50, 26);
            this.patients.Name = "patients";
            this.patients.Size = new System.Drawing.Size(45, 13);
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
            // p_adress
            // 
            this.p_adress.Location = new System.Drawing.Point(165, 125);
            this.p_adress.Name = "p_adress";
            this.p_adress.Size = new System.Drawing.Size(114, 20);
            this.p_adress.TabIndex = 3;
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
            this.p_age.Location = new System.Drawing.Point(165, 208);
            this.p_age.Name = "p_age";
            this.p_age.Size = new System.Drawing.Size(114, 20);
            this.p_age.TabIndex = 5;
            // 
            // p_case
            // 
            this.p_case.Location = new System.Drawing.Point(165, 244);
            this.p_case.Name = "p_case";
            this.p_case.Size = new System.Drawing.Size(114, 20);
            this.p_case.TabIndex = 6;
            // 
            // p_gender
            // 
            this.p_gender.Location = new System.Drawing.Point(165, 287);
            this.p_gender.Name = "p_gender";
            this.p_gender.Size = new System.Drawing.Size(114, 20);
            this.p_gender.TabIndex = 7;
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
            this.PAge.Location = new System.Drawing.Point(77, 215);
            this.PAge.Name = "PAge";
            this.PAge.Size = new System.Drawing.Size(26, 13);
            this.PAge.TabIndex = 12;
            this.PAge.Text = "Age";
            // 
            // PCase
            // 
            this.PCase.AutoSize = true;
            this.PCase.Location = new System.Drawing.Point(74, 251);
            this.PCase.Name = "PCase";
            this.PCase.Size = new System.Drawing.Size(31, 13);
            this.PCase.TabIndex = 13;
            this.PCase.Text = "Case";
            // 
            // PGender
            // 
            this.PGender.AutoSize = true;
            this.PGender.Location = new System.Drawing.Point(74, 294);
            this.PGender.Name = "PGender";
            this.PGender.Size = new System.Drawing.Size(42, 13);
            this.PGender.TabIndex = 14;
            this.PGender.Text = "Gender";
            // 
            // Doctor
            // 
            this.Doctor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Doctor.Location = new System.Drawing.Point(481, 55);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(94, 35);
            this.Doctor.TabIndex = 15;
            this.Doctor.Text = "Doctor";
            this.Doctor.UseVisualStyleBackColor = false;
            this.Doctor.Click += new System.EventHandler(this.Doctor_Click);
            // 
            // Room
            // 
            this.Room.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Room.Location = new System.Drawing.Point(481, 96);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(94, 41);
            this.Room.TabIndex = 16;
            this.Room.Text = "Room";
            this.Room.UseVisualStyleBackColor = false;
            // 
            // Visits
            // 
            this.Visits.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Visits.Location = new System.Drawing.Point(481, 143);
            this.Visits.Name = "Visits";
            this.Visits.Size = new System.Drawing.Size(94, 41);
            this.Visits.TabIndex = 17;
            this.Visits.Text = "Visits";
            this.Visits.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Back.Location = new System.Drawing.Point(481, 215);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(94, 45);
            this.Back.TabIndex = 18;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            // 
            // moveleft
            // 
            this.moveleft.Location = new System.Drawing.Point(342, 284);
            this.moveleft.Name = "moveleft";
            this.moveleft.Size = new System.Drawing.Size(39, 23);
            this.moveleft.TabIndex = 19;
            this.moveleft.Text = "<";
            this.moveleft.UseVisualStyleBackColor = true;
            // 
            // moveright
            // 
            this.moveright.Location = new System.Drawing.Point(403, 284);
            this.moveright.Name = "moveright";
            this.moveright.Size = new System.Drawing.Size(39, 23);
            this.moveright.TabIndex = 20;
            this.moveright.Text = ">";
            this.moveright.UseVisualStyleBackColor = true;
            // 
            // Patiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 325);
            this.Controls.Add(this.moveright);
            this.Controls.Add(this.moveleft);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Visits);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.PGender);
            this.Controls.Add(this.PCase);
            this.Controls.Add(this.PAge);
            this.Controls.Add(this.PPhone);
            this.Controls.Add(this.PAddress);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.PID);
            this.Controls.Add(this.p_gender);
            this.Controls.Add(this.p_case);
            this.Controls.Add(this.p_age);
            this.Controls.Add(this.p_phone);
            this.Controls.Add(this.p_adress);
            this.Controls.Add(this.p_name);
            this.Controls.Add(this.p_id);
            this.Controls.Add(this.patients);
            this.DoubleBuffered = true;
            this.Name = "Patiant";
            this.Text = "Patiant";
            this.Load += new System.EventHandler(this.Patiant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patients;
        private System.Windows.Forms.TextBox p_id;
        private System.Windows.Forms.TextBox p_name;
        private System.Windows.Forms.TextBox p_adress;
        private System.Windows.Forms.TextBox p_phone;
        private System.Windows.Forms.TextBox p_age;
        private System.Windows.Forms.TextBox p_case;
        private System.Windows.Forms.TextBox p_gender;
        private System.Windows.Forms.Label PID;
        private System.Windows.Forms.Label PName;
        private System.Windows.Forms.Label PAddress;
        private System.Windows.Forms.Label PPhone;
        private System.Windows.Forms.Label PAge;
        private System.Windows.Forms.Label PCase;
        private System.Windows.Forms.Label PGender;
        private System.Windows.Forms.Button Doctor;
        private System.Windows.Forms.Button Room;
        private System.Windows.Forms.Button Visits;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button moveleft;
        private System.Windows.Forms.Button moveright;
    }
}