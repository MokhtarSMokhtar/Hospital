﻿namespace Hospital
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainPanal = new System.Windows.Forms.Panel();
            this.DeptBtn = new System.Windows.Forms.Button();
            this.VisitBtn = new System.Windows.Forms.Button();
            this.NurseBtn = new System.Windows.Forms.Button();
            this.DoctorBtn = new System.Windows.Forms.Button();
            this.PatientBtn = new System.Windows.Forms.Button();
            this.RoomBtn = new System.Windows.Forms.Button();
            this.MainPanal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanal
            // 
            this.MainPanal.AllowDrop = true;
            this.MainPanal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MainPanal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPanal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanal.BackgroundImage")));
            this.MainPanal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanal.Controls.Add(this.DeptBtn);
            this.MainPanal.Controls.Add(this.VisitBtn);
            this.MainPanal.Controls.Add(this.NurseBtn);
            this.MainPanal.Controls.Add(this.DoctorBtn);
            this.MainPanal.Controls.Add(this.PatientBtn);
            this.MainPanal.Controls.Add(this.RoomBtn);
            this.MainPanal.Location = new System.Drawing.Point(-4, 2);
            this.MainPanal.Name = "MainPanal";
            this.MainPanal.Size = new System.Drawing.Size(816, 473);
            this.MainPanal.TabIndex = 0;
            // 
            // DeptBtn
            // 
            this.DeptBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DeptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptBtn.Location = new System.Drawing.Point(16, 12);
            this.DeptBtn.Name = "DeptBtn";
            this.DeptBtn.Size = new System.Drawing.Size(101, 34);
            this.DeptBtn.TabIndex = 7;
            this.DeptBtn.Text = "Departments";
            this.DeptBtn.UseVisualStyleBackColor = false;
            this.DeptBtn.Click += new System.EventHandler(this.DeptBtn_Click);
            // 
            // VisitBtn
            // 
            this.VisitBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.VisitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisitBtn.Location = new System.Drawing.Point(731, 12);
            this.VisitBtn.Name = "VisitBtn";
            this.VisitBtn.Size = new System.Drawing.Size(85, 34);
            this.VisitBtn.TabIndex = 6;
            this.VisitBtn.Text = "Visits";
            this.VisitBtn.UseVisualStyleBackColor = false;
            this.VisitBtn.Click += new System.EventHandler(this.VisitBtn_Click);
            // 
            // NurseBtn
            // 
            this.NurseBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NurseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NurseBtn.Location = new System.Drawing.Point(551, 12);
            this.NurseBtn.Name = "NurseBtn";
            this.NurseBtn.Size = new System.Drawing.Size(86, 34);
            this.NurseBtn.TabIndex = 5;
            this.NurseBtn.Text = "Nurse";
            this.NurseBtn.UseVisualStyleBackColor = false;
            this.NurseBtn.Click += new System.EventHandler(this.NurseBtn_Click);
            // 
            // DoctorBtn
            // 
            this.DoctorBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DoctorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoctorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorBtn.Location = new System.Drawing.Point(368, 11);
            this.DoctorBtn.Name = "DoctorBtn";
            this.DoctorBtn.Size = new System.Drawing.Size(85, 34);
            this.DoctorBtn.TabIndex = 2;
            this.DoctorBtn.Text = "Doctor";
            this.DoctorBtn.UseVisualStyleBackColor = false;
            this.DoctorBtn.Click += new System.EventHandler(this.DoctorBtn_Click);
            // 
            // PatientBtn
            // 
            this.PatientBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PatientBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientBtn.Location = new System.Drawing.Point(459, 12);
            this.PatientBtn.Name = "PatientBtn";
            this.PatientBtn.Size = new System.Drawing.Size(86, 34);
            this.PatientBtn.TabIndex = 1;
            this.PatientBtn.Text = "Patient";
            this.PatientBtn.UseVisualStyleBackColor = false;
            this.PatientBtn.Click += new System.EventHandler(this.PatientBtn_Click);
            // 
            // RoomBtn
            // 
            this.RoomBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RoomBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomBtn.Location = new System.Drawing.Point(643, 12);
            this.RoomBtn.Name = "RoomBtn";
            this.RoomBtn.Size = new System.Drawing.Size(85, 34);
            this.RoomBtn.TabIndex = 0;
            this.RoomBtn.Text = "Room";
            this.RoomBtn.UseVisualStyleBackColor = false;
            this.RoomBtn.Click += new System.EventHandler(this.RoomBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 474);
            this.Controls.Add(this.MainPanal);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanal;
        private System.Windows.Forms.Button DoctorBtn;
        private System.Windows.Forms.Button PatientBtn;
        private System.Windows.Forms.Button RoomBtn;
        private System.Windows.Forms.Button VisitBtn;
        private System.Windows.Forms.Button NurseBtn;
        private System.Windows.Forms.Button DeptBtn;
    }
}

