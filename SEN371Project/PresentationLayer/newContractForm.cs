﻿using System;
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
    public partial class newContractForm : Form
    {
        DataHandler dataHandler = new DataHandler();
        public newContractForm()
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

        private void newContract_Load(object sender, EventArgs e)
        {
            //on form load

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //back button
            contractMaintenanceForm maint = new contractMaintenanceForm();
            maint.Show();
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            //cancel button
            contractMaintenanceForm maint = new contractMaintenanceForm();
            maint.Show();
            this.Hide();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //submit button
            DataTable dt = new DataTable();
            dt = dataHandler.searchContracts(txt_Name.Text);

            if (dt.Rows.Count == 0)
            {
                dataHandler.createContract(txt_Name.Text, dtpStartDate.Value.ToString("yyyy/MM/dd"), dtpEndDate.Value.ToString("yyyy/MM/dd"), float.Parse(txt_ContractCost.Text));
                MessageBox.Show("New Contract Created Succesfully");
            }
            else
            {
                MessageBox.Show("Contract record already exists");
            }
        }
    }
}
