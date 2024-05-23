using SEN371Project.PresentationLayer;
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

namespace SEN371Project
{
    public partial class portalForm : Form
    {
        public portalForm()
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

        private void btn_CallCenter_Click(object sender, EventArgs e)
        {
            //call center
            callCenterForm call = new callCenterForm();
            call.Show();
            this.Hide();
        }

        private void btn_ClientMaintenance_Click(object sender, EventArgs e)
        {
            //client maintenance
            clientMaintenanceForm client = new clientMaintenanceForm();
            client.Show();
            this.Hide();
        }

        private void btn_ContractMaintenance_Click(object sender, EventArgs e)
        {
            //contract maintenance
            contractMaintenanceForm contract = new contractMaintenanceForm();
            contract.Show();
            this.Hide();
        }

        private void btn_ServiceDepartment_Click(object sender, EventArgs e)
        {
            //service department
            serviceDepartmentForm service = new serviceDepartmentForm();
            service.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            //logout
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }

        private void portalForm_Load(object sender, EventArgs e)
        {

        }
    }
}
