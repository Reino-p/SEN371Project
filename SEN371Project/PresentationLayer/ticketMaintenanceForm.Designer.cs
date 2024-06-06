namespace SEN371Project.PresentationLayer
{
    partial class ticketMaintenanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticketMaintenanceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_ExistingTickets = new System.Windows.Forms.Button();
            this.btn_NewTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_ExistingTickets);
            this.panel1.Controls.Add(this.btn_NewTicket);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 402);
            this.panel1.TabIndex = 16;
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
            // btn_ExistingTickets
            // 
            this.btn_ExistingTickets.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_ExistingTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExistingTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExistingTickets.Location = new System.Drawing.Point(232, 224);
            this.btn_ExistingTickets.Name = "btn_ExistingTickets";
            this.btn_ExistingTickets.Size = new System.Drawing.Size(261, 60);
            this.btn_ExistingTickets.TabIndex = 9;
            this.btn_ExistingTickets.Text = "Service Department\r\nExisting Tickets";
            this.btn_ExistingTickets.UseVisualStyleBackColor = false;
            this.btn_ExistingTickets.Click += new System.EventHandler(this.btn_ExistingTickets_Click);
            // 
            // btn_NewTicket
            // 
            this.btn_NewTicket.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_NewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewTicket.Location = new System.Drawing.Point(232, 137);
            this.btn_NewTicket.Name = "btn_NewTicket";
            this.btn_NewTicket.Size = new System.Drawing.Size(261, 60);
            this.btn_NewTicket.TabIndex = 8;
            this.btn_NewTicket.Text = "New Ticket";
            this.btn_NewTicket.UseVisualStyleBackColor = false;
            this.btn_NewTicket.Click += new System.EventHandler(this.btn_NewTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Maintenance";
            // 
            // ticketMaintenanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ticketMaintenanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Maintenance";
            this.Load += new System.EventHandler(this.ticketMaintenanceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_ExistingTickets;
        private System.Windows.Forms.Button btn_NewTicket;
        private System.Windows.Forms.Label label1;
    }
}