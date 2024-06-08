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
    public partial class callCenterForm : Form
    {
        public callCenterForm()
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

        public static string rando { get; set; }
        public Timer time;

        private void CallCenter_Load(object sender, EventArgs e)
        {
            //Form load
            string num = "";
            txt_incomingCall.Text = numbers(num);
            rando = names("");
            txt_callerID.Text = rando;
        }

        private void btn_answer_Click(object sender, EventArgs e)
        {
            //answer button
            ongoingCallForm ongoing = new ongoingCallForm();
            ongoing.Show();
            this.Hide();

        }

        private void btn_decline_Click(object sender, EventArgs e)
        {
            //decline button
            callDeclinedForm decline = new callDeclinedForm();
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

        private static Random random = new Random();

        public static string GenerateRandom2DigitNumber()
        {
            char[] digits = new char[2];
            for (int i = 0; i < 2; i++)
            {
                digits[i] = (char)('0' + random.Next(0, 10));
            }
            return new string(digits);
        }

        public static string GenerateRandom3DigitNumber()
        {
            char[] digits = new char[3];
            for (int i = 0; i < 3; i++)
            {
                digits[i] = (char)('0' + random.Next(0, 10));
            }
            return new string(digits);
        }

        private static Random randomName = new Random();

        public static string GetRandomName(List<string> names)
        {
            if (names == null || names.Count == 0)
            {
                throw new ArgumentException("The list of names cannot be null or empty");
            }

            int randomIndex = randomName.Next(names.Count);
            return names[randomIndex];
        }

        public string numbers(string num) {
            //on form load for numbers
            string num1 = GenerateRandom2DigitNumber();
            string num2 = GenerateRandom3DigitNumber();
            string num3 = GenerateRandom3DigitNumber();
            num = "+27 " + num1 + " " + num2 + " " + num3;
            return num;
        }

        public string names(string name) {
            //on form load for names
            List<string> names = new List<string>
            {
                "Alice", "Bob", "Charlie", "Diana", "Edward", "Fiona", "George", "Hannah", "Ivan", "Julia"
            };
            string randomName = GetRandomName(names);
            name = randomName;
            return name;
        }

    }
}
