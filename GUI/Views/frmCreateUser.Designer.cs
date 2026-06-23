namespace GUI.Views
{
    partial class frmCreateUser
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            cboTablespace = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            btnCreate = new Button();
            btnCannel = new Button();
            label5 = new Label();
            label6 = new Label();
            cboProfile = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(236, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 94);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 32);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 7;
            label1.Text = "CREATE USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 146);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 10;
            label2.Text = "USERNAME:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(593, 146);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(252, 23);
            txtUsername.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(372, 258);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 12;
            label3.Text = "DEFAULT TABLESPACE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 205);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 13;
            label4.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(593, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(252, 23);
            txtPassword.TabIndex = 14;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // cboTablespace
            // 
            cboTablespace.FormattingEnabled = true;
            cboTablespace.Location = new Point(593, 250);
            cboTablespace.Name = "cboTablespace";
            cboTablespace.Size = new Size(252, 23);
            cboTablespace.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(596, 352);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(249, 23);
            numericUpDown1.TabIndex = 16;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(444, 407);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(102, 36);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Save";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCannel
            // 
            btnCannel.Location = new Point(650, 407);
            btnCannel.Margin = new Padding(3, 2, 3, 2);
            btnCannel.Name = "btnCannel";
            btnCannel.Size = new Size(102, 36);
            btnCannel.TabIndex = 18;
            btnCannel.Text = "Cannel";
            btnCannel.UseVisualStyleBackColor = true;
            btnCannel.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(372, 360);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 19;
            label5.Text = "QUOTA(MB):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(372, 311);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 20;
            label6.Text = "PROFILE:";
            // 
            // cboProfile
            // 
            cboProfile.FormattingEnabled = true;
            cboProfile.Location = new Point(593, 303);
            cboProfile.Name = "cboProfile";
            cboProfile.Size = new Size(252, 23);
            cboProfile.TabIndex = 21;
            // 
            // frmCreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 472);
            Controls.Add(cboProfile);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCannel);
            Controls.Add(btnCreate);
            Controls.Add(numericUpDown1);
            Controls.Add(cboTablespace);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "frmCreateUser";
            Text = "frmCreateUser";
            Load += frmCreateUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private ComboBox cboTablespace;
        private NumericUpDown numericUpDown1;
        private Button btnCreate;
        private Button btnCannel;
        private Label label5;
        private Label label6;
        private ComboBox cboProfile;
    }
}