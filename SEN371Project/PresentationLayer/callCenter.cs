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
    public partial class callCenter : Form
    {
        public callCenter()
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

        private void CallCenter_Load(object sender, EventArgs e)
        {
            //on form load

        }

        private void btn_answer_Click(object sender, EventArgs e)
        {
            //answer button
            ongoingCall ongoing = new ongoingCall();
            ongoing.Show();
            this.Hide();
        }

        private void btn_decline_Click(object sender, EventArgs e)
        {
            //decline button
            callDeclined decline = new callDeclined();
            decline.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //back button
            portalForm portal = new portalForm();
            portal.Show();
            this.Hide();
        }

        
    }
}
