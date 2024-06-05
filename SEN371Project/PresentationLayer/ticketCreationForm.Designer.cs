namespace SEN371Project.PresentationLayer
{
    partial class ticketCreationForm
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
            this.dtp_SRReportedDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_SRPriority = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtp_INReportedDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_INPriority = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.btn_INCreate = new System.Windows.Forms.Button();
            this.btn_SRCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dataGridView_ServiceRequests = new System.Windows.Forms.DataGridView();
            this.dataGridView_Incidents = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_ServiceRequestDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_IncidentDescription = new System.Windows.Forms.TextBox();
            this.cb_SRSystemID = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_INSystemID = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_SRClientID = new System.Windows.Forms.TextBox();
            this.txt_INClientID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServiceRequests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Incidents)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_SRReportedDate
            // 
            this.dtp_SRReportedDate.Location = new System.Drawing.Point(530, 685);
            this.dtp_SRReportedDate.Name = "dtp_SRReportedDate";
            this.dtp_SRReportedDate.Size = new System.Drawing.Size(221, 22);
            this.dtp_SRReportedDate.TabIndex = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(552, 659);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 17);
            this.label13.TabIndex = 74;
            this.label13.Text = "Select Reported Date";
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
            this.cb_SRPriority.Location = new System.Drawing.Point(417, 685);
            this.cb_SRPriority.Name = "cb_SRPriority";
            this.cb_SRPriority.Size = new System.Drawing.Size(106, 24);
            this.cb_SRPriority.TabIndex = 72;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(417, 659);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 17);
            this.label14.TabIndex = 71;
            this.label14.Text = "Select Priority";
            // 
            // dtp_INReportedDate
            // 
            this.dtp_INReportedDate.Location = new System.Drawing.Point(530, 373);
            this.dtp_INReportedDate.Name = "dtp_INReportedDate";
            this.dtp_INReportedDate.Size = new System.Drawing.Size(221, 22);
            this.dtp_INReportedDate.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(552, 343);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "Select Reported Date";
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
            this.cb_INPriority.Location = new System.Drawing.Point(417, 373);
            this.cb_INPriority.Name = "cb_INPriority";
            this.cb_INPriority.Size = new System.Drawing.Size(106, 24);
            this.cb_INPriority.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(417, 343);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 17);
            this.label11.TabIndex = 65;
            this.label11.Text = "Select Priority";
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
            this.cb_INAgents.Location = new System.Drawing.Point(206, 373);
            this.cb_INAgents.Name = "cb_INAgents";
            this.cb_INAgents.Size = new System.Drawing.Size(97, 24);
            this.cb_INAgents.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(204, 343);
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
            this.cb_SRAgents.Location = new System.Drawing.Point(206, 685);
            this.cb_SRAgents.Name = "cb_SRAgents";
            this.cb_SRAgents.Size = new System.Drawing.Size(97, 24);
            this.cb_SRAgents.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(204, 659);
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
            this.cb_ServiceRequests.Location = new System.Drawing.Point(309, 685);
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
            this.cb_Incidents.Location = new System.Drawing.Point(309, 373);
            this.cb_Incidents.Name = "cb_Incidents";
            this.cb_Incidents.Size = new System.Drawing.Size(101, 24);
            this.cb_Incidents.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(309, 659);
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
            this.label7.Location = new System.Drawing.Point(306, 343);
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
            this.label6.Location = new System.Drawing.Point(25, 659);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 55;
            this.label6.Text = "Type SR Number:";
            // 
            // txt_SpecifyServiceRequest
            // 
            this.txt_SpecifyServiceRequest.ForeColor = System.Drawing.Color.Black;
            this.txt_SpecifyServiceRequest.Location = new System.Drawing.Point(23, 685);
            this.txt_SpecifyServiceRequest.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SpecifyServiceRequest.Multiline = true;
            this.txt_SpecifyServiceRequest.Name = "txt_SpecifyServiceRequest";
            this.txt_SpecifyServiceRequest.Size = new System.Drawing.Size(176, 24);
            this.txt_SpecifyServiceRequest.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Type INC Number:";
            // 
            // txt_SpecifyIncident
            // 
            this.txt_SpecifyIncident.ForeColor = System.Drawing.Color.Black;
            this.txt_SpecifyIncident.Location = new System.Drawing.Point(23, 373);
            this.txt_SpecifyIncident.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SpecifyIncident.Multiline = true;
            this.txt_SpecifyIncident.Name = "txt_SpecifyIncident";
            this.txt_SpecifyIncident.Size = new System.Drawing.Size(176, 25);
            this.txt_SpecifyIncident.TabIndex = 52;
            // 
            // btn_INCreate
            // 
            this.btn_INCreate.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_INCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_INCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_INCreate.Location = new System.Drawing.Point(1383, 344);
            this.btn_INCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_INCreate.Name = "btn_INCreate";
            this.btn_INCreate.Size = new System.Drawing.Size(107, 53);
            this.btn_INCreate.TabIndex = 51;
            this.btn_INCreate.Text = "Create INC";
            this.btn_INCreate.UseVisualStyleBackColor = false;
            this.btn_INCreate.Click += new System.EventHandler(this.btn_INCreate_Click);
            // 
            // btn_SRCreate
            // 
            this.btn_SRCreate.BackColor = System.Drawing.Color.PowderBlue;
            this.btn_SRCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SRCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SRCreate.Location = new System.Drawing.Point(1383, 658);
            this.btn_SRCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SRCreate.Name = "btn_SRCreate";
            this.btn_SRCreate.Size = new System.Drawing.Size(107, 51);
            this.btn_SRCreate.TabIndex = 46;
            this.btn_SRCreate.Text = "Create SR";
            this.btn_SRCreate.UseVisualStyleBackColor = false;
            this.btn_SRCreate.Click += new System.EventHandler(this.btn_SRCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 17);
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
            this.dataGridView_ServiceRequests.Location = new System.Drawing.Point(23, 461);
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
            this.label5.Location = new System.Drawing.Point(25, 440);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 17);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(622, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Creation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_SRClientID);
            this.panel1.Controls.Add(this.txt_INClientID);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.cb_SRSystemID);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.cb_INSystemID);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txt_ServiceRequestDescription);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txt_IncidentDescription);
            this.panel1.Controls.Add(this.dtp_SRReportedDate);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cb_SRPriority);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.dtp_INReportedDate);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.cb_INPriority);
            this.panel1.Controls.Add(this.label11);
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
            this.panel1.Controls.Add(this.btn_INCreate);
            this.panel1.Controls.Add(this.btn_SRCreate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Search);
            this.panel1.Controls.Add(this.dataGridView_ServiceRequests);
            this.panel1.Controls.Add(this.dataGridView_Incidents);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1565, 776);
            this.panel1.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(804, 659);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 17);
            this.label15.TabIndex = 79;
            this.label15.Text = "Service Request Description:";
            // 
            // txt_ServiceRequestDescription
            // 
            this.txt_ServiceRequestDescription.ForeColor = System.Drawing.Color.Black;
            this.txt_ServiceRequestDescription.Location = new System.Drawing.Point(758, 683);
            this.txt_ServiceRequestDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ServiceRequestDescription.Multiline = true;
            this.txt_ServiceRequestDescription.Name = "txt_ServiceRequestDescription";
            this.txt_ServiceRequestDescription.Size = new System.Drawing.Size(335, 24);
            this.txt_ServiceRequestDescription.TabIndex = 78;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(837, 343);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 17);
            this.label16.TabIndex = 77;
            this.label16.Text = "Incident Description";
            // 
            // txt_IncidentDescription
            // 
            this.txt_IncidentDescription.ForeColor = System.Drawing.Color.Black;
            this.txt_IncidentDescription.Location = new System.Drawing.Point(758, 372);
            this.txt_IncidentDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IncidentDescription.Multiline = true;
            this.txt_IncidentDescription.Name = "txt_IncidentDescription";
            this.txt_IncidentDescription.Size = new System.Drawing.Size(335, 25);
            this.txt_IncidentDescription.TabIndex = 76;
            // 
            // cb_SRSystemID
            // 
            this.cb_SRSystemID.FormattingEnabled = true;
            this.cb_SRSystemID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_SRSystemID.Location = new System.Drawing.Point(1099, 683);
            this.cb_SRSystemID.Name = "cb_SRSystemID";
            this.cb_SRSystemID.Size = new System.Drawing.Size(122, 24);
            this.cb_SRSystemID.TabIndex = 83;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1097, 659);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 17);
            this.label17.TabIndex = 82;
            this.label17.Text = "Select SystemID";
            // 
            // cb_INSystemID
            // 
            this.cb_INSystemID.FormattingEnabled = true;
            this.cb_INSystemID.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_INSystemID.Location = new System.Drawing.Point(1099, 372);
            this.cb_INSystemID.Name = "cb_INSystemID";
            this.cb_INSystemID.Size = new System.Drawing.Size(122, 24);
            this.cb_INSystemID.TabIndex = 81;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1096, 343);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(125, 17);
            this.label18.TabIndex = 80;
            this.label18.Text = "Select SystemID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1230, 659);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 17);
            this.label19.TabIndex = 86;
            this.label19.Text = "Provide ClientID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1226, 343);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 17);
            this.label20.TabIndex = 84;
            this.label20.Text = "Provide ClientID";
            // 
            // txt_SRClientID
            // 
            this.txt_SRClientID.ForeColor = System.Drawing.Color.Black;
            this.txt_SRClientID.Location = new System.Drawing.Point(1229, 683);
            this.txt_SRClientID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SRClientID.Multiline = true;
            this.txt_SRClientID.Name = "txt_SRClientID";
            this.txt_SRClientID.Size = new System.Drawing.Size(122, 24);
            this.txt_SRClientID.TabIndex = 88;
            // 
            // txt_INClientID
            // 
            this.txt_INClientID.ForeColor = System.Drawing.Color.Black;
            this.txt_INClientID.Location = new System.Drawing.Point(1229, 371);
            this.txt_INClientID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_INClientID.Multiline = true;
            this.txt_INClientID.Name = "txt_INClientID";
            this.txt_INClientID.Size = new System.Drawing.Size(122, 25);
            this.txt_INClientID.TabIndex = 87;
            // 
            // ticketCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1598, 803);
            this.Controls.Add(this.panel1);
            this.Name = "ticketCreationForm";
            this.Text = "ticketCreationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServiceRequests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Incidents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_SRReportedDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_SRPriority;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtp_INReportedDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cb_INPriority;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_INAgents;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_SRAgents;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_ServiceRequests;
        private System.Windows.Forms.ComboBox cb_Incidents;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SpecifyServiceRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SpecifyIncident;
        private System.Windows.Forms.Button btn_INCreate;
        private System.Windows.Forms.Button btn_SRCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView dataGridView_ServiceRequests;
        private System.Windows.Forms.DataGridView dataGridView_Incidents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_SRSystemID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_INSystemID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_ServiceRequestDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_IncidentDescription;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_SRClientID;
        private System.Windows.Forms.TextBox txt_INClientID;
    }
}