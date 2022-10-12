﻿namespace Hospital
{
    partial class NusreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NusreForm));
            this.Nurse = new System.Windows.Forms.Label();
            this.NID = new System.Windows.Forms.Label();
            this.NName = new System.Windows.Forms.Label();
            this.n_id = new System.Windows.Forms.TextBox();
            this.n_name = new System.Windows.Forms.TextBox();
            this.n_address = new System.Windows.Forms.TextBox();
            this.m_age = new System.Windows.Forms.TextBox();
            this.n_phone = new System.Windows.Forms.TextBox();
            this.n_gender = new System.Windows.Forms.TextBox();
            this.NAddress = new System.Windows.Forms.Label();
            this.NAge = new System.Windows.Forms.Label();
            this.NGender = new System.Windows.Forms.Label();
            this.Nphone = new System.Windows.Forms.Label();
            this.Nurse_Room = new System.Windows.Forms.Button();
            this.Nurse_DrageTime = new System.Windows.Forms.Button();
            this.Nurse_Back = new System.Windows.Forms.Button();
            this.Nurse_previous = new System.Windows.Forms.Button();
            this.Nurse_next = new System.Windows.Forms.Button();
            this.Nurse_patient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nurse
            // 
            this.Nurse.AutoSize = true;
            this.Nurse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Nurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nurse.Location = new System.Drawing.Point(24, 9);
            this.Nurse.Name = "Nurse";
            this.Nurse.Size = new System.Drawing.Size(66, 24);
            this.Nurse.TabIndex = 0;
            this.Nurse.Text = "Nurse";
            // 
            // NID
            // 
            this.NID.AutoSize = true;
            this.NID.Location = new System.Drawing.Point(54, 45);
            this.NID.Name = "NID";
            this.NID.Size = new System.Drawing.Size(18, 13);
            this.NID.TabIndex = 1;
            this.NID.Text = "ID";
            // 
            // NName
            // 
            this.NName.AutoSize = true;
            this.NName.Location = new System.Drawing.Point(49, 91);
            this.NName.Name = "NName";
            this.NName.Size = new System.Drawing.Size(35, 13);
            this.NName.TabIndex = 2;
            this.NName.Text = "Name";
            // 
            // n_id
            // 
            this.n_id.Location = new System.Drawing.Point(112, 45);
            this.n_id.Name = "n_id";
            this.n_id.Size = new System.Drawing.Size(100, 20);
            this.n_id.TabIndex = 3;
            // 
            // n_name
            // 
            this.n_name.Location = new System.Drawing.Point(112, 84);
            this.n_name.Name = "n_name";
            this.n_name.Size = new System.Drawing.Size(100, 20);
            this.n_name.TabIndex = 4;
            // 
            // n_address
            // 
            this.n_address.Location = new System.Drawing.Point(112, 119);
            this.n_address.Name = "n_address";
            this.n_address.Size = new System.Drawing.Size(100, 20);
            this.n_address.TabIndex = 5;
            // 
            // m_age
            // 
            this.m_age.Location = new System.Drawing.Point(112, 160);
            this.m_age.Name = "m_age";
            this.m_age.Size = new System.Drawing.Size(100, 20);
            this.m_age.TabIndex = 6;
            // 
            // n_phone
            // 
            this.n_phone.Location = new System.Drawing.Point(112, 201);
            this.n_phone.Name = "n_phone";
            this.n_phone.Size = new System.Drawing.Size(100, 20);
            this.n_phone.TabIndex = 7;
            // 
            // n_gender
            // 
            this.n_gender.Location = new System.Drawing.Point(112, 236);
            this.n_gender.Name = "n_gender";
            this.n_gender.Size = new System.Drawing.Size(100, 20);
            this.n_gender.TabIndex = 8;
            // 
            // NAddress
            // 
            this.NAddress.AutoSize = true;
            this.NAddress.Location = new System.Drawing.Point(45, 125);
            this.NAddress.Name = "NAddress";
            this.NAddress.Size = new System.Drawing.Size(45, 13);
            this.NAddress.TabIndex = 11;
            this.NAddress.Text = "Address";
            // 
            // NAge
            // 
            this.NAge.AutoSize = true;
            this.NAge.Location = new System.Drawing.Point(51, 167);
            this.NAge.Name = "NAge";
            this.NAge.Size = new System.Drawing.Size(26, 13);
            this.NAge.TabIndex = 12;
            this.NAge.Text = "Age";
            // 
            // NGender
            // 
            this.NGender.AutoSize = true;
            this.NGender.Location = new System.Drawing.Point(45, 243);
            this.NGender.Name = "NGender";
            this.NGender.Size = new System.Drawing.Size(42, 13);
            this.NGender.TabIndex = 13;
            this.NGender.Text = "Gender";
            // 
            // Nphone
            // 
            this.Nphone.AutoSize = true;
            this.Nphone.Location = new System.Drawing.Point(49, 207);
            this.Nphone.Name = "Nphone";
            this.Nphone.Size = new System.Drawing.Size(37, 13);
            this.Nphone.TabIndex = 14;
            this.Nphone.Text = "phone";
            // 
            // Nurse_Room
            // 
            this.Nurse_Room.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nurse_Room.Location = new System.Drawing.Point(453, 48);
            this.Nurse_Room.Name = "Nurse_Room";
            this.Nurse_Room.Size = new System.Drawing.Size(94, 40);
            this.Nurse_Room.TabIndex = 17;
            this.Nurse_Room.Text = "Room";
            this.Nurse_Room.UseVisualStyleBackColor = false;
            this.Nurse_Room.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nurse_DrageTime
            // 
            this.Nurse_DrageTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nurse_DrageTime.Location = new System.Drawing.Point(453, 108);
            this.Nurse_DrageTime.Name = "Nurse_DrageTime";
            this.Nurse_DrageTime.Size = new System.Drawing.Size(94, 41);
            this.Nurse_DrageTime.TabIndex = 18;
            this.Nurse_DrageTime.Text = "DrageTime";
            this.Nurse_DrageTime.UseVisualStyleBackColor = false;
            // 
            // Nurse_Back
            // 
            this.Nurse_Back.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Nurse_Back.Location = new System.Drawing.Point(453, 223);
            this.Nurse_Back.Name = "Nurse_Back";
            this.Nurse_Back.Size = new System.Drawing.Size(94, 45);
            this.Nurse_Back.TabIndex = 19;
            this.Nurse_Back.Text = "Back";
            this.Nurse_Back.UseVisualStyleBackColor = false;
            this.Nurse_Back.Click += new System.EventHandler(this.Nurse_Back_Click);
            // 
            // Nurse_previous
            // 
            this.Nurse_previous.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nurse_previous.Location = new System.Drawing.Point(112, 278);
            this.Nurse_previous.Name = "Nurse_previous";
            this.Nurse_previous.Size = new System.Drawing.Size(27, 23);
            this.Nurse_previous.TabIndex = 20;
            this.Nurse_previous.Text = "<";
            this.Nurse_previous.UseVisualStyleBackColor = false;
            // 
            // Nurse_next
            // 
            this.Nurse_next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nurse_next.Location = new System.Drawing.Point(164, 278);
            this.Nurse_next.Name = "Nurse_next";
            this.Nurse_next.Size = new System.Drawing.Size(24, 23);
            this.Nurse_next.TabIndex = 21;
            this.Nurse_next.Text = ">";
            this.Nurse_next.UseVisualStyleBackColor = false;
            // 
            // Nurse_patient
            // 
            this.Nurse_patient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nurse_patient.Location = new System.Drawing.Point(453, 167);
            this.Nurse_patient.Name = "Nurse_patient";
            this.Nurse_patient.Size = new System.Drawing.Size(94, 39);
            this.Nurse_patient.TabIndex = 22;
            this.Nurse_patient.Text = "Paient";
            this.Nurse_patient.UseVisualStyleBackColor = false;
            // 
            // Nusre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 313);
            this.Controls.Add(this.Nurse_patient);
            this.Controls.Add(this.Nurse_next);
            this.Controls.Add(this.Nurse_previous);
            this.Controls.Add(this.Nurse_Back);
            this.Controls.Add(this.Nurse_DrageTime);
            this.Controls.Add(this.Nurse_Room);
            this.Controls.Add(this.Nphone);
            this.Controls.Add(this.NGender);
            this.Controls.Add(this.NAge);
            this.Controls.Add(this.NAddress);
            this.Controls.Add(this.n_gender);
            this.Controls.Add(this.n_phone);
            this.Controls.Add(this.m_age);
            this.Controls.Add(this.n_address);
            this.Controls.Add(this.n_name);
            this.Controls.Add(this.n_id);
            this.Controls.Add(this.NName);
            this.Controls.Add(this.NID);
            this.Controls.Add(this.Nurse);
            this.Name = "Nusre";
            this.Text = "Nusre";
            this.Load += new System.EventHandler(this.Nusre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nurse;
        private System.Windows.Forms.Label NID;
        private System.Windows.Forms.Label NName;
        private System.Windows.Forms.TextBox n_id;
        private System.Windows.Forms.TextBox n_name;
        private System.Windows.Forms.TextBox n_address;
        private System.Windows.Forms.TextBox m_age;
        private System.Windows.Forms.TextBox n_phone;
        private System.Windows.Forms.TextBox n_gender;
        private System.Windows.Forms.Label NAddress;
        private System.Windows.Forms.Label NAge;
        private System.Windows.Forms.Label NGender;
        private System.Windows.Forms.Label Nphone;
        private System.Windows.Forms.Button Nurse_Room;
        private System.Windows.Forms.Button Nurse_DrageTime;
        private System.Windows.Forms.Button Nurse_Back;
        private System.Windows.Forms.Button Nurse_previous;
        private System.Windows.Forms.Button Nurse_next;
        private System.Windows.Forms.Button Nurse_patient;
    }
}