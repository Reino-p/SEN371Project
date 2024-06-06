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
    public partial class existingClientForm : Form
    {
        DataHandler dataHandler = new DataHandler();
        public existingClientForm()
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

        private void existingClient_Load(object sender, EventArgs e)
        {
            //on form load
            dataGridView1.DataSource = dataHandler.getClientDetails();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //search button

            dataGridView1.DataSource = dataHandler.searchClient(txt_search.Text);


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //delete button
            DataTable dt = new DataTable();
            dt = dataHandler.searchClient(txt_Name.Text);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Record has already been deleted or doesn't exist");

            }
            else
            {
                try
                {
                    dataHandler.deleteClient(txt_Name.Text);
                    MessageBox.Show("Record has been successfully deleted");
                }
                catch (Exception)
                {

                    MessageBox.Show("ERROR: Client has Tickets logged on the system");
                }
                

            }
            dataGridView1.DataSource = dataHandler.searchClient(txt_Name.Text);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //update button
            try
            {
                dataHandler.updateClientDetails(txt_Name.Text, txt_Number.Text, txt_Location.Text, int.Parse(cb_ContractID.Text));
                MessageBox.Show("Client Update Succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Please check that you have provided all the values");

            }
            dataGridView1.DataSource = dataHandler.searchClient(txt_Name.Text);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //back button
            clientMaintenanceForm client = new clientMaintenanceForm();
            client.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Number.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Location.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cb_ContractID.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
