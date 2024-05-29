namespace HealthCare_Plus
{
    partial class Manage_report
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_generate_patient = new System.Windows.Forms.Button();
            this.btn_Back_dashboard = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Doctor_Report = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Staff_Report = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(52, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 23);
            this.label9.TabIndex = 106;
            this.label9.Text = "Report Generation";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.btn_generate_patient);
            this.groupBox1.Location = new System.Drawing.Point(61, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 101);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Patient Report";
            // 
            // btn_generate_patient
            // 
            this.btn_generate_patient.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_generate_patient.Location = new System.Drawing.Point(114, 45);
            this.btn_generate_patient.Name = "btn_generate_patient";
            this.btn_generate_patient.Size = new System.Drawing.Size(140, 36);
            this.btn_generate_patient.TabIndex = 88;
            this.btn_generate_patient.Text = "Patient Report";
            this.btn_generate_patient.UseVisualStyleBackColor = false;
            this.btn_generate_patient.Click += new System.EventHandler(this.btn_generate_patient_Click);
            // 
            // btn_Back_dashboard
            // 
            this.btn_Back_dashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back_dashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Back_dashboard.Location = new System.Drawing.Point(1250, 549);
            this.btn_Back_dashboard.Name = "btn_Back_dashboard";
            this.btn_Back_dashboard.Size = new System.Drawing.Size(159, 50);
            this.btn_Back_dashboard.TabIndex = 105;
            this.btn_Back_dashboard.Text = "Back";
            this.btn_Back_dashboard.UseVisualStyleBackColor = false;
            this.btn_Back_dashboard.Click += new System.EventHandler(this.btn_Back_dashboard_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(1060, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 0);
            this.button5.TabIndex = 92;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox2.Controls.Add(this.btn_Doctor_Report);
            this.groupBox2.Location = new System.Drawing.Point(523, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 101);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Doctor Report";
            // 
            // btn_Doctor_Report
            // 
            this.btn_Doctor_Report.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Doctor_Report.Location = new System.Drawing.Point(128, 45);
            this.btn_Doctor_Report.Name = "btn_Doctor_Report";
            this.btn_Doctor_Report.Size = new System.Drawing.Size(140, 36);
            this.btn_Doctor_Report.TabIndex = 89;
            this.btn_Doctor_Report.Text = "Doctor Report";
            this.btn_Doctor_Report.UseVisualStyleBackColor = false;
            this.btn_Doctor_Report.Click += new System.EventHandler(this.btn_Doctor_Report_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox3.Controls.Add(this.btn_Staff_Report);
            this.groupBox3.Location = new System.Drawing.Point(991, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 101);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generate Staff Report";
            // 
            // btn_Staff_Report
            // 
            this.btn_Staff_Report.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Staff_Report.Location = new System.Drawing.Point(130, 45);
            this.btn_Staff_Report.Name = "btn_Staff_Report";
            this.btn_Staff_Report.Size = new System.Drawing.Size(140, 36);
            this.btn_Staff_Report.TabIndex = 90;
            this.btn_Staff_Report.Text = "Staff Report";
            this.btn_Staff_Report.UseVisualStyleBackColor = false;
            this.btn_Staff_Report.Click += new System.EventHandler(this.btn_Staff_Report_Click);
            // 
            // Manage_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1485, 767);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Back_dashboard);
            this.Controls.Add(this.button5);
            this.Name = "Manage_report";
            this.Text = "Manage_report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Back_dashboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_generate_patient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Doctor_Report;
        private System.Windows.Forms.Button btn_Staff_Report;
    }
}