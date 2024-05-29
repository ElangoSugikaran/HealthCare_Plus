namespace HealthCare_Plus
{
    partial class Manage_medication
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
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete_medication = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.cmbPatientID = new System.Windows.Forms.ComboBox();
            this.txtMedicationID = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.cmbDoctorID = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblcheck_in_patient = new System.Windows.Forms.Label();
            this.txtSearch_Medication = new System.Windows.Forms.TextBox();
            this.cmbMedicineDosage = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_search_medication = new System.Windows.Forms.Button();
            this.btn_back_dashboard = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_view_medication = new System.Windows.Forms.Button();
            this.btn_clear_medication = new System.Windows.Forms.Button();
            this.btn_update_medication = new System.Windows.Forms.Button();
            this.btn_insert_medication = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_medication = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbFrequecy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtMediccineCharge = new System.Windows.Forms.TextBox();
            this.lblmedicinecharge = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_medication)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "Medication Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medication ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Name";
            // 
            // btn_delete_medication
            // 
            this.btn_delete_medication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete_medication.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete_medication.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_medication.Location = new System.Drawing.Point(1209, 427);
            this.btn_delete_medication.Name = "btn_delete_medication";
            this.btn_delete_medication.Size = new System.Drawing.Size(159, 50);
            this.btn_delete_medication.TabIndex = 56;
            this.btn_delete_medication.Text = "Delete";
            this.btn_delete_medication.UseVisualStyleBackColor = false;
            this.btn_delete_medication.Click += new System.EventHandler(this.btn_delete_medication_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doctor Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.cmbPatientID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMedicationID);
            this.groupBox1.Controls.Add(this.txtDoctorName);
            this.groupBox1.Controls.Add(this.cmbDoctorID);
            this.groupBox1.Location = new System.Drawing.Point(36, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 168);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medication";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(24, 125);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(142, 22);
            this.txtPatientName.TabIndex = 22;
            // 
            // cmbPatientID
            // 
            this.cmbPatientID.FormattingEnabled = true;
            this.cmbPatientID.Location = new System.Drawing.Point(174, 125);
            this.cmbPatientID.Name = "cmbPatientID";
            this.cmbPatientID.Size = new System.Drawing.Size(69, 24);
            this.cmbPatientID.TabIndex = 21;
            this.cmbPatientID.SelectedIndexChanged += new System.EventHandler(this.cmbPatientID_SelectedIndexChanged);
            // 
            // txtMedicationID
            // 
            this.txtMedicationID.Location = new System.Drawing.Point(22, 57);
            this.txtMedicationID.Name = "txtMedicationID";
            this.txtMedicationID.Size = new System.Drawing.Size(146, 22);
            this.txtMedicationID.TabIndex = 16;
            this.txtMedicationID.Leave += new System.EventHandler(this.txtMedicationID_Leave);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(290, 125);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(142, 22);
            this.txtDoctorName.TabIndex = 17;
            // 
            // cmbDoctorID
            // 
            this.cmbDoctorID.FormattingEnabled = true;
            this.cmbDoctorID.Location = new System.Drawing.Point(438, 125);
            this.cmbDoctorID.Name = "cmbDoctorID";
            this.cmbDoctorID.Size = new System.Drawing.Size(75, 24);
            this.cmbDoctorID.TabIndex = 20;
            this.cmbDoctorID.SelectedIndexChanged += new System.EventHandler(this.cmbDoctorID_SelectedIndexChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(324, 427);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(182, 22);
            this.dtpEndDate.TabIndex = 54;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(74, 427);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(187, 22);
            this.dtpStartDate.TabIndex = 53;
            // 
            // lblcheck_in_patient
            // 
            this.lblcheck_in_patient.AutoSize = true;
            this.lblcheck_in_patient.Location = new System.Drawing.Point(70, 391);
            this.lblcheck_in_patient.Name = "lblcheck_in_patient";
            this.lblcheck_in_patient.Size = new System.Drawing.Size(66, 16);
            this.lblcheck_in_patient.TabIndex = 52;
            this.lblcheck_in_patient.Text = "Start Date";
            // 
            // txtSearch_Medication
            // 
            this.txtSearch_Medication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch_Medication.Location = new System.Drawing.Point(998, 55);
            this.txtSearch_Medication.Multiline = true;
            this.txtSearch_Medication.Name = "txtSearch_Medication";
            this.txtSearch_Medication.Size = new System.Drawing.Size(296, 34);
            this.txtSearch_Medication.TabIndex = 51;
            // 
            // cmbMedicineDosage
            // 
            this.cmbMedicineDosage.FormattingEnabled = true;
            this.cmbMedicineDosage.Items.AddRange(new object[] {
            "100mg",
            "250mg",
            "500mg",
            "850mg"});
            this.cmbMedicineDosage.Location = new System.Drawing.Point(326, 338);
            this.cmbMedicineDosage.Name = "cmbMedicineDosage";
            this.cmbMedicineDosage.Size = new System.Drawing.Size(159, 24);
            this.cmbMedicineDosage.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "End Date";
            // 
            // btn_search_medication
            // 
            this.btn_search_medication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search_medication.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_search_medication.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_medication.Location = new System.Drawing.Point(1300, 55);
            this.btn_search_medication.Name = "btn_search_medication";
            this.btn_search_medication.Size = new System.Drawing.Size(135, 34);
            this.btn_search_medication.TabIndex = 45;
            this.btn_search_medication.Text = "Search";
            this.btn_search_medication.UseVisualStyleBackColor = false;
            this.btn_search_medication.Click += new System.EventHandler(this.btn_search_medication_Click);
            // 
            // btn_back_dashboard
            // 
            this.btn_back_dashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back_dashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_back_dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_dashboard.Location = new System.Drawing.Point(1276, 548);
            this.btn_back_dashboard.Name = "btn_back_dashboard";
            this.btn_back_dashboard.Size = new System.Drawing.Size(159, 50);
            this.btn_back_dashboard.TabIndex = 57;
            this.btn_back_dashboard.Text = "Back";
            this.btn_back_dashboard.UseVisualStyleBackColor = false;
            this.btn_back_dashboard.Click += new System.EventHandler(this.btn_back_dashboard_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(1065, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 0);
            this.button5.TabIndex = 44;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_view_medication
            // 
            this.btn_view_medication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_view_medication.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_medication.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_medication.Location = new System.Drawing.Point(759, 427);
            this.btn_view_medication.Name = "btn_view_medication";
            this.btn_view_medication.Size = new System.Drawing.Size(159, 50);
            this.btn_view_medication.TabIndex = 43;
            this.btn_view_medication.Text = "View";
            this.btn_view_medication.UseVisualStyleBackColor = false;
            this.btn_view_medication.Click += new System.EventHandler(this.btn_view_medication_Click);
            // 
            // btn_clear_medication
            // 
            this.btn_clear_medication.BackColor = System.Drawing.Color.LightGray;
            this.btn_clear_medication.Location = new System.Drawing.Point(449, 587);
            this.btn_clear_medication.Name = "btn_clear_medication";
            this.btn_clear_medication.Size = new System.Drawing.Size(159, 50);
            this.btn_clear_medication.TabIndex = 42;
            this.btn_clear_medication.Text = "Clear";
            this.btn_clear_medication.UseVisualStyleBackColor = false;
            this.btn_clear_medication.Click += new System.EventHandler(this.btn_clear_medication_Click);
            // 
            // btn_update_medication
            // 
            this.btn_update_medication.BackColor = System.Drawing.Color.Thistle;
            this.btn_update_medication.Location = new System.Drawing.Point(264, 587);
            this.btn_update_medication.Name = "btn_update_medication";
            this.btn_update_medication.Size = new System.Drawing.Size(159, 50);
            this.btn_update_medication.TabIndex = 41;
            this.btn_update_medication.Text = "Update";
            this.btn_update_medication.UseVisualStyleBackColor = false;
            this.btn_update_medication.Click += new System.EventHandler(this.btn_update_medication_Click);
            // 
            // btn_insert_medication
            // 
            this.btn_insert_medication.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_insert_medication.Location = new System.Drawing.Point(76, 587);
            this.btn_insert_medication.Name = "btn_insert_medication";
            this.btn_insert_medication.Size = new System.Drawing.Size(159, 50);
            this.btn_insert_medication.TabIndex = 40;
            this.btn_insert_medication.Text = "Insert";
            this.btn_insert_medication.UseVisualStyleBackColor = false;
            this.btn_insert_medication.Click += new System.EventHandler(this.btn_insert_medication_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Medicine Name";
            // 
            // dataGridView_medication
            // 
            this.dataGridView_medication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_medication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_medication.Location = new System.Drawing.Point(633, 111);
            this.dataGridView_medication.Name = "dataGridView_medication";
            this.dataGridView_medication.RowHeadersWidth = 51;
            this.dataGridView_medication.RowTemplate.Height = 24;
            this.dataGridView_medication.Size = new System.Drawing.Size(802, 270);
            this.dataGridView_medication.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 16);
            this.label10.TabIndex = 59;
            this.label10.Text = "Medicine Dosage";
            // 
            // cmbFrequecy
            // 
            this.cmbFrequecy.FormattingEnabled = true;
            this.cmbFrequecy.Items.AddRange(new object[] {
            "Usually taken with meals.",
            "Generally taken once or twice daily before meals.",
            "Can be taken with or without food.",
            "Often taken at the same time each day or once weekly."});
            this.cmbFrequecy.Location = new System.Drawing.Point(74, 509);
            this.cmbFrequecy.Name = "cmbFrequecy";
            this.cmbFrequecy.Size = new System.Drawing.Size(159, 24);
            this.cmbFrequecy.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Frequecy";
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(74, 340);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(142, 22);
            this.txtMedicineName.TabIndex = 23;
            // 
            // txtMediccineCharge
            // 
            this.txtMediccineCharge.Location = new System.Drawing.Point(324, 509);
            this.txtMediccineCharge.Name = "txtMediccineCharge";
            this.txtMediccineCharge.Size = new System.Drawing.Size(142, 22);
            this.txtMediccineCharge.TabIndex = 62;
            // 
            // lblmedicinecharge
            // 
            this.lblmedicinecharge.AutoSize = true;
            this.lblmedicinecharge.Location = new System.Drawing.Point(322, 477);
            this.lblmedicinecharge.Name = "lblmedicinecharge";
            this.lblmedicinecharge.Size = new System.Drawing.Size(107, 16);
            this.lblmedicinecharge.TabIndex = 63;
            this.lblmedicinecharge.Text = "Medicine charge";
            // 
            // Manage_medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1485, 943);
            this.Controls.Add(this.txtMediccineCharge);
            this.Controls.Add(this.lblmedicinecharge);
            this.Controls.Add(this.txtMedicineName);
            this.Controls.Add(this.cmbFrequecy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_delete_medication);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblcheck_in_patient);
            this.Controls.Add(this.txtSearch_Medication);
            this.Controls.Add(this.cmbMedicineDosage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_search_medication);
            this.Controls.Add(this.btn_back_dashboard);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_view_medication);
            this.Controls.Add(this.btn_clear_medication);
            this.Controls.Add(this.btn_update_medication);
            this.Controls.Add(this.btn_insert_medication);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_medication);
            this.Name = "Manage_medication";
            this.Text = "Manage_medication";
            this.Load += new System.EventHandler(this.Manage_medication_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_medication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete_medication;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMedicationID;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.ComboBox cmbDoctorID;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblcheck_in_patient;
        private System.Windows.Forms.TextBox txtSearch_Medication;
        private System.Windows.Forms.ComboBox cmbMedicineDosage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_search_medication;
        private System.Windows.Forms.Button btn_back_dashboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_view_medication;
        private System.Windows.Forms.Button btn_clear_medication;
        private System.Windows.Forms.Button btn_update_medication;
        private System.Windows.Forms.Button btn_insert_medication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_medication;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.ComboBox cmbPatientID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbFrequecy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtMediccineCharge;
        private System.Windows.Forms.Label lblmedicinecharge;
    }
}