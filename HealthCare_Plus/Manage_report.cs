using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Manage_report : Form
    {
        private DataTable patientDataTable;
        private DataTable doctorDataTable;
        private DataTable staffDataTable;
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";
        public Manage_report()
        {
            InitializeComponent();
        }

        private void RetrieveData()
        {
            // Create a new DataTable
            patientDataTable = new DataTable();

            // SQL query to retrieve data from the database table
            string query = "SELECT * FROM patient";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Fill the DataTable with data from the database
                    adapter.Fill(patientDataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
                }
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);

            int topMargin = 50;
            int leftMargin = 50;
            int rowHeight = 30;

            // Print headers
            for (int j = 0; j < patientDataTable.Columns.Count; j++)
            {
                g.DrawString(patientDataTable.Columns[j].ColumnName, font, Brushes.Black, leftMargin + (j * 100), topMargin);
            }

            topMargin += rowHeight;

            // Print data
            for (int i = 0; i < patientDataTable.Rows.Count; i++)
            {
                for (int j = 0; j < patientDataTable.Columns.Count; j++)
                {
                    g.DrawString(patientDataTable.Rows[i][j].ToString(), font, Brushes.Black, leftMargin + (j * 100), topMargin + (i * rowHeight));
                }
            }
        }

        private void btn_generate_patient_Click(object sender, EventArgs e)
        {
            // Retrieve the data into the DataTable
            RetrieveData();

            // Initialize PrintDocument and PrintPreviewDialog
            PrintDocument printDocument = new PrintDocument();
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

            // Assign event handler for printing
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            // Set the PrintDocument object for PrintPreviewDialog
            printPreviewDialog.Document = printDocument;

            // Show the Print Preview Dialog
            printPreviewDialog.ShowDialog();
        }

        private void RetrieveDataDoctor()
        {
            // Create a new DataTable
            doctorDataTable = new DataTable();

            // SQL query to retrieve data from the database table
            string query = "SELECT * FROM doctor";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Fill the DataTable with data from the database
                    adapter.Fill(doctorDataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
                }
            }
        }

        private void PrintDocument_PrintPage_Doctor(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);

            int topMargin = 50;
            int leftMargin = 50;
            int rowHeight = 30;

            // Print headers
            for (int j = 0; j < doctorDataTable.Columns.Count; j++)
            {
                g.DrawString(doctorDataTable.Columns[j].ColumnName, font, Brushes.Black, leftMargin + (j * 100), topMargin);
            }

            topMargin += rowHeight;

            // Print data
            for (int i = 0; i < doctorDataTable.Rows.Count; i++)
            {
                for (int j = 0; j < doctorDataTable.Columns.Count; j++)
                {
                    g.DrawString(doctorDataTable.Rows[i][j].ToString(), font, Brushes.Black, leftMargin + (j * 100), topMargin + (i * rowHeight));
                }
            }
        }

        private void btn_Doctor_Report_Click(object sender, EventArgs e)
        {

            // Retrieve the data into the DataTable
            RetrieveDataDoctor();

            // Initialize PrintDocument and PrintPreviewDialog
            PrintDocument printDocument = new PrintDocument();
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

            // Assign event handler for printing
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage_Doctor);

            // Set the PrintDocument object for PrintPreviewDialog
            printPreviewDialog.Document = printDocument;

            // Show the Print Preview Dialog
            printPreviewDialog.ShowDialog();
        }

        private void btn_Back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
        }

        private void RetrieveDataStaff()
        {
            // Create a new DataTable
            staffDataTable = new DataTable();

            // SQL query to retrieve data from the database table
            string query = "SELECT * FROM staff";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                try
                {
                    // Open the database connection
                    connection.Open();

                    // Fill the DataTable with data from the database
                    adapter.Fill(staffDataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while retrieving data: " + ex.Message);
                }
            }
        }

        private void PrintDocument_PrintPage_Staff(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);

            int topMargin = 50;
            int leftMargin = 50;
            int rowHeight = 30;

            // Print headers
            for (int j = 0; j < staffDataTable.Columns.Count; j++)
            {
                g.DrawString(staffDataTable.Columns[j].ColumnName, font, Brushes.Black, leftMargin + (j * 100), topMargin);
            }

            topMargin += rowHeight;

            // Print data
            for (int i = 0; i < staffDataTable.Rows.Count; i++)
            {
                for (int j = 0; j < staffDataTable.Columns.Count; j++)
                {
                    g.DrawString(staffDataTable.Rows[i][j].ToString(), font, Brushes.Black, leftMargin + (j * 100), topMargin + (i * rowHeight));
                }
            }
        }

        private void btn_Staff_Report_Click(object sender, EventArgs e)
        {
            // Retrieve the data into the DataTable
            RetrieveDataStaff();

            // Initialize PrintDocument and PrintPreviewDialog
            PrintDocument printDocument = new PrintDocument();
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

            // Assign event handler for printing
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage_Staff); 

            // Set the PrintDocument object for PrintPreviewDialog
            printPreviewDialog.Document = printDocument;

            // Show the Print Preview Dialog
            printPreviewDialog.ShowDialog();
        }
    }

   

}
