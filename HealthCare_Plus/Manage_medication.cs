using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Manage_medication : Form
    {
        public Manage_medication()
        {
            InitializeComponent();
        }

        private void btn_insert_medication_Click(object sender, EventArgs e)
        {
            MedicationController controller = new MedicationController();

            Medication M1 = new Medication(txtMedicationID.Text, txtPatientName.Text, txtDoctorName.Text, txtMedicineName.Text,
                cmbMedicineDosage.Text, dtpStartDate.Value, dtpEndDate.Value,cmbFrequecy.Text, txtMediccineCharge.Text);

            controller.InsertMedication(M1);
        }

        private void btn_view_medication_Click(object sender, EventArgs e)
        {
            MedicationController controller = new MedicationController();
            controller.ViewMedication(dataGridView_medication);
        }

        private void btn_search_medication_Click(object sender, EventArgs e)
        {
            MedicationController controller = new MedicationController();
            controller.SearchMedication(dataGridView_medication, txtSearch_Medication.Text);
        }

        private void btn_update_medication_Click(object sender, EventArgs e)
        {
            MedicationController controller = new MedicationController();

            Medication M2 = new Medication(txtMedicationID.Text, txtPatientName.Text, txtDoctorName.Text, txtMedicineName.Text,
                cmbMedicineDosage.Text, dtpStartDate.Value, dtpEndDate.Value, cmbFrequecy.Text, txtMediccineCharge.Text);

            controller.UpdateMedication(M2);
        }

        private void btn_clear_medication_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtMedicationID.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            txtDoctorName.Text = string.Empty;
            txtMedicineName.Text = string.Empty;
            cmbMedicineDosage.SelectedIndex = -1; // Deselect gender dropdown   dtpDoB.Value = DateTime.Today; // Reset date to today
            dtpStartDate.Value = DateTime.Today; // Reset date to today
            dtpEndDate.Value = DateTime.Today; // Reset date to today
            cmbFrequecy.SelectedIndex = -1;
            txtSearch_Medication.Text = string.Empty;
            txtMediccineCharge.Text = string.Empty;
        }

        private void btn_delete_medication_Click(object sender, EventArgs e)
        {
            MedicationController controller = new MedicationController();
            string medicationIDToDelete = txtSearch_Medication.Text;
            controller.DeleteMedication(medicationIDToDelete);
        }

        private void Manage_medication_Load(object sender, EventArgs e)
        {
            // retrieve code througt database table to combo box
            //Connection string to your database. Replace with your actual connection string.


            string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to select distinct 'patient_ID' values from the "patient" table
                    string sql = "SELECT DISTINCT patient_ID FROM patient";

                    SqlCommand command_patient = new SqlCommand(sql, conn);
                    SqlDataReader reader_patient = command_patient.ExecuteReader();

                    while (reader_patient.Read())
                    {
                        // Add each 'patient_ID' value to the cmbPatientID ComboBox
                        cmbPatientID.Items.Add(reader_patient["patient_ID"].ToString());
                    }

                    reader_patient.Close();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database access.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to select distinct 'patient_ID' values from the "patient" table
                    string sql = "SELECT DISTINCT doctor_ID FROM doctor";

                    SqlCommand command_doctor = new SqlCommand(sql, conn);
                    SqlDataReader reader_doctor = command_doctor.ExecuteReader();

                    while (reader_doctor.Read())
                    {
                        // Add each 'patient_ID' value to the cmbPatientID ComboBox
                        cmbDoctorID.Items.Add(reader_doctor["doctor_ID"].ToString());
                    }

                    reader_doctor.Close();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database access.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void cmbPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";
            string selectedPatientID = cmbPatientID.SelectedItem.ToString();

            // Query to retrieve patient name based on the selected patient ID
            string query = "SELECT lastname FROM patient WHERE patient_ID = @PatientID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@PatientID", selectedPatientID);

                    // Execute the query and retrieve the patient name
                    string patientName = command.ExecuteScalar() as string;

                    // Display the patient name in the textbox
                    txtPatientName.Text = patientName;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database access.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void cmbDoctorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";
            string selectedDoctorID = cmbDoctorID.SelectedItem.ToString();

            // Query to retrieve patient name based on the selected patient ID
            string query = "SELECT lastname FROM doctor WHERE doctor_ID = @DoctorID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@DoctorID", selectedDoctorID);

                    // Execute the query and retrieve the patient name
                    string doctorName = command.ExecuteScalar() as string;

                    // Display the patient name in the textbox
                    txtDoctorName.Text = doctorName;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database access.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void txtMedicationID_Leave(object sender, EventArgs e)
        {
            // Check if the Staff ID textbox is empty
            if (string.IsNullOrEmpty(txtMedicationID.Text))
            {
                return; // Exit the event handler if it's empty
            }

            // Fetch staff data based on the entered Staff ID
            MedicationController controller = new MedicationController();
            string medicationIDToSearch = txtMedicationID.Text;

            // Create a method to retrieve staff data
            Medication medicationData = controller.GetMedicationData(medicationIDToSearch);

            // Check if staff data was found
            if (medicationData != null)
            {
                // Populate the other textboxes with the retrieved data
                txtPatientName.Text = medicationData.PatientName;
                txtDoctorName.Text = medicationData.DoctorName;
                txtMedicineName.Text = medicationData.MedicineName;
                cmbMedicineDosage.Text = medicationData.MedicineDosage;
                dtpStartDate.Value = medicationData.StartDate;
                dtpEndDate.Value = medicationData.EndDate;
                cmbFrequecy.Text = medicationData.Frequcey;
                txtMediccineCharge.Text = medicationData.MedicineCharge;
            }
            else
            {
                MessageBox.Show("medication not found with the entered medication ID.");
            }
        }

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_patient patient = new Manage_patient();
            patient.Show();
        }
    }
}
