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
    internal class DiagnosesController
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);

        public DiagnosesController() { }

        public void InsertDiagnoses(Diagnoses diagnosesobj)
        {
            try
            {
                if (string.IsNullOrEmpty(diagnosesobj.DiagnosesId) || string.IsNullOrEmpty(diagnosesobj.PatientId) || string.IsNullOrEmpty(diagnosesobj.PatientName) || string.IsNullOrEmpty(diagnosesobj.DiagnosesDescription))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    conn.Open();

                    string insertsql = "INSERT INTO diagnoses (diagnoses_ID, patient_ID, patientname, date, diagnoses_description) " +
                        "VALUES (@DiagnosesID, @PatientID, @PatientName, @Date, @DiagnosesDescription)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DiagnosesID", diagnosesobj.DiagnosesId);
                        cmd.Parameters.AddWithValue("@PatientID", diagnosesobj.PatientId);
                        cmd.Parameters.AddWithValue("@PatientName", diagnosesobj.PatientName);
                        cmd.Parameters.AddWithValue("@Date", diagnosesobj.Date);
                        cmd.Parameters.AddWithValue("@DiagnosesDescription", diagnosesobj.DiagnosesDescription);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Recorded inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public void ViewDiagnoses(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM diagnoses";

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

        public void SearchDiagnoses(DataGridView dataGridView, string DiagnosesID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM diagnoses WHERE diagnoses_ID = @DiagnosesID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@DiagnosesID", DiagnosesID);

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


        public void UpdateDiagnoses(Diagnoses diagnosesupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(diagnosesupdate.DiagnosesId) || string.IsNullOrEmpty(diagnosesupdate.PatientId) || string.IsNullOrEmpty(diagnosesupdate.PatientName) || string.IsNullOrEmpty(diagnosesupdate.DiagnosesDescription))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE diagnoses SET patient_ID =  @PatientID, patientname = @PatientName," +
                        "date = @Date, diagnoses_description = @DiagnosesDescription WHERE diagnoses_ID = @DiagnosesID ";

                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DiagnosesID", diagnosesupdate.DiagnosesId);
                        cmd.Parameters.AddWithValue("@PatientID", diagnosesupdate.PatientId);
                        cmd.Parameters.AddWithValue("@PatientName", diagnosesupdate.PatientName);
                        cmd.Parameters.AddWithValue("@Date", diagnosesupdate.Date);
                        cmd.Parameters.AddWithValue("@DiagnosesDescription", diagnosesupdate.DiagnosesDescription);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. diagnosos member not found.");
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

        public void DeleteDiagnoses(string diagnosesIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(diagnosesIDToDelete))
                {
                    MessageBox.Show("Enter the diagnoses ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM diagnoses WHERE diagnoses_ID = @DiagnosesID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DiagnosesID", diagnosesIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given diagnoses ID");
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

        public Diagnoses GetDiagnosesData(string DiagnosesID)
        {
            try
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM diagnoses WHERE diagnoses_ID = @DiagnosesID";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@DiagnosesID", DiagnosesID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a Staff object and populate it with data from the reader
                            Diagnoses diagnoses = new Diagnoses();
                            diagnoses.DiagnosesId = reader["diagnoses_ID"].ToString();
                            diagnoses.PatientId = reader["patient_ID"].ToString();
                            diagnoses.PatientName = reader["patientname"].ToString();
                            diagnoses.Date = (DateTime)reader["date"];
                            diagnoses.DiagnosesDescription = reader["diagnoses_description"].ToString();

                            return diagnoses;
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


    }
}
