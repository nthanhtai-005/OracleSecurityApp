namespace GUI.Views
{
    partial class frmMain
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnUser = new Guna.UI2.WinForms.Guna2Button();
            btnRole = new Guna.UI2.WinForms.Guna2Button();
            btnProfile = new Guna.UI2.WinForms.Guna2Button();
            btnGrant = new Guna.UI2.WinForms.Guna2Button();
            btnDemo = new Guna.UI2.WinForms.Guna2Button();
            lblTempTS = new Label();
            lblDefaultTS = new Label();
            lblProfile = new Label();
            lblLockDate = new Label();
            lblAccountStatus = new Label();
            lblCreatedDate = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            lblWelcome = new Label();
            tabControlPrivs = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            dgvRoles = new DataGridView();
            dgvSysPrivs = new DataGridView();
            dgvObjPrivs = new DataGridView();
            dgvQuotas = new DataGridView();
            tabControlPrivs.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSysPrivs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvObjPrivs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuotas).BeginInit();
            SuspendLayout();
            // 
            // btnUser
            // 
            btnUser.CustomizableEdges = customizableEdges1;
            btnUser.DisabledState.BorderColor = Color.DarkGray;
            btnUser.DisabledState.CustomBorderColor = Color.DarkGray;
            btnUser.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnUser.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnUser.Font = new Font("Segoe UI", 9F);
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(56, 12);
            btnUser.Name = "btnUser";
            btnUser.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnUser.Size = new Size(225, 56);
            btnUser.TabIndex = 0;
            btnUser.Text = "btnUser";
            btnUser.Click += btnUser_Click;
            // 
            // btnRole
            // 
            btnRole.CustomizableEdges = customizableEdges3;
            btnRole.DisabledState.BorderColor = Color.DarkGray;
            btnRole.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRole.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRole.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRole.Font = new Font("Segoe UI", 9F);
            btnRole.ForeColor = Color.White;
            btnRole.Location = new Point(56, 92);
            btnRole.Name = "btnRole";
            btnRole.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnRole.Size = new Size(225, 56);
            btnRole.TabIndex = 1;
            btnRole.Text = "btnRole";
            btnRole.Click += btnRole_Click;
            // 
            // btnProfile
            // 
            btnProfile.CustomizableEdges = customizableEdges5;
            btnProfile.DisabledState.BorderColor = Color.DarkGray;
            btnProfile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProfile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProfile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProfile.Font = new Font("Segoe UI", 9F);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(56, 181);
            btnProfile.Name = "btnProfile";
            btnProfile.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnProfile.Size = new Size(225, 56);
            btnProfile.TabIndex = 2;
            btnProfile.Text = "btnProfile";
            btnProfile.Click += btnProfile_Click;
            // 
            // btnGrant
            // 
            btnGrant.CustomizableEdges = customizableEdges7;
            btnGrant.DisabledState.BorderColor = Color.DarkGray;
            btnGrant.DisabledState.CustomBorderColor = Color.DarkGray;
            btnGrant.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnGrant.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnGrant.Font = new Font("Segoe UI", 9F);
            btnGrant.ForeColor = Color.White;
            btnGrant.Location = new Point(56, 273);
            btnGrant.Name = "btnGrant";
            btnGrant.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnGrant.Size = new Size(225, 56);
            btnGrant.TabIndex = 3;
            btnGrant.Text = "btnGrant";
            btnGrant.Click += btnGrant_Click;
            // 
            // btnDemo
            // 
            btnDemo.CustomizableEdges = customizableEdges9;
            btnDemo.DisabledState.BorderColor = Color.DarkGray;
            btnDemo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDemo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDemo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDemo.Font = new Font("Segoe UI", 9F);
            btnDemo.ForeColor = Color.White;
            btnDemo.Location = new Point(56, 362);
            btnDemo.Name = "btnDemo";
            btnDemo.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnDemo.Size = new Size(225, 56);
            btnDemo.TabIndex = 4;
            btnDemo.Text = "btnDemo";
            btnDemo.Click += btnDemo_Click;
            // 
            // lblTempTS
            // 
            lblTempTS.AutoSize = true;
            lblTempTS.Location = new Point(785, 172);
            lblTempTS.Name = "lblTempTS";
            lblTempTS.Size = new Size(79, 20);
            lblTempTS.TabIndex = 5;
            lblTempTS.Text = "lblTempTS";
            // 
            // lblDefaultTS
            // 
            lblDefaultTS.AutoSize = true;
            lblDefaultTS.Location = new Point(785, 128);
            lblDefaultTS.Name = "lblDefaultTS";
            lblDefaultTS.Size = new Size(91, 20);
            lblDefaultTS.TabIndex = 6;
            lblDefaultTS.Text = "lblDefaultTS";
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Location = new Point(572, 172);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(69, 20);
            lblProfile.TabIndex = 7;
            lblProfile.Text = "lblProfile";
            // 
            // lblLockDate
            // 
            lblLockDate.AutoSize = true;
            lblLockDate.Location = new Point(572, 128);
            lblLockDate.Name = "lblLockDate";
            lblLockDate.Size = new Size(88, 20);
            lblLockDate.TabIndex = 8;
            lblLockDate.Text = "lblLockDate";
            // 
            // lblAccountStatus
            // 
            lblAccountStatus.AutoSize = true;
            lblAccountStatus.Location = new Point(572, 81);
            lblAccountStatus.Name = "lblAccountStatus";
            lblAccountStatus.Size = new Size(120, 20);
            lblAccountStatus.TabIndex = 9;
            lblAccountStatus.Text = "lblAccountStatus";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Location = new Point(351, 172);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(110, 20);
            lblCreatedDate.TabIndex = 10;
            lblCreatedDate.Text = "lblCreatedDate";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(351, 128);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 20);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "lblEmail";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(351, 81);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 20);
            lblUsername.TabIndex = 12;
            lblUsername.Text = "lblUsername";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(351, 32);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(88, 20);
            lblWelcome.TabIndex = 13;
            lblWelcome.Text = "lblWelcome";
            // 
            // tabControlPrivs
            // 
            tabControlPrivs.Controls.Add(tabPage1);
            tabControlPrivs.Controls.Add(tabPage2);
            tabControlPrivs.Controls.Add(tabPage3);
            tabControlPrivs.Controls.Add(tabPage4);
            tabControlPrivs.Location = new Point(312, 216);
            tabControlPrivs.Name = "tabControlPrivs";
            tabControlPrivs.SelectedIndex = 0;
            tabControlPrivs.Size = new Size(669, 237);
            tabControlPrivs.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvRoles);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(661, 204);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Vai trò(Role)";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvSysPrivs);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(661, 204);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quyền hệ thống";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvObjPrivs);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(661, 204);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Quyền đối tượng";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvQuotas);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(661, 204);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Quota";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvRoles
            // 
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(6, 6);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.Size = new Size(652, 188);
            dgvRoles.TabIndex = 0;
            // 
            // dgvSysPrivs
            // 
            dgvSysPrivs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSysPrivs.Location = new Point(6, 6);
            dgvSysPrivs.Name = "dgvSysPrivs";
            dgvSysPrivs.RowHeadersWidth = 51;
            dgvSysPrivs.Size = new Size(649, 188);
            dgvSysPrivs.TabIndex = 0;
            // 
            // dgvObjPrivs
            // 
            dgvObjPrivs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObjPrivs.Location = new Point(6, 6);
            dgvObjPrivs.Name = "dgvObjPrivs";
            dgvObjPrivs.RowHeadersWidth = 51;
            dgvObjPrivs.Size = new Size(649, 188);
            dgvObjPrivs.TabIndex = 0;
            // 
            // dgvQuotas
            // 
            dgvQuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuotas.Location = new Point(6, 6);
            dgvQuotas.Name = "dgvQuotas";
            dgvQuotas.RowHeadersWidth = 51;
            dgvQuotas.Size = new Size(649, 188);
            dgvQuotas.TabIndex = 0;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 465);
            Controls.Add(tabControlPrivs);
            Controls.Add(lblWelcome);
            Controls.Add(lblUsername);
            Controls.Add(lblEmail);
            Controls.Add(lblCreatedDate);
            Controls.Add(lblAccountStatus);
            Controls.Add(lblLockDate);
            Controls.Add(lblProfile);
            Controls.Add(lblDefaultTS);
            Controls.Add(lblTempTS);
            Controls.Add(btnDemo);
            Controls.Add(btnGrant);
            Controls.Add(btnProfile);
            Controls.Add(btnRole);
            Controls.Add(btnUser);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            tabControlPrivs.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSysPrivs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvObjPrivs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvQuotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnRole;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnGrant;
        private Guna.UI2.WinForms.Guna2Button btnDemo;
        private Label lblTempTS;
        private Label lblDefaultTS;
        private Label lblProfile;
        private Label lblLockDate;
        private Label lblAccountStatus;
        private Label lblCreatedDate;
        private Label lblEmail;
        private Label lblUsername;
        private Label lblWelcome;
        private TabControl tabControlPrivs;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dgvRoles;
        private DataGridView dgvSysPrivs;
        private DataGridView dgvObjPrivs;
        private DataGridView dgvQuotas;
    }
}