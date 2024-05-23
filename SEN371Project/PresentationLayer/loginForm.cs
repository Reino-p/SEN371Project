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
    public partial class loginForm : Form
    {
        public loginForm()
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

        private void loginForm_Load(object sender, EventArgs e)
        {
            //on form load

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //login button

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            //register button

        }

        private void btn_Bypass_Click(object sender, EventArgs e)
        {
            //bypass button
            portalForm portal = new portalForm();
            portal.Show();
            this.Hide();
        }

        private void check_Password_CheckedChanged(object sender, EventArgs e)
        {
            //show password checkbox

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel
            
        }
    }
}
