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
    public partial class ticketCreationForm : Form
    {
        DataHandler dataHandler = new DataHandler();
        public ticketCreationForm()
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
        private void btn_INCreate_Click(object sender, EventArgs e)
        {
            // Incident Create Button
            DataTable dt = new DataTable();
            dt = dataHandler.searchIncidents(txt_SpecifyIncident.Text);

            if (dt.Rows.Count == 0)
            {
                dataHandler.createIncident(txt_SpecifyIncident.Text, txt_IncidentDescription.Text, dtp_INReportedDate.Value.ToString("yyyy/MM/dd"), " ", int.Parse(cb_Incidents.Text), int.Parse(cb_INPriority.Text), int.Parse(cb_INSystemID.Text), int.Parse(cb_INAgents.Text), int.Parse(txt_INClientID.Text));
                string message = string.Format("New Ticket Created:\n" +
                              "Ticket ID: {0}\n" +
                              "Ticket Type: Incident\n" +
                              "Date: {1}\n" +
                              "Client ID: {2}\n" +
                              "Priority: {3}",
                              txt_SpecifyIncident.Text,
                              dtp_INReportedDate.Value.ToString("yyyy/MM/dd"),
                              txt_INClientID.Text,
                              cb_INPriority.Text);
                sendMessageAsync(message);
                MessageBox.Show("Incident Record Created Succesfully");
            }
            else
            {
                MessageBox.Show("Incident record already exists");
            }

        }

        private void btn_SRCreate_Click(object sender, EventArgs e)
        {
            // Service Request Create Button
            DataTable dt = new DataTable();
            dt = dataHandler.searchServiceRequests(txt_SpecifyServiceRequest.Text);

            if (dt.Rows.Count == 0)
            {
                dataHandler.createServiceRequest(txt_SpecifyServiceRequest.Text, txt_ServiceRequestDescription.Text, dtp_SRReportedDate.Value.ToString("yyyy/MM/dd"), " ", int.Parse(cb_ServiceRequests.Text), int.Parse(cb_SRPriority.Text), int.Parse(cb_SRSystemID.Text), int.Parse(cb_SRAgents.Text), int.Parse(txt_SRClientID.Text));
                string message = string.Format("New Ticket Created:\n" +
                   "Ticket ID: {0}\n" +
                   "Ticket Type: Service Request\n" +
                   "Date: {1}\n" +
                   "Client ID: {2}\n" +
                   "Priority: {3}",
                   txt_SpecifyIncident.Text,
                   dtp_INReportedDate.Value.ToString("yyyy/MM/dd"),
                   txt_INClientID.Text,
                   cb_INPriority.Text);
                sendMessageAsync(message);
                MessageBox.Show("ServiceRequest Record Created Succesfully");
            }
            else
            {
                MessageBox.Show("ServiceRequest record already exists");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            // btn back
            ticketMaintenanceForm ticket = new ticketMaintenanceForm();
            ticket.Show();
            this.Hide();
        }
        private async void sendMessageAsync(string message) 
        {
            bool sent = await SmsAPI.SendSMSAsync(message);
        }
    }
}
