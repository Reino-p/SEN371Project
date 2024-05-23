namespace SEN371Project
{
    partial class portalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(portalForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CallCenter = new System.Windows.Forms.Button();
            this.btn_ClientMaintenance = new System.Windows.Forms.Button();
            this.btn_ContractMaintenance = new System.Windows.Forms.Button();
            this.btn_ServiceDepartment = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Premier Service Solution\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Portal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_ServiceDepartment);
            this.panel1.Controls.Add(this.btn_ContractMaintenance);
            this.panel1.Controls.Add(this.btn_ClientMaintenance);
            this.panel1.Controls.Add(this.btn_CallCenter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 402);
            this.panel1.TabIndex = 12;
            // 
            // btn_CallCenter
            // 
            this.btn_CallCenter.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_CallCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CallCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CallCenter.Location = new System.Drawing.Point(148, 126);
            this.btn_CallCenter.Name = "btn_CallCenter";
            this.btn_CallCenter.Size = new System.Drawing.Size(427, 34);
            this.btn_CallCenter.TabIndex = 7;
            this.btn_CallCenter.Text = "Call Center";
            this.btn_CallCenter.UseVisualStyleBackColor = false;
            this.btn_CallCenter.Click += new System.EventHandler(this.btn_CallCenter_Click);
            // 
            // btn_ClientMaintenance
            // 
            this.btn_ClientMaintenance.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_ClientMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClientMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClientMaintenance.Location = new System.Drawing.Point(148, 182);
            this.btn_ClientMaintenance.Name = "btn_ClientMaintenance";
            this.btn_ClientMaintenance.Size = new System.Drawing.Size(427, 34);
            this.btn_ClientMaintenance.TabIndex = 8;
            this.btn_ClientMaintenance.Text = "Client Maintenance";
            this.btn_ClientMaintenance.UseVisualStyleBackColor = false;
            this.btn_ClientMaintenance.Click += new System.EventHandler(this.btn_ClientMaintenance_Click);
            // 
            // btn_ContractMaintenance
            // 
            this.btn_ContractMaintenance.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_ContractMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ContractMaintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ContractMaintenance.Location = new System.Drawing.Point(148, 239);
            this.btn_ContractMaintenance.Name = "btn_ContractMaintenance";
            this.btn_ContractMaintenance.Size = new System.Drawing.Size(427, 34);
            this.btn_ContractMaintenance.TabIndex = 9;
            this.btn_ContractMaintenance.Text = "Contract Maintenance";
            this.btn_ContractMaintenance.UseVisualStyleBackColor = false;
            this.btn_ContractMaintenance.Click += new System.EventHandler(this.btn_ContractMaintenance_Click);
            // 
            // btn_ServiceDepartment
            // 
            this.btn_ServiceDepartment.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_ServiceDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ServiceDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ServiceDepartment.Location = new System.Drawing.Point(148, 297);
            this.btn_ServiceDepartment.Name = "btn_ServiceDepartment";
            this.btn_ServiceDepartment.Size = new System.Drawing.Size(427, 34);
            this.btn_ServiceDepartment.TabIndex = 10;
            this.btn_ServiceDepartment.Text = "Service Department";
            this.btn_ServiceDepartment.UseVisualStyleBackColor = false;
            this.btn_ServiceDepartment.Click += new System.EventHandler(this.btn_ServiceDepartment_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(15, 23);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(89, 34);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // portalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "portalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal";
            this.Load += new System.EventHandler(this.portalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ServiceDepartment;
        private System.Windows.Forms.Button btn_ContractMaintenance;
        private System.Windows.Forms.Button btn_ClientMaintenance;
        private System.Windows.Forms.Button btn_CallCenter;
        private System.Windows.Forms.Button btn_Logout;
    }
}

