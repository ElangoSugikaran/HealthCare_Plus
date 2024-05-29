using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
    public partial class Admin_Dashboard : Form
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_Patient_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_patient manage_pt = new Manage_patient();
            manage_pt.Show();
        }

        // panel count count code 
        private void pnlCountPatient_Paint(object sender, PaintEventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) FROM patient", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblPatientCount.Text = dt.Rows[0][0].ToString();
            conn.Close();

        }

        private void btn_logout_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login logout = new login();
            logout.Show();
        }

        private void pnlDoctorCount_Paint(object sender, PaintEventArgs e)
        {

            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) FROM doctor", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblDoctorCount.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void btn_resource_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_resource manage_Resource = new Manage_resource();
            manage_Resource.Show();
        }

        private void btn_doctor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_doctor manage_dt = new Manage_doctor();
            manage_dt.Show();
        }

        private void btn_theater_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_theater manage_tr = new Manage_theater();
            manage_tr.Show();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_room manage_rm = new Manage_room();
            manage_rm.Show();
        }

        private void btn_ManagePayment_admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_payment manage_pmt = new Manage_payment();
            manage_pmt.Show();
        }

        private void btn_Generate_report_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_report manage_rt= new Manage_report();
            manage_rt.Show();
        }

        private void btn_admin_dashboard_Click(object sender, EventArgs e)
        {  
            this.Hide();
            Admin_Dashboard manage_dashboard = new Admin_Dashboard();
            manage_dashboard.Show();
        }
    }
}
