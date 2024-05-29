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
    internal class TheaterController
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);

        public TheaterController() { }

        public void InsertTheater(Theater theaterobj)
        {
            try
            {
                if (string.IsNullOrEmpty(theaterobj.TheaterId) || string.IsNullOrEmpty(theaterobj.PatientName) || string.IsNullOrEmpty(theaterobj.DoctorName) || string.IsNullOrEmpty(theaterobj.Status) || string.IsNullOrEmpty(theaterobj.Location))

                {
                    MessageBox.Show("missing informaton. Please fill in all required fields.");

                }
                else
                {
                    conn.Open();

                    string insertsql = "INSERT INTO theater (theater_ID, patientname, doctorname, scheduled_date, status, location) " +
                        "VALUES (@TheaterID, @PatientName, @DoctorName, @ScheduleDate, @Status, @Location)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TheaterID", theaterobj.TheaterId);
                        cmd.Parameters.AddWithValue("@PatientName", theaterobj.PatientName);
                        cmd.Parameters.AddWithValue("@DoctorName", theaterobj.DoctorName);
                        cmd.Parameters.AddWithValue("@ScheduleDate", theaterobj.ScheduledDate);
                        cmd.Parameters.AddWithValue("@Status", theaterobj.Status);
                        cmd.Parameters.AddWithValue("@Location", theaterobj.Location);

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

        //datagridview view code for patient

        public void ViewTheater(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM theater";

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

        public void SearchTheater(DataGridView dataGridView, string TheaterID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM theater WHERE theater_ID = @TheaterID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@TheaterID", TheaterID);

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

        public void UpdateTheater(Theater theaterupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(theaterupdate.TheaterId) || string.IsNullOrEmpty(theaterupdate.PatientName) || string.IsNullOrEmpty(theaterupdate.DoctorName) || string.IsNullOrEmpty(theaterupdate.Status) || string.IsNullOrEmpty(theaterupdate.Location))

                {
                    MessageBox.Show("missing informaton. Please fill in all required fields.");
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE theater SET patientname =  @PatientName, doctorname = @DoctorName," +
                        " scheduled_date = @ScheduledDate, status = @Status, location = @Location WHERE theater_ID = @TheaterID ";

                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TheaterID", theaterupdate.TheaterId);
                        cmd.Parameters.AddWithValue("@PatientName", theaterupdate.PatientName);
                        cmd.Parameters.AddWithValue("@DoctorName", theaterupdate.DoctorName);
                        cmd.Parameters.AddWithValue("@ScheduledDate", theaterupdate.ScheduledDate);
                        cmd.Parameters.AddWithValue("@Status", theaterupdate.Status);
                        cmd.Parameters.AddWithValue("@Location", theaterupdate.Location);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. theater member not found.");
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

        public void DeleteTheater(string theaterIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(theaterIDToDelete))
                {
                    MessageBox.Show("Enter the theater ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM theater WHERE theater_ID = @TheaterID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@TheaterID", theaterIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given theater ID");
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

        public Theater GetTheaterData(string TheaterID)
        {
            try
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM theater WHERE theater_ID = @TheaterID";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@TheaterID", TheaterID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a Staff object and populate it with data from the reader
                            Theater theater = new Theater();
                            theater.TheaterId = reader["theater_ID"].ToString();
                            theater.PatientName = reader["patientname"].ToString();
                            theater.DoctorName = reader["doctorname"].ToString();
                            theater.ScheduledDate = (DateTime)reader["scheduled_date"];
                            theater.Status = reader["status"].ToString();
                            theater.Location = reader["location"].ToString();

                            return theater;
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

        public void ViewTheater_2(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM theater";

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
