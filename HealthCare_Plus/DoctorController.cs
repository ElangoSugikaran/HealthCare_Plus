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
    internal class DoctorController
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);
        public DoctorController() { }

        


        // insert code for doctor

        public void InsertDoctor(Doctor doctorobj)
        {
            try
            {

                if (string.IsNullOrEmpty(doctorobj.DoctorID) || string.IsNullOrEmpty(doctorobj.FirstName) || string.IsNullOrEmpty(doctorobj.LastName) || string.IsNullOrEmpty(doctorobj.Specialization) || string.IsNullOrEmpty(doctorobj.Qualification) || string.IsNullOrEmpty(doctorobj.YearOfExperiences) || string.IsNullOrEmpty(doctorobj.Status) || string.IsNullOrEmpty(doctorobj.Gender) || string.IsNullOrEmpty(doctorobj.ContactNo) || string.IsNullOrEmpty(doctorobj.Email) ||  string.IsNullOrEmpty(doctorobj.Address))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { // open the database connection
                    conn.Open();

                    string insertsql = "INSERT INTO doctor (doctor_ID, firstname, lastname, specialization, qualification, availability_schedule, year_of_experiences, status, gender, contact_no, dob, email, address) VALUES " +
                        "(@DoctorID, @FirstName, @LastName, @Specialization, @Qualification, @AvailabilitySchedule, @YearOfExperiences,@Status, @Gender, @ContactNo, @DoB, @Email, @Address)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", doctorobj.DoctorID);
                        cmd.Parameters.AddWithValue("@FirstName", doctorobj.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", doctorobj.LastName);
                        cmd.Parameters.AddWithValue("@Specialization", doctorobj.Specialization);
                        cmd.Parameters.AddWithValue("@Qualification", doctorobj.Qualification);
                        cmd.Parameters.AddWithValue("@AvailabilitySchedule", doctorobj.AvailabilitySchedule);
                        cmd.Parameters.AddWithValue("@YearOfExperiences", doctorobj.YearOfExperiences);
                        cmd.Parameters.AddWithValue("@Status", doctorobj.Status);
                        cmd.Parameters.AddWithValue("@Gender", doctorobj.Gender);
                        cmd.Parameters.AddWithValue("@ContactNo", doctorobj.ContactNo);
                        cmd.Parameters.AddWithValue("@DoB", doctorobj.DoB);
                        cmd.Parameters.AddWithValue("@Email", doctorobj.Email);
                        cmd.Parameters.AddWithValue("@Address", doctorobj.Address);
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

        // datagridview view code for staff
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

        //search  code for staff

        public void SearchDoctor(DataGridView dataGridView, string DoctorID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM doctor WHERE doctor_ID = @DoctorID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", DoctorID);

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

        public void UpdateDoctor(Doctor doctorupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(doctorupdate.DoctorID) || string.IsNullOrEmpty(doctorupdate.FirstName) || string.IsNullOrEmpty(doctorupdate.LastName) || string.IsNullOrEmpty(doctorupdate.Specialization) || string.IsNullOrEmpty(doctorupdate.Qualification) || string.IsNullOrEmpty(doctorupdate.YearOfExperiences) || string.IsNullOrEmpty(doctorupdate.Status) || string.IsNullOrEmpty(doctorupdate.Gender) || string.IsNullOrEmpty(doctorupdate.ContactNo) || string.IsNullOrEmpty(doctorupdate.Email) || string.IsNullOrEmpty(doctorupdate.Address))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE doctor SET firstname =  @FirstName, lastname = @LastName," +
                        " specialization = @Specialization , qualification = @Qualification, availability_schedule= @AvailabilitySchedule,year_of_experiences= @YearOfExperiences, status= @Status, gender = @Gender, contact_no = @ContactNo, dob = @DoB, email = @Email," +
                        " address = @Address WHERE doctor_ID = @DoctorID ";

                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", doctorupdate.DoctorID);
                        cmd.Parameters.AddWithValue("@FirstName", doctorupdate.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", doctorupdate.LastName);
                        cmd.Parameters.AddWithValue("@Specialization", doctorupdate.Specialization);
                        cmd.Parameters.AddWithValue("@Qualification", doctorupdate.Qualification);
                        cmd.Parameters.AddWithValue("@AvailabilitySchedule", doctorupdate.AvailabilitySchedule);
                        cmd.Parameters.AddWithValue("@YearOfExperiences", doctorupdate.YearOfExperiences);
                        cmd.Parameters.AddWithValue("@Status", doctorupdate.Status);
                        cmd.Parameters.AddWithValue("@Gender", doctorupdate.Gender);
                        cmd.Parameters.AddWithValue("@ContactNo", doctorupdate.ContactNo);
                        cmd.Parameters.AddWithValue("@DoB", doctorupdate.DoB);
                        cmd.Parameters.AddWithValue("@Email", doctorupdate.Email);
                        cmd.Parameters.AddWithValue("@Address", doctorupdate.Address);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Updated Successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Dcotor member not found.");
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


        // delete code for staff

        public void DeleteDoctor(string doctorIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(doctorIDToDelete))
                {
                    MessageBox.Show("Enter the doctor ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM doctor WHERE doctor_ID = @DoctorID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@DoctorID", doctorIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given Doctor ID");
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

        public Doctor GetDoctorData(string doctorID)
        {
            try
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM doctor WHERE doctor_ID = @DoctorID";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@DoctorID", doctorID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a doctor object and populate it with data from the reader
                            Doctor doctor = new Doctor();
                            doctor.DoctorID = reader["doctor_ID"].ToString();
                            doctor.FirstName = reader["firstname"].ToString();
                            doctor.LastName = reader["lastname"].ToString();
                            doctor.Specialization = reader["specialization"].ToString();
                            doctor.Qualification = reader["qualification"].ToString();
                            doctor.AvailabilitySchedule = (DateTime)reader["availability_schedule"];
                            doctor.YearOfExperiences =reader["year_of_experiences"].ToString();
                            doctor.Status = reader["status"].ToString();
                            doctor.Gender = reader["gender"].ToString();
                            doctor.ContactNo = reader["contact_no"].ToString();
                            doctor.DoB = (DateTime)reader["dob"];
                            doctor.Email = reader["email"].ToString();
                            doctor.Address = reader["address"].ToString();
                            

                            return doctor;
                        }
                    }
                }

                // Staff not found
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
