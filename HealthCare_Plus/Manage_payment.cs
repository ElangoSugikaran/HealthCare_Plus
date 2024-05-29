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
    public partial class Manage_payment : Form
    {
        private string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";
        private decimal medicationCharge;  // Declare medicationCharge at the class level
        private decimal appointmentCharge;
        private decimal roomCharge;



        public Manage_payment()
        {
            InitializeComponent();
        }

        private void Manage_payment_Load(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Query to select distinct 'patient_ID' values from the "patient" table
                    string sql = "SELECT DISTINCT patient_ID FROM patient";

                    SqlCommand command_patient = new SqlCommand(sql, conn);
                    SqlDataReader reader_patient = command_patient.ExecuteReader();

                    while (reader_patient.Read())
                    {
                        // Add each 'patient_ID' value to the cmbPatientID ComboBox
                        cmbPatientID.Items.Add(reader_patient["patient_ID"].ToString());
                    }

                    reader_patient.Close();
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database access.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void cmbPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";
            string selectedPatientID = cmbPatientID.SelectedItem.ToString();

            // Query to retrieve patient name based on the selected patient ID
            string query = "SELECT lastname FROM patient WHERE patient_ID = @PatientID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                try
                {
                    conn.Open();
                    command.Parameters.AddWithValue("@PatientID", selectedPatientID);

                    // Execute the query and retrieve the patient name
                    string patientName = command.ExecuteScalar() as string;

                    // Display the patient name in the textbox
                    txtPatientName.Text = patientName;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during database access.
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void RetrieveCharges(string patientname)
        {
            medicationCharge = RetrieveChargeFromDatabase("SELECT medicinecharge FROM medication WHERE patientname = @PatientName", "@PatientName", patientname);
            appointmentCharge = RetrieveChargeFromDatabase("SELECT appointment_charge FROM appointment WHERE patientname = @PatientName", "@PatientName", patientname);
            roomCharge = RetrieveChargeFromDatabase("SELECT room_charge FROM room WHERE patientname = @PatientName", "@PatientName", patientname);

            txtMedicineCharge.Text = medicationCharge.ToString("C");
            txtAppointmentCharge.Text = appointmentCharge.ToString("C");
            txtRoomCharge.Text = roomCharge.ToString("C");
        }

        private decimal RetrieveChargeFromDatabase(string query, string parameterName, string parameterValue)
        {
            decimal charge = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(parameterName, parameterValue);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read() && !reader.IsDBNull(0))
                {
                    charge = Convert.ToDecimal(reader[0]);
                }
            }

            return charge;
        }

        private void btn_Retrieve_Charge_Click(object sender, EventArgs e)
        {
            string patientID = txtPatient_Name.Text; // Retrieve patient ID from textbox

            if (!string.IsNullOrEmpty(patientID))
            {
                RetrieveCharges(patientID);
            }
            else
            {
                MessageBox.Show("Please enter a patient ID.");
            }
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            decimal totalAmount = medicationCharge + appointmentCharge + roomCharge;
            txtPaymentAmount.Text = totalAmount.ToString("C");
        }

        private void btn_insert_payment_Click(object sender, EventArgs e)
        {
            PaymentController controller = new PaymentController();

            Payment Pt1 = new Payment(txtPaymentID.Text, txtPatientName.Text, dtp_PaymentDate.Value, cmbPaymentMethod.Text,
                txtPaymentInvoice.Text, cmbStatus.Text, txtMedicineCharge.Text, txtRoomCharge.Text, txtAppointmentCharge.Text, txtPaymentAmount.Text);

            controller.InsertPayment(Pt1);
        }

        private void btn_view_payment_Click(object sender, EventArgs e)
        {
            PaymentController controller = new PaymentController();
            controller.ViewPayment(dataGridView_Payment);
        }

        private void btn_search_payment_Click(object sender, EventArgs e)
        {
            PaymentController controller = new PaymentController();
            controller.SearchPayemnt(dataGridView_Payment, txtSearch_Payment.Text);
        }

        private void btn_update_payment_Click(object sender, EventArgs e)
        {
            PaymentController controller = new PaymentController();

            Payment Pt2 = new Payment(txtPaymentID.Text, txtPatientName.Text, dtp_PaymentDate.Value, cmbPaymentMethod.Text,
                txtPaymentInvoice.Text, cmbStatus.Text, txtMedicineCharge.Text, txtRoomCharge.Text, txtAppointmentCharge.Text, txtPaymentAmount.Text);

            controller.UpdatePayment(Pt2);
        }

        private void btn_clear_payment_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtPaymentID.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            dtp_PaymentDate.Value = DateTime.Today; // Reset date to today
            cmbPaymentMethod.SelectedIndex = -1; // Deselect gender dropdown
            txtPaymentInvoice.Text = string.Empty;
            cmbStatus.SelectedIndex = -1; // Deselect gender dropdown
            txtMedicineCharge.Text = string.Empty;
            txtAppointmentCharge.Text = string.Empty;
            txtRoomCharge.Text = string.Empty;
            txtPaymentAmount.Text = string.Empty;
            txtSearch_Payment.Text = string.Empty;


        }

        private void btn_delete_payment_Click(object sender, EventArgs e)
        {

            PaymentController controller = new PaymentController();
            string paymentIDToDelete = txtSearch_Payment.Text;
            controller.DeletePayment(paymentIDToDelete);
        }

        private void btn_Back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
        }

        private void txtPaymentID_Leave(object sender, EventArgs e)
        {
            // Check if the Staff ID textbox is empty
            if (string.IsNullOrEmpty(txtPaymentID.Text))
            {
                return; // Exit the event handler if it's empty
            }

            // Fetch staff data based on the entered Staff ID
            PaymentController controller = new PaymentController();
            string paymentIDToSearch = txtPaymentID.Text;

            // Create a method to retrieve staff data
            Payment paymentData = controller.GetPaymentData(paymentIDToSearch);

            // Check if staff data was found
            if (paymentData != null)
            {
                // Populate the other textboxes with the retrieved data
                txtPatientName.Text = paymentData.PatientName;
                dtp_PaymentDate.Value = paymentData.PaymentDate;
                cmbPaymentMethod.Text = paymentData.PaymnetMethod;
                txtPaymentInvoice.Text = paymentData.PaymentInvoiceNo;
                cmbStatus.Text = paymentData.Status;
                txtMedicineCharge.Text = paymentData.MedicineCharge;
                txtRoomCharge.Text = paymentData.RoomCharge;
                txtAppointmentCharge.Text = paymentData.AppointmentCharge;
                txtPaymentAmount.Text = paymentData.PaymentAmount;
            }
            else
            {
                MessageBox.Show("Patient not found with the entered Patient ID.");
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 10);

            // Set margins and padding
            int topMargin = e.MarginBounds.Top;
            int leftMargin = e.MarginBounds.Left;

            // Calculate column widths
            int[] columnWidths = CalculateColumnWidths(dataGridView_Payment.Columns.Count, e.MarginBounds.Width);

            // Print column headers
            for (int j = 0; j < dataGridView_Payment.Columns.Count; j++)
            {
                string headerText = dataGridView_Payment.Columns[j].HeaderText;
                g.DrawString(headerText, font, Brushes.Black, leftMargin, topMargin);
                leftMargin += columnWidths[j];
            }

            topMargin += (int)font.GetHeight();

            // Loop through each row in the DataGridView
            for (int i = 0; i < dataGridView_Payment.Rows.Count; i++)
            {
                leftMargin = e.MarginBounds.Left;

                // Loop through each column in the current row
                for (int j = 0; j < dataGridView_Payment.Columns.Count; j++)
                {
                    string cellValue = dataGridView_Payment[j, i].Value == null ? "" : dataGridView_Payment[j, i].Value.ToString();
                    g.DrawString(cellValue, font, Brushes.Black, leftMargin, topMargin);
                    leftMargin += columnWidths[j];
                }

                topMargin += dataGridView_Payment.Rows[i].Height;

                if (topMargin + dataGridView_Payment.Rows[i].Height >= e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

        private int[] CalculateColumnWidths(int totalColumns, int printableWidth)
        {
            int[] columnWidths = new int[totalColumns];
            int totalWidth = 0;

            for (int i = 0; i < totalColumns; i++)
            {
                int width = (int)((double)printableWidth * dataGridView_Payment.Columns[i].Width / dataGridView_Payment.Columns.GetColumnsWidth(DataGridViewElementStates.Visible));
                columnWidths[i] = width;
                totalWidth += width;
            }

            if (totalWidth > printableWidth)
            {
                double scaleFactor = (double)printableWidth / totalWidth;
                for (int i = 0; i < totalColumns; i++)
                {
                    columnWidths[i] = (int)(columnWidths[i] * scaleFactor);
                }
            }

            return columnWidths;
        }


        private void btn_print_preview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            PrintDocument printDocument = new PrintDocument();

            // Set the PrintDocument event handler to handle printing logic
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
    }
}

