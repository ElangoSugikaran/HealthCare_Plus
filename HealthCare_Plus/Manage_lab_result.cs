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
    public partial class Manage_lab_result : Form
    {
        public Manage_lab_result()
        {
            InitializeComponent();
        }

        private void btn_insert_lab_Click(object sender, EventArgs e)
        {
            LabResultController controller = new LabResultController();

            LabResult L1 = new LabResult(txtLabResultID.Text, txtPatientName.Text, cmbTestType.Text, dtpDate.Value, rtbResultDetails.Text);

            controller.InsertLabResult(L1);
        }

        private void btn_view_lab_Click(object sender, EventArgs e)
        {
            LabResultController controller = new LabResultController();
            controller.ViewLabResult(dataGridView_lab_result);
        }

        private void btn_search_lab_Click(object sender, EventArgs e)
        {
            LabResultController controller = new LabResultController();
            controller.SearchLabResult(dataGridView_lab_result, txtSearch_lab.Text);
        }

        private void btn_clear_lab_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtLabResultID.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            cmbTestType.SelectedIndex = -1;
            dtpDate.Value = DateTime.Today; // Reset date to today
            rtbResultDetails.Text = string.Empty;
            txtSearch_lab.Text = string.Empty;
        }

        private void btn_update_lab_Click(object sender, EventArgs e)
        {
            LabResultController controller = new LabResultController();

            LabResult L2 = new LabResult(txtLabResultID.Text, txtPatientName.Text, cmbTestType.Text, dtpDate.Value, rtbResultDetails.Text);

            controller.UpdateLabResult(L2);
        }

        private void btn_delete_lab_Click(object sender, EventArgs e)
        {
            LabResultController controller = new LabResultController();
            string labresultIDToDelete = txtSearch_lab.Text;
            controller.DeleteLabResult(labresultIDToDelete);
        }

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manage_patient patient = new Manage_patient();
            patient.Show();
        }

        private void txtLabResultID_Leave(object sender, EventArgs e)
        {
            // Check if the Staff ID textbox is empty
            if (string.IsNullOrEmpty(txtLabResultID.Text))
            {
                return; // Exit the event handler if it's empty
            }

            // Fetch staff data based on the entered Staff ID
            LabResultController controller = new LabResultController();
            string labresultIDToSearch = txtLabResultID.Text;

            // Create a method to retrieve staff data
            LabResult labresultData = controller.GetLabResultData(labresultIDToSearch);

            // Check if staff data was found
            if (labresultData != null)
            {
                // Populate the other textboxes with the retrieved data
                txtPatientName.Text = labresultData.PatientName;
                cmbTestType.Text = labresultData.TestType;
                dtpDate.Value = labresultData.Date;
                rtbResultDetails.Text = labresultData.LabResult_Details;
               
            }
            else
            {
                MessageBox.Show("Patient not found with the entered Patient ID.");
            }
        }
    }
    
}
