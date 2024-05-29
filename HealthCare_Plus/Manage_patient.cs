using HealthCare_Plus;
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
    public partial class Manage_patient : Form
    {
        public Manage_patient()
        {
            InitializeComponent();
        }

        private void btn_insert_patient_Click(object sender, EventArgs e)
        {
            PatientController controller = new PatientController();

            Patient P1 = new Patient(txtPatientID.Text, txtFirstName.Text, txtLastName.Text, dtpDoB.Value, txtContactNo.Text,
                cmbGender.Text, cmbBloodGroup.Text, txtMajorDisease.Text, rtbAddress.Text);

            controller.InsertPatient(P1);
        }

        private void btn_view_patient_Click(object sender, EventArgs e)
        {
            PatientController controller = new PatientController();
            controller.ViewPatient(dataGridView_patient);
        }

        private void btn_search_patient_Click(object sender, EventArgs e)
        {
            PatientController controller = new PatientController();
            controller.SearchPatient(dataGridView_patient, txtSearchPatient.Text);
        }

        private void btn_update_patient_Click(object sender, EventArgs e)
        {
            PatientController controller = new PatientController();

            Patient P2 = new Patient(txtPatientID.Text, txtFirstName.Text, txtLastName.Text, dtpDoB.Value, txtContactNo.Text,
                cmbGender.Text, cmbBloodGroup.Text, txtMajorDisease.Text, rtbAddress.Text);

            controller.UpdatePatient(P2);
        }

        private void btn_clear_patient_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtPatientID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            dtpDoB.Value = DateTime.Today; // Reset date to today
            txtContactNo.Text = string.Empty;
            cmbGender.SelectedIndex = -1; // Deselect gender dropdown
            cmbBloodGroup.SelectedIndex = -1; // Deselect bloodgroup dropdown
            txtMajorDisease.Text = string.Empty;
            rtbAddress.Text = string.Empty;
            txtSearchPatient.Text = string.Empty;
        }

        private void btn_delete_patient_Click(object sender, EventArgs e)
        {
            PatientController controller = new PatientController();
            string patientIDToDelete = txtSearchPatient.Text;
            controller.DeletePatient(patientIDToDelete);
        }

       

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
        }

        private void btn_Diagnosis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_diagnoses diagnoses = new Manage_diagnoses();
            diagnoses.Show();
        }

        private void btn_MedicalHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_medical_history medicalhistory = new Manage_medical_history();
            medicalhistory.Show();
        }

        private void btn_LabResult_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_lab_result lab = new Manage_lab_result();
            lab.Show();
        }

        private void btn_Medication_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_medication medication = new Manage_medication();
            medication.Show();
        }

        private void txtPatientID_Leave(object sender, EventArgs e)
        {
            // Check if the Staff ID textbox is empty
            if (string.IsNullOrEmpty(txtPatientID.Text))
            {
                return; // Exit the event handler if it's empty
            }

            // Fetch staff data based on the entered Staff ID
            PatientController controller = new PatientController();
            string patientIDToSearch = txtPatientID.Text;

            // Create a method to retrieve staff data
            Patient patientData = controller.GetPatientData(patientIDToSearch);

            // Check if staff data was found
            if (patientData != null)
            {
                // Populate the other textboxes with the retrieved data
                txtFirstName.Text = patientData.FirstName;
                txtLastName.Text = patientData.LastName;
                dtpDoB.Value = patientData.DoB;
                txtContactNo.Text = patientData.ContactNo;
                cmbGender.Text = patientData.Gender;
                cmbBloodGroup.Text = patientData.BloodGroup;
                txtMajorDisease.Text = patientData.MajorDisease;
                rtbAddress.Text = patientData.Address;
            }
            else
            {
                MessageBox.Show("Patient not found with the entered Patient ID.");
            }
        }
    }
}


