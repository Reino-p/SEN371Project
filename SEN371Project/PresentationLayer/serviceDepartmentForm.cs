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
            ticketMaintenanceForm ticket = new ticketMaintenanceForm();
            ticket.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //search button
            
            dataGridView_ServiceRequests.DataSource = dataHandler.searchServiceRequests(txt_Search.Text);
            dataGridView_Incidents.DataSource = dataHandler.searchIncidents(txt_Search.Text);
            
        }

        /////////////////////////////////////////////
        //                                         //
        //----------- Incidents Section -----------//
        //                                         //
        /////////////////////////////////////////////
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
            // Update Status Button
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
        private void btn_INassign_Click(object sender, EventArgs e)
        {
            // Update Assignee Button
            try
            {
                dataHandler.updateIncidentAssignee(txt_SpecifyIncident.Text, int.Parse(cb_INAgents.Text));
                MessageBox.Show("Incident Agent Updated Succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check that you have provided an Assignee from the dropdown list");

            }
            dataGridView_Incidents.DataSource = dataHandler.searchIncidents(txt_SpecifyIncident.Text);
        }

        private void btn_INUpdatePriority_Click(object sender, EventArgs e)
        {
            // Update Priority Button
            try
            {
                dataHandler.updateIncidentPriority(txt_SpecifyIncident.Text, int.Parse(cb_INPriority.Text));
                MessageBox.Show("Incident Priority Updated Succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check that you have provided a status in the dropdown list");

            }
            dataGridView_Incidents.DataSource = dataHandler.searchIncidents(txt_SpecifyIncident.Text);
        }

        private void btn_INUpdateResDate_Click(object sender, EventArgs e)
        {
            // Update ResolutionDate Button
            try
            {
                dataHandler.updateIncidentResolutionDate(txt_SpecifyIncident.Text, dtp_INResDate.Value.ToString("yyyy/MM/dd"));
                MessageBox.Show("Incident Resolution Date Updated Succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check that you have selected an appropriate Date on the Date Picker");

            }
            dataGridView_Incidents.DataSource = dataHandler.searchIncidents(txt_SpecifyIncident.Text);
        }


        /////////////////////////////////////////////
        //                                         //
        //------- Service Requests Section --------//
        //                                         //
        /////////////////////////////////////////////
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
            dataGridView_ServiceRequests.DataSource = dataHandler.searchServiceRequests(txt_SpecifyServiceRequest.Text);
        }

        private void btn_SRassign_Click(object sender, EventArgs e)
        {
            // Update Assignee Button
            try
            {
                dataHandler.updateServiceRequestAssignee(txt_SpecifyServiceRequest.Text, int.Parse(cb_SRAgents.Text));
                MessageBox.Show("Service Request Agent Updated Succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check that you have provided an Assignee from the dropdown list");

            }
            dataGridView_ServiceRequests.DataSource = dataHandler.searchServiceRequests(txt_SpecifyServiceRequest.Text);
        }

        private void btn_SRUpdatePriority_Click(object sender, EventArgs e)
        {
            // Update Priority Button
            try
            {
                dataHandler.updateServiceRequestPriority(txt_SpecifyServiceRequest.Text, int.Parse(cb_SRPriority.Text));
                MessageBox.Show("Service Request Priority Updated Succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check that you have provided a Priority in the dropdown list");

            }
            dataGridView_ServiceRequests.DataSource = dataHandler.searchServiceRequests(txt_SpecifyServiceRequest.Text);
        }

        private void btn_SRUpdateResDate_Click(object sender, EventArgs e)
        {
            // Update ResolutionDate Button
            try
            {
                dataHandler.updateServiceRequestResolutionDate(txt_SpecifyServiceRequest.Text, dtp_SRResDate.Value.ToString("yyyy/MM/dd"));
                MessageBox.Show("Service Request Resolution Date Updated Succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check that you have selected an appropriate Date on the Date Picker");

            }
            dataGridView_ServiceRequests.DataSource = dataHandler.searchServiceRequests(txt_SpecifyServiceRequest.Text);
        }

        private void dataGridView_Incidents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_SpecifyIncident.Text = dataGridView_Incidents.CurrentRow.Cells[1].Value.ToString();
            cb_INAgents.Text = dataGridView_Incidents.CurrentRow.Cells[8].Value.ToString();
            cb_Incidents.Text = dataGridView_Incidents.CurrentRow.Cells[5].Value.ToString();
            cb_INPriority.Text = dataGridView_Incidents.CurrentRow.Cells[6].Value.ToString();
            dtp_INResDate.Text = dataGridView_Incidents.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView_ServiceRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_SpecifyServiceRequest.Text = dataGridView_ServiceRequests.CurrentRow.Cells[1].Value.ToString();
            cb_SRAgents.Text = dataGridView_ServiceRequests.CurrentRow.Cells[9].Value.ToString();
            cb_ServiceRequests.Text = dataGridView_ServiceRequests.CurrentRow.Cells[5].Value.ToString();
            cb_SRPriority.Text = dataGridView_ServiceRequests.CurrentRow.Cells[7].Value.ToString();
            dtp_SRResDate.Text = dataGridView_ServiceRequests.CurrentRow.Cells[4].Value.ToString();
            
        }
    }
}
