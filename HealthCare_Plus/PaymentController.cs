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
    internal class PaymentController
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);
        public PaymentController() { }

        public void InsertPayment(Payment paymentobj)
        {
            try
            {
                if (string.IsNullOrEmpty(paymentobj.PaymentID) || string.IsNullOrEmpty(paymentobj.PatientName) || string.IsNullOrEmpty(paymentobj.PaymnetMethod) || string.IsNullOrEmpty(paymentobj.PaymentInvoiceNo) || string.IsNullOrEmpty(paymentobj.Status) || string.IsNullOrEmpty(paymentobj.PaymentAmount))

                {
                    MessageBox.Show("missing informaton. Please fill in all required fields.");

                }
                else
                {
                    conn.Open();

                    string insertsql = "INSERT INTO payment (payment_ID, patientname, date, method, invoice_no, status, medicine_charge, room_charge, appointment_charge, payment_amount) " +
                        "VALUES (@payment_ID, @PatientName, @Date, @Method, @Invoice_No, @Status, @Medicine_Charge, @Room_Charge, @Appointment_Charge, @Payment_Amount)";

                    using (SqlCommand cmd = new SqlCommand(insertsql, conn))
                    {
                        cmd.Parameters.AddWithValue("@payment_ID", paymentobj.PaymentID);
                        cmd.Parameters.AddWithValue("@PatientName", paymentobj.PatientName);
                        cmd.Parameters.AddWithValue("@Date", paymentobj.PaymentDate);
                        cmd.Parameters.AddWithValue("@Method", paymentobj.PaymnetMethod);
                        cmd.Parameters.AddWithValue("@Invoice_No", paymentobj.PaymentInvoiceNo);
                        cmd.Parameters.AddWithValue("Status", paymentobj.Status);
                        cmd.Parameters.AddWithValue("@Medicine_Charge", paymentobj.MedicineCharge);
                        cmd.Parameters.AddWithValue("@Room_Charge", paymentobj.RoomCharge);
                        cmd.Parameters.AddWithValue("@Appointment_Charge", paymentobj.AppointmentCharge);
                        cmd.Parameters.AddWithValue("@Payment_Amount", paymentobj.PaymentAmount);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Recorded inserted Successfully");

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

        public void ViewPayment(DataGridView dataGridView)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM payment";

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

        public void SearchPayemnt(DataGridView dataGridView, string PaymentID)
        {
            try
            {
                conn.Open();

                string sqlView = "SELECT * FROM payment WHERE payment_ID = @PaymentID";

                using (SqlCommand cmd = new SqlCommand(sqlView, conn))
                {
                    cmd.Parameters.AddWithValue("@PaymentID", PaymentID);

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

        public void UpdatePayment(Payment paymentupdate)
        {
            try
            {

                if (string.IsNullOrEmpty(paymentupdate.PaymentID) || string.IsNullOrEmpty(paymentupdate.PatientName) || string.IsNullOrEmpty(paymentupdate.PaymnetMethod) || string.IsNullOrEmpty(paymentupdate.PaymentInvoiceNo) || string.IsNullOrEmpty(paymentupdate.Status) || string.IsNullOrEmpty(paymentupdate.PaymentAmount))

                {
                    MessageBox.Show("missing informaton. Please fill in all required fields.");
                }
                else
                { // open the database connection
                    conn.Open();

                    string updatesql = "UPDATE payment SET patientname =  @PatientName, date = @Date, method = @Method" +
                        "  invoice_no =  @Invoice_No, status = @Status, medicine_charge = @Medicine_Charge, room_charge = @Room_Charge, appointment_charge = @Appointment_Charge" +
                        "  WHERE payment_amount = @Payment_Amount ";


                    using (SqlCommand cmd = new SqlCommand(updatesql, conn))
                    {
                        cmd.Parameters.AddWithValue("@payment_ID", paymentupdate.PaymentID);
                        cmd.Parameters.AddWithValue("@PatientName", paymentupdate.PatientName);
                        cmd.Parameters.AddWithValue("@Date", paymentupdate.PaymentDate);
                        cmd.Parameters.AddWithValue("@Method", paymentupdate.PaymnetMethod);
                        cmd.Parameters.AddWithValue("@Invoice_No", paymentupdate.PaymentInvoiceNo);
                        cmd.Parameters.AddWithValue("Status", paymentupdate.Status);
                        cmd.Parameters.AddWithValue("@Medicine_Charge", paymentupdate.MedicineCharge);
                        cmd.Parameters.AddWithValue("@Room_Charge", paymentupdate.RoomCharge);
                        cmd.Parameters.AddWithValue("@Appointment_Charge", paymentupdate.AppointmentCharge);
                        cmd.Parameters.AddWithValue("@Payment_Amount", paymentupdate.PaymentAmount);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. payment member not found.");
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

        public void DeletePayment(string paymentIDToDelete)
        {
            try
            {
                if (string.IsNullOrEmpty(paymentIDToDelete))
                {
                    MessageBox.Show("Enter the payment ID");
                }
                else
                {
                    conn.Open();

                    string deleteSql = "DELETE FROM payment WHERE payment_ID = @PaymentID";

                    using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@PaymentID", paymentIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted Successfully");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the given payment ID");
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

        public Payment GetPaymentData(string PaymentID)
        {
            try
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM payment WHERE payment_ID = @PaymentID";

                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@PaymentID", PaymentID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a Staff object and populate it with data from the reader
                            Payment payment = new Payment();
                            payment.PaymentID = reader["payment_ID"].ToString();
                            payment.PatientName = reader["patientname"].ToString();
                            payment.PaymentDate = (DateTime)reader["date"];
                            payment.PaymnetMethod = reader["method"].ToString();
                            payment.PaymentInvoiceNo = reader["invoice_no"].ToString();
                            payment.Status= reader["status"].ToString();
                            payment.MedicineCharge = reader["medicine_charge"].ToString();
                            payment.RoomCharge = reader["room_charge"].ToString();
                            payment.AppointmentCharge = reader["appointment_charge"].ToString();
                            payment.PaymentAmount = reader["payment_amount"].ToString();

                            return payment;
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

