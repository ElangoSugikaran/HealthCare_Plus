using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    internal class Medical_HistoryController
    {

        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);

        public Medical_HistoryController() { }

        public void InsertMedicalHistory(Medical_History medicalhistoryobj)
        {
            try
            {
                if (string.IsNullOrEmpty(medicalhistoryobj.MedicalHistory_Id) || string.IsNullOrEmpty(medicalhistoryobj.PateintName) || string.IsNullOrEmpty(medicalhistoryobj.Condition) || string.IsNullOrEmpty(medicalhistoryobj.DiaggnosisDetails))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    conn.Open();

                    string insertsql = "INSERT INTO medical_history (medical_history_ID, patientname, Date, condition, diagnosis_details) " +
                        "VALUES (@MwdicalHistoryID, @PatientName, @Date, @Condition, @DiagnosisDetails)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MwdicalHistoryID", medicalhistoryobj.MedicalHistory_Id);
                        cmd.Parameters.AddWithValue("@PatientName", medicalhistoryobj.PateintName);
                        cmd.Parameters.AddWithValue("@Date", medicalhistoryobj.Date);
                        cmd.Parameters.AddWithValue("@Condition", medicalhistoryobj.Condition);
                        cmd.Parameters.AddWithValue("@DiagnosisDetails", medicalhistoryobj.DiaggnosisDetails);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Recorded Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public void ViewMedicalHistory(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM medical_history";

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

        public void SearchMedicalHistory(DataGridView dataGridView, string MedicalHistoryID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM medical_history WHERE medical_history_ID = @MedicalHistoryID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicalHistoryID", MedicalHistoryID);

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

        public void UpdateMedicalHistory(Medical_History medicalhistoryupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(medicalhistoryupdate.MedicalHistory_Id) || string.IsNullOrEmpty(medicalhistoryupdate.PateintName) || string.IsNullOrEmpty(medicalhistoryupdate.Condition) || string.IsNullOrEmpty(medicalhistoryupdate.DiaggnosisDetails))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE medical_history SET patientname =  @PatientName, date = @Date," +
                        " condition = @Condition, diagnosis_details = @DiagnosisDetails WHERE medical_history_ID = @MedicalHistoryID ";

                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MwdicalHistoryID", medicalhistoryupdate.MedicalHistory_Id);
                        cmd.Parameters.AddWithValue("@PatientName", medicalhistoryupdate.PateintName);
                        cmd.Parameters.AddWithValue("@Date", medicalhistoryupdate.Date);
                        cmd.Parameters.AddWithValue("@Condition", medicalhistoryupdate.Condition);
                        cmd.Parameters.AddWithValue("@DiagnosisDetails", medicalhistoryupdate.DiaggnosisDetails);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void DeleteMedicalHistory(string medicalhistoryIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(medicalhistoryIDToDelete))
                {
                    MessageBox.Show("Enter the medical history ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM medical_history WHERE medical_history_ID = @MedicalHistoryID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MedicalHistoryID", medicalhistoryIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given medical history ID");
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

        public Medical_History GetMedicalHistoryData(string MedicalHistoryID)
        {
            try
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM medical_history WHERE medical_history_ID = @MedicalHistoryID";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicalHistoryID",MedicalHistoryID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a Staff object and populate it with data from the reader
                            Medical_History medical_history = new Medical_History();
                            medical_history.MedicalHistory_Id= reader["medical_history_ID"].ToString();
                            medical_history.PateintName= reader["patientname"].ToString();
                            medical_history.Date = (DateTime)reader["date"];
                            medical_history.Condition = reader["condition"].ToString();
                            medical_history.DiaggnosisDetails = reader["diagnosis_details"].ToString();
                          

                            return medical_history;
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
