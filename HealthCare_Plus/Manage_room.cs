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
    public partial class Manage_room : Form
    {
        public Manage_room()
        {
            InitializeComponent();
        }

        private void Manage_room_Load(object sender, EventArgs e)
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

        }

        private void cmbPatientID_Leave(object sender, EventArgs e)
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
    }
}
