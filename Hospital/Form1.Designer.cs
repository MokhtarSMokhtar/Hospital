namespace Hospital
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanal = new System.Windows.Forms.Panel();
            this.DoctorAndPatientbtn = new System.Windows.Forms.Button();
            this.PatientStateBtn = new System.Windows.Forms.Button();
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
            this.MainPanal.Controls.Add(this.DoctorAndPatientbtn);
            this.MainPanal.Controls.Add(this.PatientStateBtn);
            this.MainPanal.Controls.Add(this.DoctorBtn);
            this.MainPanal.Controls.Add(this.PatientBtn);
            this.MainPanal.Controls.Add(this.RoomBtn);
            this.MainPanal.Location = new System.Drawing.Point(-4, 2);
            this.MainPanal.Name = "MainPanal";
            this.MainPanal.Size = new System.Drawing.Size(816, 473);
            this.MainPanal.TabIndex = 0;
            // 
            // DoctorAndPatientbtn
            // 
            this.DoctorAndPatientbtn.Location = new System.Drawing.Point(27, 11);
            this.DoctorAndPatientbtn.Name = "DoctorAndPatientbtn";
            this.DoctorAndPatientbtn.Size = new System.Drawing.Size(112, 24);
            this.DoctorAndPatientbtn.TabIndex = 4;
            this.DoctorAndPatientbtn.Text = "Doctor And Patient";
            this.DoctorAndPatientbtn.UseVisualStyleBackColor = true;
            // 
            // PatientStateBtn
            // 
            this.PatientStateBtn.Location = new System.Drawing.Point(219, 11);
            this.PatientStateBtn.Name = "PatientStateBtn";
            this.PatientStateBtn.Size = new System.Drawing.Size(112, 23);
            this.PatientStateBtn.TabIndex = 3;
            this.PatientStateBtn.Text = "Patient State";
            this.PatientStateBtn.UseVisualStyleBackColor = true;
            // 
            // DoctorBtn
            // 
            this.DoctorBtn.Location = new System.Drawing.Point(475, 12);
            this.DoctorBtn.Name = "DoctorBtn";
            this.DoctorBtn.Size = new System.Drawing.Size(85, 23);
            this.DoctorBtn.TabIndex = 2;
            this.DoctorBtn.Text = "Doctor";
            this.DoctorBtn.UseVisualStyleBackColor = true;
            this.DoctorBtn.Click += new System.EventHandler(this.DoctorBtn_Click);
            // 
            // PatientBtn
            // 
            this.PatientBtn.Location = new System.Drawing.Point(589, 11);
            this.PatientBtn.Name = "PatientBtn";
            this.PatientBtn.Size = new System.Drawing.Size(86, 23);
            this.PatientBtn.TabIndex = 1;
            this.PatientBtn.Text = "Patient";
            this.PatientBtn.UseVisualStyleBackColor = true;
            // 
            // RoomBtn
            // 
            this.RoomBtn.Location = new System.Drawing.Point(699, 11);
            this.RoomBtn.Name = "RoomBtn";
            this.RoomBtn.Size = new System.Drawing.Size(85, 23);
            this.RoomBtn.TabIndex = 0;
            this.RoomBtn.Text = "Room";
            this.RoomBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 474);
            this.Controls.Add(this.MainPanal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanal;
        private System.Windows.Forms.Button DoctorAndPatientbtn;
        private System.Windows.Forms.Button PatientStateBtn;
        private System.Windows.Forms.Button DoctorBtn;
        private System.Windows.Forms.Button PatientBtn;
        private System.Windows.Forms.Button RoomBtn;

    }
}

