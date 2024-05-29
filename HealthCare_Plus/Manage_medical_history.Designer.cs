namespace HealthCare_Plus
{
    partial class Manage_medical_history
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear_medicalhistory = new System.Windows.Forms.Button();
            this.txtSearch_medical_history = new System.Windows.Forms.TextBox();
            this.btn_search_medicalhistory = new System.Windows.Forms.Button();
            this.btn_delete_medicalhistory = new System.Windows.Forms.Button();
            this.btn_view_medicalhistory = new System.Windows.Forms.Button();
            this.btn_update_medicalhistory = new System.Windows.Forms.Button();
            this.btn_insert_medicalhistory = new System.Windows.Forms.Button();
            this.dataGridView_MedicalHistory = new System.Windows.Forms.DataGridView();
            this.lblpatientID = new System.Windows.Forms.Label();
            this.txtMedicalHistoryID = new System.Windows.Forms.TextBox();
            this.btn_back_dashboard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblcontactno = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbDiagnosisDetails = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedicalHistory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Medical History Details";
            // 
            // btn_clear_medicalhistory
            // 
            this.btn_clear_medicalhistory.BackColor = System.Drawing.Color.LightGray;
            this.btn_clear_medicalhistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_medicalhistory.Location = new System.Drawing.Point(425, 511);
            this.btn_clear_medicalhistory.Name = "btn_clear_medicalhistory";
            this.btn_clear_medicalhistory.Size = new System.Drawing.Size(159, 50);
            this.btn_clear_medicalhistory.TabIndex = 53;
            this.btn_clear_medicalhistory.Text = "Clear";
            this.btn_clear_medicalhistory.UseVisualStyleBackColor = false;
            this.btn_clear_medicalhistory.Click += new System.EventHandler(this.btn_clear_medicalhistory_Click);
            // 
            // txtSearch_medical_history
            // 
            this.txtSearch_medical_history.Location = new System.Drawing.Point(1113, 90);
            this.txtSearch_medical_history.Multiline = true;
            this.txtSearch_medical_history.Name = "txtSearch_medical_history";
            this.txtSearch_medical_history.Size = new System.Drawing.Size(193, 34);
            this.txtSearch_medical_history.TabIndex = 50;
            // 
            // btn_search_medicalhistory
            // 
            this.btn_search_medicalhistory.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_search_medicalhistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_medicalhistory.Location = new System.Drawing.Point(1334, 90);
            this.btn_search_medicalhistory.Name = "btn_search_medicalhistory";
            this.btn_search_medicalhistory.Size = new System.Drawing.Size(135, 34);
            this.btn_search_medicalhistory.TabIndex = 49;
            this.btn_search_medicalhistory.Text = "Search";
            this.btn_search_medicalhistory.UseVisualStyleBackColor = false;
            this.btn_search_medicalhistory.Click += new System.EventHandler(this.btn_search_medicalhistory_Click);
            // 
            // btn_delete_medicalhistory
            // 
            this.btn_delete_medicalhistory.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete_medicalhistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_medicalhistory.Location = new System.Drawing.Point(1211, 594);
            this.btn_delete_medicalhistory.Name = "btn_delete_medicalhistory";
            this.btn_delete_medicalhistory.Size = new System.Drawing.Size(159, 50);
            this.btn_delete_medicalhistory.TabIndex = 48;
            this.btn_delete_medicalhistory.Text = "Delete";
            this.btn_delete_medicalhistory.UseVisualStyleBackColor = false;
            this.btn_delete_medicalhistory.Click += new System.EventHandler(this.btn_delete_medicalhistory_Click);
            // 
            // btn_view_medicalhistory
            // 
            this.btn_view_medicalhistory.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_medicalhistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_medicalhistory.Location = new System.Drawing.Point(788, 594);
            this.btn_view_medicalhistory.Name = "btn_view_medicalhistory";
            this.btn_view_medicalhistory.Size = new System.Drawing.Size(159, 50);
            this.btn_view_medicalhistory.TabIndex = 47;
            this.btn_view_medicalhistory.Text = "View";
            this.btn_view_medicalhistory.UseVisualStyleBackColor = false;
            this.btn_view_medicalhistory.Click += new System.EventHandler(this.btn_view_medicalhistory_Click);
            // 
            // btn_update_medicalhistory
            // 
            this.btn_update_medicalhistory.BackColor = System.Drawing.Color.Thistle;
            this.btn_update_medicalhistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_medicalhistory.Location = new System.Drawing.Point(238, 511);
            this.btn_update_medicalhistory.Name = "btn_update_medicalhistory";
            this.btn_update_medicalhistory.Size = new System.Drawing.Size(159, 50);
            this.btn_update_medicalhistory.TabIndex = 46;
            this.btn_update_medicalhistory.Text = "Update";
            this.btn_update_medicalhistory.UseVisualStyleBackColor = false;
            this.btn_update_medicalhistory.Click += new System.EventHandler(this.btn_update_medicalhistory_Click);
            // 
            // btn_insert_medicalhistory
            // 
            this.btn_insert_medicalhistory.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_insert_medicalhistory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_medicalhistory.Location = new System.Drawing.Point(40, 511);
            this.btn_insert_medicalhistory.Name = "btn_insert_medicalhistory";
            this.btn_insert_medicalhistory.Size = new System.Drawing.Size(159, 50);
            this.btn_insert_medicalhistory.TabIndex = 45;
            this.btn_insert_medicalhistory.Text = "Insert";
            this.btn_insert_medicalhistory.UseVisualStyleBackColor = false;
            this.btn_insert_medicalhistory.Click += new System.EventHandler(this.btn_insert_medicalhistory_Click);
            // 
            // dataGridView_MedicalHistory
            // 
            this.dataGridView_MedicalHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MedicalHistory.Location = new System.Drawing.Point(677, 146);
            this.dataGridView_MedicalHistory.Name = "dataGridView_MedicalHistory";
            this.dataGridView_MedicalHistory.RowHeadersWidth = 51;
            this.dataGridView_MedicalHistory.RowTemplate.Height = 24;
            this.dataGridView_MedicalHistory.Size = new System.Drawing.Size(792, 404);
            this.dataGridView_MedicalHistory.TabIndex = 44;
            // 
            // lblpatientID
            // 
            this.lblpatientID.AutoSize = true;
            this.lblpatientID.Location = new System.Drawing.Point(30, 24);
            this.lblpatientID.Name = "lblpatientID";
            this.lblpatientID.Size = new System.Drawing.Size(123, 16);
            this.lblpatientID.TabIndex = 9;
            this.lblpatientID.Text = "Medicine History ID";
            // 
            // txtMedicalHistoryID
            // 
            this.txtMedicalHistoryID.Location = new System.Drawing.Point(31, 55);
            this.txtMedicalHistoryID.Name = "txtMedicalHistoryID";
            this.txtMedicalHistoryID.Size = new System.Drawing.Size(200, 22);
            this.txtMedicalHistoryID.TabIndex = 10;
            this.txtMedicalHistoryID.Leave += new System.EventHandler(this.txtMedicalHistoryID_Leave);
            // 
            // btn_back_dashboard
            // 
            this.btn_back_dashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_back_dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_dashboard.Location = new System.Drawing.Point(1310, 728);
            this.btn_back_dashboard.Name = "btn_back_dashboard";
            this.btn_back_dashboard.Size = new System.Drawing.Size(159, 50);
            this.btn_back_dashboard.TabIndex = 54;
            this.btn_back_dashboard.Text = "Back";
            this.btn_back_dashboard.UseVisualStyleBackColor = false;
            this.btn_back_dashboard.Click += new System.EventHandler(this.btn_back_dashboard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.lblpatientID);
            this.groupBox1.Controls.Add(this.txtMedicalHistoryID);
            this.groupBox1.Controls.Add(this.lblfirstname);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Location = new System.Drawing.Point(51, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 112);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medical History ";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(257, 24);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(88, 16);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "Patient Name";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(257, 54);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(200, 22);
            this.txtPatientName.TabIndex = 7;
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(314, 276);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(200, 22);
            this.txtCondition.TabIndex = 39;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(64, 276);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 38;
            // 
            // lblcontactno
            // 
            this.lblcontactno.AutoSize = true;
            this.lblcontactno.Location = new System.Drawing.Point(311, 245);
            this.lblcontactno.Name = "lblcontactno";
            this.lblcontactno.Size = new System.Drawing.Size(63, 16);
            this.lblcontactno.TabIndex = 34;
            this.lblcontactno.Text = "Condition";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(61, 245);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(36, 16);
            this.lbldob.TabIndex = 33;
            this.lbldob.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Diagnosis Details";
            // 
            // rtbDiagnosisDetails
            // 
            this.rtbDiagnosisDetails.Location = new System.Drawing.Point(64, 377);
            this.rtbDiagnosisDetails.Name = "rtbDiagnosisDetails";
            this.rtbDiagnosisDetails.Size = new System.Drawing.Size(382, 76);
            this.rtbDiagnosisDetails.TabIndex = 57;
            this.rtbDiagnosisDetails.Text = "";
            // 
            // Manage_medical_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1517, 895);
            this.Controls.Add(this.rtbDiagnosisDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear_medicalhistory);
            this.Controls.Add(this.txtSearch_medical_history);
            this.Controls.Add(this.btn_search_medicalhistory);
            this.Controls.Add(this.btn_delete_medicalhistory);
            this.Controls.Add(this.btn_view_medicalhistory);
            this.Controls.Add(this.btn_update_medicalhistory);
            this.Controls.Add(this.btn_insert_medicalhistory);
            this.Controls.Add(this.dataGridView_MedicalHistory);
            this.Controls.Add(this.btn_back_dashboard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblcontactno);
            this.Controls.Add(this.lbldob);
            this.Name = "Manage_medical_history";
            this.Text = "Manage_medical_history";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MedicalHistory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear_medicalhistory;
        private System.Windows.Forms.TextBox txtSearch_medical_history;
        private System.Windows.Forms.Button btn_search_medicalhistory;
        private System.Windows.Forms.Button btn_delete_medicalhistory;
        private System.Windows.Forms.Button btn_view_medicalhistory;
        private System.Windows.Forms.Button btn_update_medicalhistory;
        private System.Windows.Forms.Button btn_insert_medicalhistory;
        private System.Windows.Forms.DataGridView dataGridView_MedicalHistory;
        private System.Windows.Forms.Label lblpatientID;
        private System.Windows.Forms.TextBox txtMedicalHistoryID;
        private System.Windows.Forms.Button btn_back_dashboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblcontactno;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDiagnosisDetails;
    }
}