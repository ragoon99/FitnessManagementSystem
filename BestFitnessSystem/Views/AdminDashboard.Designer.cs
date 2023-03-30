namespace BestFitnessSystem.Views {
    partial class AdminDashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.plan_tab = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.plan_table = new System.Windows.Forms.DataGridView();
            this.plan_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.session = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.users_tab = new System.Windows.Forms.TabPage();
            this.search_button = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.addClient_button = new System.Windows.Forms.Button();
            this.client_table = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registration_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.user_label = new System.Windows.Forms.Label();
            this.payment_tab = new System.Windows.Forms.TabPage();
            this.topPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.plan_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plan_table)).BeginInit();
            this.users_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client_table)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.label5);
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Controls.Add(this.heading);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(943, 81);
            this.topPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(878, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Logout";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(787, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fitness Management";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(787, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Himalayan Digital Solution ©";
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.SystemColors.Control;
            this.heading.Location = new System.Drawing.Point(26, 27);
            this.heading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(148, 21);
            this.heading.TabIndex = 0;
            this.heading.Text = "Admin Dashboard";
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.tabControl1);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 81);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(943, 518);
            this.centerPanel.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.plan_tab);
            this.tabControl1.Controls.Add(this.users_tab);
            this.tabControl1.Controls.Add(this.payment_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 518);
            this.tabControl1.TabIndex = 0;
            // 
            // plan_tab
            // 
            this.plan_tab.Controls.Add(this.button3);
            this.plan_tab.Controls.Add(this.button2);
            this.plan_tab.Controls.Add(this.button1);
            this.plan_tab.Controls.Add(this.plan_table);
            this.plan_tab.Controls.Add(this.label1);
            this.plan_tab.Location = new System.Drawing.Point(4, 34);
            this.plan_tab.Name = "plan_tab";
            this.plan_tab.Padding = new System.Windows.Forms.Padding(3);
            this.plan_tab.Size = new System.Drawing.Size(935, 480);
            this.plan_tab.TabIndex = 0;
            this.plan_tab.Text = "Traning Plans";
            this.plan_tab.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(26, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Plan";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(26, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 41);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit Plan";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(26, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Plan";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // plan_table
            // 
            this.plan_table.AllowUserToAddRows = false;
            this.plan_table.AllowUserToDeleteRows = false;
            this.plan_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plan_table.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plan_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plan_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plan_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plan_id,
            this.plan_name,
            this.session,
            this.paymentType,
            this.cost,
            this.planType});
            this.plan_table.Location = new System.Drawing.Point(254, 57);
            this.plan_table.Name = "plan_table";
            this.plan_table.ReadOnly = true;
            this.plan_table.RowHeadersVisible = false;
            this.plan_table.Size = new System.Drawing.Size(669, 415);
            this.plan_table.TabIndex = 1;
            // 
            // plan_id
            // 
            this.plan_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plan_id.DataPropertyName = "plan_id";
            this.plan_id.HeaderText = "ID";
            this.plan_id.Name = "plan_id";
            this.plan_id.ReadOnly = true;
            // 
            // plan_name
            // 
            this.plan_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plan_name.DataPropertyName = "plan_name";
            this.plan_name.HeaderText = "Plan Name";
            this.plan_name.Name = "plan_name";
            this.plan_name.ReadOnly = true;
            // 
            // session
            // 
            this.session.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.session.DataPropertyName = "session";
            this.session.HeaderText = "Session";
            this.session.Name = "session";
            this.session.ReadOnly = true;
            // 
            // paymentType
            // 
            this.paymentType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paymentType.DataPropertyName = "paymentType";
            this.paymentType.HeaderText = "Payment Type";
            this.paymentType.Name = "paymentType";
            this.paymentType.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // planType
            // 
            this.planType.DataPropertyName = "plan_type";
            this.planType.HeaderText = "Plan Type";
            this.planType.Name = "planType";
            this.planType.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(929, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Traning Plans";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // users_tab
            // 
            this.users_tab.Controls.Add(this.search_button);
            this.users_tab.Controls.Add(this.searchBar);
            this.users_tab.Controls.Add(this.addClient_button);
            this.users_tab.Controls.Add(this.client_table);
            this.users_tab.Controls.Add(this.user_label);
            this.users_tab.Location = new System.Drawing.Point(4, 34);
            this.users_tab.Name = "users_tab";
            this.users_tab.Padding = new System.Windows.Forms.Padding(3);
            this.users_tab.Size = new System.Drawing.Size(935, 480);
            this.users_tab.TabIndex = 1;
            this.users_tab.Text = "Users";
            this.users_tab.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            this.search_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_button.Location = new System.Drawing.Point(836, 75);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 4;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBar.Location = new System.Drawing.Point(612, 75);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(218, 25);
            this.searchBar.TabIndex = 3;
            this.searchBar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addClient_button
            // 
            this.addClient_button.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addClient_button.FlatAppearance.BorderSize = 0;
            this.addClient_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addClient_button.Location = new System.Drawing.Point(26, 63);
            this.addClient_button.Name = "addClient_button";
            this.addClient_button.Size = new System.Drawing.Size(114, 35);
            this.addClient_button.TabIndex = 2;
            this.addClient_button.Text = "Add Client";
            this.addClient_button.UseVisualStyleBackColor = false;
            this.addClient_button.Click += new System.EventHandler(this.addClient_button_Click);
            // 
            // client_table
            // 
            this.client_table.AllowUserToAddRows = false;
            this.client_table.AllowUserToDeleteRows = false;
            this.client_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.client_table.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.client_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.client_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.client_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.fname,
            this.lname,
            this.address,
            this.gender,
            this.dob,
            this.registration_date,
            this.currentWeight,
            this.targetWeight,
            this.edit,
            this.delete});
            this.client_table.Location = new System.Drawing.Point(26, 106);
            this.client_table.MultiSelect = false;
            this.client_table.Name = "client_table";
            this.client_table.ReadOnly = true;
            this.client_table.RowHeadersVisible = false;
            this.client_table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.client_table.Size = new System.Drawing.Size(885, 366);
            this.client_table.TabIndex = 1;
            this.client_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.client_table_CellClick);
            // 
            // user_id
            // 
            this.user_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_id.DataPropertyName = "id";
            this.user_id.HeaderText = "id";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // fname
            // 
            this.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fname.DataPropertyName = "fname";
            this.fname.HeaderText = "First Name";
            this.fname.Name = "fname";
            this.fname.ReadOnly = true;
            // 
            // lname
            // 
            this.lname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lname.DataPropertyName = "lname";
            this.lname.HeaderText = "Last Name";
            this.lname.Name = "lname";
            this.lname.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // dob
            // 
            this.dob.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "DOB";
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            // 
            // registration_date
            // 
            this.registration_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.registration_date.DataPropertyName = "registration_date";
            this.registration_date.HeaderText = "Registration Date";
            this.registration_date.Name = "registration_date";
            this.registration_date.ReadOnly = true;
            // 
            // currentWeight
            // 
            this.currentWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.currentWeight.DataPropertyName = "current_weight(kg)";
            this.currentWeight.HeaderText = "Current Weight (kg)";
            this.currentWeight.Name = "currentWeight";
            this.currentWeight.ReadOnly = true;
            // 
            // targetWeight
            // 
            this.targetWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.targetWeight.DataPropertyName = "target_weight(kg)";
            this.targetWeight.HeaderText = "Target Weight(kg)";
            this.targetWeight.Name = "targetWeight";
            this.targetWeight.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.edit.DefaultCellStyle = dataGridViewCellStyle3;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.HeaderText = "";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Edit";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.delete.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Delete";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // user_label
            // 
            this.user_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.Location = new System.Drawing.Point(3, 3);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(929, 57);
            this.user_label.TabIndex = 0;
            this.user_label.Text = "Client List";
            this.user_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payment_tab
            // 
            this.payment_tab.Location = new System.Drawing.Point(4, 34);
            this.payment_tab.Name = "payment_tab";
            this.payment_tab.Size = new System.Drawing.Size(935, 480);
            this.payment_tab.TabIndex = 2;
            this.payment_tab.Text = "Payments";
            this.payment_tab.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 599);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.topPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.centerPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.plan_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plan_table)).EndInit();
            this.users_tab.ResumeLayout(false);
            this.users_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.client_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage plan_tab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage users_tab;
        private System.Windows.Forms.TabPage payment_tab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView plan_table;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView client_table;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.Button addClient_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn session;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn planType;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn registration_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetWeight;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}