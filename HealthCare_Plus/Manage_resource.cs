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
    public partial class Manage_resource : Form
    {
        public Manage_resource()
        {
            InitializeComponent();
        }

        private void btn_insert_resource_Click(object sender, EventArgs e)
        {
            ResourceController controller = new ResourceController();

            Resource R1 = new Resource(txtResourceID.Text, cmbTypeResource.Text, txtResourceName.Text, cmbAvailable.Text, txtCost.Text, cmbLocation.Text);

            controller.InsertResource(R1);
        }

        private void btn_view_resource_Click(object sender, EventArgs e)
        {
            ResourceController controller = new ResourceController();
            controller.ViewResource(dataGridView_resource);
        }

        private void btn_search_resource_Click(object sender, EventArgs e)
        {
            ResourceController controller = new ResourceController();
            controller.SearchResource(dataGridView_resource, txtSearch_Resource.Text);
        }

        private void btn_update_resource_Click(object sender, EventArgs e)
        {
            ResourceController controller = new ResourceController();

            Resource R2 = new Resource(txtResourceID.Text, cmbTypeResource.Text, txtResourceName.Text, cmbAvailable.Text, txtCost.Text, cmbLocation.Text);

            controller.UpdateResource(R2);
        }

        private void btn_clear_resource_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtResourceID.Text = string.Empty;
            cmbTypeResource.SelectedIndex = -1;
            txtResourceName.Text = string.Empty;
            cmbAvailable.SelectedIndex = -1;
            txtCost.Text = string.Empty;
            cmbLocation.SelectedIndex = -1; // Deselect location dropdown
            txtSearch_Resource.Text = string.Empty;

        }

        private void btn_delete_resource_Click(object sender, EventArgs e)
        {
            ResourceController controller = new ResourceController();
            string resourceIDToDelete = txtSearch_Resource.Text;
            controller.DeleteResource(resourceIDToDelete);
        }

        private void txtResourceID_Leave(object sender, EventArgs e)
        {
            // Check if the Patient ID textbox is empty
            if (string.IsNullOrEmpty(txtResourceID.Text))
            {
                return; // Exit the event handler if it's empty
            }

            // Fetch patient data based on the entered Patient ID
            ResourceController controller = new ResourceController();
            string resourceIDToSearch = txtResourceID.Text;
            Resource resourceData = controller.GetResourceData(resourceIDToSearch); 

            // Check if patient data was found
            if (resourceData != null)
            {
                // Populate the other textboxes with the retrieved data
                txtResourceID.Text = resourceData.ResourceId;
                cmbTypeResource.Text = resourceData.TypeResource;
                txtResourceName.Text = resourceData.ResourceName;
                cmbAvailable.Text = resourceData.Available;
                txtCost.Text = resourceData.Cost;
                cmbLocation.Text = resourceData.Location;
            }
            else
            {
                MessageBox.Show("patient not found with the entered resource ID.");
            }
        }

        private void btn_back_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dashboard adminDashboard = new Admin_Dashboard();
            adminDashboard.Show();
        }
    }
}
