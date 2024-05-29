namespace HealthCare_Plus
{
    partial class Manage_doctor
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
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblspecialization = new System.Windows.Forms.Label();
            this.lblqualification = new System.Windows.Forms.Label();
            this.lblavailability_schedule = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.dtpAvailabilitySchedule = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_doctor = new System.Windows.Forms.DataGridView();
            this.btn_insert_doctor = new System.Windows.Forms.Button();
            this.btn_update_doctor = new System.Windows.Forms.Button();
            this.btn_view_doctor = new System.Windows.Forms.Button();
            this.btn_delete_doctor = new System.Windows.Forms.Button();
            this.btn_search_doctor = new System.Windows.Forms.Button();
            this.txtSearchDoctor = new System.Windows.Forms.TextBox();
            this.lbldoctorID = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.lblyear_of_experiences = new System.Windows.Forms.Label();
            this.txtYearOfExperiences = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblcontactno = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.lbladdress = new System.Windows.Forms.Label();
            this.btn_clear_doctor = new System.Windows.Forms.Button();
            this.cmbQualification = new System.Windows.Forms.ComboBox();
            this.btn_back_dashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doctor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(23, 96);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(72, 16);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "First Name";
            // 
            // lblspecialization
            // 
            this.lblspecialization.AutoSize = true;
            this.lblspecialization.Location = new System.Drawing.Point(56, 272);
            this.lblspecialization.Name = "lblspecialization";
            this.lblspecialization.Size = new System.Drawing.Size(91, 16);
            this.lblspecialization.TabIndex = 1;
            this.lblspecialization.Text = "Specialization";
            // 
            // lblqualification
            // 
            this.lblqualification.AutoSize = true;
            this.lblqualification.Location = new System.Drawing.Point(286, 272);
            this.lblqualification.Name = "lblqualification";
            this.lblqualification.Size = new System.Drawing.Size(80, 16);
            this.lblqualification.TabIndex = 2;
            this.lblqualification.Text = "Qualification";
            // 
            // lblavailability_schedule
            // 
            this.lblavailability_schedule.AutoSize = true;
            this.lblavailability_schedule.Location = new System.Drawing.Point(56, 356);
            this.lblavailability_schedule.Name = "lblavailability_schedule";
            this.lblavailability_schedule.Size = new System.Drawing.Size(132, 16);
            this.lblavailability_schedule.TabIndex = 7;
            this.lblavailability_schedule.Text = "Availability Schedule";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(23, 129);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(166, 22);
            this.txtFirstName.TabIndex = 9;
            // 
            // cmbSpecialization
            // 
            this.cmbSpecialization.FormattingEnabled = true;
            this.cmbSpecialization.Items.AddRange(new object[] {
            "Cardiology",
            "Dermatology",
            "Endocrinology",
            "Gastroenterology",
            "Hematology",
            "Neurology",
            "Oncology",
            "Pediatrics",
            "Psychiatry",
            "Radiology"});
            this.cmbSpecialization.Location = new System.Drawing.Point(63, 303);
            this.cmbSpecialization.Name = "cmbSpecialization";
            this.cmbSpecialization.Size = new System.Drawing.Size(166, 24);
            this.cmbSpecialization.TabIndex = 13;
            // 
            // dtpAvailabilitySchedule
            // 
            this.dtpAvailabilitySchedule.Location = new System.Drawing.Point(59, 386);
            this.dtpAvailabilitySchedule.Name = "dtpAvailabilitySchedule";
            this.dtpAvailabilitySchedule.Size = new System.Drawing.Size(172, 22);
            this.dtpAvailabilitySchedule.TabIndex = 14;
            // 
            // dataGridView_doctor
            // 
            this.dataGridView_doctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doctor.Location = new System.Drawing.Point(782, 86);
            this.dataGridView_doctor.Name = "dataGridView_doctor";
            this.dataGridView_doctor.RowHeadersWidth = 51;
            this.dataGridView_doctor.RowTemplate.Height = 24;
            this.dataGridView_doctor.Size = new System.Drawing.Size(628, 400);
            this.dataGridView_doctor.TabIndex = 18;
            // 
            // btn_insert_doctor
            // 
            this.btn_insert_doctor.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_insert_doctor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_doctor.Location = new System.Drawing.Point(63, 634);
            this.btn_insert_doctor.Name = "btn_insert_doctor";
            this.btn_insert_doctor.Size = new System.Drawing.Size(159, 50);
            this.btn_insert_doctor.TabIndex = 19;
            this.btn_insert_doctor.Text = "Insert";
            this.btn_insert_doctor.UseVisualStyleBackColor = false;
            this.btn_insert_doctor.Click += new System.EventHandler(this.btn_insert_doctor_Click);
            // 
            // btn_update_doctor
            // 
            this.btn_update_doctor.BackColor = System.Drawing.Color.Thistle;
            this.btn_update_doctor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_doctor.Location = new System.Drawing.Point(259, 634);
            this.btn_update_doctor.Name = "btn_update_doctor";
            this.btn_update_doctor.Size = new System.Drawing.Size(159, 50);
            this.btn_update_doctor.TabIndex = 20;
            this.btn_update_doctor.Text = "Update";
            this.btn_update_doctor.UseVisualStyleBackColor = false;
            this.btn_update_doctor.Click += new System.EventHandler(this.btn_update_doctor_Click);
            // 
            // btn_view_doctor
            // 
            this.btn_view_doctor.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_doctor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_doctor.Location = new System.Drawing.Point(823, 527);
            this.btn_view_doctor.Name = "btn_view_doctor";
            this.btn_view_doctor.Size = new System.Drawing.Size(159, 50);
            this.btn_view_doctor.TabIndex = 21;
            this.btn_view_doctor.Text = "View";
            this.btn_view_doctor.UseVisualStyleBackColor = false;
            this.btn_view_doctor.Click += new System.EventHandler(this.btn_view_doctor_Click);
            // 
            // btn_delete_doctor
            // 
            this.btn_delete_doctor.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete_doctor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_doctor.Location = new System.Drawing.Point(1207, 527);
            this.btn_delete_doctor.Name = "btn_delete_doctor";
            this.btn_delete_doctor.Size = new System.Drawing.Size(159, 50);
            this.btn_delete_doctor.TabIndex = 22;
            this.btn_delete_doctor.Text = "Delete";
            this.btn_delete_doctor.UseVisualStyleBackColor = false;
            this.btn_delete_doctor.Click += new System.EventHandler(this.btn_delete_doctor_Click);
            // 
            // btn_search_doctor
            // 
            this.btn_search_doctor.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_search_doctor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_doctor.Location = new System.Drawing.Point(1275, 35);
            this.btn_search_doctor.Name = "btn_search_doctor";
            this.btn_search_doctor.Size = new System.Drawing.Size(135, 34);
            this.btn_search_doctor.TabIndex = 23;
            this.btn_search_doctor.Text = "Search";
            this.btn_search_doctor.UseVisualStyleBackColor = false;
            this.btn_search_doctor.Click += new System.EventHandler(this.btn_search_doctor_Click);
            // 
            // txtSearchDoctor
            // 
            this.txtSearchDoctor.Location = new System.Drawing.Point(1100, 35);
            this.txtSearchDoctor.Multiline = true;
            this.txtSearchDoctor.Name = "txtSearchDoctor";
            this.txtSearchDoctor.Size = new System.Drawing.Size(169, 34);
            this.txtSearchDoctor.TabIndex = 24;
            // 
            // lbldoctorID
            // 
            this.lbldoctorID.AutoSize = true;
            this.lbldoctorID.Location = new System.Drawing.Point(18, 25);
            this.lbldoctorID.Name = "lbldoctorID";
            this.lbldoctorID.Size = new System.Drawing.Size(60, 16);
            this.lbldoctorID.TabIndex = 25;
            this.lbldoctorID.Text = "DoctorID";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Location = new System.Drawing.Point(241, 96);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(72, 16);
            this.lbllastname.TabIndex = 26;
            this.lbllastname.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(244, 129);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(163, 22);
            this.txtLastName.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.txtDoctorID);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lbldoctorID);
            this.groupBox1.Controls.Add(this.lblfirstname);
            this.groupBox1.Controls.Add(this.lbllastname);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Location = new System.Drawing.Point(40, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 183);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor ";
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Location = new System.Drawing.Point(19, 54);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.Size = new System.Drawing.Size(166, 22);
            this.txtDoctorID.TabIndex = 28;
            this.txtDoctorID.Leave += new System.EventHandler(this.txtDoctorID_Leave);
            // 
            // lblyear_of_experiences
            // 
            this.lblyear_of_experiences.AutoSize = true;
            this.lblyear_of_experiences.Location = new System.Drawing.Point(286, 356);
            this.lblyear_of_experiences.Name = "lblyear_of_experiences";
            this.lblyear_of_experiences.Size = new System.Drawing.Size(128, 16);
            this.lblyear_of_experiences.TabIndex = 30;
            this.lblyear_of_experiences.Text = "Year of Experiences";
            // 
            // txtYearOfExperiences
            // 
            this.txtYearOfExperiences.Location = new System.Drawing.Point(289, 386);
            this.txtYearOfExperiences.Name = "txtYearOfExperiences";
            this.txtYearOfExperiences.Size = new System.Drawing.Size(160, 22);
            this.txtYearOfExperiences.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 515);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(59, 534);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 22);
            this.txtEmail.TabIndex = 34;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(287, 462);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(160, 22);
            this.txtContactNo.TabIndex = 37;
            // 
            // lblcontactno
            // 
            this.lblcontactno.AutoSize = true;
            this.lblcontactno.Location = new System.Drawing.Point(284, 430);
            this.lblcontactno.Name = "lblcontactno";
            this.lblcontactno.Size = new System.Drawing.Size(73, 16);
            this.lblcontactno.TabIndex = 36;
            this.lblcontactno.Text = "Contact No";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(57, 462);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(170, 24);
            this.cmbGender.TabIndex = 38;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(289, 542);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(361, 58);
            this.rtbAddress.TabIndex = 39;
            this.rtbAddress.Text = "";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(54, 432);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(52, 16);
            this.lblgender.TabIndex = 40;
            this.lblgender.Text = "Gender";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(56, 515);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(41, 16);
            this.lblemail.TabIndex = 41;
            this.lblemail.Text = "Email";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(485, 444);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(34, 16);
            this.lbldob.TabIndex = 42;
            this.lbldob.Text = "DoB";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Location = new System.Drawing.Point(488, 464);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(162, 22);
            this.dtpDoB.TabIndex = 43;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(286, 515);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(58, 16);
            this.lbladdress.TabIndex = 45;
            this.lbladdress.Text = "Address";
            // 
            // btn_clear_doctor
            // 
            this.btn_clear_doctor.BackColor = System.Drawing.Color.LightGray;
            this.btn_clear_doctor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_doctor.Location = new System.Drawing.Point(455, 634);
            this.btn_clear_doctor.Name = "btn_clear_doctor";
            this.btn_clear_doctor.Size = new System.Drawing.Size(159, 50);
            this.btn_clear_doctor.TabIndex = 47;
            this.btn_clear_doctor.Text = "Clear";
            this.btn_clear_doctor.UseVisualStyleBackColor = false;
            this.btn_clear_doctor.Click += new System.EventHandler(this.btn_clear_doctor_Click);
            // 
            // cmbQualification
            // 
            this.cmbQualification.FormattingEnabled = true;
            this.cmbQualification.Items.AddRange(new object[] {
            "MD (Doctor of Medicine)",
            "MBBS (Bachelor of Medicine, Bachelor of Surgery)",
            "MS (Master of Surgery)",
            "DM (Doctorate of Medicine)",
            "DNB (Diplomate of National Board)",
            "Ph.D. in Medical Sciences",
            "MCh (Master of Chirurgiae)",
            "FRCS (Fellow of the Royal College of Surgeons)",
            "MRCP (Member of the Royal College of Physicians)"});
            this.cmbQualification.Location = new System.Drawing.Point(284, 303);
            this.cmbQualification.Name = "cmbQualification";
            this.cmbQualification.Size = new System.Drawing.Size(163, 24);
            this.cmbQualification.TabIndex = 49;
            // 
            // btn_back_dashboard
            // 
            this.btn_back_dashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_back_dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_dashboard.Location = new System.Drawing.Point(1264, 634);
            this.btn_back_dashboard.Name = "btn_back_dashboard";
            this.btn_back_dashboard.Size = new System.Drawing.Size(146, 50);
            this.btn_back_dashboard.TabIndex = 50;
            this.btn_back_dashboard.Text = "Back";
            this.btn_back_dashboard.UseVisualStyleBackColor = false;
            this.btn_back_dashboard.Click += new System.EventHandler(this.btn_back_dashboard_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Doctor Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.cmbStatus.Location = new System.Drawing.Point(488, 386);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(159, 24);
            this.cmbStatus.TabIndex = 53;
            // 
            // Manage_doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1442, 752);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back_dashboard);
            this.Controls.Add(this.cmbQualification);
            this.Controls.Add(this.btn_clear_doctor);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.dtpDoB);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.lblcontactno);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYearOfExperiences);
            this.Controls.Add(this.lblyear_of_experiences);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearchDoctor);
            this.Controls.Add(this.btn_search_doctor);
            this.Controls.Add(this.btn_delete_doctor);
            this.Controls.Add(this.btn_view_doctor);
            this.Controls.Add(this.btn_update_doctor);
            this.Controls.Add(this.btn_insert_doctor);
            this.Controls.Add(this.dataGridView_doctor);
            this.Controls.Add(this.dtpAvailabilitySchedule);
            this.Controls.Add(this.cmbSpecialization);
            this.Controls.Add(this.lblavailability_schedule);
            this.Controls.Add(this.lblqualification);
            this.Controls.Add(this.lblspecialization);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Manage_doctor";
            this.Text = "Manage_doctor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doctor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblspecialization;
        private System.Windows.Forms.Label lblqualification;
        private System.Windows.Forms.Label lblavailability_schedule;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cmbSpecialization;
        private System.Windows.Forms.DateTimePicker dtpAvailabilitySchedule;
        private System.Windows.Forms.DataGridView dataGridView_doctor;
        private System.Windows.Forms.Button btn_insert_doctor;
        private System.Windows.Forms.Button btn_update_doctor;
        private System.Windows.Forms.Button btn_view_doctor;
        private System.Windows.Forms.Button btn_delete_doctor;
        private System.Windows.Forms.Button btn_search_doctor;
        private System.Windows.Forms.TextBox txtSearchDoctor;
        private System.Windows.Forms.Label lbldoctorID;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Label lblyear_of_experiences;
        private System.Windows.Forms.TextBox txtYearOfExperiences;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblcontactno;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Button btn_clear_doctor;
        private System.Windows.Forms.ComboBox cmbQualification;
        private System.Windows.Forms.Button btn_back_dashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}