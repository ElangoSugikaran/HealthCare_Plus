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
    public partial class Manage_appointment : Form
    {

        public Manage_appointment()
        {
            InitializeComponent();
            PopulateComboData();
        }

        private void btn_insert_appointment_Click(object sender, EventArgs e)
        {
            AppointmentController controller = new AppointmentController();

            Appointment A1 = new Appointment(txtAppointmentID.Text, txtPatientName.Text, txtDoctorName.Text, dtpAppointmentDate.Value, rtbPurpose.Text,
                cmbStatus.Text, txtAppointmentCharge.Text);

            controller.InsertAppointment(A1);
        }

        private void btn_view_appointment_Click(object sender, EventArgs e)
        {
            AppointmentController controller = new AppointmentController();
            controller.ViewAppointment(dataGridView_Appointment);
        }

        private void btn_search_appointment_Click(object sender, EventArgs e)
        {
            AppointmentController controller = new AppointmentController();
            controller.SearchAppointment(dataGridView_Appointment, txtSearchAppointment.Text);
        }

        private void btn_update_appointment_Click(object sender, EventArgs e)
        {
            AppointmentController controller = new AppointmentController();

            Appointment A2 = new Appointment(txtAppointmentID.Text, txtPatientName.Text, txtDoctorName.Text, dtpAppointmentDate.Value, rtbPurpose.Text,
                cmbStatus.Text, txtAppointmentCharge.Text);

            controller.UpdateAppointment(A2);
        }

        private void btn_clear_appointment_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtAppointmentID.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            txtDoctorName.Text = string.Empty;
            dtpAppointmentDate.Value = DateTime.Today; // Reset date to today
            rtbPurpose.Text = string.Empty;
            cmbStatus.SelectedIndex = -1; // Deselect gender dropdown
            txtAppointmentCharge.Text = string.Empty; // Deselect bloodgroup dropdown
            txtSearchAppointment.Text = string.Empty;
           
        }

        private void btn_delete_appointment_Click(object sender, EventArgs e)
        {
            AppointmentController controller = new AppointmentController();
            string appointmentIDToDelete = txtSearchAppointment.Text;
            controller.DeleteAppointment(appointmentIDToDelete);
        }

        private void txtAppointmentID_Leave(object sender, EventArgs e)
        {
            // Check if the Patient ID textbox is empty
            if (string.IsNullOrEmpty(txtAppointmentID.Text))
            {
                return; // Exit the event handler if it's empty
            }

            // Fetch patient data based on the entered Patient ID
            AppointmentController controller = new AppointmentController();
            string appointmentIDToSearch = txtAppointmentID.Text;
            Appointment appointmentData = controller.GetAppointmentData(appointmentIDToSearch); // Create a method to retrieve patient data

            // Check if patient data was found
            if (appointmentData != null)
            {
                // Populate the other textboxes with the retrieved data
                txtPatientName.Text = appointmentData.PatientName;
                txtDoctorName.Text = appointmentData.DoctorName;
                dtpAppointmentDate.Value = appointmentData.Date;
                rtbPurpose.Text = appointmentData.Purpose;
                cmbStatus.Text = appointmentData.Status;
                txtAppointmentCharge.Text = appointmentData.AppointmentCharge;

            }
            else
            {
                MessageBox.Show("appointment not found with the entered appointment ID.");
            }
        }

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptionist_Dashboard receptionistDashboard = new Receptionist_Dashboard();
            receptionistDashboard.Show();
        }

        private void btn_view_docoter_Click(object sender, EventArgs e)
        {
            AppointmentController controller = new AppointmentController();
            controller.ViewDoctor(dataGridView_doctor_appointment);
        }

        private void Manage_appointment_Load(object sender, EventArgs e)
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

           /* using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to select distinct 'patient_ID' values from the "patient" table
                    string sql = "SELECT DISTINCT lastname FROM doctor";

                    SqlCommand command_doctor = new SqlCommand(sql, conn);
                    SqlDataReader reader_doctor = command_doctor.ExecuteReader();

                    while (reader_doctor.Read())
                    {
                        // Add each 'patient_ID' value to the cmbPatientID ComboBox
                        cmbDoctorName.Items.Add(reader_doctor["lastname"].ToString());
                    }

                    reader_doctor.Close();
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
                    string sql = "SELECT DISTINCT specialization FROM doctor";

                    SqlCommand command_specialization = new SqlCommand(sql, conn);
                    SqlDataReader reader_specialization = command_specialization.ExecuteReader();

                    while (reader_specialization.Read())
                    {
                        // Add each 'patient_ID' value to the cmbPatientID ComboBox
                        cmbSpecialization.Items.Add(reader_specialization["specialization"].ToString());
                    }

                    reader_specialization.Close();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database access.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }*/

        }

        // by selecting in combo box particular id it retrieve namce or etc.. to code for text box

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

        
        private void PopulateComboData()
        {
            // Populate doctor names
            PopulateComboBox("SELECT DISTINCT lastname FROM doctor", cmbDoctorName);

            // Populate specializations
            PopulateComboBox("SELECT DISTINCT specialization FROM doctor", cmbSpecialization);

            // Populate status
            cmbStatus.Items.Add("Availbale");
            cmbStatus.Items.Add("No Available");
            // ... add other status options as needed
        }

        private void PopulateComboBox(string query, ComboBox comboBox)
        {
            string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";
            // Populate doctor names
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader[0].ToString());
                }
            }
        }

        private void btn_search_doctor_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";
            string selectedDoctor = cmbDoctorName.SelectedItem?.ToString();
            string selectedSpecialization = cmbSpecialization.SelectedItem?.ToString();
            DateTime selectedDate = dtpAvailability_Schedule.Value;
            string selectedStatus = cmbStatus.SelectedItem?.ToString();

            // Construct the SQL query based on the selected values
            string query = "SELECT * FROM doctor WHERE 1=1";

            if (!string.IsNullOrEmpty(selectedDoctor))
                query += $" AND lastname = '{selectedDoctor}'";

            if (!string.IsNullOrEmpty(selectedSpecialization))
                query += $" AND specialization = '{selectedSpecialization}'";

            query += $" AND availability_schedule = '{selectedDate.ToString("yyyy-MM-dd")}'";

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

                dataGridView_doctor_appointment.DataSource = dataTable;
            }
        }
    }

}