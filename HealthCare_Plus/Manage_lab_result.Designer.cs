namespace HealthCare_Plus
{
    partial class Manage_lab_result
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
            this.btn_clear_lab = new System.Windows.Forms.Button();
            this.txtSearch_lab = new System.Windows.Forms.TextBox();
            this.btn_search_lab = new System.Windows.Forms.Button();
            this.btn_delete_lab = new System.Windows.Forms.Button();
            this.btn_view_lab = new System.Windows.Forms.Button();
            this.btn_update_lab = new System.Windows.Forms.Button();
            this.btn_insert_lab = new System.Windows.Forms.Button();
            this.dataGridView_lab_result = new System.Windows.Forms.DataGridView();
            this.lblpatientID = new System.Windows.Forms.Label();
            this.txtLabResultID = new System.Windows.Forms.TextBox();
            this.btn_back_dashboard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTestType = new System.Windows.Forms.ComboBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblcontactno = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.rtbResultDetails = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lab_result)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Lab_Results Details";
            // 
            // btn_clear_lab
            // 
            this.btn_clear_lab.BackColor = System.Drawing.Color.LightGray;
            this.btn_clear_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_lab.Location = new System.Drawing.Point(429, 600);
            this.btn_clear_lab.Name = "btn_clear_lab";
            this.btn_clear_lab.Size = new System.Drawing.Size(159, 50);
            this.btn_clear_lab.TabIndex = 53;
            this.btn_clear_lab.Text = "Clear";
            this.btn_clear_lab.UseVisualStyleBackColor = false;
            this.btn_clear_lab.Click += new System.EventHandler(this.btn_clear_lab_Click);
            // 
            // txtSearch_lab
            // 
            this.txtSearch_lab.Location = new System.Drawing.Point(1104, 57);
            this.txtSearch_lab.Multiline = true;
            this.txtSearch_lab.Name = "txtSearch_lab";
            this.txtSearch_lab.Size = new System.Drawing.Size(193, 34);
            this.txtSearch_lab.TabIndex = 50;
            // 
            // btn_search_lab
            // 
            this.btn_search_lab.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_search_lab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_lab.Location = new System.Drawing.Point(1325, 57);
            this.btn_search_lab.Name = "btn_search_lab";
            this.btn_search_lab.Size = new System.Drawing.Size(135, 34);
            this.btn_search_lab.TabIndex = 49;
            this.btn_search_lab.Text = "Search";
            this.btn_search_lab.UseVisualStyleBackColor = false;
            this.btn_search_lab.Click += new System.EventHandler(this.btn_search_lab_Click);
            // 
            // btn_delete_lab
            // 
            this.btn_delete_lab.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete_lab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_lab.Location = new System.Drawing.Point(1214, 561);
            this.btn_delete_lab.Name = "btn_delete_lab";
            this.btn_delete_lab.Size = new System.Drawing.Size(159, 50);
            this.btn_delete_lab.TabIndex = 48;
            this.btn_delete_lab.Text = "Delete";
            this.btn_delete_lab.UseVisualStyleBackColor = false;
            this.btn_delete_lab.Click += new System.EventHandler(this.btn_delete_lab_Click);
            // 
            // btn_view_lab
            // 
            this.btn_view_lab.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_lab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_lab.Location = new System.Drawing.Point(791, 561);
            this.btn_view_lab.Name = "btn_view_lab";
            this.btn_view_lab.Size = new System.Drawing.Size(159, 50);
            this.btn_view_lab.TabIndex = 47;
            this.btn_view_lab.Text = "View";
            this.btn_view_lab.UseVisualStyleBackColor = false;
            this.btn_view_lab.Click += new System.EventHandler(this.btn_view_lab_Click);
            // 
            // btn_update_lab
            // 
            this.btn_update_lab.BackColor = System.Drawing.Color.Thistle;
            this.btn_update_lab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_lab.Location = new System.Drawing.Point(242, 600);
            this.btn_update_lab.Name = "btn_update_lab";
            this.btn_update_lab.Size = new System.Drawing.Size(159, 50);
            this.btn_update_lab.TabIndex = 46;
            this.btn_update_lab.Text = "Update";
            this.btn_update_lab.UseVisualStyleBackColor = false;
            this.btn_update_lab.Click += new System.EventHandler(this.btn_update_lab_Click);
            // 
            // btn_insert_lab
            // 
            this.btn_insert_lab.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_insert_lab.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_lab.Location = new System.Drawing.Point(44, 600);
            this.btn_insert_lab.Name = "btn_insert_lab";
            this.btn_insert_lab.Size = new System.Drawing.Size(159, 50);
            this.btn_insert_lab.TabIndex = 45;
            this.btn_insert_lab.Text = "Insert";
            this.btn_insert_lab.UseVisualStyleBackColor = false;
            this.btn_insert_lab.Click += new System.EventHandler(this.btn_insert_lab_Click);
            // 
            // dataGridView_lab_result
            // 
            this.dataGridView_lab_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lab_result.Location = new System.Drawing.Point(668, 113);
            this.dataGridView_lab_result.Name = "dataGridView_lab_result";
            this.dataGridView_lab_result.RowHeadersWidth = 51;
            this.dataGridView_lab_result.RowTemplate.Height = 24;
            this.dataGridView_lab_result.Size = new System.Drawing.Size(792, 404);
            this.dataGridView_lab_result.TabIndex = 44;
            // 
            // lblpatientID
            // 
            this.lblpatientID.AutoSize = true;
            this.lblpatientID.Location = new System.Drawing.Point(30, 24);
            this.lblpatientID.Name = "lblpatientID";
            this.lblpatientID.Size = new System.Drawing.Size(81, 16);
            this.lblpatientID.TabIndex = 9;
            this.lblpatientID.Text = "LabResultID";
            // 
            // txtLabResultID
            // 
            this.txtLabResultID.Location = new System.Drawing.Point(31, 55);
            this.txtLabResultID.Name = "txtLabResultID";
            this.txtLabResultID.Size = new System.Drawing.Size(200, 22);
            this.txtLabResultID.TabIndex = 10;
            this.txtLabResultID.Leave += new System.EventHandler(this.txtLabResultID_Leave);
            // 
            // btn_back_dashboard
            // 
            this.btn_back_dashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_back_dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_dashboard.Location = new System.Drawing.Point(1301, 727);
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
            this.groupBox1.Controls.Add(this.cmbTestType);
            this.groupBox1.Controls.Add(this.lblpatientID);
            this.groupBox1.Controls.Add(this.txtLabResultID);
            this.groupBox1.Controls.Add(this.lblfirstname);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.lblcontactno);
            this.groupBox1.Location = new System.Drawing.Point(37, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 170);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lab";
            // 
            // cmbTestType
            // 
            this.cmbTestType.FormattingEnabled = true;
            this.cmbTestType.Items.AddRange(new object[] {
            "kidney function test",
            "liver function test",
            "fasting blood sugar test"});
            this.cmbTestType.Location = new System.Drawing.Point(28, 122);
            this.cmbTestType.Name = "cmbTestType";
            this.cmbTestType.Size = new System.Drawing.Size(200, 24);
            this.cmbTestType.TabIndex = 56;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Location = new System.Drawing.Point(30, 93);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(69, 16);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "Test Type";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(260, 55);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(200, 22);
            this.txtPatientName.TabIndex = 39;
            // 
            // lblcontactno
            // 
            this.lblcontactno.AutoSize = true;
            this.lblcontactno.Location = new System.Drawing.Point(257, 24);
            this.lblcontactno.Name = "lblcontactno";
            this.lblcontactno.Size = new System.Drawing.Size(88, 16);
            this.lblcontactno.TabIndex = 34;
            this.lblcontactno.Text = "Patient Name";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(50, 339);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(248, 22);
            this.dtpDate.TabIndex = 38;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(47, 404);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(90, 16);
            this.lbladdress.TabIndex = 36;
            this.lbladdress.Text = "Result Details";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Location = new System.Drawing.Point(47, 308);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(36, 16);
            this.lbldob.TabIndex = 33;
            this.lbldob.Text = "Date";
            // 
            // rtbResultDetails
            // 
            this.rtbResultDetails.Location = new System.Drawing.Point(50, 435);
            this.rtbResultDetails.Name = "rtbResultDetails";
            this.rtbResultDetails.Size = new System.Drawing.Size(438, 85);
            this.rtbResultDetails.TabIndex = 42;
            this.rtbResultDetails.Text = "";
            // 
            // Manage_lab_result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1500, 835);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear_lab);
            this.Controls.Add(this.txtSearch_lab);
            this.Controls.Add(this.btn_search_lab);
            this.Controls.Add(this.btn_delete_lab);
            this.Controls.Add(this.btn_view_lab);
            this.Controls.Add(this.btn_update_lab);
            this.Controls.Add(this.btn_insert_lab);
            this.Controls.Add(this.dataGridView_lab_result);
            this.Controls.Add(this.btn_back_dashboard);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.rtbResultDetails);
            this.Name = "Manage_lab_result";
            this.Text = "Manage_lab_result";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lab_result)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear_lab;
        private System.Windows.Forms.TextBox txtSearch_lab;
        private System.Windows.Forms.Button btn_search_lab;
        private System.Windows.Forms.Button btn_delete_lab;
        private System.Windows.Forms.Button btn_view_lab;
        private System.Windows.Forms.Button btn_update_lab;
        private System.Windows.Forms.Button btn_insert_lab;
        private System.Windows.Forms.DataGridView dataGridView_lab_result;
        private System.Windows.Forms.Label lblpatientID;
        private System.Windows.Forms.TextBox txtLabResultID;
        private System.Windows.Forms.Button btn_back_dashboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblcontactno;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.RichTextBox rtbResultDetails;
        private System.Windows.Forms.ComboBox cmbTestType;
    }
}