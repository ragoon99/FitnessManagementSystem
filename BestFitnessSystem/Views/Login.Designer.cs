namespace BestFitnessSystem {
    partial class Login {
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.error_Label = new System.Windows.Forms.Label();
            this.adminMode = new System.Windows.Forms.Label();
            this.email_TBox = new System.Windows.Forms.TextBox();
            this.showPass_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_TBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 66);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(433, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fitness Management";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(433, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Himalayan Digital Solution ©";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(46, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login";
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomPanel.Controls.Add(this.button1);
            this.bottomPanel.Controls.Add(this.loginButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 352);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(586, 58);
            this.bottomPanel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(314, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Location = new System.Drawing.Point(194, 5);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 24);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.panel4);
            this.centerPanel.Controls.Add(this.bottomPanel);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(0, 66);
            this.centerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(586, 410);
            this.centerPanel.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.rightPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 352);
            this.panel4.TabIndex = 2;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.error_Label);
            this.rightPanel.Controls.Add(this.adminMode);
            this.rightPanel.Controls.Add(this.email_TBox);
            this.rightPanel.Controls.Add(this.showPass_label);
            this.rightPanel.Controls.Add(this.label1);
            this.rightPanel.Controls.Add(this.label2);
            this.rightPanel.Controls.Add(this.password_TBox);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(367, 0);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(219, 352);
            this.rightPanel.TabIndex = 0;
            // 
            // error_Label
            // 
            this.error_Label.ForeColor = System.Drawing.Color.Red;
            this.error_Label.Location = new System.Drawing.Point(2, 140);
            this.error_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.error_Label.Name = "error_Label";
            this.error_Label.Size = new System.Drawing.Size(200, 13);
            this.error_Label.TabIndex = 20;
            this.error_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminMode
            // 
            this.adminMode.AutoSize = true;
            this.adminMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminMode.ForeColor = System.Drawing.Color.Gray;
            this.adminMode.Location = new System.Drawing.Point(165, 328);
            this.adminMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.adminMode.Name = "adminMode";
            this.adminMode.Size = new System.Drawing.Size(48, 13);
            this.adminMode.TabIndex = 19;
            this.adminMode.Text = "Admin ->";
            this.adminMode.Click += new System.EventHandler(this.adminMode_Click);
            // 
            // email_TBox
            // 
            this.email_TBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email_TBox.Location = new System.Drawing.Point(95, 46);
            this.email_TBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.email_TBox.Name = "email_TBox";
            this.email_TBox.Size = new System.Drawing.Size(103, 20);
            this.email_TBox.TabIndex = 16;
            // 
            // showPass_label
            // 
            this.showPass_label.AutoSize = true;
            this.showPass_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPass_label.Location = new System.Drawing.Point(121, 108);
            this.showPass_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showPass_label.Name = "showPass_label";
            this.showPass_label.Size = new System.Drawing.Size(83, 13);
            this.showPass_label.TabIndex = 18;
            this.showPass_label.Text = "Show Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password:";
            // 
            // password_TBox
            // 
            this.password_TBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_TBox.Location = new System.Drawing.Point(95, 78);
            this.password_TBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.password_TBox.Name = "password_TBox";
            this.password_TBox.Size = new System.Drawing.Size(104, 20);
            this.password_TBox.TabIndex = 17;
            this.password_TBox.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 476);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label error_Label;
        private System.Windows.Forms.Label adminMode;
        private System.Windows.Forms.TextBox email_TBox;
        private System.Windows.Forms.Label showPass_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_TBox;
    }
}