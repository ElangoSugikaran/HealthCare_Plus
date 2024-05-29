namespace HealthCare_Plus
{
    partial class Manage_appointment
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView_Appointment = new System.Windows.Forms.DataGridView();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearchAppointment = new System.Windows.Forms.TextBox();
            this.dataGridView_doctor_appointment = new System.Windows.Forms.DataGridView();
            this.cmbDoctorName = new System.Windows.Forms.ComboBox();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpAvailability_Schedule = new System.Windows.Forms.DateTimePicker();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDoctorID = new System.Windows.Forms.ComboBox();
            this.cmbPatientID = new System.Windows.Forms.ComboBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtAppointmentID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAppointmentCharge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbStaus = new System.Windows.Forms.ComboBox();
            this.rtbPurpose = new System.Windows.Forms.RichTextBox();
            this.btn_clear_appointment = new System.Windows.Forms.Button();
            this.btn_update_appointment = new System.Windows.Forms.Button();
            this.btn_insert_appointment = new System.Windows.Forms.Button();
            this.btn_back_dashboard = new System.Windows.Forms.Button();
            this.btn_view_appointment = new System.Windows.Forms.Button();
            this.btn_delete_appointment = new System.Windows.Forms.Button();
            this.btn_search_appointment = new System.Windows.Forms.Button();
            this.btn_search_doctor = new System.Windows.Forms.Button();
            this.btn_view_docoter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doctor_appointment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointment Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Purpose";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Status";
            // 
            // dataGridView_Appointment
            // 
            this.dataGridView_Appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Appointment.Location = new System.Drawing.Point(679, 78);
            this.dataGridView_Appointment.Name = "dataGridView_Appointment";
            this.dataGridView_Appointment.RowHeadersWidth = 51;
            this.dataGridView_Appointment.RowTemplate.Height = 24;
            this.dataGridView_Appointment.Size = new System.Drawing.Size(770, 231);
            this.dataGridView_Appointment.TabIndex = 6;
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(50, 314);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(200, 22);
            this.dtpAppointmentDate.TabIndex = 19;
            // 
            // txtSearchAppointment
            // 
            this.txtSearchAppointment.Location = new System.Drawing.Point(1138, 39);
            this.txtSearchAppointment.Name = "txtSearchAppointment";
            this.txtSearchAppointment.Size = new System.Drawing.Size(152, 22);
            this.txtSearchAppointment.TabIndex = 20;
            // 
            // dataGridView_doctor_appointment
            // 
            this.dataGridView_doctor_appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_doctor_appointment.Location = new System.Drawing.Point(581, 564);
            this.dataGridView_doctor_appointment.Name = "dataGridView_doctor_appointment";
            this.dataGridView_doctor_appointment.RowHeadersWidth = 51;
            this.dataGridView_doctor_appointment.RowTemplate.Height = 24;
            this.dataGridView_doctor_appointment.Size = new System.Drawing.Size(892, 261);
            this.dataGridView_doctor_appointment.TabIndex = 21;
            // 
            // cmbDoctorName
            // 
            this.cmbDoctorName.FormattingEnabled = true;
            this.cmbDoctorName.Location = new System.Drawing.Point(581, 517);
            this.cmbDoctorName.Name = "cmbDoctorName";
            this.cmbDoctorName.Size = new System.Drawing.Size(162, 24);
            this.cmbDoctorName.TabIndex = 22;
            // 
            // cmbSpecialization
            // 
            this.cmbSpecialization.FormattingEnabled = true;
            this.cmbSpecialization.Location = new System.Drawing.Point(762, 516);
            this.cmbSpecialization.Name = "cmbSpecialization";
            this.cmbSpecialization.Size = new System.Drawing.Size(153, 24);
            this.cmbSpecialization.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Doctor Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(759, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "Specialization";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(930, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Availability Schedule";
            // 
            // dtpAvailability_Schedule
            // 
            this.dtpAvailability_Schedule.Location = new System.Drawing.Point(933, 517);
            this.dtpAvailability_Schedule.Name = "dtpAvailability_Schedule";
            this.dtpAvailability_Schedule.Size = new System.Drawing.Size(184, 22);
            this.dtpAvailability_Schedule.TabIndex = 30;
            this.dtpAvailability_Schedule.TabStop = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Scheduled",
            "Re-Scheduled",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(50, 419);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(189, 24);
            this.cmbStatus.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.cmbDoctorID);
            this.groupBox1.Controls.Add(this.cmbPatientID);
            this.groupBox1.Controls.Add(this.txtDoctorName);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.txtAppointmentID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 184);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment";
            // 
            // cmbDoctorID
            // 
            this.cmbDoctorID.FormattingEnabled = true;
            this.cmbDoctorID.Location = new System.Drawing.Point(392, 78);
            this.cmbDoctorID.Name = "cmbDoctorID";
            this.cmbDoctorID.Size = new System.Drawing.Size(121, 24);
            this.cmbDoctorID.TabIndex = 26;
            this.cmbDoctorID.SelectedIndexChanged += new System.EventHandler(this.cmbDoctorID_SelectedIndexChanged);
            // 
            // cmbPatientID
            // 
            this.cmbPatientID.FormattingEnabled = true;
            this.cmbPatientID.Location = new System.Drawing.Point(138, 78);
            this.cmbPatientID.Name = "cmbPatientID";
            this.cmbPatientID.Size = new System.Drawing.Size(121, 24);
            this.cmbPatientID.TabIndex = 25;
            this.cmbPatientID.SelectedIndexChanged += new System.EventHandler(this.cmbPatientID_SelectedIndexChanged);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(290, 129);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(223, 22);
            this.txtDoctorName.TabIndex = 24;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(29, 129);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(230, 22);
            this.txtPatientName.TabIndex = 23;
            // 
            // txtAppointmentID
            // 
            this.txtAppointmentID.Location = new System.Drawing.Point(135, 33);
            this.txtAppointmentID.Name = "txtAppointmentID";
            this.txtAppointmentID.Size = new System.Drawing.Size(121, 22);
            this.txtAppointmentID.TabIndex = 22;
            this.txtAppointmentID.Leave += new System.EventHandler(this.txtAppointmentID_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Doctor Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Patient Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Appointment id";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 23);
            this.label10.TabIndex = 35;
            this.label10.Text = "Appointment Details";
            // 
            // txtAppointmentCharge
            // 
            this.txtAppointmentCharge.Location = new System.Drawing.Point(311, 421);
            this.txtAppointmentCharge.Name = "txtAppointmentCharge";
            this.txtAppointmentCharge.Size = new System.Drawing.Size(223, 22);
            this.txtAppointmentCharge.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(308, 391);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Appointment Charge";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1133, 485);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 39;
            this.label12.Text = "Status";
            // 
            // cmbStaus
            // 
            this.cmbStaus.FormattingEnabled = true;
            this.cmbStaus.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.cmbStaus.Location = new System.Drawing.Point(1136, 516);
            this.cmbStaus.Name = "cmbStaus";
            this.cmbStaus.Size = new System.Drawing.Size(148, 24);
            this.cmbStaus.TabIndex = 38;
            // 
            // rtbPurpose
            // 
            this.rtbPurpose.Location = new System.Drawing.Point(311, 314);
            this.rtbPurpose.Name = "rtbPurpose";
            this.rtbPurpose.Size = new System.Drawing.Size(269, 52);
            this.rtbPurpose.TabIndex = 40;
            this.rtbPurpose.Text = "";
            // 
            // btn_clear_appointment
            // 
            this.btn_clear_appointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clear_appointment.BackColor = System.Drawing.Color.LightGray;
            this.btn_clear_appointment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_appointment.Location = new System.Drawing.Point(365, 583);
            this.btn_clear_appointment.Name = "btn_clear_appointment";
            this.btn_clear_appointment.Size = new System.Drawing.Size(159, 50);
            this.btn_clear_appointment.TabIndex = 43;
            this.btn_clear_appointment.Text = "Clear";
            this.btn_clear_appointment.UseVisualStyleBackColor = false;
            this.btn_clear_appointment.Click += new System.EventHandler(this.btn_clear_appointment_Click);
            // 
            // btn_update_appointment
            // 
            this.btn_update_appointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_update_appointment.BackColor = System.Drawing.Color.Thistle;
            this.btn_update_appointment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_appointment.Location = new System.Drawing.Point(195, 583);
            this.btn_update_appointment.Name = "btn_update_appointment";
            this.btn_update_appointment.Size = new System.Drawing.Size(159, 50);
            this.btn_update_appointment.TabIndex = 42;
            this.btn_update_appointment.Text = "Update";
            this.btn_update_appointment.UseVisualStyleBackColor = false;
            this.btn_update_appointment.Click += new System.EventHandler(this.btn_update_appointment_Click);
            // 
            // btn_insert_appointment
            // 
            this.btn_insert_appointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_insert_appointment.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_insert_appointment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_appointment.ForeColor = System.Drawing.Color.Black;
            this.btn_insert_appointment.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_insert_appointment.Location = new System.Drawing.Point(26, 583);
            this.btn_insert_appointment.Name = "btn_insert_appointment";
            this.btn_insert_appointment.Size = new System.Drawing.Size(159, 50);
            this.btn_insert_appointment.TabIndex = 41;
            this.btn_insert_appointment.Text = "Insert";
            this.btn_insert_appointment.UseVisualStyleBackColor = false;
            this.btn_insert_appointment.Click += new System.EventHandler(this.btn_insert_appointment_Click);
            // 
            // btn_back_dashboard
            // 
            this.btn_back_dashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back_dashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_back_dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_dashboard.Location = new System.Drawing.Point(26, 775);
            this.btn_back_dashboard.Name = "btn_back_dashboard";
            this.btn_back_dashboard.Size = new System.Drawing.Size(159, 50);
            this.btn_back_dashboard.TabIndex = 46;
            this.btn_back_dashboard.Text = "Back";
            this.btn_back_dashboard.UseVisualStyleBackColor = false;
            this.btn_back_dashboard.Click += new System.EventHandler(this.btn_back_dashboard_Click);
            // 
            // btn_view_appointment
            // 
            this.btn_view_appointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_view_appointment.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_appointment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_appointment.Location = new System.Drawing.Point(766, 342);
            this.btn_view_appointment.Name = "btn_view_appointment";
            this.btn_view_appointment.Size = new System.Drawing.Size(163, 50);
            this.btn_view_appointment.TabIndex = 45;
            this.btn_view_appointment.Text = "View";
            this.btn_view_appointment.UseVisualStyleBackColor = false;
            this.btn_view_appointment.Click += new System.EventHandler(this.btn_view_appointment_Click);
            // 
            // btn_delete_appointment
            // 
            this.btn_delete_appointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_appointment.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete_appointment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_appointment.Location = new System.Drawing.Point(1193, 342);
            this.btn_delete_appointment.Name = "btn_delete_appointment";
            this.btn_delete_appointment.Size = new System.Drawing.Size(159, 50);
            this.btn_delete_appointment.TabIndex = 44;
            this.btn_delete_appointment.Text = "Delete";
            this.btn_delete_appointment.UseVisualStyleBackColor = false;
            this.btn_delete_appointment.Click += new System.EventHandler(this.btn_delete_appointment_Click);
            // 
            // btn_search_appointment
            // 
            this.btn_search_appointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_appointment.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_search_appointment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_appointment.Location = new System.Drawing.Point(1296, 30);
            this.btn_search_appointment.Name = "btn_search_appointment";
            this.btn_search_appointment.Size = new System.Drawing.Size(135, 34);
            this.btn_search_appointment.TabIndex = 47;
            this.btn_search_appointment.Text = "Search";
            this.btn_search_appointment.UseVisualStyleBackColor = false;
            this.btn_search_appointment.Click += new System.EventHandler(this.btn_search_appointment_Click);
            // 
            // btn_search_doctor
            // 
            this.btn_search_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_doctor.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_search_doctor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_doctor.Location = new System.Drawing.Point(1328, 512);
            this.btn_search_doctor.Name = "btn_search_doctor";
            this.btn_search_doctor.Size = new System.Drawing.Size(135, 34);
            this.btn_search_doctor.TabIndex = 48;
            this.btn_search_doctor.Text = "Search";
            this.btn_search_doctor.UseVisualStyleBackColor = false;
            this.btn_search_doctor.Click += new System.EventHandler(this.btn_search_doctor_Click);
            // 
            // btn_view_docoter
            // 
            this.btn_view_docoter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_view_docoter.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_docoter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_docoter.Location = new System.Drawing.Point(1328, 451);
            this.btn_view_docoter.Name = "btn_view_docoter";
            this.btn_view_docoter.Size = new System.Drawing.Size(135, 50);
            this.btn_view_docoter.TabIndex = 49;
            this.btn_view_docoter.Text = "View";
            this.btn_view_docoter.UseVisualStyleBackColor = false;
            this.btn_view_docoter.Click += new System.EventHandler(this.btn_view_docoter_Click);
            // 
            // Manage_appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1485, 943);
            this.Controls.Add(this.btn_view_docoter);
            this.Controls.Add(this.btn_search_doctor);
            this.Controls.Add(this.btn_search_appointment);
            this.Controls.Add(this.btn_back_dashboard);
            this.Controls.Add(this.btn_view_appointment);
            this.Controls.Add(this.btn_delete_appointment);
            this.Controls.Add(this.btn_clear_appointment);
            this.Controls.Add(this.btn_update_appointment);
            this.Controls.Add(this.btn_insert_appointment);
            this.Controls.Add(this.rtbPurpose);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbStaus);
            this.Controls.Add(this.txtAppointmentCharge);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.dtpAvailability_Schedule);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSpecialization);
            this.Controls.Add(this.cmbDoctorName);
            this.Controls.Add(this.dataGridView_doctor_appointment);
            this.Controls.Add(this.txtSearchAppointment);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.dataGridView_Appointment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.MinimumSize = new System.Drawing.Size(1503, 990);
            this.Name = "Manage_appointment";
            this.Text = "Manage_appointment";
            this.Load += new System.EventHandler(this.Manage_appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doctor_appointment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_Appointment;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.TextBox txtSearchAppointment;
        private System.Windows.Forms.DataGridView dataGridView_doctor_appointment;
        private System.Windows.Forms.ComboBox cmbDoctorName;
        private System.Windows.Forms.ComboBox cmbSpecialization;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpAvailability_Schedule;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDoctorID;
        private System.Windows.Forms.ComboBox cmbPatientID;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtAppointmentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAppointmentCharge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbStaus;
        private System.Windows.Forms.RichTextBox rtbPurpose;
        private System.Windows.Forms.Button btn_clear_appointment;
        private System.Windows.Forms.Button btn_update_appointment;
        private System.Windows.Forms.Button btn_insert_appointment;
        private System.Windows.Forms.Button btn_back_dashboard;
        private System.Windows.Forms.Button btn_view_appointment;
        private System.Windows.Forms.Button btn_delete_appointment;
        private System.Windows.Forms.Button btn_search_appointment;
        private System.Windows.Forms.Button btn_search_doctor;
        private System.Windows.Forms.Button btn_view_docoter;
    }
}