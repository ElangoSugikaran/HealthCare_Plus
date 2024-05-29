namespace HealthCare_Plus
{
    partial class Manage_resource
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
            this.btn_back_dashboard = new System.Windows.Forms.Button();
            this.btn_delete_resource = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResourceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResourceID = new System.Windows.Forms.TextBox();
            this.cmbTypeResource = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch_Resource = new System.Windows.Forms.TextBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.cmbAvailable = new System.Windows.Forms.ComboBox();
            this.btn_search_resource = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_view_resource = new System.Windows.Forms.Button();
            this.btn_clear_resource = new System.Windows.Forms.Button();
            this.btn_update_resource = new System.Windows.Forms.Button();
            this.btn_insert_resource = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView_resource = new System.Windows.Forms.DataGridView();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resource)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 23);
            this.label9.TabIndex = 62;
            this.label9.Text = "Resource Details";
            // 
            // btn_back_dashboard
            // 
            this.btn_back_dashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back_dashboard.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_back_dashboard.Location = new System.Drawing.Point(1242, 599);
            this.btn_back_dashboard.Name = "btn_back_dashboard";
            this.btn_back_dashboard.Size = new System.Drawing.Size(159, 50);
            this.btn_back_dashboard.TabIndex = 61;
            this.btn_back_dashboard.Text = "Back";
            this.btn_back_dashboard.UseVisualStyleBackColor = false;
            this.btn_back_dashboard.Click += new System.EventHandler(this.btn_back_dashboard_Click);
            // 
            // btn_delete_resource
            // 
            this.btn_delete_resource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delete_resource.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete_resource.Location = new System.Drawing.Point(1176, 428);
            this.btn_delete_resource.Name = "btn_delete_resource";
            this.btn_delete_resource.Size = new System.Drawing.Size(159, 50);
            this.btn_delete_resource.TabIndex = 60;
            this.btn_delete_resource.Text = "Delete";
            this.btn_delete_resource.UseVisualStyleBackColor = false;
            this.btn_delete_resource.Click += new System.EventHandler(this.btn_delete_resource_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.txtResourceName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtResourceID);
            this.groupBox1.Controls.Add(this.cmbTypeResource);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(32, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 195);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resource";
            // 
            // txtResourceName
            // 
            this.txtResourceName.Location = new System.Drawing.Point(22, 124);
            this.txtResourceName.Name = "txtResourceName";
            this.txtResourceName.Size = new System.Drawing.Size(146, 22);
            this.txtResourceName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resource ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resource Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 5;
            // 
            // txtResourceID
            // 
            this.txtResourceID.Location = new System.Drawing.Point(22, 53);
            this.txtResourceID.Name = "txtResourceID";
            this.txtResourceID.Size = new System.Drawing.Size(146, 22);
            this.txtResourceID.TabIndex = 16;
            this.txtResourceID.Leave += new System.EventHandler(this.txtResourceID_Leave);
            // 
            // cmbTypeResource
            // 
            this.cmbTypeResource.FormattingEnabled = true;
            this.cmbTypeResource.Items.AddRange(new object[] {
            "Radiographic",
            "Diagnostic",
            "Functional",
            "Nuclear medicine"});
            this.cmbTypeResource.Location = new System.Drawing.Point(232, 51);
            this.cmbTypeResource.Name = "cmbTypeResource";
            this.cmbTypeResource.Size = new System.Drawing.Size(159, 24);
            this.cmbTypeResource.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Type Resourse";
            // 
            // txtSearch_Resource
            // 
            this.txtSearch_Resource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch_Resource.Location = new System.Drawing.Point(946, 57);
            this.txtSearch_Resource.Multiline = true;
            this.txtSearch_Resource.Name = "txtSearch_Resource";
            this.txtSearch_Resource.Size = new System.Drawing.Size(296, 34);
            this.txtSearch_Resource.TabIndex = 55;
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "1 floor",
            "2 floor"});
            this.cmbLocation.Location = new System.Drawing.Point(41, 428);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(159, 24);
            this.cmbLocation.TabIndex = 54;
            // 
            // cmbAvailable
            // 
            this.cmbAvailable.FormattingEnabled = true;
            this.cmbAvailable.Items.AddRange(new object[] {
            "yes ",
            "no"});
            this.cmbAvailable.Location = new System.Drawing.Point(41, 357);
            this.cmbAvailable.Name = "cmbAvailable";
            this.cmbAvailable.Size = new System.Drawing.Size(159, 24);
            this.cmbAvailable.TabIndex = 52;
            // 
            // btn_search_resource
            // 
            this.btn_search_resource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search_resource.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_search_resource.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_resource.Location = new System.Drawing.Point(1267, 57);
            this.btn_search_resource.Name = "btn_search_resource";
            this.btn_search_resource.Size = new System.Drawing.Size(135, 34);
            this.btn_search_resource.TabIndex = 47;
            this.btn_search_resource.Text = "Search";
            this.btn_search_resource.UseVisualStyleBackColor = false;
            this.btn_search_resource.Click += new System.EventHandler(this.btn_search_resource_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(1051, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 0);
            this.button5.TabIndex = 46;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btn_view_resource
            // 
            this.btn_view_resource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_view_resource.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_view_resource.Location = new System.Drawing.Point(613, 428);
            this.btn_view_resource.Name = "btn_view_resource";
            this.btn_view_resource.Size = new System.Drawing.Size(159, 50);
            this.btn_view_resource.TabIndex = 45;
            this.btn_view_resource.Text = "View";
            this.btn_view_resource.UseVisualStyleBackColor = false;
            this.btn_view_resource.Click += new System.EventHandler(this.btn_view_resource_Click);
            // 
            // btn_clear_resource
            // 
            this.btn_clear_resource.BackColor = System.Drawing.Color.LightGray;
            this.btn_clear_resource.Location = new System.Drawing.Point(396, 527);
            this.btn_clear_resource.Name = "btn_clear_resource";
            this.btn_clear_resource.Size = new System.Drawing.Size(159, 50);
            this.btn_clear_resource.TabIndex = 44;
            this.btn_clear_resource.Text = "Clear";
            this.btn_clear_resource.UseVisualStyleBackColor = false;
            this.btn_clear_resource.Click += new System.EventHandler(this.btn_clear_resource_Click);
            // 
            // btn_update_resource
            // 
            this.btn_update_resource.BackColor = System.Drawing.Color.Thistle;
            this.btn_update_resource.Location = new System.Drawing.Point(217, 527);
            this.btn_update_resource.Name = "btn_update_resource";
            this.btn_update_resource.Size = new System.Drawing.Size(159, 50);
            this.btn_update_resource.TabIndex = 43;
            this.btn_update_resource.Text = "Update";
            this.btn_update_resource.UseVisualStyleBackColor = false;
            this.btn_update_resource.Click += new System.EventHandler(this.btn_update_resource_Click);
            // 
            // btn_insert_resource
            // 
            this.btn_insert_resource.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_insert_resource.Location = new System.Drawing.Point(32, 527);
            this.btn_insert_resource.Name = "btn_insert_resource";
            this.btn_insert_resource.Size = new System.Drawing.Size(159, 50);
            this.btn_insert_resource.TabIndex = 42;
            this.btn_insert_resource.Text = "Insert";
            this.btn_insert_resource.UseVisualStyleBackColor = false;
            this.btn_insert_resource.Click += new System.EventHandler(this.btn_insert_resource_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Available";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Cost";
            // 
            // dataGridView_resource
            // 
            this.dataGridView_resource.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_resource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_resource.Location = new System.Drawing.Point(551, 104);
            this.dataGridView_resource.Name = "dataGridView_resource";
            this.dataGridView_resource.RowHeadersWidth = 51;
            this.dataGridView_resource.RowTemplate.Height = 24;
            this.dataGridView_resource.Size = new System.Drawing.Size(850, 285);
            this.dataGridView_resource.TabIndex = 37;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(264, 359);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(159, 22);
            this.txtCost.TabIndex = 18;
            // 
            // Manage_resource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1413, 841);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_back_dashboard);
            this.Controls.Add(this.btn_delete_resource);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearch_Resource);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.cmbAvailable);
            this.Controls.Add(this.btn_search_resource);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_view_resource);
            this.Controls.Add(this.btn_clear_resource);
            this.Controls.Add(this.btn_update_resource);
            this.Controls.Add(this.btn_insert_resource);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_resource);
            this.Name = "Manage_resource";
            this.Text = "Manage_resource";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_resource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_back_dashboard;
        private System.Windows.Forms.Button btn_delete_resource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResourceID;
        private System.Windows.Forms.TextBox txtSearch_Resource;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.ComboBox cmbAvailable;
        private System.Windows.Forms.ComboBox cmbTypeResource;
        private System.Windows.Forms.Button btn_search_resource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_view_resource;
        private System.Windows.Forms.Button btn_clear_resource;
        private System.Windows.Forms.Button btn_update_resource;
        private System.Windows.Forms.Button btn_insert_resource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView_resource;
        private System.Windows.Forms.TextBox txtResourceName;
        private System.Windows.Forms.TextBox txtCost;
    }
}