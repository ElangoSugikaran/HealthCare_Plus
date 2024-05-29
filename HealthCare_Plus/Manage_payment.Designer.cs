namespace HealthCare_Plus
{
    partial class Manage_payment
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
            this.btn_delete_payment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_PaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.cmbPatientID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPaymentID = new System.Windows.Forms.TextBox();
            this.txtSearch_Payment = new System.Windows.Forms.TextBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btn_search_payment = new System.Windows.Forms.Button();
            this.btn_Back_dashboard = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_clear_payment = new System.Windows.Forms.Button();
            this.btn_insert_payment = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_Payment = new System.Windows.Forms.DataGridView();
            this.txtPaymentInvoice = new System.Windows.Forms.TextBox();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.btn_update_payment = new System.Windows.Forms.Button();
            this.btn_view_payment = new System.Windows.Forms.Button();
            this.txtPatient_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRoomCharge = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAppointmentCharge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMedicineCharge = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Retrieve_Charge = new System.Windows.Forms.Button();
            this.btn_print_preview = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payment)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 23);
            this.label9.TabIndex = 82;
            this.label9.Text = "Payment Details";
            // 
            // btn_delete_payment
            // 
            this.btn_delete_payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete_payment.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete_payment.Location = new System.Drawing.Point(1178, 408);
            this.btn_delete_payment.Name = "btn_delete_payment";
            this.btn_delete_payment.Size = new System.Drawing.Size(159, 50);
            this.btn_delete_payment.TabIndex = 80;
            this.btn_delete_payment.Text = "Delete";
            this.btn_delete_payment.UseVisualStyleBackColor = false;
            this.btn_delete_payment.Click += new System.EventHandler(this.btn_delete_payment_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.dtp_PaymentDate);
            this.groupBox1.Controls.Add(this.txtPatientName);
            this.groupBox1.Controls.Add(this.cmbPatientID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPaymentID);
            this.groupBox1.Location = new System.Drawing.Point(50, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 168);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment";
            // 
            // dtp_PaymentDate
            // 
            this.dtp_PaymentDate.Location = new System.Drawing.Point(22, 129);
            this.dtp_PaymentDate.Name = "dtp_PaymentDate";
            this.dtp_PaymentDate.Size = new System.Drawing.Size(200, 22);
            this.dtp_PaymentDate.TabIndex = 22;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(213, 55);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(142, 22);
            this.txtPatientName.TabIndex = 21;
            // 
            // cmbPatientID
            // 
            this.cmbPatientID.FormattingEnabled = true;
            this.cmbPatientID.Location = new System.Drawing.Point(375, 55);
            this.cmbPatientID.Name = "cmbPatientID";
            this.cmbPatientID.Size = new System.Drawing.Size(59, 24);
            this.cmbPatientID.TabIndex = 19;
            this.cmbPatientID.SelectedIndexChanged += new System.EventHandler(this.cmbPatientID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "PaymentID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Payment Date";
            // 
            // txtPaymentID
            // 
            this.txtPaymentID.Location = new System.Drawing.Point(22, 57);
            this.txtPaymentID.Name = "txtPaymentID";
            this.txtPaymentID.Size = new System.Drawing.Size(146, 22);
            this.txtPaymentID.TabIndex = 16;
            this.txtPaymentID.Leave += new System.EventHandler(this.txtPaymentID_Leave);
            // 
            // txtSearch_Payment
            // 
            this.txtSearch_Payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch_Payment.Location = new System.Drawing.Point(1020, 16);
            this.txtSearch_Payment.Multiline = true;
            this.txtSearch_Payment.Name = "txtSearch_Payment";
            this.txtSearch_Payment.Size = new System.Drawing.Size(296, 34);
            this.txtSearch_Payment.TabIndex = 75;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Items.AddRange(new object[] {
            "Cash",
            "Debit Card",
            "Credit Card"});
            this.cmbPaymentMethod.Location = new System.Drawing.Point(72, 301);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(159, 24);
            this.cmbPaymentMethod.TabIndex = 74;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Payment Completed"});
            this.cmbStatus.Location = new System.Drawing.Point(72, 379);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(159, 24);
            this.cmbStatus.TabIndex = 72;
            // 
            // btn_search_payment
            // 
            this.btn_search_payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search_payment.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_search_payment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_payment.Location = new System.Drawing.Point(1322, 16);
            this.btn_search_payment.Name = "btn_search_payment";
            this.btn_search_payment.Size = new System.Drawing.Size(135, 34);
            this.btn_search_payment.TabIndex = 69;
            this.btn_search_payment.Text = "Search";
            this.btn_search_payment.UseVisualStyleBackColor = false;
            this.btn_search_payment.Click += new System.EventHandler(this.btn_search_payment_Click);
            // 
            // btn_Back_dashboard
            // 
            this.btn_Back_dashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back_dashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_Back_dashboard.Location = new System.Drawing.Point(1298, 752);
            this.btn_Back_dashboard.Name = "btn_Back_dashboard";
            this.btn_Back_dashboard.Size = new System.Drawing.Size(159, 50);
            this.btn_Back_dashboard.TabIndex = 81;
            this.btn_Back_dashboard.Text = "Back";
            this.btn_Back_dashboard.UseVisualStyleBackColor = false;
            this.btn_Back_dashboard.Click += new System.EventHandler(this.btn_Back_dashboard_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(1043, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 0);
            this.button5.TabIndex = 68;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_clear_payment
            // 
            this.btn_clear_payment.BackColor = System.Drawing.Color.LightGray;
            this.btn_clear_payment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_payment.Location = new System.Drawing.Point(1115, 527);
            this.btn_clear_payment.Name = "btn_clear_payment";
            this.btn_clear_payment.Size = new System.Drawing.Size(159, 50);
            this.btn_clear_payment.TabIndex = 66;
            this.btn_clear_payment.Text = "Clear";
            this.btn_clear_payment.UseVisualStyleBackColor = false;
            this.btn_clear_payment.Click += new System.EventHandler(this.btn_clear_payment_Click);
            // 
            // btn_insert_payment
            // 
            this.btn_insert_payment.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_insert_payment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_payment.Location = new System.Drawing.Point(731, 527);
            this.btn_insert_payment.Name = "btn_insert_payment";
            this.btn_insert_payment.Size = new System.Drawing.Size(159, 50);
            this.btn_insert_payment.TabIndex = 64;
            this.btn_insert_payment.Text = "Insert";
            this.btn_insert_payment.UseVisualStyleBackColor = false;
            this.btn_insert_payment.Click += new System.EventHandler(this.btn_insert_payment_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 63;
            this.label7.Text = "Payment Invoice No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 62;
            this.label6.Text = "Payment Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Payment Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "Status";
            // 
            // dataGridView_Payment
            // 
            this.dataGridView_Payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_Payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Payment.Location = new System.Drawing.Point(555, 78);
            this.dataGridView_Payment.Name = "dataGridView_Payment";
            this.dataGridView_Payment.RowHeadersWidth = 51;
            this.dataGridView_Payment.RowTemplate.Height = 24;
            this.dataGridView_Payment.Size = new System.Drawing.Size(902, 300);
            this.dataGridView_Payment.TabIndex = 59;
            // 
            // txtPaymentInvoice
            // 
            this.txtPaymentInvoice.Location = new System.Drawing.Point(263, 303);
            this.txtPaymentInvoice.Name = "txtPaymentInvoice";
            this.txtPaymentInvoice.Size = new System.Drawing.Size(160, 22);
            this.txtPaymentInvoice.TabIndex = 23;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(72, 636);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(165, 22);
            this.txtPaymentAmount.TabIndex = 23;
            // 
            // btn_update_payment
            // 
            this.btn_update_payment.BackColor = System.Drawing.Color.Thistle;
            this.btn_update_payment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_payment.Location = new System.Drawing.Point(923, 527);
            this.btn_update_payment.Name = "btn_update_payment";
            this.btn_update_payment.Size = new System.Drawing.Size(159, 50);
            this.btn_update_payment.TabIndex = 83;
            this.btn_update_payment.Text = "Update";
            this.btn_update_payment.UseVisualStyleBackColor = false;
            this.btn_update_payment.Click += new System.EventHandler(this.btn_update_payment_Click);
            // 
            // btn_view_payment
            // 
            this.btn_view_payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_view_payment.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_payment.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_payment.Location = new System.Drawing.Point(675, 408);
            this.btn_view_payment.Name = "btn_view_payment";
            this.btn_view_payment.Size = new System.Drawing.Size(159, 50);
            this.btn_view_payment.TabIndex = 84;
            this.btn_view_payment.Text = "View";
            this.btn_view_payment.UseVisualStyleBackColor = false;
            this.btn_view_payment.Click += new System.EventHandler(this.btn_view_payment_Click);
            // 
            // txtPatient_Name
            // 
            this.txtPatient_Name.Location = new System.Drawing.Point(206, 440);
            this.txtPatient_Name.Name = "txtPatient_Name";
            this.txtPatient_Name.Size = new System.Drawing.Size(142, 22);
            this.txtPatient_Name.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Patient ID";
            // 
            // txtRoomCharge
            // 
            this.txtRoomCharge.Location = new System.Drawing.Point(206, 542);
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.Size = new System.Drawing.Size(142, 22);
            this.txtRoomCharge.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 544);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 85;
            this.label10.Text = "room charge";
            // 
            // txtAppointmentCharge
            // 
            this.txtAppointmentCharge.Location = new System.Drawing.Point(206, 510);
            this.txtAppointmentCharge.Name = "txtAppointmentCharge";
            this.txtAppointmentCharge.Size = new System.Drawing.Size(142, 22);
            this.txtAppointmentCharge.TabIndex = 88;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 511);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 16);
            this.label11.TabIndex = 87;
            this.label11.Text = "appointment charge";
            // 
            // txtMedicineCharge
            // 
            this.txtMedicineCharge.Location = new System.Drawing.Point(206, 472);
            this.txtMedicineCharge.Name = "txtMedicineCharge";
            this.txtMedicineCharge.Size = new System.Drawing.Size(142, 22);
            this.txtMedicineCharge.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 474);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 16);
            this.label12.TabIndex = 89;
            this.label12.Text = "medicine charge";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_Calculate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.Location = new System.Drawing.Point(387, 627);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(131, 38);
            this.btn_Calculate.TabIndex = 91;
            this.btn_Calculate.Text = "calculate";
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Retrieve_Charge
            // 
            this.btn_Retrieve_Charge.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Retrieve_Charge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retrieve_Charge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Retrieve_Charge.Location = new System.Drawing.Point(387, 527);
            this.btn_Retrieve_Charge.Name = "btn_Retrieve_Charge";
            this.btn_Retrieve_Charge.Size = new System.Drawing.Size(131, 38);
            this.btn_Retrieve_Charge.TabIndex = 92;
            this.btn_Retrieve_Charge.Text = "charges";
            this.btn_Retrieve_Charge.UseVisualStyleBackColor = false;
            this.btn_Retrieve_Charge.Click += new System.EventHandler(this.btn_Retrieve_Charge_Click);
            // 
            // btn_print_preview
            // 
            this.btn_print_preview.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_print_preview.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print_preview.Location = new System.Drawing.Point(923, 636);
            this.btn_print_preview.Name = "btn_print_preview";
            this.btn_print_preview.Size = new System.Drawing.Size(159, 50);
            this.btn_print_preview.TabIndex = 93;
            this.btn_print_preview.Text = "Print Preview";
            this.btn_print_preview.UseVisualStyleBackColor = false;
            this.btn_print_preview.Click += new System.EventHandler(this.btn_print_preview_Click);
            // 
            // Manage_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1485, 1055);
            this.Controls.Add(this.btn_print_preview);
            this.Controls.Add(this.btn_Retrieve_Charge);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txtMedicineCharge);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtAppointmentCharge);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRoomCharge);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPatient_Name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_view_payment);
            this.Controls.Add(this.btn_update_payment);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.txtPaymentInvoice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_delete_payment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch_Payment);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btn_search_payment);
            this.Controls.Add(this.btn_Back_dashboard);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_clear_payment);
            this.Controls.Add(this.btn_insert_payment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_Payment);
            this.Name = "Manage_payment";
            this.Text = "Manage_payment";
            this.Load += new System.EventHandler(this.Manage_payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_delete_payment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbPatientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPaymentID;
        private System.Windows.Forms.TextBox txtSearch_Payment;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btn_search_payment;
        private System.Windows.Forms.Button btn_Back_dashboard;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_clear_payment;
        private System.Windows.Forms.Button btn_insert_payment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_Payment;
        private System.Windows.Forms.DateTimePicker dtp_PaymentDate;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPaymentInvoice;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Button btn_update_payment;
        private System.Windows.Forms.Button btn_view_payment;
        private System.Windows.Forms.TextBox txtPatient_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRoomCharge;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAppointmentCharge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMedicineCharge;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Retrieve_Charge;
        private System.Windows.Forms.Button btn_print_preview;
    }
}