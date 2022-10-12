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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.Label();
            this.Case = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
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
            this.patients.Location = new System.Drawing.Point(46, 32);
            this.patients.Name = "patients";
            this.patients.Size = new System.Drawing.Size(45, 13);
            this.patients.TabIndex = 0;
            this.patients.Text = "Patients";
            this.patients.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(165, 125);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(165, 164);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(114, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(165, 208);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(114, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(165, 244);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(114, 20);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(165, 287);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(114, 20);
            this.textBox7.TabIndex = 7;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(68, 56);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 8;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(68, 96);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 9;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(68, 132);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 10;
            this.Address.Text = "Address";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(71, 170);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(38, 13);
            this.Phone.TabIndex = 11;
            this.Phone.Text = "Phone";
            // 
            // Age
            // 
            this.Age.AutoSize = true;
            this.Age.Location = new System.Drawing.Point(77, 215);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(26, 13);
            this.Age.TabIndex = 12;
            this.Age.Text = "Age";
            // 
            // Case
            // 
            this.Case.AutoSize = true;
            this.Case.Location = new System.Drawing.Point(74, 251);
            this.Case.Name = "Case";
            this.Case.Size = new System.Drawing.Size(31, 13);
            this.Case.TabIndex = 13;
            this.Case.Text = "Case";
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(74, 294);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 14;
            this.Gender.Text = "Gender";
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
            this.Visits.Size = new System.Drawing.Size(94, 40);
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
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Case);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Case;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Button Doctor;
        private System.Windows.Forms.Button Room;
        private System.Windows.Forms.Button Visits;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button moveleft;
        private System.Windows.Forms.Button moveright;
    }
}