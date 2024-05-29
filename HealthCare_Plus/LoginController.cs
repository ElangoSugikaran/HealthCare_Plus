using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class LoginController

{
    private readonly string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True"; // Replace with your actual database connection string

    public bool AuthenticateUser(string email, string password, string role)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Build a SQL query to retrieve the user with the provided email, password, and role.
                string query = "SELECT COUNT(*) FROM login WHERE email = @Email AND password = @Password AND role = @Role";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Role", role);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // If a matching user is found, return true; otherwise, return false.
                    return count > 0;
                }
            }
        }
        catch (Exception ex)
        {
            // Handle any exceptions that may occur during database access.
            // You can log the error and rethrow it or return false.
            Console.WriteLine("An error occurred: " + ex.Message);
            return false;
        }
    }
}
