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
            this.cb_INAgents = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_SRAgents = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_ServiceRequests = new System.Windows.Forms.ComboBox();
            this.cb_Incidents = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SpecifyServiceRequest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SpecifyIncident = new System.Windows.Forms.TextBox();
            this.btn_INDelete = new System.Windows.Forms.Button();
            this.btn_INUpdateStatus = new System.Windows.Forms.Button();
            this.btn_INassign = new System.Windows.Forms.Button();
            this.btn_SRDelete = new System.Windows.Forms.Button();
            this.btn_SRUpdateStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dataGridView_ServiceRequests = new System.Windows.Forms.DataGridView();
            this.dataGridView_Incidents = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_SRassign = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_INUpdatePriority = new System.Windows.Forms.Button();
            this.cb_INPriority = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_INUpdateResDate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_INResDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_SRResDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_SRUpdateResDate = new System.Windows.Forms.Button();
            this.cb_SRPriority = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_SRUpdatePriority = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServiceRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Incidents)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtp_SRResDate);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btn_SRUpdateResDate);
            this.panel1.Controls.Add(this.cb_SRPriority);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btn_SRUpdatePriority);
            this.panel1.Controls.Add(this.dtp_INResDate);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btn_INUpdateResDate);
            this.panel1.Controls.Add(this.cb_INPriority);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btn_INUpdatePriority);
            this.panel1.Controls.Add(this.cb_INAgents);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cb_SRAgents);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cb_ServiceRequests);
            this.panel1.Controls.Add(this.cb_Incidents);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_SpecifyServiceRequest);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_SpecifyIncident);
            this.panel1.Controls.Add(this.btn_INDelete);
            this.panel1.Controls.Add(this.btn_INUpdateStatus);
            this.panel1.Controls.Add(this.btn_INassign);
            this.panel1.Controls.Add(this.btn_SRDelete);
            this.panel1.Controls.Add(this.btn_SRUpdateStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.dataGridView_ServiceRequests);
            this.panel1.Controls.Add(this.dataGridView_Incidents);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.btn_SRassign);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1525, 775);
            this.panel1.TabIndex = 17;
            // 
            // cb_INAgents
            // 
            this.cb_INAgents.FormattingEnabled = true;
            this.cb_INAgents.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cb_INAgents.Location = new System.Drawing.Point(363, 368);
            this.cb_INAgents.Name = "cb_INAgents";
            this.cb_INAgents.Size = new System.Drawing.Size(97, 24);
            this.cb_INAgents.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(360, 347);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 62;
            this.label10.Text = "Select Agent";
            // 
            // cb_SRAgents
            // 
            this.cb_SRAgents.FormattingEnabled = true;
            this.cb_SRAgents.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cb_SRAgents.Location = new System.Drawing.Point(363, 664);
            this.cb_SRAgents.Name = "cb_SRAgents";
            this.cb_SRAgents.Size = new System.Drawing.Size(97, 24);
            this.cb_SRAgents.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(360, 646);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 17);
            this.label9.TabIndex = 60;
            this.label9.Text = "Select Agent";
            // 
            // cb_ServiceRequests
            // 
            this.cb_ServiceRequests.FormattingEnabled = true;
            this.cb_ServiceRequests.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cb_ServiceRequests.Location = new System.Drawing.Point(623, 664);
            this.cb_ServiceRequests.Name = "cb_ServiceRequests";
            this.cb_ServiceRequests.Size = new System.Drawing.Size(102, 24);
            this.cb_ServiceRequests.TabIndex = 59;
            // 
            // cb_Incidents
            // 
            this.cb_Incidents.FormattingEnabled = true;
            this.cb_Incidents.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cb_Incidents.Location = new System.Drawing.Point(622, 367);
            this.cb_Incidents.Name = "cb_Incidents";
            this.cb_Incidents.Size = new System.Drawing.Size(101, 24);
            this.cb_Incidents.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(620, 646);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "Select Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(619, 347);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Select Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 651);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Type SR Number:";
            // 
            // txt_SpecifyServiceRequest
            // 
            this.txt_SpecifyServiceRequest.ForeColor = System.Drawing.Color.Black;
            this.txt_SpecifyServiceRequest.Location = new System.Drawing.Point(23, 672);
            this.txt_SpecifyServiceRequest.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SpecifyServiceRequest.Multiline = true;
            this.txt_SpecifyServiceRequest.Name = "txt_SpecifyServiceRequest";
            this.txt_SpecifyServiceRequest.Size = new System.Drawing.Size(176, 30);
            this.txt_SpecifyServiceRequest.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Type INC Number:";
            // 
            // txt_SpecifyIncident
            // 
            this.txt_SpecifyIncident.ForeColor = System.Drawing.Color.Black;
            this.txt_SpecifyIncident.Location = new System.Drawing.Point(23, 369);
            this.txt_SpecifyIncident.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SpecifyIncident.Multiline = true;
            this.txt_SpecifyIncident.Name = "txt_SpecifyIncident";
            this.txt_SpecifyIncident.Size = new System.Drawing.Size(176, 30);
            this.txt_SpecifyIncident.TabIndex = 52;
            // 
            // btn_INDelete
            // 
            this.btn_INDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_INDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_INDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_INDelete.Location = new System.Drawing.Point(1383, 346);
            this.btn_INDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_INDelete.Name = "btn_INDelete";
            this.btn_INDelete.Size = new System.Drawing.Size(107, 53);
            this.btn_INDelete.TabIndex = 51;
            this.btn_INDelete.Text = "Delete INC";
            this.btn_INDelete.UseVisualStyleBackColor = false;
            this.btn_INDelete.Click += new System.EventHandler(this.btn_INDelete_Click);
            // 
            // btn_INUpdateStatus
            // 
            this.btn_INUpdateStatus.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_INUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_INUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_INUpdateStatus.Location = new System.Drawing.Point(466, 348);
            this.btn_INUpdateStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_INUpdateStatus.Name = "btn_INUpdateStatus";
            this.btn_INUpdateStatus.Size = new System.Drawing.Size(149, 50);
            this.btn_INUpdateStatus.TabIndex = 50;
            this.btn_INUpdateStatus.Text = "Update Status";
            this.btn_INUpdateStatus.UseVisualStyleBackColor = false;
            this.btn_INUpdateStatus.Click += new System.EventHandler(this.btn_INUpdateStatus_Click);
            // 
            // btn_INassign
            // 
            this.btn_INassign.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_INassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_INassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_INassign.Location = new System.Drawing.Point(207, 347);
            this.btn_INassign.Margin = new System.Windows.Forms.Padding(4);
            this.btn_INassign.Name = "btn_INassign";
            this.btn_INassign.Size = new System.Drawing.Size(149, 51);
            this.btn_INassign.TabIndex = 47;
            this.btn_INassign.Text = "Update Assignee";
            this.btn_INassign.UseVisualStyleBackColor = false;
            this.btn_INassign.Click += new System.EventHandler(this.btn_INassign_Click);
            // 
            // btn_SRDelete
            // 
            this.btn_SRDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_SRDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SRDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SRDelete.Location = new System.Drawing.Point(1383, 651);
            this.btn_SRDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SRDelete.Name = "btn_SRDelete";
            this.btn_SRDelete.Size = new System.Drawing.Size(107, 51);
            this.btn_SRDelete.TabIndex = 46;
            this.btn_SRDelete.Text = "Delete SR";
            this.btn_SRDelete.UseVisualStyleBackColor = false;
            this.btn_SRDelete.Click += new System.EventHandler(this.btn_SRDelete_Click);
            // 
            // btn_SRUpdateStatus
            // 
            this.btn_SRUpdateStatus.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_SRUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SRUpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SRUpdateStatus.Location = new System.Drawing.Point(466, 648);
            this.btn_SRUpdateStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SRUpdateStatus.Name = "btn_SRUpdateStatus";
            this.btn_SRUpdateStatus.Size = new System.Drawing.Size(149, 54);
            this.btn_SRUpdateStatus.TabIndex = 45;
            this.btn_SRUpdateStatus.Text = "Update Status";
            this.btn_SRUpdateStatus.UseVisualStyleBackColor = false;
            this.btn_SRUpdateStatus.Click += new System.EventHandler(this.btn_SRStatus_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "Incident Tickets (INC):";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(962, 87);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(115, 31);
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
            this.label2.Location = new System.Drawing.Point(435, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Search All Tickets:";
            // 
            // txt_Search
            // 
            this.txt_Search.ForeColor = System.Drawing.Color.Black;
            this.txt_Search.Location = new System.Drawing.Point(623, 87);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(343, 30);
            this.txt_Search.TabIndex = 41;
            // 
            // dataGridView_ServiceRequests
            // 
            this.dataGridView_ServiceRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ServiceRequests.Location = new System.Drawing.Point(23, 448);
            this.dataGridView_ServiceRequests.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_ServiceRequests.Name = "dataGridView_ServiceRequests";
            this.dataGridView_ServiceRequests.RowHeadersWidth = 51;
            this.dataGridView_ServiceRequests.Size = new System.Drawing.Size(1467, 194);
            this.dataGridView_ServiceRequests.TabIndex = 40;
            // 
            // dataGridView_Incidents
            // 
            this.dataGridView_Incidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Incidents.Location = new System.Drawing.Point(23, 126);
            this.dataGridView_Incidents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Incidents.Name = "dataGridView_Incidents";
            this.dataGridView_Incidents.RowHeadersWidth = 51;
            this.dataGridView_Incidents.Size = new System.Drawing.Size(1467, 213);
            this.dataGridView_Incidents.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 427);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Service Request Tickets (SR):";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.LightBlue;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(49, 18);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(135, 28);
            this.btn_back.TabIndex = 12;
            this.btn_back.Text = "<<< Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_SRassign
            // 
            this.btn_SRassign.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_SRassign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SRassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SRassign.Location = new System.Drawing.Point(207, 648);
            this.btn_SRassign.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SRassign.Name = "btn_SRassign";
            this.btn_SRassign.Size = new System.Drawing.Size(149, 54);
            this.btn_SRassign.TabIndex = 8;
            this.btn_SRassign.Text = "Update Assignee";
            this.btn_SRassign.UseVisualStyleBackColor = false;
            this.btn_SRassign.Click += new System.EventHandler(this.btn_SRassign_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Department";
            // 
            // btn_INUpdatePriority
            // 
            this.btn_INUpdatePriority.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_INUpdatePriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_INUpdatePriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_INUpdatePriority.Location = new System.Drawing.Point(730, 348);
            this.btn_INUpdatePriority.Margin = new System.Windows.Forms.Padding(4);
            this.btn_INUpdatePriority.Name = "btn_INUpdatePriority";
            this.btn_INUpdatePriority.Size = new System.Drawing.Size(149, 50);
            this.btn_INUpdatePriority.TabIndex = 64;
            this.btn_INUpdatePriority.Text = "Update Priority";
            this.btn_INUpdatePriority.UseVisualStyleBackColor = false;
            this.btn_INUpdatePriority.Click += new System.EventHandler(this.btn_INUpdatePriority_Click);
            // 
            // cb_INPriority
            // 
            this.cb_INPriority.FormattingEnabled = true;
            this.cb_INPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_INPriority.Location = new System.Drawing.Point(886, 367);
            this.cb_INPriority.Name = "cb_INPriority";
            this.cb_INPriority.Size = new System.Drawing.Size(106, 24);
            this.cb_INPriority.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(883, 347);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 65;
            this.label11.Text = "Select Priority";
            // 
            // btn_INUpdateResDate
            // 
            this.btn_INUpdateResDate.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_INUpdateResDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_INUpdateResDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_INUpdateResDate.Location = new System.Drawing.Point(999, 347);
            this.btn_INUpdateResDate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_INUpdateResDate.Name = "btn_INUpdateResDate";
            this.btn_INUpdateResDate.Size = new System.Drawing.Size(149, 52);
            this.btn_INUpdateResDate.TabIndex = 67;
            this.btn_INUpdateResDate.Text = "Update Resolution Date";
            this.btn_INUpdateResDate.UseVisualStyleBackColor = false;
            this.btn_INUpdateResDate.Click += new System.EventHandler(this.btn_INUpdateResDate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1177, 348);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "Select Resolution Date";
            // 
            // dtp_INResDate
            // 
            this.dtp_INResDate.Location = new System.Drawing.Point(1155, 371);
            this.dtp_INResDate.Name = "dtp_INResDate";
            this.dtp_INResDate.Size = new System.Drawing.Size(221, 22);
            this.dtp_INResDate.TabIndex = 69;
            // 
            // dtp_SRResDate
            // 
            this.dtp_SRResDate.Location = new System.Drawing.Point(1155, 671);
            this.dtp_SRResDate.Name = "dtp_SRResDate";
            this.dtp_SRResDate.Size = new System.Drawing.Size(221, 22);
            this.dtp_SRResDate.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1177, 648);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 17);
            this.label13.TabIndex = 74;
            this.label13.Text = "Select Resolution Date";
            // 
            // btn_SRUpdateResDate
            // 
            this.btn_SRUpdateResDate.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_SRUpdateResDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SRUpdateResDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SRUpdateResDate.Location = new System.Drawing.Point(999, 650);
            this.btn_SRUpdateResDate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SRUpdateResDate.Name = "btn_SRUpdateResDate";
            this.btn_SRUpdateResDate.Size = new System.Drawing.Size(149, 52);
            this.btn_SRUpdateResDate.TabIndex = 73;
            this.btn_SRUpdateResDate.Text = "Update Resolution Date";
            this.btn_SRUpdateResDate.UseVisualStyleBackColor = false;
            this.btn_SRUpdateResDate.Click += new System.EventHandler(this.btn_SRUpdateResDate_Click);
            // 
            // cb_SRPriority
            // 
            this.cb_SRPriority.FormattingEnabled = true;
            this.cb_SRPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_SRPriority.Location = new System.Drawing.Point(886, 664);
            this.cb_SRPriority.Name = "cb_SRPriority";
            this.cb_SRPriority.Size = new System.Drawing.Size(106, 24);
            this.cb_SRPriority.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(883, 646);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 17);
            this.label14.TabIndex = 71;
            this.label14.Text = "Select Priority";
            // 
            // btn_SRUpdatePriority
            // 
            this.btn_SRUpdatePriority.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_SRUpdatePriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SRUpdatePriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SRUpdatePriority.Location = new System.Drawing.Point(730, 651);
            this.btn_SRUpdatePriority.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SRUpdatePriority.Name = "btn_SRUpdatePriority";
            this.btn_SRUpdatePriority.Size = new System.Drawing.Size(149, 51);
            this.btn_SRUpdatePriority.TabIndex = 70;
            this.btn_SRUpdatePriority.Text = "Update Priority";
            this.btn_SRUpdatePriority.UseVisualStyleBackColor = false;
            this.btn_SRUpdatePriority.Click += new System.EventHandler(this.btn_SRUpdatePriority_Click);
            // 
            // serviceDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1561, 828);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "serviceDepartmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "serviceDepartment";
            this.Load += new System.EventHandler(this.serviceDepartment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServiceRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Incidents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_Incidents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_SRassign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dataGridView_ServiceRequests;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SRUpdateStatus;
        private System.Windows.Forms.Button btn_SRDelete;
        private System.Windows.Forms.Button btn_INDelete;
        private System.Windows.Forms.Button btn_INUpdateStatus;
        private System.Windows.Forms.Button btn_INassign;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SpecifyServiceRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SpecifyIncident;
        private System.Windows.Forms.ComboBox cb_ServiceRequests;
        private System.Windows.Forms.ComboBox cb_Incidents;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_SRAgents;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_INAgents;
        private System.Windows.Forms.Button btn_INUpdatePriority;
        private System.Windows.Forms.ComboBox cb_INPriority;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_INResDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_INUpdateResDate;
        private System.Windows.Forms.DateTimePicker dtp_SRResDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_SRUpdateResDate;
        private System.Windows.Forms.ComboBox cb_SRPriority;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_SRUpdatePriority;
    }
}