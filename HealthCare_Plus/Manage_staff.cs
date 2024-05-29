using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Manage_staff : Form
    {
        public Manage_staff()
        {
            InitializeComponent();
        }

        private void btn_insert_staff_Click(object sender, EventArgs e)
        {
            StaffController controller = new StaffController();
            Staff S1 = new Staff(txtStaffID.Text, txtFirstName.Text, txtLastName.Text, 
                dtpDob.Value, txtContact_No.Text, cmbGender.Text, cmbRole.Text, txtemail.Text,
                txtpassword.Text, rtbAddress.Text);
            controller.InsertStaff(S1);
        }

        private void btn_clear_staff_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtStaffID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            dtpDob.Value = DateTime.Today; // Reset date to today
            txtContact_No.Text = string.Empty;
            cmbGender.SelectedIndex = -1; // Deselect gender dropdown
            cmbRole.SelectedIndex = -1; // Deselect role dropdown
            txtemail.Text = string.Empty;
            txtpassword.Text = string.Empty;
            rtbAddress.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }

        private void btn_update_staff_Click(object sender, EventArgs e)
        {
            StaffController Controller = new StaffController();
            Staff S3 = new Staff(txtStaffID.Text, txtFirstName.Text, txtLastName.Text, dtpDob.Value, 
                txtContact_No.Text, cmbGender.Text, cmbRole.Text, txtemail.Text, txtpassword.Text,
                rtbAddress.Text);
            Controller.UpdateSatff(S3);
        }

        private void btn_view_staff_Click(object sender, EventArgs e)
        {
            StaffController controller = new StaffController();
            controller.ViewStaff(dataGridView_staff);
        }

        private void btn_search_staff_Click(object sender, EventArgs e)
        {
            StaffController controller = new StaffController();
            controller.SearchStaff(dataGridView_staff, txtSearch.Text);
        }

        private void btn_delete_staff_Click(object sender, EventArgs e)
        {
            StaffController controller = new StaffController();
            string staffIDToDelete = txtSearch.Text; // Get the Staff ID from your textbox
            controller.DeleteStaff(staffIDToDelete);

        }

        private void txtStaffID_Leave(object sender, EventArgs e)
        {

            // Check if the Staff ID textbox is empty
            if (string.IsNullOrEmpty(txtStaffID.Text))
            {
                return; // Exit the event handler if it's empty
            }

            // Fetch staff data based on the entered Staff ID
            StaffController controller = new StaffController();
            string staffIDToSearch = txtStaffID.Text;

            // Create a method to retrieve staff data
            Staff staffData = controller.GetStaffData(staffIDToSearch); 

            // Check if staff data was found
            if (staffData != null)
            {
                    // Populate the other textboxes with the retrieved data
                    txtFirstName.Text = staffData.FirstName;
                    txtLastName.Text = staffData.LastName;
                    dtpDob.Value = staffData.DoB;
                    txtContact_No.Text = staffData.ContactNo;
                    cmbGender.Text = staffData.Gender;
                    cmbRole.Text = staffData.Role;
                    txtemail.Text = staffData.Email;
                    txtpassword.Text = staffData.Password;
                    rtbAddress.Text = staffData.Address;
            }
            else
            {
               MessageBox.Show("Staff not found with the entered Staff ID.");
            }
        }

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptionist_Dashboard receptionistDashboard = new Receptionist_Dashboard();
            receptionistDashboard.Show();
        }

       
    }
}

