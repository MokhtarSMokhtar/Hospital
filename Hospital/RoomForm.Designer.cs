namespace Hospital
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.Room = new System.Windows.Forms.Label();
            this.R_ID = new System.Windows.Forms.Label();
            this.R_Nurse = new System.Windows.Forms.Label();
            this.NofBed = new System.Windows.Forms.Label();
            this.R_type = new System.Windows.Forms.Label();
            this.RID = new System.Windows.Forms.TextBox();
            this.RoomNurse = new System.Windows.Forms.TextBox();
            this.numberofbed = new System.Windows.Forms.TextBox();
            this.roomtype = new System.Windows.Forms.TextBox();
            this.Room_Back = new System.Windows.Forms.Button();
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.Room_Visits = new System.Windows.Forms.Button();
            this.Room_Doctor = new System.Windows.Forms.Button();
            this.Room_patient = new System.Windows.Forms.Button();
            this.Room_next = new System.Windows.Forms.Button();
            this.Room_previous = new System.Windows.Forms.Button();
            this.RoomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room.Location = new System.Drawing.Point(12, 9);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(56, 20);
            this.Room.TabIndex = 0;
            this.Room.Text = "Room";
            // 
            // R_ID
            // 
            this.R_ID.AutoSize = true;
            this.R_ID.Location = new System.Drawing.Point(39, 114);
            this.R_ID.Name = "R_ID";
            this.R_ID.Size = new System.Drawing.Size(49, 13);
            this.R_ID.TabIndex = 1;
            this.R_ID.Text = "Room ID";
            // 
            // R_Nurse
            // 
            this.R_Nurse.AutoSize = true;
            this.R_Nurse.Location = new System.Drawing.Point(39, 166);
            this.R_Nurse.Name = "R_Nurse";
            this.R_Nurse.Size = new System.Drawing.Size(66, 13);
            this.R_Nurse.TabIndex = 2;
            this.R_Nurse.Text = "Room Nurse";
            // 
            // NofBed
            // 
            this.NofBed.AutoSize = true;
            this.NofBed.Location = new System.Drawing.Point(39, 214);
            this.NofBed.Name = "NofBed";
            this.NofBed.Size = new System.Drawing.Size(80, 13);
            this.NofBed.TabIndex = 3;
            this.NofBed.Text = "Number Of Bed";
            // 
            // R_type
            // 
            this.R_type.AutoSize = true;
            this.R_type.Location = new System.Drawing.Point(39, 257);
            this.R_type.Name = "R_type";
            this.R_type.Size = new System.Drawing.Size(62, 13);
            this.R_type.TabIndex = 4;
            this.R_type.Text = "Room Type";
            // 
            // RID
            // 
            this.RID.Location = new System.Drawing.Point(197, 114);
            this.RID.Name = "RID";
            this.RID.Size = new System.Drawing.Size(114, 20);
            this.RID.TabIndex = 5;
            // 
            // RoomNurse
            // 
            this.RoomNurse.Location = new System.Drawing.Point(197, 163);
            this.RoomNurse.Name = "RoomNurse";
            this.RoomNurse.Size = new System.Drawing.Size(114, 20);
            this.RoomNurse.TabIndex = 6;
            // 
            // numberofbed
            // 
            this.numberofbed.Location = new System.Drawing.Point(197, 207);
            this.numberofbed.Name = "numberofbed";
            this.numberofbed.Size = new System.Drawing.Size(114, 20);
            this.numberofbed.TabIndex = 7;
            // 
            // roomtype
            // 
            this.roomtype.Location = new System.Drawing.Point(197, 254);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(114, 20);
            this.roomtype.TabIndex = 8;
            // 
            // Room_Back
            // 
            this.Room_Back.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Room_Back.Location = new System.Drawing.Point(506, 241);
            this.Room_Back.Name = "Room_Back";
            this.Room_Back.Size = new System.Drawing.Size(94, 45);
            this.Room_Back.TabIndex = 19;
            this.Room_Back.Text = "Back";
            this.Room_Back.UseVisualStyleBackColor = false;
            // 
            // RoomPanel
            // 
            this.RoomPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RoomPanel.BackgroundImage")));
            this.RoomPanel.Controls.Add(this.Room_previous);
            this.RoomPanel.Controls.Add(this.Room_next);
            this.RoomPanel.Controls.Add(this.Room_patient);
            this.RoomPanel.Controls.Add(this.Room_Doctor);
            this.RoomPanel.Controls.Add(this.Room_Visits);
            this.RoomPanel.Controls.Add(this.Room_Back);
            this.RoomPanel.Controls.Add(this.roomtype);
            this.RoomPanel.Controls.Add(this.numberofbed);
            this.RoomPanel.Controls.Add(this.RoomNurse);
            this.RoomPanel.Controls.Add(this.RID);
            this.RoomPanel.Controls.Add(this.R_type);
            this.RoomPanel.Controls.Add(this.NofBed);
            this.RoomPanel.Controls.Add(this.R_Nurse);
            this.RoomPanel.Controls.Add(this.R_ID);
            this.RoomPanel.Controls.Add(this.Room);
            this.RoomPanel.Location = new System.Drawing.Point(0, 0);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(721, 309);
            this.RoomPanel.TabIndex = 1;
            // 
            // Room_Visits
            // 
            this.Room_Visits.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Room_Visits.Location = new System.Drawing.Point(506, 129);
            this.Room_Visits.Name = "Room_Visits";
            this.Room_Visits.Size = new System.Drawing.Size(94, 41);
            this.Room_Visits.TabIndex = 20;
            this.Room_Visits.Text = "Visits";
            this.Room_Visits.UseVisualStyleBackColor = false;
            // 
            // Room_Doctor
            // 
            this.Room_Doctor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Room_Doctor.Location = new System.Drawing.Point(506, 78);
            this.Room_Doctor.Name = "Room_Doctor";
            this.Room_Doctor.Size = new System.Drawing.Size(94, 35);
            this.Room_Doctor.TabIndex = 21;
            this.Room_Doctor.Text = "Doctor";
            this.Room_Doctor.UseVisualStyleBackColor = false;
            this.Room_Doctor.Click += new System.EventHandler(this.Doctor_Click);
            // 
            // Room_patient
            // 
            this.Room_patient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Room_patient.Location = new System.Drawing.Point(506, 188);
            this.Room_patient.Name = "Room_patient";
            this.Room_patient.Size = new System.Drawing.Size(94, 39);
            this.Room_patient.TabIndex = 23;
            this.Room_patient.Text = "Paient";
            this.Room_patient.UseVisualStyleBackColor = false;
            // 
            // Room_next
            // 
            this.Room_next.Location = new System.Drawing.Point(228, 286);
            this.Room_next.Name = "Room_next";
            this.Room_next.Size = new System.Drawing.Size(34, 23);
            this.Room_next.TabIndex = 24;
            this.Room_next.Text = ">";
            this.Room_next.UseVisualStyleBackColor = true;
            // 
            // Room_previous
            // 
            this.Room_previous.Location = new System.Drawing.Point(186, 286);
            this.Room_previous.Name = "Room_previous";
            this.Room_previous.Size = new System.Drawing.Size(36, 23);
            this.Room_previous.TabIndex = 25;
            this.Room_previous.Text = "<";
            this.Room_previous.UseVisualStyleBackColor = true;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 321);
            this.Controls.Add(this.RoomPanel);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            this.ResumeLayout(false);
            this.FormClosed += RoomForm_FormClosed;

        }

       

        #endregion

        private System.Windows.Forms.Label Room;
        private System.Windows.Forms.Label R_ID;
        private System.Windows.Forms.Label R_Nurse;
        private System.Windows.Forms.Label NofBed;
        private System.Windows.Forms.Label R_type;
        private System.Windows.Forms.TextBox RID;
        private System.Windows.Forms.TextBox RoomNurse;
        private System.Windows.Forms.TextBox numberofbed;
        private System.Windows.Forms.TextBox roomtype;
        private System.Windows.Forms.Button Room_Back;
        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.Button Room_Visits;
        private System.Windows.Forms.Button Room_Doctor;
        private System.Windows.Forms.Button Room_patient;
        private System.Windows.Forms.Button Room_next;
        private System.Windows.Forms.Button Room_previous;
    }
}