using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Manage_doctor : Form
    {
        public Manage_doctor()
        {
            InitializeComponent();
        }

        private void btn_insert_doctor_Click(object sender, EventArgs e)
        {
            DoctorController controller = new DoctorController();   
            Doctor D1 = new Doctor(txtDoctorID.Text, txtFirstName.Text, txtLastName.Text, cmbSpecialization.Text, cmbQualification.Text,
            dtpAvailabilitySchedule.Value, txtYearOfExperiences.Text, cmbStatus.Text, cmbGender.Text, txtContactNo.Text, dtpDoB.Value, txtEmail.Text,
            rtbAddress.Text); // Use the text from the textbox

            controller.InsertDoctor(D1);


        }


        private void btn_view_doctor_Click(object sender, EventArgs e)
        {
            DoctorController controller = new DoctorController();
            controller.ViewDoctor(dataGridView_doctor);
        }

        private void btn_search_doctor_Click(object sender, EventArgs e)
        {
            DoctorController controller = new DoctorController();
            controller.SearchDoctor(dataGridView_doctor, txtSearchDoctor.Text);
        }

        private void btn_clear_doctor_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtDoctorID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            cmbSpecialization.SelectedIndex = -1;
            cmbQualification.SelectedIndex = -1;
            dtpAvailabilitySchedule.Value = DateTime.Today; // Reset date to today
            txtYearOfExperiences.Text = string.Empty;
            cmbStatus.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1; // Deselect gender dropdown
            txtContactNo.Text = string.Empty;
            dtpDoB.Value = DateTime.Today;
            txtEmail.Text = string.Empty;
            rtbAddress.Text = string.Empty;
            txtSearchDoctor.Text = string.Empty;
           
        }

        private void btn_update_doctor_Click(object sender, EventArgs e)
        {
            DoctorController controller = new DoctorController();
            Doctor D2 = new Doctor(txtDoctorID.Text, txtFirstName.Text, txtLastName.Text, cmbSpecialization.Text, cmbQualification.Text,
            dtpAvailabilitySchedule.Value, txtYearOfExperiences.Text, cmbStatus.Text, cmbGender.Text, txtContactNo.Text, dtpDoB.Value, txtEmail.Text,
            rtbAddress.Text); // Use the text from the textbox

            controller.UpdateDoctor(D2);
        }

        private void btn_delete_doctor_Click(object sender, EventArgs e)
        {
            DoctorController controller = new DoctorController();
            string doctorIDToDelete = txtSearchDoctor.Text; // Get the Staff ID from your textbox
            controller.DeleteDoctor(doctorIDToDelete);
        }

        private void txtDoctorID_Leave(object sender, EventArgs e)
        {
            // Check if the doctor ID textbox is empty
            if (string.IsNullOrEmpty(txtDoctorID.Text))
            {
                return; // Exit the event handler if it's empty
            }

            // Fetch staff data based on the entered Staff ID
            DoctorController controller = new DoctorController();
            string doctorIDToSearch = txtDoctorID.Text;
            Doctor doctorData = controller.GetDoctorData(doctorIDToSearch); // Create a method to retrieve staff data

            // Check if staff data was found
            if (doctorData != null)
            {
                // Populate the other textboxes with the retrieved data
                txtFirstName.Text = doctorData.FirstName;
                txtLastName.Text = doctorData.LastName;
                cmbSpecialization.Text = doctorData.Specialization;
                cmbQualification.Text = doctorData.Qualification;
                dtpAvailabilitySchedule.Value = doctorData.AvailabilitySchedule;
                txtYearOfExperiences.Text = doctorData.YearOfExperiences;
                cmbStatus.Text = doctorData.Status;
                cmbGender.Text = doctorData.Gender;
                txtContactNo.Text = doctorData.ContactNo;
                dtpDoB.Value = doctorData.DoB;
                txtEmail.Text = doctorData.Email;
                rtbAddress.Text = doctorData.Address;
               
            }
            else
            {
                MessageBox.Show("doctor not found with the entered doctor ID.");
            }
        }

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
        }
    }
}
