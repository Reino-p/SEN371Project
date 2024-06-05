namespace SEN371Project.PresentationLayer
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_Bypass = new System.Windows.Forms.Button();
            this.check_Password = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login or Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txt_Username
            // 
            this.txt_Username.ForeColor = System.Drawing.Color.Black;
            this.txt_Username.Location = new System.Drawing.Point(263, 177);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(525, 22);
            this.txt_Username.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.ForeColor = System.Drawing.Color.Black;
            this.txt_Password.Location = new System.Drawing.Point(263, 251);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(525, 22);
            this.txt_Password.TabIndex = 5;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(352, 345);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(141, 42);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(520, 345);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(141, 42);
            this.btn_Register.TabIndex = 7;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_Bypass
            // 
            this.btn_Bypass.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Bypass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bypass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bypass.Location = new System.Drawing.Point(704, 398);
            this.btn_Bypass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Bypass.Name = "btn_Bypass";
            this.btn_Bypass.Size = new System.Drawing.Size(141, 42);
            this.btn_Bypass.TabIndex = 8;
            this.btn_Bypass.Text = "Bypass";
            this.btn_Bypass.UseVisualStyleBackColor = false;
            this.btn_Bypass.Click += new System.EventHandler(this.btn_Bypass_Click);
            // 
            // check_Password
            // 
            this.check_Password.AutoSize = true;
            this.check_Password.BackColor = System.Drawing.Color.White;
            this.check_Password.Location = new System.Drawing.Point(653, 298);
            this.check_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.check_Password.Name = "check_Password";
            this.check_Password.Size = new System.Drawing.Size(125, 20);
            this.check_Password.TabIndex = 10;
            this.check_Password.Text = "Show Password";
            this.check_Password.UseVisualStyleBackColor = false;
            this.check_Password.Click += new System.EventHandler(this.check_Password_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Bypass);
            this.panel1.Location = new System.Drawing.Point(111, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 459);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.check_Password);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login or Register";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Bypass;
        private System.Windows.Forms.CheckBox check_Password;
        private System.Windows.Forms.Panel panel1;
    }
}