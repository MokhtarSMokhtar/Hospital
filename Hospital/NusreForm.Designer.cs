namespace Hospital
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
            this.n_age = new System.Windows.Forms.TextBox();
            this.n_phone = new System.Windows.Forms.TextBox();
            this.NAddress = new System.Windows.Forms.Label();
            this.NAge = new System.Windows.Forms.Label();
            this.NGender = new System.Windows.Forms.Label();
            this.Nphone = new System.Windows.Forms.Label();
            this.Nurse_Room = new System.Windows.Forms.Button();
            this.Nurse_DrageTime = new System.Windows.Forms.Button();
            this.Nurse_Back = new System.Windows.Forms.Button();
            this.Nurse_patient = new System.Windows.Forms.Button();
            this.NurseAddBtn = new System.Windows.Forms.Button();
            this.NurseUpdateBtn = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.NurseMale = new System.Windows.Forms.CheckBox();
            this.NurseFemale = new System.Windows.Forms.CheckBox();
            this.NurseDeptCompo = new System.Windows.Forms.ComboBox();
            this.NurseDepartment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboRoom = new System.Windows.Forms.ComboBox();
            this.PMCheked = new System.Windows.Forms.CheckBox();
            this.AmChecked = new System.Windows.Forms.CheckBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.DargelistCom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.NName.Location = new System.Drawing.Point(49, 74);
            this.NName.Name = "NName";
            this.NName.Size = new System.Drawing.Size(35, 13);
            this.NName.TabIndex = 2;
            this.NName.Text = "Name";
            // 
            // n_id
            // 
            this.n_id.Location = new System.Drawing.Point(112, 45);
            this.n_id.Name = "n_id";
            this.n_id.Size = new System.Drawing.Size(115, 20);
            this.n_id.TabIndex = 3;
            // 
            // n_name
            // 
            this.n_name.Location = new System.Drawing.Point(112, 74);
            this.n_name.Name = "n_name";
            this.n_name.Size = new System.Drawing.Size(115, 20);
            this.n_name.TabIndex = 4;
            // 
            // n_address
            // 
            this.n_address.Location = new System.Drawing.Point(112, 106);
            this.n_address.Name = "n_address";
            this.n_address.Size = new System.Drawing.Size(115, 20);
            this.n_address.TabIndex = 5;
            // 
            // n_age
            // 
            this.n_age.Location = new System.Drawing.Point(112, 141);
            this.n_age.Name = "n_age";
            this.n_age.Size = new System.Drawing.Size(115, 20);
            this.n_age.TabIndex = 6;
            // 
            // n_phone
            // 
            this.n_phone.Location = new System.Drawing.Point(112, 177);
            this.n_phone.Name = "n_phone";
            this.n_phone.Size = new System.Drawing.Size(115, 20);
            this.n_phone.TabIndex = 7;
            // 
            // NAddress
            // 
            this.NAddress.AutoSize = true;
            this.NAddress.Location = new System.Drawing.Point(45, 106);
            this.NAddress.Name = "NAddress";
            this.NAddress.Size = new System.Drawing.Size(45, 13);
            this.NAddress.TabIndex = 11;
            this.NAddress.Text = "Address";
            // 
            // NAge
            // 
            this.NAge.AutoSize = true;
            this.NAge.Location = new System.Drawing.Point(51, 144);
            this.NAge.Name = "NAge";
            this.NAge.Size = new System.Drawing.Size(26, 13);
            this.NAge.TabIndex = 12;
            this.NAge.Text = "Age";
            // 
            // NGender
            // 
            this.NGender.AutoSize = true;
            this.NGender.Location = new System.Drawing.Point(35, 318);
            this.NGender.Name = "NGender";
            this.NGender.Size = new System.Drawing.Size(42, 13);
            this.NGender.TabIndex = 13;
            this.NGender.Text = "Gender";
            // 
            // Nphone
            // 
            this.Nphone.AutoSize = true;
            this.Nphone.Location = new System.Drawing.Point(49, 184);
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
            // Nurse_patient
            // 
            this.Nurse_patient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nurse_patient.Location = new System.Drawing.Point(453, 167);
            this.Nurse_patient.Name = "Nurse_patient";
            this.Nurse_patient.Size = new System.Drawing.Size(94, 39);
            this.Nurse_patient.TabIndex = 22;
            this.Nurse_patient.Text = "Paient";
            this.Nurse_patient.UseVisualStyleBackColor = false;
            this.Nurse_patient.Click += new System.EventHandler(this.Nurse_patient_Click);
            // 
            // NurseAddBtn
            // 
            this.NurseAddBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NurseAddBtn.Location = new System.Drawing.Point(82, 348);
            this.NurseAddBtn.Name = "NurseAddBtn";
            this.NurseAddBtn.Size = new System.Drawing.Size(75, 23);
            this.NurseAddBtn.TabIndex = 23;
            this.NurseAddBtn.Text = "Add";
            this.NurseAddBtn.UseVisualStyleBackColor = false;
            this.NurseAddBtn.Click += new System.EventHandler(this.NurseAddBtn_Click);
            // 
            // NurseUpdateBtn
            // 
            this.NurseUpdateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NurseUpdateBtn.Location = new System.Drawing.Point(167, 348);
            this.NurseUpdateBtn.Name = "NurseUpdateBtn";
            this.NurseUpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.NurseUpdateBtn.TabIndex = 24;
            this.NurseUpdateBtn.Text = "Update";
            this.NurseUpdateBtn.UseVisualStyleBackColor = false;
            this.NurseUpdateBtn.Click += new System.EventHandler(this.NurseUpdateBtn_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Delete.Location = new System.Drawing.Point(266, 348);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 25;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // NurseMale
            // 
            this.NurseMale.AutoSize = true;
            this.NurseMale.Location = new System.Drawing.Point(109, 318);
            this.NurseMale.Name = "NurseMale";
            this.NurseMale.Size = new System.Drawing.Size(49, 17);
            this.NurseMale.TabIndex = 26;
            this.NurseMale.Text = "Male";
            this.NurseMale.UseVisualStyleBackColor = true;
            // 
            // NurseFemale
            // 
            this.NurseFemale.AutoSize = true;
            this.NurseFemale.Location = new System.Drawing.Point(167, 318);
            this.NurseFemale.Name = "NurseFemale";
            this.NurseFemale.Size = new System.Drawing.Size(60, 17);
            this.NurseFemale.TabIndex = 27;
            this.NurseFemale.Text = "Female";
            this.NurseFemale.UseVisualStyleBackColor = true;
            // 
            // NurseDeptCompo
            // 
            this.NurseDeptCompo.FormattingEnabled = true;
            this.NurseDeptCompo.Location = new System.Drawing.Point(112, 204);
            this.NurseDeptCompo.Name = "NurseDeptCompo";
            this.NurseDeptCompo.Size = new System.Drawing.Size(115, 21);
            this.NurseDeptCompo.TabIndex = 28;
            this.NurseDeptCompo.SelectedIndexChanged += new System.EventHandler(this.NurseDeptCompo_SelectedIndexChanged);
            // 
            // NurseDepartment
            // 
            this.NurseDepartment.AutoSize = true;
            this.NurseDepartment.Location = new System.Drawing.Point(28, 212);
            this.NurseDepartment.Name = "NurseDepartment";
            this.NurseDepartment.Size = new System.Drawing.Size(62, 13);
            this.NurseDepartment.TabIndex = 29;
            this.NurseDepartment.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Shift";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Room";
            // 
            // ComboRoom
            // 
            this.ComboRoom.FormattingEnabled = true;
            this.ComboRoom.Location = new System.Drawing.Point(109, 236);
            this.ComboRoom.Name = "ComboRoom";
            this.ComboRoom.Size = new System.Drawing.Size(115, 21);
            this.ComboRoom.TabIndex = 33;
            // 
            // PMCheked
            // 
            this.PMCheked.AutoSize = true;
            this.PMCheked.Location = new System.Drawing.Point(109, 295);
            this.PMCheked.Name = "PMCheked";
            this.PMCheked.Size = new System.Drawing.Size(41, 17);
            this.PMCheked.TabIndex = 34;
            this.PMCheked.Text = "Pm";
            this.PMCheked.UseVisualStyleBackColor = true;
            // 
            // AmChecked
            // 
            this.AmChecked.AutoSize = true;
            this.AmChecked.Location = new System.Drawing.Point(167, 295);
            this.AmChecked.Name = "AmChecked";
            this.AmChecked.Size = new System.Drawing.Size(41, 17);
            this.AmChecked.TabIndex = 35;
            this.AmChecked.Text = "Am";
            this.AmChecked.UseVisualStyleBackColor = true;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // DargelistCom
            // 
            this.DargelistCom.FormattingEnabled = true;
            this.DargelistCom.Location = new System.Drawing.Point(106, 268);
            this.DargelistCom.Name = "DargelistCom";
            this.DargelistCom.Size = new System.Drawing.Size(121, 21);
            this.DargelistCom.TabIndex = 36;
            this.DargelistCom.SelectedIndexChanged += new System.EventHandler(this.DargelistCom_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Drage";
            // 
            // NusreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 408);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DargelistCom);
            this.Controls.Add(this.AmChecked);
            this.Controls.Add(this.PMCheked);
            this.Controls.Add(this.ComboRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NurseDepartment);
            this.Controls.Add(this.NurseDeptCompo);
            this.Controls.Add(this.NurseFemale);
            this.Controls.Add(this.NurseMale);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.NurseUpdateBtn);
            this.Controls.Add(this.NurseAddBtn);
            this.Controls.Add(this.Nurse_patient);
            this.Controls.Add(this.Nurse_Back);
            this.Controls.Add(this.Nurse_DrageTime);
            this.Controls.Add(this.Nurse_Room);
            this.Controls.Add(this.Nphone);
            this.Controls.Add(this.NGender);
            this.Controls.Add(this.NAge);
            this.Controls.Add(this.NAddress);
            this.Controls.Add(this.n_phone);
            this.Controls.Add(this.n_age);
            this.Controls.Add(this.n_address);
            this.Controls.Add(this.n_name);
            this.Controls.Add(this.n_id);
            this.Controls.Add(this.NName);
            this.Controls.Add(this.NID);
            this.Controls.Add(this.Nurse);
            this.Name = "NusreForm";
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
        private System.Windows.Forms.TextBox n_age;
        private System.Windows.Forms.TextBox n_phone;
        private System.Windows.Forms.Label NAddress;
        private System.Windows.Forms.Label NAge;
        private System.Windows.Forms.Label NGender;
        private System.Windows.Forms.Label Nphone;
        private System.Windows.Forms.Button Nurse_Room;
        private System.Windows.Forms.Button Nurse_DrageTime;
        private System.Windows.Forms.Button Nurse_Back;
        private System.Windows.Forms.Button Nurse_patient;
        private System.Windows.Forms.Button NurseAddBtn;
        private System.Windows.Forms.Button NurseUpdateBtn;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.CheckBox NurseMale;
        private System.Windows.Forms.CheckBox NurseFemale;
        private System.Windows.Forms.ComboBox NurseDeptCompo;
        private System.Windows.Forms.Label NurseDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboRoom;
        private System.Windows.Forms.CheckBox PMCheked;
        private System.Windows.Forms.CheckBox AmChecked;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.ComboBox DargelistCom;
        private System.Windows.Forms.Label label3;
    }
}