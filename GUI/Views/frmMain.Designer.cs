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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnUser = new Guna.UI2.WinForms.Guna2Button();
            btnRole = new Guna.UI2.WinForms.Guna2Button();
            btnProfile = new Guna.UI2.WinForms.Guna2Button();
            btnGrant = new Guna.UI2.WinForms.Guna2Button();
            btnDemo = new Guna.UI2.WinForms.Guna2Button();
            lblTempTs = new Label();
            lblDefaultTs = new Label();
            lblProfile = new Label();
            lblLockDate = new Label();
            lblStatus = new Label();
            lblJoinDate = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            lblWelcome = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvUserRoles = new DataGridView();
            tabPage2 = new TabPage();
            dgvUserSysPrivs = new DataGridView();
            tabPage3 = new TabPage();
            dgvUserObjPrivs = new DataGridView();
            tabPage4 = new TabPage();
            dgvUserQuotas = new DataGridView();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserSysPrivs).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserObjPrivs).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserQuotas).BeginInit();
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
            // lblTempTs
            // 
            lblTempTs.AutoSize = true;
            lblTempTs.Location = new Point(827, 162);
            lblTempTs.Name = "lblTempTs";
            lblTempTs.Size = new Size(76, 20);
            lblTempTs.TabIndex = 5;
            lblTempTs.Text = "lblTempTs";
            // 
            // lblDefaultTs
            // 
            lblDefaultTs.AutoSize = true;
            lblDefaultTs.Location = new Point(827, 118);
            lblDefaultTs.Name = "lblDefaultTs";
            lblDefaultTs.Size = new Size(88, 20);
            lblDefaultTs.TabIndex = 6;
            lblDefaultTs.Text = "lblDefaultTs";
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Location = new Point(590, 162);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(69, 20);
            lblProfile.TabIndex = 7;
            lblProfile.Text = "lblProfile";
            // 
            // lblLockDate
            // 
            lblLockDate.AutoSize = true;
            lblLockDate.Location = new Point(590, 118);
            lblLockDate.Name = "lblLockDate";
            lblLockDate.Size = new Size(88, 20);
            lblLockDate.TabIndex = 8;
            lblLockDate.Text = "lblLockDate";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(590, 79);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 20);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "lblStatus";
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Location = new Point(350, 162);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(84, 20);
            lblJoinDate.TabIndex = 10;
            lblJoinDate.Text = "lblJoinDate";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(350, 118);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 20);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "lblEmail";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(350, 79);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(92, 20);
            lblUsername.TabIndex = 12;
            lblUsername.Text = "lblUsername";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(350, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(88, 20);
            lblWelcome.TabIndex = 13;
            lblWelcome.Text = "lblWelcome";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(350, 204);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(628, 234);
            tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvUserRoles);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(620, 201);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Role";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvUserRoles
            // 
            dgvUserRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserRoles.Location = new Point(6, 7);
            dgvUserRoles.Name = "dgvUserRoles";
            dgvUserRoles.RowHeadersWidth = 51;
            dgvUserRoles.Size = new Size(608, 188);
            dgvUserRoles.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvUserSysPrivs);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(620, 201);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quyền hệ thống";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvUserSysPrivs
            // 
            dgvUserSysPrivs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserSysPrivs.Location = new Point(6, 7);
            dgvUserSysPrivs.Name = "dgvUserSysPrivs";
            dgvUserSysPrivs.RowHeadersWidth = 51;
            dgvUserSysPrivs.Size = new Size(608, 188);
            dgvUserSysPrivs.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvUserObjPrivs);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(620, 201);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Quyền đối tượng";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvUserObjPrivs
            // 
            dgvUserObjPrivs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserObjPrivs.Location = new Point(6, 7);
            dgvUserObjPrivs.Name = "dgvUserObjPrivs";
            dgvUserObjPrivs.RowHeadersWidth = 51;
            dgvUserObjPrivs.Size = new Size(608, 188);
            dgvUserObjPrivs.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvUserQuotas);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(620, 201);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Quota";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvUserQuotas
            // 
            dgvUserQuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserQuotas.Location = new Point(6, 6);
            dgvUserQuotas.Name = "dgvUserQuotas";
            dgvUserQuotas.RowHeadersWidth = 51;
            dgvUserQuotas.Size = new Size(608, 188);
            dgvUserQuotas.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.CustomizableEdges = customizableEdges11;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.Font = new Font("Segoe UI", 9F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(56, 514);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnLogout.Size = new Size(225, 56);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Đăng xuất";
            btnLogout.Click += btnLogout_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 596);
            Controls.Add(btnLogout);
            Controls.Add(tabControl1);
            Controls.Add(lblWelcome);
            Controls.Add(lblUsername);
            Controls.Add(lblEmail);
            Controls.Add(lblJoinDate);
            Controls.Add(lblStatus);
            Controls.Add(lblLockDate);
            Controls.Add(lblProfile);
            Controls.Add(lblDefaultTs);
            Controls.Add(lblTempTs);
            Controls.Add(btnDemo);
            Controls.Add(btnGrant);
            Controls.Add(btnProfile);
            Controls.Add(btnRole);
            Controls.Add(btnUser);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserRoles).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserSysPrivs).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserObjPrivs).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUserQuotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnRole;
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2Button btnGrant;
        private Guna.UI2.WinForms.Guna2Button btnDemo;
        private Label lblTempTs;
        private Label lblDefaultTs;
        private Label lblProfile;
        private Label lblLockDate;
        private Label lblStatus;
        private Label lblJoinDate;
        private Label lblEmail;
        private Label lblUsername;
        private Label lblWelcome;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvUserRoles;
        private DataGridView dgvUserSysPrivs;
        private TabPage tabPage3;
        private DataGridView dgvUserObjPrivs;
        private TabPage tabPage4;
        private DataGridView dgvUserQuotas;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}