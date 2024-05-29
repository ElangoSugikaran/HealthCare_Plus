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
    public partial class Receptionist_Dashboard : Form
    {
        static string connectionString = "Data Source=DESKTOP-LTVMOGG\\SQLEXPRESS;Initial Catalog=HealthCare_plus;Integrated Security=True";

        SqlConnection conn = new SqlConnection(connectionString);

        public Receptionist_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_staaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_staff mf = new Manage_staff();
            mf.Show();
        }

        private void btn_logout_receptionist_Click(object sender, EventArgs e)
        {
            this.Hide();
            login logout = new login();
            logout.Show();
        }

        private void pnlCountStaff_Paint(object sender, PaintEventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) FROM Staff", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblStaffCount.Text = dt.Rows[0][0].ToString();
            conn.Close();

        }

        private void pnlCountAppointment_Paint(object sender, PaintEventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT (*) FROM appointment", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblAppointmentCount.Text = dt.Rows[0][0].ToString();
            conn.Close();
        }

        private void btn_receptionist_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptionist_Dashboard receptionist_Dashboard = new Receptionist_Dashboard();
            receptionist_Dashboard.Show();
        }

        private void btn_appointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_appointment manage_Appointment = new Manage_appointment();
            manage_Appointment.Show();
        }
    }
}
