namespace SEN371Project.PresentationLayer
{
    partial class contractMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contractMaintenance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_ExistingContracts = new System.Windows.Forms.Button();
            this.btn_NewContract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_ExistingContracts);
            this.panel1.Controls.Add(this.btn_NewContract);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 402);
            this.panel1.TabIndex = 15;
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
            // btn_ExistingContracts
            // 
            this.btn_ExistingContracts.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_ExistingContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExistingContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExistingContracts.Location = new System.Drawing.Point(232, 224);
            this.btn_ExistingContracts.Name = "btn_ExistingContracts";
            this.btn_ExistingContracts.Size = new System.Drawing.Size(261, 60);
            this.btn_ExistingContracts.TabIndex = 9;
            this.btn_ExistingContracts.Text = "Existing Contracts";
            this.btn_ExistingContracts.UseVisualStyleBackColor = false;
            this.btn_ExistingContracts.Click += new System.EventHandler(this.btn_ExistingContracts_Click);
            // 
            // btn_NewContract
            // 
            this.btn_NewContract.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_NewContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewContract.Location = new System.Drawing.Point(232, 137);
            this.btn_NewContract.Name = "btn_NewContract";
            this.btn_NewContract.Size = new System.Drawing.Size(261, 60);
            this.btn_NewContract.TabIndex = 8;
            this.btn_NewContract.Text = "New Contract";
            this.btn_NewContract.UseVisualStyleBackColor = false;
            this.btn_NewContract.Click += new System.EventHandler(this.btn_NewContract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contracts";
            // 
            // contractMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "contractMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "contractMaintenance";
            this.Load += new System.EventHandler(this.contractMaintenance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_ExistingContracts;
        private System.Windows.Forms.Button btn_NewContract;
        private System.Windows.Forms.Label label1;
    }
}