using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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
            string filePath = @"C:\Users\RGottsche\Desktop\SEN371\Git\SEN371Project\LoginDetails.txt";


            string InputUsername = txt_Username.Text;
            string InputPassword = txt_Password.Text;
            bool validation = false;


            using (StreamReader reader = new StreamReader(filePath))
            {
                string txtLine;

                while ((txtLine = reader.ReadLine()) != null)
                {
                    string[] parts = txtLine.Split(',');
                    string NewUsername = parts[0];
                    string NewPassword = parts[1];

                    LoginClass.Users.Add(new LoginDetails { Username = NewUsername, Password = NewPassword });
                }

            }

            for (int i = 0; i < LoginClass.Users.Count; i++)
            {

                if (InputUsername == LoginClass.Users[i].Username && InputPassword == LoginClass.Users[i].Password)

                {
                    MessageBox.Show("Login Success. Press OK ");

                    new portalForm().Show();
                    this.Hide();
                    validation = true;
                    break;
                }

            }
            if (!validation)
            {
                MessageBox.Show("Either Username or Password is incorrect");
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            //register button
            string filePath = @"C:\Users\RGottsche\Desktop\SEN371\Git\SEN371Project\LoginDetails.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                string InputUsername = txt_Username.Text;
                string InputPassword = txt_Password.Text;

                writer.WriteLine(InputUsername + "," + InputPassword);
            }

            MessageBox.Show("You are registered, Press ok and then proceed to Log in.");
        }





















        private void btn_Bypass_Click(object sender, EventArgs e)
        {
            //bypass button
            portalForm portal = new portalForm();
            portal.Show();
            this.Hide();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel
            
        }

        private void check_Password_Click(object sender, EventArgs e)
        {
            //show password checkbox
            if (txt_Password.UseSystemPasswordChar == false)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = false;
            }
        }
    }
}
