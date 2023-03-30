namespace BestFitnessSystem.Views {
    partial class Dashboard {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plan_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cWeight = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.client_name = new System.Windows.Forms.Label();
            this.current_weight = new System.Windows.Forms.Label();
            this.target_weight = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(478, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Logout";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(377, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fitness Management";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(377, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Himalayan Digital Solution ©";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(29, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(33, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 348);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(285, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Cost:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plan_name,
            this.cost});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(465, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // plan_name
            // 
            this.plan_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plan_name.DataPropertyName = "plan_name";
            this.plan_name.HeaderText = "Plan Name";
            this.plan_name.Name = "plan_name";
            this.plan_name.ReadOnly = true;
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cost.DataPropertyName = "cost";
            this.cost.HeaderText = "Cost";
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.totalCost);
            this.panel3.Controls.Add(this.target_weight);
            this.panel3.Controls.Add(this.current_weight);
            this.panel3.Controls.Add(this.client_name);
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.cWeight);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 266);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 82);
            this.panel3.TabIndex = 2;
            // 
            // cWeight
            // 
            this.cWeight.AutoSize = true;
            this.cWeight.Location = new System.Drawing.Point(15, 35);
            this.cWeight.Name = "cWeight";
            this.cWeight.Size = new System.Drawing.Size(99, 13);
            this.cWeight.TabIndex = 2;
            this.cWeight.Text = "Current Weight(kg):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Traget Weight(kg):";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(73, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 13);
            this.name.TabIndex = 2;
            this.name.Text = "Name: ";
            // 
            // client_name
            // 
            this.client_name.AutoSize = true;
            this.client_name.Location = new System.Drawing.Point(120, 12);
            this.client_name.Name = "client_name";
            this.client_name.Size = new System.Drawing.Size(0, 13);
            this.client_name.TabIndex = 4;
            // 
            // current_weight
            // 
            this.current_weight.AutoSize = true;
            this.current_weight.Location = new System.Drawing.Point(120, 36);
            this.current_weight.Name = "current_weight";
            this.current_weight.Size = new System.Drawing.Size(0, 13);
            this.current_weight.TabIndex = 4;
            // 
            // target_weight
            // 
            this.target_weight.AutoSize = true;
            this.target_weight.Location = new System.Drawing.Point(120, 61);
            this.target_weight.Name = "target_weight";
            this.target_weight.Size = new System.Drawing.Size(0, 13);
            this.target_weight.TabIndex = 4;
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Location = new System.Drawing.Point(358, 56);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(0, 13);
            this.totalCost.TabIndex = 4;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label target_weight;
        private System.Windows.Forms.Label current_weight;
        private System.Windows.Forms.Label client_name;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cWeight;
    }
}