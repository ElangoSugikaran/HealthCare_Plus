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
    internal class ResourceController
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);

        public ResourceController() { }

        //insert code for patient

        public void InsertResource(Resource resourceobj)
        {
            try
            {
                if (string.IsNullOrEmpty(resourceobj.ResourceId) || string.IsNullOrEmpty(resourceobj.TypeResource) || string.IsNullOrEmpty(resourceobj.ResourceName) || string.IsNullOrEmpty(resourceobj.Available) || string.IsNullOrEmpty(resourceobj.Cost) || string.IsNullOrEmpty(resourceobj.Location))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    conn.Open();

                    string insertsql = "INSERT INTO resource (resource_ID, type_resource, resource_name, available, cost, location) " +
                        "VALUES (@ResourceID, @TypeResource, @ResourceName, @Available, @Cost, @Location)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ResourceID", resourceobj.ResourceId);
                        cmd.Parameters.AddWithValue("@TypeResource", resourceobj.TypeResource);
                        cmd.Parameters.AddWithValue("@ResourceName", resourceobj.ResourceName);
                        cmd.Parameters.AddWithValue("@Available", resourceobj.Available);
                        cmd.Parameters.AddWithValue("@Cost", resourceobj.Cost);
                        cmd.Parameters.AddWithValue("@Location", resourceobj.Location);

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

        public void ViewResource(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM resource";

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

        public void SearchResource(DataGridView dataGridView, string ResourceID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM resource WHERE resource_ID = @ResourceID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@ResourceID", ResourceID);

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

        public void UpdateResource(Resource resourceupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(resourceupdate.ResourceId) || string.IsNullOrEmpty(resourceupdate.TypeResource) || string.IsNullOrEmpty(resourceupdate.ResourceName) || string.IsNullOrEmpty(resourceupdate.Available) || string.IsNullOrEmpty(resourceupdate.Cost) || string.IsNullOrEmpty(resourceupdate.Location))

                {
                    MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE resource SET type_resource =  @TypeResource, resource_name = @ResourceName," +
                        " available = @Available, cost = @Cost, location = @Location WHERE resource_ID = @ResourceID ";

                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ResourceID", resourceupdate.ResourceId);
                        cmd.Parameters.AddWithValue("@TypeResource", resourceupdate.TypeResource);
                        cmd.Parameters.AddWithValue("@ResourceName", resourceupdate.ResourceName);
                        cmd.Parameters.AddWithValue("@Available", resourceupdate.Available);
                        cmd.Parameters.AddWithValue("@Cost", resourceupdate.Cost);
                        cmd.Parameters.AddWithValue("@Location", resourceupdate.Location);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. resource member not found.");
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

        public void DeleteResource(string resourceIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(resourceIDToDelete))
                {
                    MessageBox.Show("Enter the resource ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM resource WHERE resource_ID = @ResourceID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ResourceID", resourceIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Recorded Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given resource ID");
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

        public Resource GetResourceData(string ResourceID)
        {
            try
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM resource WHERE resource_ID = @ResourceID";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@ResourceID", ResourceID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a Staff object and populate it with data from the reader
                            Resource resource = new Resource();
                            resource.ResourceId = reader["resource_ID"].ToString();
                            resource.TypeResource = reader["type_resource"].ToString();
                            resource.ResourceName = reader["resource_name"].ToString();
                            resource.Available = reader["available"].ToString();
                            resource.Cost = reader["cost"].ToString();
                            resource.Location = reader["location"].ToString();

                            return resource;
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
