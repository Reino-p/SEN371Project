namespace SEN371Project.PresentationLayer
{
    partial class serviceDepartmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serviceDepartmentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Resolve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dataGridView_assigned = new System.Windows.Forms.DataGridView();
            this.btn_escalate = new System.Windows.Forms.Button();
            this.dataGridView_unassigned = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_unassign = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_assign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_assigned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_unassigned)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Resolve);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.dataGridView_assigned);
            this.panel1.Controls.Add(this.btn_escalate);
            this.panel1.Controls.Add(this.dataGridView_unassigned);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_unassign);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_assign);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 402);
            this.panel1.TabIndex = 17;
            // 
            // btn_Resolve
            // 
            this.btn_Resolve.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Resolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Resolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Resolve.Location = new System.Drawing.Point(309, 334);
            this.btn_Resolve.Name = "btn_Resolve";
            this.btn_Resolve.Size = new System.Drawing.Size(112, 25);
            this.btn_Resolve.TabIndex = 45;
            this.btn_Resolve.Text = "Resolve Job";
            this.btn_Resolve.UseVisualStyleBackColor = false;
            this.btn_Resolve.Click += new System.EventHandler(this.btn_Resolve_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Unassigned Tickets:";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(400, 166);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(86, 25);
            this.btn_Search.TabIndex = 43;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Search Ticket:";
            // 
            // txt_Search
            // 
            this.txt_Search.ForeColor = System.Drawing.Color.Black;
            this.txt_Search.Location = new System.Drawing.Point(247, 166);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(157, 25);
            this.txt_Search.TabIndex = 41;
            // 
            // dataGridView_assigned
            // 
            this.dataGridView_assigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_assigned.Location = new System.Drawing.Point(526, 137);
            this.dataGridView_assigned.Name = "dataGridView_assigned";
            this.dataGridView_assigned.Size = new System.Drawing.Size(192, 246);
            this.dataGridView_assigned.TabIndex = 40;
            // 
            // btn_escalate
            // 
            this.btn_escalate.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_escalate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_escalate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_escalate.Location = new System.Drawing.Point(309, 209);
            this.btn_escalate.Name = "btn_escalate";
            this.btn_escalate.Size = new System.Drawing.Size(112, 25);
            this.btn_escalate.TabIndex = 39;
            this.btn_escalate.Text = "Escalate";
            this.btn_escalate.UseVisualStyleBackColor = false;
            this.btn_escalate.Click += new System.EventHandler(this.btn_escalate_Click);
            // 
            // dataGridView_unassigned
            // 
            this.dataGridView_unassigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_unassigned.Location = new System.Drawing.Point(17, 137);
            this.dataGridView_unassigned.Name = "dataGridView_unassigned";
            this.dataGridView_unassigned.Size = new System.Drawing.Size(202, 246);
            this.dataGridView_unassigned.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(523, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Assigned Tickets:";
            // 
            // btn_unassign
            // 
            this.btn_unassign.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_unassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_unassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_unassign.Location = new System.Drawing.Point(309, 251);
            this.btn_unassign.Name = "btn_unassign";
            this.btn_unassign.Size = new System.Drawing.Size(112, 25);
            this.btn_unassign.TabIndex = 13;
            this.btn_unassign.Text = "Unassign";
            this.btn_unassign.UseVisualStyleBackColor = false;
            this.btn_unassign.Click += new System.EventHandler(this.btn_unassign_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightBlue;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(37, 15);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(101, 23);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "<<< Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_assign
            // 
            this.btn_assign.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_assign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_assign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_assign.Location = new System.Drawing.Point(309, 292);
            this.btn_assign.Name = "btn_assign";
            this.btn_assign.Size = new System.Drawing.Size(112, 25);
            this.btn_assign.TabIndex = 8;
            this.btn_assign.Text = "Assign";
            this.btn_assign.UseVisualStyleBackColor = false;
            this.btn_assign.Click += new System.EventHandler(this.btn_assign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Department";
            // 
            // serviceDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "serviceDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "serviceDepartment";
            this.Load += new System.EventHandler(this.serviceDepartment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_assigned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_unassigned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_unassigned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_unassign;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_assign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dataGridView_assigned;
        private System.Windows.Forms.Button btn_escalate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Resolve;
    }
}