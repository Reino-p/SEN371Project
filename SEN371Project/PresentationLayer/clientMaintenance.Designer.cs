namespace SEN371Project.PresentationLayer
{
    partial class clientMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientMaintenance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NewClient = new System.Windows.Forms.Button();
            this.btn_ExistingClient = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_ExistingClient);
            this.panel1.Controls.Add(this.btn_NewClient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 402);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clients";
            // 
            // btn_NewClient
            // 
            this.btn_NewClient.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_NewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewClient.Location = new System.Drawing.Point(232, 137);
            this.btn_NewClient.Name = "btn_NewClient";
            this.btn_NewClient.Size = new System.Drawing.Size(261, 60);
            this.btn_NewClient.TabIndex = 8;
            this.btn_NewClient.Text = "New Client";
            this.btn_NewClient.UseVisualStyleBackColor = false;
            this.btn_NewClient.Click += new System.EventHandler(this.btn_NewClient_Click);
            // 
            // btn_ExistingClient
            // 
            this.btn_ExistingClient.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_ExistingClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExistingClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExistingClient.Location = new System.Drawing.Point(232, 224);
            this.btn_ExistingClient.Name = "btn_ExistingClient";
            this.btn_ExistingClient.Size = new System.Drawing.Size(261, 60);
            this.btn_ExistingClient.TabIndex = 9;
            this.btn_ExistingClient.Text = "Existing Clients";
            this.btn_ExistingClient.UseVisualStyleBackColor = false;
            this.btn_ExistingClient.Click += new System.EventHandler(this.btn_ExistingClient_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightBlue;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(16, 15);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(101, 23);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "<<< Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // clientMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "clientMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientMaintenance";
            this.Load += new System.EventHandler(this.clientMaintenance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ExistingClient;
        private System.Windows.Forms.Button btn_NewClient;
        private System.Windows.Forms.Button btn_back;
    }
}