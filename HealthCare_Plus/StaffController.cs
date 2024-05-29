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
    internal class StaffController
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);
        public StaffController() { }

        // insert code for staff

        public void InsertStaff(Staff staffobj)
        {
            try
            {

                if (string.IsNullOrEmpty(staffobj.StaffID) || string.IsNullOrEmpty(staffobj.FirstName) || string.IsNullOrEmpty(staffobj.LastName) || string.IsNullOrEmpty(staffobj.ContactNo)
                    || string.IsNullOrEmpty(staffobj.Gender) || string.IsNullOrEmpty(staffobj.Role) || string.IsNullOrEmpty(staffobj.Email) || string.IsNullOrEmpty(staffobj.Password) 
                    || string.IsNullOrEmpty(staffobj.Address))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { // open the database connection
                    conn.Open();

                    string insertsql = "INSERT INTO staff (staff_ID, firstname, lastname, dob, contact_no, gender, role, email, password, address) " +
                        "VALUES (@StaffID, @FirstName, @LastName, @DoB, @ContactNo, @Gender, @Role, @Email, @Password, @Address)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", staffobj.StaffID);
                        cmd.Parameters.AddWithValue("@FirstName", staffobj.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", staffobj.LastName);
                        cmd.Parameters.AddWithValue("@DoB", staffobj.DoB);
                        cmd.Parameters.AddWithValue("@ContactNo", staffobj.ContactNo);
                        cmd.Parameters.AddWithValue("@Gender", staffobj.Gender);
                        cmd.Parameters.AddWithValue("@Role", staffobj.Role);
                        cmd.Parameters.AddWithValue("@Email", staffobj.Email);
                        cmd.Parameters.AddWithValue("@Password", staffobj.Password);
                        cmd.Parameters.AddWithValue("@Address", staffobj.Address);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Recorded inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    string insertSqllogin = "INSERT INTO login (email, password, role) " +
                           "VALUES (@Email, @Password, @Role)";

                    using (SqlCommand cmd = new SqlCommand(insertSqllogin, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", staffobj.Email);
                        cmd.Parameters.AddWithValue("@Password", staffobj.Password);
                        cmd.Parameters.AddWithValue("@Role", staffobj.Role);
                        cmd.Parameters.AddWithValue("@StaffID", staffobj.StaffID);

                        cmd.ExecuteNonQuery();
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

        public void ViewStaff(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM staff";

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

        public void SearchStaff(DataGridView dataGridView, string StaffID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM staff WHERE staff_ID = @StaffID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", StaffID);

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

        public void UpdateSatff(Staff staffupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(staffupdate.StaffID) || string.IsNullOrEmpty(staffupdate.FirstName) || string.IsNullOrEmpty(staffupdate.LastName) || 
                    string.IsNullOrEmpty(staffupdate.ContactNo) || string.IsNullOrEmpty(staffupdate.Gender) || string.IsNullOrEmpty(staffupdate.Role) || 
                    string.IsNullOrEmpty(staffupdate.Email) || string.IsNullOrEmpty(staffupdate.Password) || string.IsNullOrEmpty(staffupdate.Address))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE staff SET firstname =  @FirstName, lastname = @LastName," +
                        " dob = @DoB, contact_no = @ContactNo, gender = @Gender, role = @Role, email = @Email," +
                        " password = @Password, address = @Address WHERE staff_ID = @StaffID ";

                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", staffupdate.StaffID);
                        cmd.Parameters.AddWithValue("@FirstName", staffupdate.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", staffupdate.LastName);
                        cmd.Parameters.AddWithValue("@DoB", staffupdate.DoB);
                        cmd.Parameters.AddWithValue("@ContactNo", staffupdate.ContactNo);
                        cmd.Parameters.AddWithValue("@Gender", staffupdate.Gender);
                        cmd.Parameters.AddWithValue("@Role", staffupdate.Role);
                        cmd.Parameters.AddWithValue("@Email", staffupdate.Email);
                        cmd.Parameters.AddWithValue("@Password", staffupdate.Password);
                        cmd.Parameters.AddWithValue("@Address", staffupdate.Address);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            MessageBox.Show("Recorded Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Staff member not found.");
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

        public void DeleteStaff(string staffIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(staffIDToDelete))
                {
                    MessageBox.Show("Enter the Staff ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM staff WHERE staff_ID = @StaffID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@StaffID", staffIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given Staff ID");
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

        public Staff GetStaffData(string staffID)
        {
            try
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM staff WHERE staff_ID = @StaffID";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", staffID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a Staff object and populate it with data from the reader
                            Staff staff = new Staff();
                            staff.StaffID = reader["staff_ID"].ToString();
                            staff.FirstName = reader["firstname"].ToString();
                            staff.LastName = reader["lastname"].ToString();
                            staff.DoB = (DateTime)reader["dob"];
                            staff.ContactNo = reader["contact_no"].ToString();
                            staff.Gender = reader["gender"].ToString();
                            staff.Role = reader["role"].ToString();
                            staff.Email = reader["email"].ToString();
                            staff.Password = reader["password"].ToString();
                            staff.Address = reader["address"].ToString();

                            return staff;
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



