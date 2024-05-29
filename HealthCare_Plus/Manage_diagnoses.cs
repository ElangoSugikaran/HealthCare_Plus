using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Manage_diagnoses : Form
    {
        
        public Manage_diagnoses()
        {
            InitializeComponent();

        }

        private void btn_insert_diagnoses_Click(object sender, EventArgs e)
        {
            DiagnosesController controller = new DiagnosesController();

            Diagnoses D1 = new Diagnoses(txtDiagnosesID.Text, cmbPatientID_diagmosis.Text, txtPatientName.Text, dtpDate.Value, rtbDiagnosesDescription.Text);

            controller.InsertDiagnoses(D1);
        }

        private void btn_view_diagnoses_Click(object sender, EventArgs e)
        {
            DiagnosesController controller = new DiagnosesController();
            controller.ViewDiagnoses(dataGridView_diagnoses);
        }

        private void btn_search_diagnoses_Click(object sender, EventArgs e)
        {
            DiagnosesController controller = new DiagnosesController();
            controller.SearchDiagnoses(dataGridView_diagnoses, txtSearch_Diagnoses.Text);
        }

        private void btn_update_diagnoses_Click(object sender, EventArgs e)
        {
            DiagnosesController controller = new DiagnosesController();

            Diagnoses D2 = new Diagnoses(txtDiagnosesID.Text, cmbPatientID_diagmosis.Text, txtPatientName.Text, dtpDate.Value, rtbDiagnosesDescription.Text);

            controller.UpdateDiagnoses(D2);
        }

        private void btn_delete_diagnoses_Click(object sender, EventArgs e)
        {
            DiagnosesController controller = new DiagnosesController();
            string diagnosesIDToDelete = txtSearch_Diagnoses.Text;
            controller.DeleteDiagnoses(diagnosesIDToDelete);
        }

        private void btn_clear_diagnoses_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtDiagnosesID.Text = string.Empty;
            cmbPatientID_diagmosis.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            dtpDate.Value = DateTime.Today; // Reset date to today
            rtbDiagnosesDescription.Text = string.Empty;
            txtSearch_Diagnoses.Text = string.Empty;
        }

        private void txtDiagnosesID_Leave(object sender, EventArgs e)
        {
            // Check if the Patient ID textbox is empty
            if (string.IsNullOrEmpty(txtDiagnosesID.Text))
            {
                return; // Exit the event handler if it's empty
            }

            // Fetch patient data based on the entered Patient ID
            DiagnosesController controller = new DiagnosesController();
            string diagnosesIDToSearch = txtDiagnosesID.Text;
            Diagnoses diagnosesData = controller.GetDiagnosesData(diagnosesIDToSearch); // Create a method to retrieve patient data

            // Check if patient data was found
            if (diagnosesData != null)
            {
                // Populate the other textboxes with the retrieved data
                cmbPatientID_diagmosis.Text = diagnosesData.PatientId;
                txtPatientName.Text = diagnosesData.PatientName;
                dtpDate.Value = diagnosesData.Date;
                rtbDiagnosesDescription.Text = diagnosesData.DiagnosesDescription;

            }
            else
            {
                MessageBox.Show("diagnoses not found with the entered diagnoses ID.");
            }
        }

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_patient patient = new Manage_patient();
            patient.Show();
        }

        private void Manage_diagnoses_Load(object sender, EventArgs e)
        {
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
                        cmbPatientID_diagmosis.Items.Add(reader_patient["patient_ID"].ToString());
                    }

                    reader_patient.Close();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database access.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cmbPatientID_diagmosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";
            string selectedPatientID = cmbPatientID_diagmosis.SelectedItem.ToString();

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
    }
}
