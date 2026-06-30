namespace GUI.Views
{
    partial class frmChangePassword
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
            label3 = new Label();
            btnSave = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnCancel = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cboDefaultTablespace = new ComboBox();
            numQuota = new NumericUpDown();
            cboTemporaryTablespace = new ComboBox();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuota).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(49, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 84);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 43);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 7;
            label1.Text = "CHANGE PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 126);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 175);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(295, 485);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(422, 172);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(225, 27);
            txtPassword.TabIndex = 14;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(422, 123);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(225, 27);
            txtUsername.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(475, 485);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 312);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 17;
            label4.Text = "DefaultTablespace";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(203, 363);
            label5.Name = "label5";
            label5.Size = new Size(153, 20);
            label5.TabIndex = 18;
            label5.Text = "TemporaryTablespace";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 412);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 19;
            label6.Text = "Quota";
            // 
            // cboDefaultTablespace
            // 
            cboDefaultTablespace.FormattingEnabled = true;
            cboDefaultTablespace.Location = new Point(422, 304);
            cboDefaultTablespace.Name = "cboDefaultTablespace";
            cboDefaultTablespace.Size = new Size(225, 28);
            cboDefaultTablespace.TabIndex = 20;
            // 
            // numQuota
            // 
            numQuota.Location = new Point(422, 405);
            numQuota.Name = "numQuota";
            numQuota.Size = new Size(225, 27);
            numQuota.TabIndex = 21;
            // 
            // cboTemporaryTablespace
            // 
            cboTemporaryTablespace.FormattingEnabled = true;
            cboTemporaryTablespace.Location = new Point(422, 355);
            cboTemporaryTablespace.Name = "cboTemporaryTablespace";
            cboTemporaryTablespace.Size = new Size(225, 28);
            cboTemporaryTablespace.TabIndex = 22;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(422, 217);
            txtFullname.Margin = new Padding(3, 4, 3, 4);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(225, 27);
            txtFullname.TabIndex = 23;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(422, 261);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 27);
            txtEmail.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(203, 224);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 25;
            label7.Text = "Fullname";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(203, 268);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 26;
            label8.Text = "Email";
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(txtFullname);
            Controls.Add(cboTemporaryTablespace);
            Controls.Add(numQuota);
            Controls.Add(cboDefaultTablespace);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmChangePassword";
            Text = "frmChangePassword";
            Load += frmChangePassword_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numQuota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSave;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnCancel;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cboDefaultTablespace;
        private NumericUpDown numQuota;
        private ComboBox cboTemporaryTablespace;
        private TextBox txtFullname;
        private TextBox txtEmail;
        private Label label7;
        private Label label8;
    }
}