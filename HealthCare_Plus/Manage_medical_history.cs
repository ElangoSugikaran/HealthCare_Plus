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
    public partial class Manage_medical_history : Form
    {
        public Manage_medical_history()
        {
            InitializeComponent();
        }

        private void btn_insert_medicalhistory_Click(object sender, EventArgs e)
        {
            Medical_HistoryController controller = new Medical_HistoryController();

            Medical_History MH1 = new Medical_History(txtMedicalHistoryID.Text, txtPatientName.Text, dtpDate.Value, txtCondition.Text, rtbDiagnosisDetails.Text);

            controller.InsertMedicalHistory(MH1);
        }

        private void btn_view_medicalhistory_Click(object sender, EventArgs e)
        {
            Medical_HistoryController controller = new Medical_HistoryController();
            controller.ViewMedicalHistory(dataGridView_MedicalHistory);
        }

        private void btn_search_medicalhistory_Click(object sender, EventArgs e)
        {
            Medical_HistoryController controller = new Medical_HistoryController();
            controller.SearchMedicalHistory(dataGridView_MedicalHistory, txtSearch_medical_history.Text);
        }

        private void btn_update_medicalhistory_Click(object sender, EventArgs e)
        {
            Medical_HistoryController controller = new Medical_HistoryController();

            Medical_History MH2 = new Medical_History(txtMedicalHistoryID.Text, txtPatientName.Text, dtpDate.Value, txtCondition.Text, rtbDiagnosisDetails.Text);

            controller.UpdateMedicalHistory(MH2);
        }

        private void btn_clear_medicalhistory_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtMedicalHistoryID.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            dtpDate.Value = DateTime.Today; // Reset date to today
            txtCondition.Text = string.Empty;
            rtbDiagnosisDetails.Text = string.Empty;
            txtSearch_medical_history.Text = string.Empty;
        }

        private void btn_delete_medicalhistory_Click(object sender, EventArgs e)
        {
            Medical_HistoryController controller = new Medical_HistoryController();
            string medicalhistoryIDToDelete = txtSearch_medical_history.Text;
            controller.DeleteMedicalHistory(medicalhistoryIDToDelete);
        }

        private void txtMedicalHistoryID_Leave(object sender, EventArgs e)
        {
            // Check if the Patient ID textbox is empty
            if (string.IsNullOrEmpty(txtMedicalHistoryID.Text))
            {
                return; // Exit the event handler if it's empty
            }

            // Fetch patient data based on the entered Patient ID
            Medical_HistoryController controller = new Medical_HistoryController();
            string medicalhistoryIDToSearch = txtMedicalHistoryID.Text;
            Medical_History medicalhistoryData = controller.GetMedicalHistoryData(medicalhistoryIDToSearch); // Create a method to retrieve patient data

            // Check if patient data was found
            if (medicalhistoryData != null)
            {
                // Populate the other textboxes with the retrieved data
                txtPatientName.Text = medicalhistoryData.PateintName;
                dtpDate.Value = medicalhistoryData.Date;
                txtCondition.Text = medicalhistoryData.Condition;
                rtbDiagnosisDetails.Text = medicalhistoryData.DiaggnosisDetails;
            }
            else
            {
                MessageBox.Show("medical history not found with the entered medical history.");
            }
        }

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_patient patient = new Manage_patient();
            patient.Show();
        }
    }
}
