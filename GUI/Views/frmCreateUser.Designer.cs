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
            label7 = new Label();
            cboTemporaryTablespace = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(270, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 86);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 34);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 7;
            label1.Text = "CREATE USER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(424, 130);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 10;
            label2.Text = "USERNAME:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(677, 130);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(287, 27);
            txtUsername.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 309);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 12;
            label3.Text = "DEFAULT TABLESPACE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 188);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 13;
            label4.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(677, 181);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(287, 27);
            txtPassword.TabIndex = 14;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // cboTablespace
            // 
            cboTablespace.FormattingEnabled = true;
            cboTablespace.Location = new Point(678, 306);
            cboTablespace.Margin = new Padding(3, 4, 3, 4);
            cboTablespace.Name = "cboTablespace";
            cboTablespace.Size = new Size(287, 28);
            cboTablespace.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(681, 469);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(285, 27);
            numericUpDown1.TabIndex = 16;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(507, 543);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(117, 48);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "Save";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCannel
            // 
            btnCannel.Location = new Point(743, 543);
            btnCannel.Name = "btnCannel";
            btnCannel.Size = new Size(117, 48);
            btnCannel.TabIndex = 18;
            btnCannel.Text = "Cannel";
            btnCannel.UseVisualStyleBackColor = true;
            btnCannel.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(425, 480);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 19;
            label5.Text = "QUOTA(MB):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 427);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 20;
            label6.Text = "PROFILE:";
            // 
            // cboProfile
            // 
            cboProfile.FormattingEnabled = true;
            cboProfile.Location = new Point(678, 419);
            cboProfile.Margin = new Padding(3, 4, 3, 4);
            cboProfile.Name = "cboProfile";
            cboProfile.Size = new Size(287, 28);
            cboProfile.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(425, 374);
            label7.Name = "label7";
            label7.Size = new Size(180, 20);
            label7.TabIndex = 22;
            label7.Text = "TEMPORARY TABLESPACE";
            // 
            // cboTemporaryTablespace
            // 
            cboTemporaryTablespace.FormattingEnabled = true;
            cboTemporaryTablespace.Location = new Point(678, 366);
            cboTemporaryTablespace.Margin = new Padding(3, 4, 3, 4);
            cboTemporaryTablespace.Name = "cboTemporaryTablespace";
            cboTemporaryTablespace.Size = new Size(287, 28);
            cboTemporaryTablespace.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(425, 229);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 24;
            label8.Text = "FULLNAME:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(425, 270);
            label9.Name = "label9";
            label9.Size = new Size(54, 20);
            label9.TabIndex = 25;
            label9.Text = "EMAIL:";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(677, 222);
            txtFullname.Margin = new Padding(3, 4, 3, 4);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(287, 27);
            txtFullname.TabIndex = 26;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(677, 263);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 27);
            txtEmail.TabIndex = 27;
            // 
            // frmCreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 629);
            Controls.Add(txtEmail);
            Controls.Add(txtFullname);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(cboTemporaryTablespace);
            Controls.Add(label7);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label7;
        private ComboBox cboTemporaryTablespace;
        private Label label8;
        private Label label9;
        private TextBox txtFullname;
        private TextBox txtEmail;
    }
}