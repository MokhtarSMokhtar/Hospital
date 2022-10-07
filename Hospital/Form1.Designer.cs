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
            this.DoctorPanal = new System.Windows.Forms.Panel();
            this.label1Label = new System.Windows.Forms.Label();
            this.label1DoctorId = new System.Windows.Forms.Label();
            this.label1DoctorAdd = new System.Windows.Forms.Label();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.label3DoctorSpi = new System.Windows.Forms.Label();
            this.label4DoctorPh = new System.Windows.Forms.Label();
            this.DoctorIDText = new System.Windows.Forms.TextBox();
            this.DoctorSpicia = new System.Windows.Forms.TextBox();
            this.DoctorNameText = new System.Windows.Forms.TextBox();
            this.DoctorPhoneText = new System.Windows.Forms.TextBox();
            this.DoctorAddressText = new System.Windows.Forms.TextBox();
            this.AddDoctorbtn = new System.Windows.Forms.Button();
            this.DeleteDoctorbtn = new System.Windows.Forms.Button();
            this.UpdateDoctorbtn = new System.Windows.Forms.Button();
            this.FromDoctorToRoom = new System.Windows.Forms.Button();
            this.FromDoctorToVisite = new System.Windows.Forms.Button();
            this.FromDoctorToPAtiant = new System.Windows.Forms.Button();
            this.FromDoctorToMain = new System.Windows.Forms.Button();
            this.MainPanal.SuspendLayout();
            this.DoctorPanal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanal
            // 
            this.MainPanal.AllowDrop = true;
            this.MainPanal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MainPanal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPanal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanal.BackgroundImage")));
            this.MainPanal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanal.Controls.Add(this.DoctorPanal);
            this.MainPanal.Controls.Add(this.DoctorAndPatientbtn);
            this.MainPanal.Controls.Add(this.PatientStateBtn);
            this.MainPanal.Controls.Add(this.DoctorBtn);
            this.MainPanal.Controls.Add(this.PatientBtn);
            this.MainPanal.Controls.Add(this.RoomBtn);
            this.MainPanal.Location = new System.Drawing.Point(-4, 1);
            this.MainPanal.Name = "MainPanal";
            this.MainPanal.Size = new System.Drawing.Size(816, 474);
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
            // DoctorPanal
            // 
            this.DoctorPanal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DoctorPanal.Controls.Add(this.FromDoctorToMain);
            this.DoctorPanal.Controls.Add(this.FromDoctorToPAtiant);
            this.DoctorPanal.Controls.Add(this.FromDoctorToVisite);
            this.DoctorPanal.Controls.Add(this.FromDoctorToRoom);
            this.DoctorPanal.Controls.Add(this.UpdateDoctorbtn);
            this.DoctorPanal.Controls.Add(this.DeleteDoctorbtn);
            this.DoctorPanal.Controls.Add(this.AddDoctorbtn);
            this.DoctorPanal.Controls.Add(this.DoctorAddressText);
            this.DoctorPanal.Controls.Add(this.DoctorPhoneText);
            this.DoctorPanal.Controls.Add(this.DoctorNameText);
            this.DoctorPanal.Controls.Add(this.DoctorSpicia);
            this.DoctorPanal.Controls.Add(this.DoctorIDText);
            this.DoctorPanal.Controls.Add(this.label4DoctorPh);
            this.DoctorPanal.Controls.Add(this.label3DoctorSpi);
            this.DoctorPanal.Controls.Add(this.labelDoctorName);
            this.DoctorPanal.Controls.Add(this.label1DoctorAdd);
            this.DoctorPanal.Controls.Add(this.label1DoctorId);
            this.DoctorPanal.Controls.Add(this.label1Label);
            this.DoctorPanal.Location = new System.Drawing.Point(0, 0);
            this.DoctorPanal.Name = "DoctorPanal";
            this.DoctorPanal.Size = new System.Drawing.Size(816, 471);
            this.DoctorPanal.TabIndex = 5;
            // 
            // label1Label
            // 
            this.label1Label.AutoSize = true;
            this.label1Label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Label.Location = new System.Drawing.Point(20, 12);
            this.label1Label.Name = "label1Label";
            this.label1Label.Size = new System.Drawing.Size(120, 39);
            this.label1Label.TabIndex = 0;
            this.label1Label.Text = "Doctor";
            this.label1Label.Click += new System.EventHandler(this.label1Label_Click);
            // 
            // label1DoctorId
            // 
            this.label1DoctorId.AutoSize = true;
            this.label1DoctorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1DoctorId.Location = new System.Drawing.Point(38, 102);
            this.label1DoctorId.Name = "label1DoctorId";
            this.label1DoctorId.Size = new System.Drawing.Size(101, 25);
            this.label1DoctorId.TabIndex = 1;
            this.label1DoctorId.Text = "Doctor ID";
            // 
            // label1DoctorAdd
            // 
            this.label1DoctorAdd.AutoSize = true;
            this.label1DoctorAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1DoctorAdd.Location = new System.Drawing.Point(38, 370);
            this.label1DoctorAdd.Name = "label1DoctorAdd";
            this.label1DoctorAdd.Size = new System.Drawing.Size(160, 25);
            this.label1DoctorAdd.TabIndex = 2;
            this.label1DoctorAdd.Text = "Doctor Address";
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.AutoSize = true;
            this.labelDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoctorName.Location = new System.Drawing.Point(38, 167);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(137, 25);
            this.labelDoctorName.TabIndex = 3;
            this.labelDoctorName.Text = "Doctor Name";
            // 
            // label3DoctorSpi
            // 
            this.label3DoctorSpi.AutoSize = true;
            this.label3DoctorSpi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3DoctorSpi.Location = new System.Drawing.Point(38, 234);
            this.label3DoctorSpi.Name = "label3DoctorSpi";
            this.label3DoctorSpi.Size = new System.Drawing.Size(140, 25);
            this.label3DoctorSpi.TabIndex = 4;
            this.label3DoctorSpi.Text = "Doctor Spicia";
            // 
            // label4DoctorPh
            // 
            this.label4DoctorPh.AutoSize = true;
            this.label4DoctorPh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4DoctorPh.Location = new System.Drawing.Point(38, 300);
            this.label4DoctorPh.Name = "label4DoctorPh";
            this.label4DoctorPh.Size = new System.Drawing.Size(143, 25);
            this.label4DoctorPh.TabIndex = 5;
            this.label4DoctorPh.Text = "Doctor Phone";
            // 
            // DoctorIDText
            // 
            this.DoctorIDText.Location = new System.Drawing.Point(219, 108);
            this.DoctorIDText.Name = "DoctorIDText";
            this.DoctorIDText.Size = new System.Drawing.Size(169, 20);
            this.DoctorIDText.TabIndex = 6;
            // 
            // DoctorSpicia
            // 
            this.DoctorSpicia.Location = new System.Drawing.Point(219, 234);
            this.DoctorSpicia.Name = "DoctorSpicia";
            this.DoctorSpicia.Size = new System.Drawing.Size(169, 20);
            this.DoctorSpicia.TabIndex = 7;
            // 
            // DoctorNameText
            // 
            this.DoctorNameText.Location = new System.Drawing.Point(219, 173);
            this.DoctorNameText.Name = "DoctorNameText";
            this.DoctorNameText.Size = new System.Drawing.Size(169, 20);
            this.DoctorNameText.TabIndex = 8;
            // 
            // DoctorPhoneText
            // 
            this.DoctorPhoneText.Location = new System.Drawing.Point(219, 300);
            this.DoctorPhoneText.Name = "DoctorPhoneText";
            this.DoctorPhoneText.Size = new System.Drawing.Size(169, 20);
            this.DoctorPhoneText.TabIndex = 9;
            // 
            // DoctorAddressText
            // 
            this.DoctorAddressText.Location = new System.Drawing.Point(219, 370);
            this.DoctorAddressText.Name = "DoctorAddressText";
            this.DoctorAddressText.Size = new System.Drawing.Size(169, 20);
            this.DoctorAddressText.TabIndex = 10;
            // 
            // AddDoctorbtn
            // 
            this.AddDoctorbtn.Location = new System.Drawing.Point(190, 425);
            this.AddDoctorbtn.Name = "AddDoctorbtn";
            this.AddDoctorbtn.Size = new System.Drawing.Size(75, 23);
            this.AddDoctorbtn.TabIndex = 11;
            this.AddDoctorbtn.Text = "Add";
            this.AddDoctorbtn.UseVisualStyleBackColor = true;
            // 
            // DeleteDoctorbtn
            // 
            this.DeleteDoctorbtn.Location = new System.Drawing.Point(401, 425);
            this.DeleteDoctorbtn.Name = "DeleteDoctorbtn";
            this.DeleteDoctorbtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteDoctorbtn.TabIndex = 12;
            this.DeleteDoctorbtn.Text = "Delete";
            this.DeleteDoctorbtn.UseVisualStyleBackColor = true;
            // 
            // UpdateDoctorbtn
            // 
            this.UpdateDoctorbtn.Location = new System.Drawing.Point(300, 425);
            this.UpdateDoctorbtn.Name = "UpdateDoctorbtn";
            this.UpdateDoctorbtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateDoctorbtn.TabIndex = 13;
            this.UpdateDoctorbtn.Text = "Update";
            this.UpdateDoctorbtn.UseVisualStyleBackColor = true;
            // 
            // FromDoctorToRoom
            // 
            this.FromDoctorToRoom.Location = new System.Drawing.Point(492, 108);
            this.FromDoctorToRoom.Name = "FromDoctorToRoom";
            this.FromDoctorToRoom.Size = new System.Drawing.Size(75, 23);
            this.FromDoctorToRoom.TabIndex = 14;
            this.FromDoctorToRoom.Text = "Room";
            this.FromDoctorToRoom.UseVisualStyleBackColor = true;
            // 
            // FromDoctorToVisite
            // 
            this.FromDoctorToVisite.Location = new System.Drawing.Point(492, 169);
            this.FromDoctorToVisite.Name = "FromDoctorToVisite";
            this.FromDoctorToVisite.Size = new System.Drawing.Size(75, 23);
            this.FromDoctorToVisite.TabIndex = 15;
            this.FromDoctorToVisite.Text = "Visite";
            this.FromDoctorToVisite.UseVisualStyleBackColor = true;
            // 
            // FromDoctorToPAtiant
            // 
            this.FromDoctorToPAtiant.Location = new System.Drawing.Point(492, 231);
            this.FromDoctorToPAtiant.Name = "FromDoctorToPAtiant";
            this.FromDoctorToPAtiant.Size = new System.Drawing.Size(75, 23);
            this.FromDoctorToPAtiant.TabIndex = 16;
            this.FromDoctorToPAtiant.Text = "Patient";
            this.FromDoctorToPAtiant.UseVisualStyleBackColor = true;
            // 
            // FromDoctorToMain
            // 
            this.FromDoctorToMain.Location = new System.Drawing.Point(492, 297);
            this.FromDoctorToMain.Name = "FromDoctorToMain";
            this.FromDoctorToMain.Size = new System.Drawing.Size(75, 23);
            this.FromDoctorToMain.TabIndex = 17;
            this.FromDoctorToMain.Text = "Back";
            this.FromDoctorToMain.UseVisualStyleBackColor = true;
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
            this.DoctorPanal.ResumeLayout(false);
            this.DoctorPanal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanal;
        private System.Windows.Forms.Button DoctorAndPatientbtn;
        private System.Windows.Forms.Button PatientStateBtn;
        private System.Windows.Forms.Button DoctorBtn;
        private System.Windows.Forms.Button PatientBtn;
        private System.Windows.Forms.Button RoomBtn;
        private System.Windows.Forms.Panel DoctorPanal;
        private System.Windows.Forms.Label label1Label;
        private System.Windows.Forms.Button FromDoctorToMain;
        private System.Windows.Forms.Button FromDoctorToPAtiant;
        private System.Windows.Forms.Button FromDoctorToVisite;
        private System.Windows.Forms.Button FromDoctorToRoom;
        private System.Windows.Forms.Button UpdateDoctorbtn;
        private System.Windows.Forms.Button DeleteDoctorbtn;
        private System.Windows.Forms.Button AddDoctorbtn;
        private System.Windows.Forms.TextBox DoctorAddressText;
        private System.Windows.Forms.TextBox DoctorPhoneText;
        private System.Windows.Forms.TextBox DoctorNameText;
        private System.Windows.Forms.TextBox DoctorSpicia;
        private System.Windows.Forms.TextBox DoctorIDText;
        private System.Windows.Forms.Label label4DoctorPh;
        private System.Windows.Forms.Label label3DoctorSpi;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.Label label1DoctorAdd;
        private System.Windows.Forms.Label label1DoctorId;
    }
}

