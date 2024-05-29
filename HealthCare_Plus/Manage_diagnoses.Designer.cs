namespace HealthCare_Plus
{
    partial class Manage_diagnoses
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
            this.btn_clear_diagnoses = new System.Windows.Forms.Button();
            this.txtSearch_Diagnoses = new System.Windows.Forms.TextBox();
            this.btn_search_diagnoses = new System.Windows.Forms.Button();
            this.btn_delete_diagnoses = new System.Windows.Forms.Button();
            this.btn_view_diagnoses = new System.Windows.Forms.Button();
            this.btn_update_diagnoses = new System.Windows.Forms.Button();
            this.btn_insert_diagnoses = new System.Windows.Forms.Button();
            this.dataGridView_diagnoses = new System.Windows.Forms.DataGridView();
            this.lblpatientID = new System.Windows.Forms.Label();
            this.txtDiagnosesID = new System.Windows.Forms.TextBox();
            this.btn_back_dashboard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPatientID_diagmosis = new System.Windows.Forms.ComboBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.rtbDiagnosesDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_diagnoses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Diagnoses Details";
            // 
            // btn_clear_diagnoses
            // 
            this.btn_clear_diagnoses.BackColor = System.Drawing.Color.LightGray;
            this.btn_clear_diagnoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_diagnoses.Location = new System.Drawing.Point(439, 675);
            this.btn_clear_diagnoses.Name = "btn_clear_diagnoses";
            this.btn_clear_diagnoses.Size = new System.Drawing.Size(159, 50);
            this.btn_clear_diagnoses.TabIndex = 53;
            this.btn_clear_diagnoses.Text = "Clear";
            this.btn_clear_diagnoses.UseVisualStyleBackColor = false;
            this.btn_clear_diagnoses.Click += new System.EventHandler(this.btn_clear_diagnoses_Click);
            // 
            // txtSearch_Diagnoses
            // 
            this.txtSearch_Diagnoses.Location = new System.Drawing.Point(1103, 39);
            this.txtSearch_Diagnoses.Multiline = true;
            this.txtSearch_Diagnoses.Name = "txtSearch_Diagnoses";
            this.txtSearch_Diagnoses.Size = new System.Drawing.Size(193, 34);
            this.txtSearch_Diagnoses.TabIndex = 50;
            // 
            // btn_search_diagnoses
            // 
            this.btn_search_diagnoses.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_search_diagnoses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_diagnoses.Location = new System.Drawing.Point(1324, 39);
            this.btn_search_diagnoses.Name = "btn_search_diagnoses";
            this.btn_search_diagnoses.Size = new System.Drawing.Size(135, 34);
            this.btn_search_diagnoses.TabIndex = 49;
            this.btn_search_diagnoses.Text = "Search";
            this.btn_search_diagnoses.UseVisualStyleBackColor = false;
            this.btn_search_diagnoses.Click += new System.EventHandler(this.btn_search_diagnoses_Click);
            // 
            // btn_delete_diagnoses
            // 
            this.btn_delete_diagnoses.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete_diagnoses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_diagnoses.Location = new System.Drawing.Point(1161, 549);
            this.btn_delete_diagnoses.Name = "btn_delete_diagnoses";
            this.btn_delete_diagnoses.Size = new System.Drawing.Size(159, 50);
            this.btn_delete_diagnoses.TabIndex = 48;
            this.btn_delete_diagnoses.Text = "Delete";
            this.btn_delete_diagnoses.UseVisualStyleBackColor = false;
            this.btn_delete_diagnoses.Click += new System.EventHandler(this.btn_delete_diagnoses_Click);
            // 
            // btn_view_diagnoses
            // 
            this.btn_view_diagnoses.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_diagnoses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_diagnoses.Location = new System.Drawing.Point(738, 549);
            this.btn_view_diagnoses.Name = "btn_view_diagnoses";
            this.btn_view_diagnoses.Size = new System.Drawing.Size(159, 50);
            this.btn_view_diagnoses.TabIndex = 47;
            this.btn_view_diagnoses.Text = "View";
            this.btn_view_diagnoses.UseVisualStyleBackColor = false;
            this.btn_view_diagnoses.Click += new System.EventHandler(this.btn_view_diagnoses_Click);
            // 
            // btn_update_diagnoses
            // 
            this.btn_update_diagnoses.BackColor = System.Drawing.Color.Thistle;
            this.btn_update_diagnoses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_diagnoses.Location = new System.Drawing.Point(252, 675);
            this.btn_update_diagnoses.Name = "btn_update_diagnoses";
            this.btn_update_diagnoses.Size = new System.Drawing.Size(159, 50);
            this.btn_update_diagnoses.TabIndex = 46;
            this.btn_update_diagnoses.Text = "Update";
            this.btn_update_diagnoses.UseVisualStyleBackColor = false;
            this.btn_update_diagnoses.Click += new System.EventHandler(this.btn_update_diagnoses_Click);
            // 
            // btn_insert_diagnoses
            // 
            this.btn_insert_diagnoses.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_insert_diagnoses.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_diagnoses.Location = new System.Drawing.Point(54, 675);
            this.btn_insert_diagnoses.Name = "btn_insert_diagnoses";
            this.btn_insert_diagnoses.Size = new System.Drawing.Size(159, 50);
            this.btn_insert_diagnoses.TabIndex = 45;
            this.btn_insert_diagnoses.Text = "Insert";
            this.btn_insert_diagnoses.UseVisualStyleBackColor = false;
            this.btn_insert_diagnoses.Click += new System.EventHandler(this.btn_insert_diagnoses_Click);
            // 
            // dataGridView_diagnoses
            // 
            this.dataGridView_diagnoses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_diagnoses.Location = new System.Drawing.Point(667, 92);
            this.dataGridView_diagnoses.Name = "dataGridView_diagnoses";
            this.dataGridView_diagnoses.RowHeadersWidth = 51;
            this.dataGridView_diagnoses.RowTemplate.Height = 24;
            this.dataGridView_diagnoses.Size = new System.Drawing.Size(792, 404);
            this.dataGridView_diagnoses.TabIndex = 44;
            // 
            // lblpatientID
            // 
            this.lblpatientID.AutoSize = true;
            this.lblpatientID.Location = new System.Drawing.Point(10, 35);
            this.lblpatientID.Name = "lblpatientID";
            this.lblpatientID.Size = new System.Drawing.Size(86, 16);
            this.lblpatientID.TabIndex = 9;
            this.lblpatientID.Text = "DiagnosesID";
            // 
            // txtDiagnosesID
            // 
            this.txtDiagnosesID.Location = new System.Drawing.Point(13, 59);
            this.txtDiagnosesID.Name = "txtDiagnosesID";
            this.txtDiagnosesID.Size = new System.Drawing.Size(172, 22);
            this.txtDiagnosesID.TabIndex = 10;
            this.txtDiagnosesID.Leave += new System.EventHandler(this.txtDiagnosesID_Leave);
            // 
            // btn_back_dashboard
            // 
            this.btn_back_dashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_back_dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_dashboard.Location = new System.Drawing.Point(1260, 675);
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbPatientID_diagmosis);
            this.groupBox1.Controls.Add(this.lblpatientID);
            this.groupBox1.Controls.Add(this.txtDiagnosesID);
            this.groupBox1.Controls.Add(this.lblfirstname);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Location = new System.Drawing.Point(54, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 164);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Diagnoses";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Patient Name";
            // 
            // cmbPatientID_diagmosis
            // 
            this.cmbPatientID_diagmosis.FormattingEnabled = true;
            this.cmbPatientID_diagmosis.Location = new System.Drawing.Point(272, 59);
            this.cmbPatientID_diagmosis.Name = "cmbPatientID_diagmosis";
            this.cmbPatientID_diagmosis.Size = new System.Drawing.Size(155, 24);
            this.cmbPatientID_diagmosis.TabIndex = 11;
            this.cmbPatientID_diagmosis.SelectedIndexChanged += new System.EventHandler(this.cmbPatientID_diagmosis_SelectedIndexChanged);
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(269, 35);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(61, 16);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "PatientID";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(13, 121);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(200, 22);
            this.txtPatientName.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(54, 299);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(253, 22);
            this.dtpDate.TabIndex = 38;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(51, 358);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(144, 16);
            this.lbladdress.TabIndex = 36;
            this.lbladdress.Text = "Diagnoses Description";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(51, 268);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(36, 16);
            this.lbldob.TabIndex = 33;
            this.lbldob.Text = "Date";
            // 
            // rtbDiagnosesDescription
            // 
            this.rtbDiagnosesDescription.Location = new System.Drawing.Point(54, 389);
            this.rtbDiagnosesDescription.Name = "rtbDiagnosesDescription";
            this.rtbDiagnosesDescription.Size = new System.Drawing.Size(490, 187);
            this.rtbDiagnosesDescription.TabIndex = 42;
            this.rtbDiagnosesDescription.Text = "";
            // 
            // Manage_diagnoses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1471, 968);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear_diagnoses);
            this.Controls.Add(this.txtSearch_Diagnoses);
            this.Controls.Add(this.btn_search_diagnoses);
            this.Controls.Add(this.btn_delete_diagnoses);
            this.Controls.Add(this.btn_view_diagnoses);
            this.Controls.Add(this.btn_update_diagnoses);
            this.Controls.Add(this.btn_insert_diagnoses);
            this.Controls.Add(this.dataGridView_diagnoses);
            this.Controls.Add(this.btn_back_dashboard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.rtbDiagnosesDescription);
            this.Name = "Manage_diagnoses";
            this.Text = "Manage_diagnoses";
            this.Load += new System.EventHandler(this.Manage_diagnoses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_diagnoses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear_diagnoses;
        private System.Windows.Forms.TextBox txtSearch_Diagnoses;
        private System.Windows.Forms.Button btn_search_diagnoses;
        private System.Windows.Forms.Button btn_delete_diagnoses;
        private System.Windows.Forms.Button btn_view_diagnoses;
        private System.Windows.Forms.Button btn_update_diagnoses;
        private System.Windows.Forms.Button btn_insert_diagnoses;
        private System.Windows.Forms.DataGridView dataGridView_diagnoses;
        private System.Windows.Forms.Label lblpatientID;
        private System.Windows.Forms.TextBox txtDiagnosesID;
        private System.Windows.Forms.Button btn_back_dashboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.RichTextBox rtbDiagnosesDescription;
        private System.Windows.Forms.ComboBox cmbPatientID_diagmosis;
        private System.Windows.Forms.Label label2;
    }
}