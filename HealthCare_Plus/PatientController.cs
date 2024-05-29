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
    internal class PatientController
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection (connectionString);
        

        public PatientController() { } // want to code it

        //insert code for patient

        public void InsertPatient(Patient patientobj)
        {
            try
            {
                if (string.IsNullOrEmpty(patientobj.PatientId) || string.IsNullOrEmpty(patientobj.FirstName) || string.IsNullOrEmpty(patientobj.LastName) || string.IsNullOrEmpty(patientobj.ContactNo) || string.IsNullOrEmpty(patientobj.Gender) || string.IsNullOrEmpty(patientobj.BloodGroup) || string.IsNullOrEmpty(patientobj.MajorDisease) || string.IsNullOrEmpty(patientobj.Address))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    conn.Open();

                    string insertsql = "INSERT INTO patient (patient_ID, firstname, lastname, dob, contact_no, gender, blood_group, major_disease, address) " +
                        "VALUES (@PatientID, @FirstName, @LastName, @DoB, @ContactNo, @Gender, @BloodGroup, @MajorDisease, @Address)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientobj.PatientId);
                        cmd.Parameters.AddWithValue("@FirstName", patientobj.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", patientobj.LastName);
                        cmd.Parameters.AddWithValue("@DoB", patientobj.DoB);
                        cmd.Parameters.AddWithValue("@ContactNo", patientobj.ContactNo);
                        cmd.Parameters.AddWithValue("@Gender", patientobj.Gender);
                        cmd.Parameters.AddWithValue("@BloodGroup", patientobj.BloodGroup);
                        cmd.Parameters.AddWithValue("@MajorDisease", patientobj.MajorDisease);
                        cmd.Parameters.AddWithValue("@Address", patientobj.Address);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Recorded inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

            }
            catch(Exception ex)
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

        public void ViewPatient(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM patient";

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

        public void SearchPatient(DataGridView dataGridView, string PatientID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM patient WHERE patient_ID = @PatientID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);

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

        public void UpdatePatient(Patient patientupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(patientupdate.PatientId) || string.IsNullOrEmpty(patientupdate.FirstName) || string.IsNullOrEmpty(patientupdate.LastName) || string.IsNullOrEmpty(patientupdate.ContactNo) || string.IsNullOrEmpty(patientupdate.Gender) || string.IsNullOrEmpty(patientupdate.BloodGroup) || string.IsNullOrEmpty(patientupdate.MajorDisease) || string.IsNullOrEmpty(patientupdate.Address))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE patient SET firstname =  @FirstName, lastname = @LastName," +
                        " dob = @DoB, contact_no = @ContactNo, gender = @Gender, blood_group = @BloodGroup, major_disease = @MajorDisease," +
                        " address = @Address WHERE patient_ID = @PatientID ";

                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientupdate.PatientId);
                        cmd.Parameters.AddWithValue("@FirstName", patientupdate.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", patientupdate.LastName);
                        cmd.Parameters.AddWithValue("@DoB", patientupdate.DoB);
                        cmd.Parameters.AddWithValue("@ContactNo", patientupdate.ContactNo);
                        cmd.Parameters.AddWithValue("@Gender", patientupdate.Gender);
                        cmd.Parameters.AddWithValue("@BloodGroup", patientupdate.BloodGroup);
                        cmd.Parameters.AddWithValue("@MajorDisease", patientupdate.MajorDisease);
                        cmd.Parameters.AddWithValue("@Address", patientupdate.Address);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. patient member not found.");
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

        public void DeletePatient(string patientIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(patientIDToDelete))
                {
                    MessageBox.Show("Enter the patient ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM patient WHERE patient_ID = @PatientID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given patient ID");
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

        public Patient GetPatientData(string PatientID)
        {
            try
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM patient WHERE patient_ID = @PatientID";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@PatientID", PatientID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a Staff object and populate it with data from the reader
                            Patient patient = new Patient();
                            patient.PatientId = reader["patient_ID"].ToString();
                            patient.FirstName = reader["firstname"].ToString();
                            patient.LastName = reader["lastname"].ToString();
                            patient.DoB = (DateTime)reader["dob"];
                            patient.ContactNo = reader["contact_no"].ToString();
                            patient.Gender = reader["gender"].ToString();
                            patient.BloodGroup = reader["blood_group"].ToString();
                            patient.MajorDisease = reader["major_disease"].ToString();
                            patient.Address = reader["address"].ToString();

                            return patient;
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


