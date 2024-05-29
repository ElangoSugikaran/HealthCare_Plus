using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class login : Form
    {


        public login()
        {
            InitializeComponent();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Exit the method early as validation failed
            }

            LoginController loginController = new LoginController();
            bool isAuthenticated = loginController.AuthenticateUser(email, password, role);

            if (isAuthenticated)
            {
                // Redirect to the appropriate dashboard or main application form based on the role.

                if (role == "Admin")
                {
                    Admin_Dashboard adminDashboard = new Admin_Dashboard();
                    adminDashboard.Show();
                }
                else if (role == "Receptionist")
                {
                    Receptionist_Dashboard receptionistDashboard = new Receptionist_Dashboard();
                    receptionistDashboard.Show();
                }

                // Close the login form
                this.Hide();

                // Display a success message
                MessageBox.Show("Login successful. Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid login credentials. Please check and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

