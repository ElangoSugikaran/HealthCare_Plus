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
    internal class LabResultController
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);


        public LabResultController() { }

        //insert code for patient

        public void InsertLabResult(LabResult labresultobj)
        {
            try
            {
                if (string.IsNullOrEmpty(labresultobj.LabResult_Id) || string.IsNullOrEmpty(labresultobj.PatientName) || string.IsNullOrEmpty(labresultobj.TestType) || string.IsNullOrEmpty(labresultobj.LabResult_Details))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    conn.Open();

                    string insertsql = "INSERT INTO lab_result (labresult_ID, patientname, test_type, date, result_details) " +
                        "VALUES (@LabResultID, @PatientName, @TestType, @Date, @ResultDetails)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@LabResultID", labresultobj.LabResult_Id);
                        cmd.Parameters.AddWithValue("@PatientName", labresultobj.PatientName);
                        cmd.Parameters.AddWithValue("@TestType", labresultobj.TestType);
                        cmd.Parameters.AddWithValue("@Date", labresultobj.Date);
                        cmd.Parameters.AddWithValue("@ResultDetails", labresultobj.LabResult_Details);

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

        public void ViewLabResult(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM lab_result";

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

        public void SearchLabResult(DataGridView dataGridView, string LabResultID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM lab_result WHERE labresult_ID = @LabResultID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@LabResultID", LabResultID);

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

        public void UpdateLabResult(LabResult labresultupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(labresultupdate.LabResult_Id) || string.IsNullOrEmpty(labresultupdate.PatientName) || string.IsNullOrEmpty(labresultupdate.TestType) || string.IsNullOrEmpty(labresultupdate.LabResult_Details))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE lab_result SET patientname =  @PatientName, test_type = @TestType," +
                        " date = @Date, result_details = @ResultDetails WHERE labresult_ID = @LabResultID ";

                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@LabResultID", labresultupdate.LabResult_Id);
                        cmd.Parameters.AddWithValue("@PatientName", labresultupdate.PatientName);
                        cmd.Parameters.AddWithValue("@TestType", labresultupdate.TestType);
                        cmd.Parameters.AddWithValue("@Date", labresultupdate.Date);
                        cmd.Parameters.AddWithValue("@ResultDetails", labresultupdate.LabResult_Details);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. lab result not found.");
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

        public void DeleteLabResult(string labresultIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(labresultIDToDelete))
                {
                    MessageBox.Show("Enter the lab result ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM lab_result WHERE labresult_ID = @LabResultID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@LabResultID", labresultIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given lab result ID");
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

        public LabResult GetLabResultData(string LabResultID)
        {
            try
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM lab_result WHERE labresult_ID = @LabResultID";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@LabResultID", LabResultID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a Staff object and populate it with data from the reader
                            LabResult labresult = new LabResult();
                            labresult.LabResult_Id = reader["labresult_ID"].ToString();
                            labresult.PatientName = reader["patientname"].ToString();
                            labresult.TestType = reader["test_type"].ToString();
                            labresult.Date = (DateTime)reader["date"];
                            labresult.LabResult_Details = reader["result_details"].ToString();

                            return labresult;
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
