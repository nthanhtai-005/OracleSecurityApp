namespace GUI.Views
{
    partial class frmRole
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
            label1 = new Label();
            txtRoleName = new TextBox();
            chkHasPassword = new CheckBox();
            txtPassword = new TextBox();
            btnCreate = new Button();
            btnDrop = new Button();
            dgvRoles = new DataGridView();
            btnUpdatePassword = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên Role";
            label1.Click += label1_Click;
            // 
            // txtRoleName
            // 
            txtRoleName.Location = new Point(140, 23);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(150, 31);
            txtRoleName.TabIndex = 1;
            // 
            // chkHasPassword
            // 
            chkHasPassword.AutoSize = true;
            chkHasPassword.Location = new Point(140, 144);
            chkHasPassword.Name = "chkHasPassword";
            chkHasPassword.Size = new Size(121, 29);
            chkHasPassword.TabIndex = 2;
            chkHasPassword.Text = "checkBox1";
            chkHasPassword.UseVisualStyleBackColor = true;
            chkHasPassword.CheckedChanged += chkHasPassword_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(140, 88);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DodgerBlue;
            btnCreate.Location = new Point(388, 23);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(281, 70);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Tạo role";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDrop
            // 
            btnDrop.BackColor = Color.Red;
            btnDrop.Location = new Point(728, 26);
            btnDrop.Name = "btnDrop";
            btnDrop.Size = new Size(281, 70);
            btnDrop.TabIndex = 5;
            btnDrop.Text = "Xóa Role";
            btnDrop.UseVisualStyleBackColor = false;
            btnDrop.Click += btnDrop_Click;
            // 
            // dgvRoles
            // 
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(12, 231);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersWidth = 62;
            dgvRoles.Size = new Size(1037, 516);
            dgvRoles.TabIndex = 6;
            dgvRoles.CellClick += dgvRoles_CellContentClick;
            dgvRoles.CellContentClick += dgvRoles_CellContentClick;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.BackColor = SystemColors.Highlight;
            btnUpdatePassword.Location = new Point(388, 122);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(281, 70);
            btnUpdatePassword.TabIndex = 7;
            btnUpdatePassword.Text = "Thay đổi pass";
            btnUpdatePassword.UseVisualStyleBackColor = false;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 101);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // frmRole
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 759);
            Controls.Add(label2);
            Controls.Add(btnUpdatePassword);
            Controls.Add(dgvRoles);
            Controls.Add(btnDrop);
            Controls.Add(btnCreate);
            Controls.Add(txtPassword);
            Controls.Add(chkHasPassword);
            Controls.Add(txtRoleName);
            Controls.Add(label1);
            Name = "frmRole";
            Text = "frmRole";
            Load += frmRole_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRoleName;
        private CheckBox chkHasPassword;
        private TextBox txtPassword;
        private Button btnCreate;
        private Button btnDrop;
        private DataGridView dgvRoles;
        private Button btnUpdatePassword;
        private Label label2;
    }
}