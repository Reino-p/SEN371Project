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
    public partial class ongoingCallForm : Form
    {

        /*callCenterForm details = new callCenterForm();*/
        /*private callCenterForm details;*/

        public ongoingCallForm()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(loginForm_Paint);
            timer1 = new Timer();
            timer1.Interval = 1000; // Set the interval in milliseconds (e.g., 1000 for 1 second)
            timer1.Tick += new EventHandler(timer1_Tick);
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

        private static int elapsedTime = 0;

        private void OngoingCall_Load(object sender, EventArgs e)
        {
            //on form load
            elapsedTime = 0;
            
            string value = callCenterForm.rando;
            label_CallerID.Text = value;
            if (!string.IsNullOrEmpty(callCenterForm.rando))
            {
                timer1.Start(); // Start the timer only if rando has a value
            }

        }

        //private void btn_back_Click(object sender, EventArgs e)
        //{
        //    //back button
        //    CallCenter call = new CallCenter();
        //    call.Show();
        //    this.Hide();
        //}

        private void btn_decline_Click(object sender, EventArgs e)
        {
            //decline button
            timer1.Stop();
            callCenterForm call = new callCenterForm();
            call.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            label_Duration.Text = TimeSpan.FromSeconds(elapsedTime).ToString(@"mm\:ss");
        }
    }
}
