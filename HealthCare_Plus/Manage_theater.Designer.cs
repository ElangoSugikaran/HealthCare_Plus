namespace HealthCare_Plus
{
    partial class Manage_theater
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
            this.cmbPatientID = new System.Windows.Forms.ComboBox();
            this.btn_back_dashboard = new System.Windows.Forms.Button();
            this.btn_delete_theater = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTheaterID = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.cmbDoctorID = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtSearch_Theater = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.dataGridView_resource = new System.Windows.Forms.DataGridView();
            this.btn_search_theater = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_view_theater = new System.Windows.Forms.Button();
            this.btn_clear_theater = new System.Windows.Forms.Button();
            this.btn_update_theater = new System.Windows.Forms.Button();
            this.btn_insert_theater = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView_theater_2 = new System.Windows.Forms.DataGridView();
            this.btn_search_2 = new System.Windows.Forms.Button();
            this.dtp_schedule_date = new System.Windows.Forms.DateTimePicker();
            this.cmb_status_theater = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_view_2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_theater_2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPatientID
            // 
            this.cmbPatientID.FormattingEnabled = true;
            this.cmbPatientID.Location = new System.Drawing.Point(173, 127);
            this.cmbPatientID.Name = "cmbPatientID";
            this.cmbPatientID.Size = new System.Drawing.Size(64, 24);
            this.cmbPatientID.TabIndex = 19;
            this.cmbPatientID.SelectedIndexChanged += new System.EventHandler(this.cmbPatientID_SelectedIndexChanged);
            // 
            // btn_back_dashboard
            // 
            this.btn_back_dashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back_dashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_back_dashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_dashboard.Location = new System.Drawing.Point(1324, 786);
            this.btn_back_dashboard.Name = "btn_back_dashboard";
            this.btn_back_dashboard.Size = new System.Drawing.Size(159, 50);
            this.btn_back_dashboard.TabIndex = 56;
            this.btn_back_dashboard.Text = "Back";
            this.btn_back_dashboard.UseVisualStyleBackColor = false;
            this.btn_back_dashboard.Click += new System.EventHandler(this.btn_back_dashboard_Click);
            // 
            // btn_delete_theater
            // 
            this.btn_delete_theater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete_theater.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete_theater.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_theater.Location = new System.Drawing.Point(1232, 359);
            this.btn_delete_theater.Name = "btn_delete_theater";
            this.btn_delete_theater.Size = new System.Drawing.Size(159, 50);
            this.btn_delete_theater.TabIndex = 55;
            this.btn_delete_theater.Text = "Delete";
            this.btn_delete_theater.UseVisualStyleBackColor = false;
            this.btn_delete_theater.Click += new System.EventHandler(this.btn_delete_theater_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.cmbPatientID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTheaterID);
            this.groupBox1.Controls.Add(this.txtDoctorName);
            this.groupBox1.Controls.Add(this.cmbDoctorID);
            this.groupBox1.Location = new System.Drawing.Point(53, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 168);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theater";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(22, 129);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(142, 22);
            this.txtPatientName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "TheaterID";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Doctor Name";
            // 
            // txtTheaterID
            // 
            this.txtTheaterID.Location = new System.Drawing.Point(22, 57);
            this.txtTheaterID.Name = "txtTheaterID";
            this.txtTheaterID.Size = new System.Drawing.Size(146, 22);
            this.txtTheaterID.TabIndex = 16;
            this.txtTheaterID.Leave += new System.EventHandler(this.txtTheaterID_Leave);
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(265, 129);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(142, 22);
            this.txtDoctorName.TabIndex = 17;
            // 
            // cmbDoctorID
            // 
            this.cmbDoctorID.FormattingEnabled = true;
            this.cmbDoctorID.Location = new System.Drawing.Point(413, 127);
            this.cmbDoctorID.Name = "cmbDoctorID";
            this.cmbDoctorID.Size = new System.Drawing.Size(75, 24);
            this.cmbDoctorID.TabIndex = 20;
            this.cmbDoctorID.SelectedIndexChanged += new System.EventHandler(this.cmbDoctorID_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(78, 331);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(215, 22);
            this.dtpDate.TabIndex = 52;
            // 
            // txtSearch_Theater
            // 
            this.txtSearch_Theater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch_Theater.Location = new System.Drawing.Point(1052, 42);
            this.txtSearch_Theater.Multiline = true;
            this.txtSearch_Theater.Name = "txtSearch_Theater";
            this.txtSearch_Theater.Size = new System.Drawing.Size(296, 34);
            this.txtSearch_Theater.TabIndex = 50;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Available",
            "not available"});
            this.cmbStatus.Location = new System.Drawing.Point(318, 329);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(188, 24);
            this.cmbStatus.TabIndex = 49;
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "1 first floor",
            "2 second floor"});
            this.cmbLocation.Location = new System.Drawing.Point(80, 406);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(182, 24);
            this.cmbLocation.TabIndex = 48;
            // 
            // dataGridView_resource
            // 
            this.dataGridView_resource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_resource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_resource.Location = new System.Drawing.Point(687, 98);
            this.dataGridView_resource.Name = "dataGridView_resource";
            this.dataGridView_resource.RowHeadersWidth = 51;
            this.dataGridView_resource.RowTemplate.Height = 24;
            this.dataGridView_resource.Size = new System.Drawing.Size(802, 233);
            this.dataGridView_resource.TabIndex = 34;
            // 
            // btn_search_theater
            // 
            this.btn_search_theater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search_theater.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_search_theater.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_theater.Location = new System.Drawing.Point(1354, 42);
            this.btn_search_theater.Name = "btn_search_theater";
            this.btn_search_theater.Size = new System.Drawing.Size(135, 34);
            this.btn_search_theater.TabIndex = 44;
            this.btn_search_theater.Text = "Search";
            this.btn_search_theater.UseVisualStyleBackColor = false;
            this.btn_search_theater.Click += new System.EventHandler(this.btn_search_theater_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(1119, 478);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 0);
            this.button5.TabIndex = 43;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_view_theater
            // 
            this.btn_view_theater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_view_theater.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_theater.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_theater.Location = new System.Drawing.Point(749, 359);
            this.btn_view_theater.Name = "btn_view_theater";
            this.btn_view_theater.Size = new System.Drawing.Size(159, 50);
            this.btn_view_theater.TabIndex = 42;
            this.btn_view_theater.Text = "View";
            this.btn_view_theater.UseVisualStyleBackColor = false;
            this.btn_view_theater.Click += new System.EventHandler(this.btn_view_theater_Click);
            // 
            // btn_clear_theater
            // 
            this.btn_clear_theater.BackColor = System.Drawing.Color.LightGray;
            this.btn_clear_theater.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_theater.Location = new System.Drawing.Point(418, 521);
            this.btn_clear_theater.Name = "btn_clear_theater";
            this.btn_clear_theater.Size = new System.Drawing.Size(159, 50);
            this.btn_clear_theater.TabIndex = 41;
            this.btn_clear_theater.Text = "Clear";
            this.btn_clear_theater.UseVisualStyleBackColor = false;
            this.btn_clear_theater.Click += new System.EventHandler(this.btn_clear_theater_Click);
            // 
            // btn_update_theater
            // 
            this.btn_update_theater.BackColor = System.Drawing.Color.Thistle;
            this.btn_update_theater.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_theater.Location = new System.Drawing.Point(233, 521);
            this.btn_update_theater.Name = "btn_update_theater";
            this.btn_update_theater.Size = new System.Drawing.Size(159, 50);
            this.btn_update_theater.TabIndex = 40;
            this.btn_update_theater.Text = "Update";
            this.btn_update_theater.UseVisualStyleBackColor = false;
            this.btn_update_theater.Click += new System.EventHandler(this.btn_update_theater_Click);
            // 
            // btn_insert_theater
            // 
            this.btn_insert_theater.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_insert_theater.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_theater.Location = new System.Drawing.Point(53, 521);
            this.btn_insert_theater.Name = "btn_insert_theater";
            this.btn_insert_theater.Size = new System.Drawing.Size(159, 50);
            this.btn_insert_theater.TabIndex = 39;
            this.btn_insert_theater.Text = "Insert";
            this.btn_insert_theater.UseVisualStyleBackColor = false;
            this.btn_insert_theater.Click += new System.EventHandler(this.btn_insert_theater_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 16);
            this.label5.TabIndex = 36;
            this.label5.Text = "Scheduled Date";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(58, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 23);
            this.label9.TabIndex = 57;
            this.label9.Text = "Theater Details";
            // 
            // dataGridView_theater_2
            // 
            this.dataGridView_theater_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_theater_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_theater_2.Location = new System.Drawing.Point(680, 520);
            this.dataGridView_theater_2.Name = "dataGridView_theater_2";
            this.dataGridView_theater_2.RowHeadersWidth = 51;
            this.dataGridView_theater_2.RowTemplate.Height = 24;
            this.dataGridView_theater_2.Size = new System.Drawing.Size(802, 235);
            this.dataGridView_theater_2.TabIndex = 58;
            // 
            // btn_search_2
            // 
            this.btn_search_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search_2.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_search_2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_2.Location = new System.Drawing.Point(1348, 468);
            this.btn_search_2.Name = "btn_search_2";
            this.btn_search_2.Size = new System.Drawing.Size(135, 34);
            this.btn_search_2.TabIndex = 59;
            this.btn_search_2.Text = "Search";
            this.btn_search_2.UseVisualStyleBackColor = false;
            this.btn_search_2.Click += new System.EventHandler(this.btn_search_2_Click);
            // 
            // dtp_schedule_date
            // 
            this.dtp_schedule_date.Location = new System.Drawing.Point(787, 492);
            this.dtp_schedule_date.Name = "dtp_schedule_date";
            this.dtp_schedule_date.Size = new System.Drawing.Size(160, 22);
            this.dtp_schedule_date.TabIndex = 63;
            // 
            // cmb_status_theater
            // 
            this.cmb_status_theater.FormattingEnabled = true;
            this.cmb_status_theater.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.cmb_status_theater.Location = new System.Drawing.Point(1023, 491);
            this.cmb_status_theater.Name = "cmb_status_theater";
            this.cmb_status_theater.Size = new System.Drawing.Size(146, 24);
            this.cmb_status_theater.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(973, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(677, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Scheduled Date";
            // 
            // btn_view_2
            // 
            this.btn_view_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_view_2.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_2.Location = new System.Drawing.Point(680, 786);
            this.btn_view_2.Name = "btn_view_2";
            this.btn_view_2.Size = new System.Drawing.Size(159, 50);
            this.btn_view_2.TabIndex = 64;
            this.btn_view_2.Text = "View";
            this.btn_view_2.UseVisualStyleBackColor = false;
            this.btn_view_2.Click += new System.EventHandler(this.btn_view_2_Click);
            // 
            // Manage_theater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1588, 1053);
            this.Controls.Add(this.btn_view_2);
            this.Controls.Add(this.dtp_schedule_date);
            this.Controls.Add(this.cmb_status_theater);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_search_2);
            this.Controls.Add(this.dataGridView_theater_2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_back_dashboard);
            this.Controls.Add(this.btn_delete_theater);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtSearch_Theater);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.dataGridView_resource);
            this.Controls.Add(this.btn_search_theater);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_view_theater);
            this.Controls.Add(this.btn_clear_theater);
            this.Controls.Add(this.btn_update_theater);
            this.Controls.Add(this.btn_insert_theater);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Manage_theater";
            this.Text = "Manage_theater";
            this.Load += new System.EventHandler(this.Manage_theater_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_theater_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPatientID;
        private System.Windows.Forms.Button btn_back_dashboard;
        private System.Windows.Forms.Button btn_delete_theater;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTheaterID;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.ComboBox cmbDoctorID;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtSearch_Theater;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.DataGridView dataGridView_resource;
        private System.Windows.Forms.Button btn_search_theater;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_view_theater;
        private System.Windows.Forms.Button btn_clear_theater;
        private System.Windows.Forms.Button btn_update_theater;
        private System.Windows.Forms.Button btn_insert_theater;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.DataGridView dataGridView_theater_2;
        private System.Windows.Forms.Button btn_search_2;
        private System.Windows.Forms.DateTimePicker dtp_schedule_date;
        private System.Windows.Forms.ComboBox cmb_status_theater;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_view_2;
    }
}