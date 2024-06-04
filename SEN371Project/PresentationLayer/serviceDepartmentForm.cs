using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEN371Project.PresentationLayer
{
    public partial class serviceDepartmentForm : Form
    {
        DataHandler dataHandler = new DataHandler();
        public serviceDepartmentForm()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(loginForm_Paint);
        }

        private void loginForm_Paint(object sender, PaintEventArgs e)
        {
            Color color2 = ColorTranslator.FromHtml("#ABD9DA");
            Color color1 = ColorTranslator.FromHtml("#4D4DC3");

            Rectangle rectangle = new Rectangle(0, 0, this.ClientSize.Width, this.ClientSize.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, color1, color2, LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, rectangle);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Invalidate the form to trigger a repaint when the form is resized
            this.Invalidate();
        }

        private void serviceDepartment_Load(object sender, EventArgs e)
        {
            //on form load
            dataGridView_Incidents.DataSource = dataHandler.getIncidentDetails();
            dataGridView_ServiceRequests.DataSource = dataHandler.getServiceRequests();
           
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //back button
            portalForm portal = new portalForm();
            portal.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //search button
            
            dataGridView_ServiceRequests.DataSource = dataHandler.searchServiceRequests(txt_Search.Text);
            dataGridView_Incidents.DataSource = dataHandler.searchIncidents(txt_Search.Text);
            
        }

        private void btn_SRStatus_Click(object sender, EventArgs e)
        {
            //Status Update button
            try
            {
                dataHandler.updateServiceRequestStatus(txt_SpecifyServiceRequest.Text, int.Parse(cb_ServiceRequests.Text));
                MessageBox.Show("Service Request Status Updated Succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check that you have provided a status in the dropdown list");

            }
            dataGridView_Incidents.DataSource = dataHandler.searchServiceRequests(txt_SpecifyServiceRequest.Text);
        }

        private void btn_SRDelete_Click(object sender, EventArgs e)
        {
            //delete sr button
            DataTable dt = new DataTable();
            dt = dataHandler.searchServiceRequests(txt_SpecifyServiceRequest.Text);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Service Request has already been deleted or doesn't exist");
            }
            else
            {
                try
                {
                    dataHandler.deleteServiceRequest(txt_SpecifyServiceRequest.Text);
                    MessageBox.Show("Service Request has been successfully deleted");
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: Cant complete deletion");
                }
            }
            dataGridView_ServiceRequests.DataSource = dataHandler.searchServiceRequests(txt_SpecifyServiceRequest.Text);
        }

        private void btn_INDelete_Click(object sender, EventArgs e)
        {
            //delete in button
            DataTable dt = new DataTable();
            dt = dataHandler.searchIncidents(txt_SpecifyIncident.Text);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Incident has already been deleted or doesn't exist");
            }
            else
            {
                try
                {
                    dataHandler.deleteIncident(txt_SpecifyIncident.Text);
                    MessageBox.Show("Incident has been successfully deleted");
                }
                catch (Exception)
                {
                    MessageBox.Show("ERROR: Cant complete deletion");
                }
            }
            dataGridView_Incidents.DataSource = dataHandler.searchIncidents(txt_SpecifyIncident.Text);
        }

        private void btn_INUpdateStatus_Click(object sender, EventArgs e)
        {
            
            try
            {
                dataHandler.updateIncidentStatus(txt_SpecifyIncident.Text,int.Parse(cb_Incidents.Text));
                MessageBox.Show("Incident Status Updated Succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check that you have provided a status in the dropdown list");

            }
            dataGridView_Incidents.DataSource = dataHandler.searchIncidents(txt_SpecifyIncident.Text);
        }

       
    }
}
