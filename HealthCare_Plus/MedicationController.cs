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
    internal class MedicationController
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);

        public MedicationController() { }

        public void InsertMedication(Medication medicationobj)
        {
            try
            {
                if (string.IsNullOrEmpty(medicationobj.MedicationId) || string.IsNullOrEmpty(medicationobj.PatientName) || string.IsNullOrEmpty(medicationobj.DoctorName) || string.IsNullOrEmpty(medicationobj.MedicineName) || string.IsNullOrEmpty(medicationobj.MedicineDosage) || string.IsNullOrEmpty(medicationobj.Frequcey))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    conn.Open();

                    string insertsql = "INSERT INTO medication (medication_ID, patientname, doctorname, medicinename, medicinedoasge, startdate, enddate, frequecy, medicinecharge) " +
                        "VALUES (@MedicationID, @PatientName, @DoctorName, @MedicineName, @MedicineDosage, @StartDate, @EndDate, @Frequecy, @MedicineCharge)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MedicationID", medicationobj.MedicationId);
                        cmd.Parameters.AddWithValue("@PatientName", medicationobj.PatientName);
                        cmd.Parameters.AddWithValue("@DoctorName", medicationobj.DoctorName);
                        cmd.Parameters.AddWithValue("@MedicineName", medicationobj.MedicineName);
                        cmd.Parameters.AddWithValue("@MedicineDosage", medicationobj.MedicineDosage);
                        cmd.Parameters.AddWithValue("@StartDate", medicationobj.StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", medicationobj.EndDate);
                        cmd.Parameters.AddWithValue("@Frequecy", medicationobj.Frequcey);
                        cmd.Parameters.AddWithValue("@MedicineCharge", medicationobj.MedicineCharge);

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

        public void ViewMedication(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM medication";

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

        public void SearchMedication(DataGridView dataGridView, string MedicationID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM medication WHERE medication_ID = @MedicationID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicationID", MedicationID);

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

        public void UpdateMedication(Medication medicationupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(medicationupdate.MedicationId) || string.IsNullOrEmpty(medicationupdate.PatientName) || string.IsNullOrEmpty(medicationupdate.DoctorName) || string.IsNullOrEmpty(medicationupdate.MedicineName) || string.IsNullOrEmpty(medicationupdate.MedicineDosage) || string.IsNullOrEmpty(medicationupdate.Frequcey))
                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE medication SET patientname =  @PatientName, Doctorname = @DoctorName," +
                        " medicinename = @MedicineName, medicinedoasge = @MedicineDosage, startdate = @StartDate, enddate = @EndDate, frequecy = @Frequecy, medicinecharge = @MedicineCharge WHERE medication_ID = @MedicationID ";

                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MedicationID", medicationupdate.MedicationId);
                        cmd.Parameters.AddWithValue("@PatientName", medicationupdate.PatientName);
                        cmd.Parameters.AddWithValue("@DoctorName", medicationupdate.DoctorName);
                        cmd.Parameters.AddWithValue("@MedicineName", medicationupdate.MedicineName);
                        cmd.Parameters.AddWithValue("@MedicineDosage", medicationupdate.MedicineDosage);
                        cmd.Parameters.AddWithValue("@StartDate", medicationupdate.StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", medicationupdate.EndDate);
                        cmd.Parameters.AddWithValue("@Frequecy", medicationupdate.Frequcey);
                        cmd.Parameters.AddWithValue("@MedicineCharge", medicationupdate.MedicineCharge);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. medicationnot found.");
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

        public void DeleteMedication(string medicationIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(medicationIDToDelete))
                {
                    MessageBox.Show("Enter the medication ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM patient WHERE patient_ID = @PatientID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MedicationID", medicationIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given medication ID");
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

        public Medication GetMedicationData(string MedicationID)
        {
            try
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM medication WHERE medication_ID = @MedicationID";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@MedicationID", MedicationID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a Staff object and populate it with data from the reader
                            Medication medication = new Medication();
                            medication.MedicationId = reader["medication_ID"].ToString();
                            medication.PatientName = reader["patientname"].ToString();
                            medication.DoctorName = reader["doctorname"].ToString();
                            medication.MedicineName = reader["medicinename"].ToString();
                            medication.MedicineDosage = reader["medicinedoasge"].ToString();
                            medication.StartDate = (DateTime)reader["startdate"];
                            medication.EndDate = (DateTime)reader["enddate"];
                            medication.Frequcey = reader["frequecy"].ToString();
                            medication.MedicineCharge = reader["medicinecharge"].ToString();

                            return medication;
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
