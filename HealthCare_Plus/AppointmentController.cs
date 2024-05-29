using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    internal class AppointmentController
    {

        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);
        public AppointmentController() { }

        //insert code for appointment

        public void InsertAppointment(Appointment appointmentobj)
        {
            try
            {
                if (string.IsNullOrEmpty(appointmentobj.AppointmnetID) || string.IsNullOrEmpty(appointmentobj.PatientName) || string.IsNullOrEmpty(appointmentobj.DoctorName) || string.IsNullOrEmpty(appointmentobj.Purpose) || string.IsNullOrEmpty(appointmentobj.Status) || string.IsNullOrEmpty(appointmentobj.AppointmentCharge))

                {
                    MessageBox.Show("missing informaton. Please fill in all required fields.");

                }
                else
                {
                    conn.Open();

                    string insertsql = "INSERT INTO appointment (appointment_ID, patientname, doctorname, date, purpose, status, appointment_charge) " +
                        "VALUES (@AppointmentID, @PatientName, @DoctorName, @Date, @Purpose, @Status, @AppointmentCharge)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentobj.AppointmnetID);
                        cmd.Parameters.AddWithValue("@PatientName", appointmentobj.PatientName);
                        cmd.Parameters.AddWithValue("@DoctorName", appointmentobj.DoctorName);
                        cmd.Parameters.AddWithValue("@Date", appointmentobj.Date);
                        cmd.Parameters.AddWithValue("@Purpose", appointmentobj.Purpose);
                        cmd.Parameters.AddWithValue("@Status", appointmentobj.Status);
                        cmd.Parameters.AddWithValue("@AppointmentCharge", appointmentobj.AppointmentCharge);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Recorded inserted Successfully");

                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }


            }

        }

        public void ViewAppointment(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM appointment";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        //search  code for patient

        public void SearchAppointment(DataGridView dataGridView, string AppointmentID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM appointment WHERE appointment_ID = @AppointmentID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // update code for staff

        public void UpdateAppointment(Appointment appointmentupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(appointmentupdate.AppointmnetID) || string.IsNullOrEmpty(appointmentupdate.PatientName) || string.IsNullOrEmpty(appointmentupdate.DoctorName) || string.IsNullOrEmpty(appointmentupdate.Purpose) || string.IsNullOrEmpty(appointmentupdate.Status) || string.IsNullOrEmpty(appointmentupdate.AppointmentCharge))

                {
                    MessageBox.Show("missing informaton. Please fill in all required fields.");
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE appointment SET patientname =  @PatientName, doctorname = @DoctorName," +
                        " date = @Date, purpose = @Purpose, status = @Status, appointment_charge = @AppointmentCharge" +
                        "  WHERE appointment_ID = @AppointmentID ";

                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentupdate.AppointmnetID);
                        cmd.Parameters.AddWithValue("@PatientName", appointmentupdate.PatientName);
                        cmd.Parameters.AddWithValue("@DoctorName", appointmentupdate.DoctorName);
                        cmd.Parameters.AddWithValue("@Date", appointmentupdate.Date);
                        cmd.Parameters.AddWithValue("@Purpose", appointmentupdate.Purpose);
                        cmd.Parameters.AddWithValue("@Status", appointmentupdate.Status);
                        cmd.Parameters.AddWithValue("@AppointmentCharge", appointmentupdate.AppointmentCharge);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. appointment member not found.");
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the database connection
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }

        // delete code for patient

        public void DeleteAppointment(string appointmentIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(appointmentIDToDelete))
                {
                    MessageBox.Show("Enter the appointment ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM appointment WHERE appointment_ID = @AppointmentID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given appointment ID");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // retrieve data for update

        public Appointment GetAppointmentData(string AppointmentID)
        {
            try
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM appointment WHERE appointment_ID = @AppointmentID";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a Staff object and populate it with data from the reader
                            Appointment appointment = new Appointment();
                            appointment.AppointmnetID = reader["appointment_ID"].ToString();
                            appointment.PatientName = reader["patientname"].ToString();
                            appointment.DoctorName = reader["doctorname"].ToString();
                            appointment.Date = (DateTime)reader["date"];
                            appointment.Purpose = reader["purpose"].ToString();
                            appointment.Status = reader["status"].ToString();
                            appointment.AppointmentCharge = reader["appointment_charge"].ToString();

                            return appointment;
                        }
                    }
                }

                // Patient not found
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // see the doctor availability this grid view

        public void ViewDoctor(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM doctor";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    DataTable dt = new DataTable();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    da.Fill(dt);

                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
