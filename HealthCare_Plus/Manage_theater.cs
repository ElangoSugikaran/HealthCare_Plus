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
    public partial class Manage_theater : Form
    {
        public Manage_theater()
        {
            InitializeComponent();
            PopulateComboData();
        }

        private void btn_insert_theater_Click(object sender, EventArgs e)
        {
            TheaterController controller = new TheaterController();

            Theater T1 = new Theater(txtTheaterID.Text, txtPatientName.Text, txtDoctorName.Text, dtpDate.Value, cmbStatus.Text,
                cmbLocation.Text);

            controller.InsertTheater(T1);
        }

        private void btn_view_theater_Click(object sender, EventArgs e)
        {
            TheaterController controller = new TheaterController();
            controller.ViewTheater(dataGridView_resource);
        }

        private void btn_search_theater_Click(object sender, EventArgs e)
        {
            TheaterController controller = new TheaterController();
            controller.SearchTheater(dataGridView_resource, txtSearch_Theater.Text);
        }

        private void btn_update_theater_Click(object sender, EventArgs e)
        {
            TheaterController controller = new TheaterController();


            Theater T2 = new Theater(txtTheaterID.Text, txtPatientName.Text, txtDoctorName.Text, dtpDate.Value, cmbStatus.Text,
                cmbLocation.Text);

            controller.UpdateTheater(T2);
        }

        private void btn_delete_theater_Click(object sender, EventArgs e)
        {
            TheaterController controller = new TheaterController();
            string theaterIDToDelete = txtSearch_Theater.Text;
            controller.DeleteTheater(theaterIDToDelete);
        }

        private void btn_clear_theater_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtTheaterID.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            txtDoctorName.Text = string.Empty;
            dtpDate.Value = DateTime.Today; // Reset date to today
            cmbStatus.SelectedIndex = -1;
            cmbLocation.SelectedIndex = -1; // Deselect gender dropdown
            txtSearch_Theater.Text= string.Empty;
        }

        private void txtTheaterID_Leave(object sender, EventArgs e)
        {
            // Check if the Patient ID textbox is empty
            if (string.IsNullOrEmpty(txtTheaterID.Text))
            {
                return; // Exit the event handler if it's empty
            }

            // Fetch patient data based on the entered Patient ID
            TheaterController controller = new TheaterController();
            string theaterIDToSearch = txtTheaterID.Text;
            Theater theaterData = controller.GetTheaterData(theaterIDToSearch); // Create a method to retrieve patient data

            // Check if patient data was found
            if (theaterData != null)
            {
                // Populate the other textboxes with the retrieved data
                txtPatientName.Text = theaterData.PatientName;
                txtDoctorName.Text = theaterData.DoctorName;
                dtpDate.Value = theaterData.ScheduledDate;
                cmbStatus.Text = theaterData.Status;
                cmbLocation.Text = theaterData.Location;
            }
            else
            {
                MessageBox.Show("theater not found with the entered theater ID.");
            }
        }

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
        }

        private void Manage_theater_Load(object sender, EventArgs e)
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

        private void btn_view_2_Click(object sender, EventArgs e)
        {
            TheaterController controller = new TheaterController();
            controller.ViewTheater_2(dataGridView_theater_2);
        }

        private void PopulateComboData()
        {

            // Populate status
            cmb_status_theater.Items.Add("Availbale");
            cmb_status_theater.Items.Add("No Available");
            // ... add other status options as needed
        }

       

        private void btn_search_2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";
           
            DateTime selectedDate = dtp_schedule_date.Value;
            string selectedStatus = cmb_status_theater.SelectedItem?.ToString();

            // Construct the SQL query based on the selected values
            string query = "SELECT * FROM theater WHERE 1=1";

            query += $" AND scheduled_date = '{selectedDate.ToString("yyyy-MM-dd")}'";

            if (!string.IsNullOrEmpty(selectedStatus))
                query += $" AND status = '{selectedStatus}'";

            // Execute the query and display the results in the DataGridView
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView_theater_2.DataSource = dataTable;
            }
        }
    }
}
    


