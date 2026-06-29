namespace GUI.Views
{
    partial class frmGrant
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
            tabMain = new TabControl();
            tabSystemPriv = new TabPage();
            dgvSystemPrivileges = new DataGridView();
            btnRevokeSysPriv = new Button();
            btnGrantSysPriv = new Button();
            chkAdminOption = new CheckBox();
            cboPrivilege = new ComboBox();
            label2 = new Label();
            cboGrantee = new ComboBox();
            label1 = new Label();
            tabObjectPriv = new TabPage();
            dgvObjectPrivileges = new DataGridView();
            btnRevokeObjColumn = new Button();
            btnGrantObjColumn = new Button();
            btnRevokeObjTable = new Button();
            btnGrantObjTable = new Button();
            chkGrantOption = new CheckBox();
            cboColumn = new ComboBox();
            label6 = new Label();
            cboTable = new ComboBox();
            label5 = new Label();
            cboObjectPrivilege = new ComboBox();
            label4 = new Label();
            cboGranteeObj = new ComboBox();
            label3 = new Label();
            tabRoleGrant = new TabPage();
            dgvRoleGrants = new DataGridView();
            btnRevokeRole = new Button();
            btnGrantRole = new Button();
            chkRoleAdminOption = new CheckBox();
            cboRole = new ComboBox();
            label8 = new Label();
            cboGranteeRole = new ComboBox();
            label7 = new Label();
            tabMain.SuspendLayout();
            tabSystemPriv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSystemPrivileges).BeginInit();
            tabObjectPriv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvObjectPrivileges).BeginInit();
            tabRoleGrant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoleGrants).BeginInit();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabSystemPriv);
            tabMain.Controls.Add(tabObjectPriv);
            tabMain.Controls.Add(tabRoleGrant);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(801, 499);
            tabMain.TabIndex = 0;
            // 
            // tabSystemPriv
            // 
            tabSystemPriv.Controls.Add(dgvSystemPrivileges);
            tabSystemPriv.Controls.Add(btnRevokeSysPriv);
            tabSystemPriv.Controls.Add(btnGrantSysPriv);
            tabSystemPriv.Controls.Add(chkAdminOption);
            tabSystemPriv.Controls.Add(cboPrivilege);
            tabSystemPriv.Controls.Add(label2);
            tabSystemPriv.Controls.Add(cboGrantee);
            tabSystemPriv.Controls.Add(label1);
            tabSystemPriv.Location = new Point(4, 29);
            tabSystemPriv.Name = "tabSystemPriv";
            tabSystemPriv.Padding = new Padding(3);
            tabSystemPriv.Size = new Size(793, 466);
            tabSystemPriv.TabIndex = 0;
            tabSystemPriv.Text = "System Privilege";
            tabSystemPriv.UseVisualStyleBackColor = true;
            // 
            // dgvSystemPrivileges
            // 
            dgvSystemPrivileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSystemPrivileges.Location = new Point(67, 228);
            dgvSystemPrivileges.Name = "dgvSystemPrivileges";
            dgvSystemPrivileges.RowHeadersWidth = 51;
            dgvSystemPrivileges.Size = new Size(662, 188);
            dgvSystemPrivileges.TabIndex = 7;
            // 
            // btnRevokeSysPriv
            // 
            btnRevokeSysPriv.Location = new Point(304, 162);
            btnRevokeSysPriv.Name = "btnRevokeSysPriv";
            btnRevokeSysPriv.Size = new Size(94, 29);
            btnRevokeSysPriv.TabIndex = 6;
            btnRevokeSysPriv.Text = "Revoke";
            btnRevokeSysPriv.UseVisualStyleBackColor = true;
            btnRevokeSysPriv.Click += btnRevokeSysPriv_Click;
            // 
            // btnGrantSysPriv
            // 
            btnGrantSysPriv.Location = new Point(118, 162);
            btnGrantSysPriv.Name = "btnGrantSysPriv";
            btnGrantSysPriv.Size = new Size(94, 29);
            btnGrantSysPriv.TabIndex = 5;
            btnGrantSysPriv.Text = "Grant";
            btnGrantSysPriv.UseVisualStyleBackColor = true;
            btnGrantSysPriv.Click += btnGrantSysPriv_Click;
            // 
            // chkAdminOption
            // 
            chkAdminOption.AutoSize = true;
            chkAdminOption.Location = new Point(396, 106);
            chkAdminOption.Name = "chkAdminOption";
            chkAdminOption.Size = new Size(178, 24);
            chkAdminOption.TabIndex = 4;
            chkAdminOption.Text = "WITH ADMIN OPTION";
            chkAdminOption.UseVisualStyleBackColor = true;
            // 
            // cboPrivilege
            // 
            cboPrivilege.FormattingEnabled = true;
            cboPrivilege.Location = new Point(192, 102);
            cboPrivilege.Name = "cboPrivilege";
            cboPrivilege.Size = new Size(151, 28);
            cboPrivilege.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 102);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Privilege:";
            // 
            // cboGrantee
            // 
            cboGrantee.FormattingEnabled = true;
            cboGrantee.Location = new Point(194, 39);
            cboGrantee.Name = "cboGrantee";
            cboGrantee.Size = new Size(151, 28);
            cboGrantee.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 37);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Grantee (User/Role):";
            // 
            // tabObjectPriv
            // 
            tabObjectPriv.Controls.Add(dgvObjectPrivileges);
            tabObjectPriv.Controls.Add(btnRevokeObjColumn);
            tabObjectPriv.Controls.Add(btnGrantObjColumn);
            tabObjectPriv.Controls.Add(btnRevokeObjTable);
            tabObjectPriv.Controls.Add(btnGrantObjTable);
            tabObjectPriv.Controls.Add(chkGrantOption);
            tabObjectPriv.Controls.Add(cboColumn);
            tabObjectPriv.Controls.Add(label6);
            tabObjectPriv.Controls.Add(cboTable);
            tabObjectPriv.Controls.Add(label5);
            tabObjectPriv.Controls.Add(cboObjectPrivilege);
            tabObjectPriv.Controls.Add(label4);
            tabObjectPriv.Controls.Add(cboGranteeObj);
            tabObjectPriv.Controls.Add(label3);
            tabObjectPriv.Location = new Point(4, 29);
            tabObjectPriv.Name = "tabObjectPriv";
            tabObjectPriv.Padding = new Padding(3);
            tabObjectPriv.Size = new Size(793, 466);
            tabObjectPriv.TabIndex = 1;
            tabObjectPriv.Text = "Object Privilege";
            tabObjectPriv.UseVisualStyleBackColor = true;
            // 
            // dgvObjectPrivileges
            // 
            dgvObjectPrivileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvObjectPrivileges.Location = new Point(45, 243);
            dgvObjectPrivileges.Name = "dgvObjectPrivileges";
            dgvObjectPrivileges.RowHeadersWidth = 51;
            dgvObjectPrivileges.Size = new Size(692, 215);
            dgvObjectPrivileges.TabIndex = 13;
            // 
            // btnRevokeObjColumn
            // 
            btnRevokeObjColumn.Location = new Point(557, 179);
            btnRevokeObjColumn.Name = "btnRevokeObjColumn";
            btnRevokeObjColumn.Size = new Size(132, 40);
            btnRevokeObjColumn.TabIndex = 12;
            btnRevokeObjColumn.Text = "Revoke Column";
            btnRevokeObjColumn.UseVisualStyleBackColor = true;
            btnRevokeObjColumn.Click += btnRevokeObjColumn_Click;
            // 
            // btnGrantObjColumn
            // 
            btnGrantObjColumn.Location = new Point(400, 178);
            btnGrantObjColumn.Name = "btnGrantObjColumn";
            btnGrantObjColumn.Size = new Size(111, 41);
            btnGrantObjColumn.TabIndex = 11;
            btnGrantObjColumn.Text = "Grant Column";
            btnGrantObjColumn.UseVisualStyleBackColor = true;
            btnGrantObjColumn.Click += btnGrantObjColumn_Click;
            // 
            // btnRevokeObjTable
            // 
            btnRevokeObjTable.Location = new Point(239, 180);
            btnRevokeObjTable.Name = "btnRevokeObjTable";
            btnRevokeObjTable.Size = new Size(110, 39);
            btnRevokeObjTable.TabIndex = 10;
            btnRevokeObjTable.Text = "Revoke Table";
            btnRevokeObjTable.UseVisualStyleBackColor = true;
            btnRevokeObjTable.Click += btnRevokeObjTable_Click;
            // 
            // btnGrantObjTable
            // 
            btnGrantObjTable.Location = new Point(71, 175);
            btnGrantObjTable.Name = "btnGrantObjTable";
            btnGrantObjTable.Size = new Size(103, 44);
            btnGrantObjTable.TabIndex = 9;
            btnGrantObjTable.Text = "Grant Table";
            btnGrantObjTable.UseVisualStyleBackColor = true;
            btnGrantObjTable.Click += btnGrantObjTable_Click;
            // 
            // chkGrantOption
            // 
            chkGrantOption.AutoSize = true;
            chkGrantOption.Location = new Point(36, 128);
            chkGrantOption.Name = "chkGrantOption";
            chkGrantOption.Size = new Size(177, 24);
            chkGrantOption.TabIndex = 8;
            chkGrantOption.Text = "WITH GRANT OPTION";
            chkGrantOption.UseVisualStyleBackColor = true;
            // 
            // cboColumn
            // 
            cboColumn.FormattingEnabled = true;
            cboColumn.Location = new Point(458, 109);
            cboColumn.Name = "cboColumn";
            cboColumn.Size = new Size(151, 28);
            cboColumn.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(401, 86);
            label6.Name = "label6";
            label6.Size = new Size(288, 20);
            label6.TabIndex = 6;
            label6.Text = "Column (để trống nếu grant trên cả table):";
            // 
            // cboTable
            // 
            cboTable.FormattingEnabled = true;
            cboTable.Location = new Point(458, 26);
            cboTable.Name = "cboTable";
            cboTable.Size = new Size(151, 28);
            cboTable.TabIndex = 5;
            cboTable.SelectedIndexChanged += cboTable_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 29);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 4;
            label5.Text = "Table :";
            // 
            // cboObjectPrivilege
            // 
            cboObjectPrivilege.FormattingEnabled = true;
            cboObjectPrivilege.Location = new Point(193, 83);
            cboObjectPrivilege.Name = "cboObjectPrivilege";
            cboObjectPrivilege.Size = new Size(151, 28);
            cboObjectPrivilege.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 77);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 2;
            label4.Text = "Privilege:";
            // 
            // cboGranteeObj
            // 
            cboGranteeObj.FormattingEnabled = true;
            cboGranteeObj.Location = new Point(198, 26);
            cboGranteeObj.Name = "cboGranteeObj";
            cboGranteeObj.Size = new Size(151, 28);
            cboGranteeObj.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 27);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 0;
            label3.Text = "Grantee (User/Role):";
            // 
            // tabRoleGrant
            // 
            tabRoleGrant.Controls.Add(dgvRoleGrants);
            tabRoleGrant.Controls.Add(btnRevokeRole);
            tabRoleGrant.Controls.Add(btnGrantRole);
            tabRoleGrant.Controls.Add(chkRoleAdminOption);
            tabRoleGrant.Controls.Add(cboRole);
            tabRoleGrant.Controls.Add(label8);
            tabRoleGrant.Controls.Add(cboGranteeRole);
            tabRoleGrant.Controls.Add(label7);
            tabRoleGrant.Location = new Point(4, 29);
            tabRoleGrant.Name = "tabRoleGrant";
            tabRoleGrant.Padding = new Padding(3);
            tabRoleGrant.Size = new Size(793, 466);
            tabRoleGrant.TabIndex = 2;
            tabRoleGrant.Text = "Role Grant";
            tabRoleGrant.UseVisualStyleBackColor = true;
            // 
            // dgvRoleGrants
            // 
            dgvRoleGrants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoleGrants.Location = new Point(44, 207);
            dgvRoleGrants.Name = "dgvRoleGrants";
            dgvRoleGrants.RowHeadersWidth = 51;
            dgvRoleGrants.Size = new Size(683, 251);
            dgvRoleGrants.TabIndex = 7;
            // 
            // btnRevokeRole
            // 
            btnRevokeRole.Location = new Point(354, 142);
            btnRevokeRole.Name = "btnRevokeRole";
            btnRevokeRole.Size = new Size(94, 29);
            btnRevokeRole.TabIndex = 6;
            btnRevokeRole.Text = "Revoke";
            btnRevokeRole.UseVisualStyleBackColor = true;
            btnRevokeRole.Click += btnRevokeRole_Click;
            // 
            // btnGrantRole
            // 
            btnGrantRole.Location = new Point(93, 141);
            btnGrantRole.Name = "btnGrantRole";
            btnGrantRole.Size = new Size(94, 29);
            btnGrantRole.TabIndex = 5;
            btnGrantRole.Text = "Grant";
            btnGrantRole.UseVisualStyleBackColor = true;
            btnGrantRole.Click += btnGrantRole_Click;
            // 
            // chkRoleAdminOption
            // 
            chkRoleAdminOption.AutoSize = true;
            chkRoleAdminOption.Location = new Point(404, 96);
            chkRoleAdminOption.Name = "chkRoleAdminOption";
            chkRoleAdminOption.Size = new Size(178, 24);
            chkRoleAdminOption.TabIndex = 4;
            chkRoleAdminOption.Text = "WITH ADMIN OPTION";
            chkRoleAdminOption.UseVisualStyleBackColor = true;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(200, 86);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(151, 28);
            cboRole.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 88);
            label8.Name = "label8";
            label8.Size = new Size(42, 20);
            label8.TabIndex = 2;
            label8.Text = "Role:";
            // 
            // cboGranteeRole
            // 
            cboGranteeRole.FormattingEnabled = true;
            cboGranteeRole.Location = new Point(200, 30);
            cboGranteeRole.Name = "cboGranteeRole";
            cboGranteeRole.Size = new Size(151, 28);
            cboGranteeRole.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 30);
            label7.Name = "label7";
            label7.Size = new Size(143, 20);
            label7.TabIndex = 0;
            label7.Text = "Grantee (User/Role):";
            // 
            // frmGrant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 499);
            Controls.Add(tabMain);
            Name = "frmGrant";
            Text = "frmGrant";
            Load += frmGrant_Load;
            tabMain.ResumeLayout(false);
            tabSystemPriv.ResumeLayout(false);
            tabSystemPriv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSystemPrivileges).EndInit();
            tabObjectPriv.ResumeLayout(false);
            tabObjectPriv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvObjectPrivileges).EndInit();
            tabRoleGrant.ResumeLayout(false);
            tabRoleGrant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoleGrants).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabSystemPriv;
        private TabPage tabObjectPriv;
        private TabPage tabRoleGrant;
        private CheckBox chkAdminOption;
        private ComboBox cboPrivilege;
        private Label label2;
        private ComboBox cboGrantee;
        private Label label1;
        private DataGridView dgvSystemPrivileges;
        private Button btnRevokeSysPriv;
        private Button btnGrantSysPriv;
        private Label label4;
        private ComboBox cboGranteeObj;
        private Label label3;
        private Button btnRevokeObjTable;
        private Button btnGrantObjTable;
        private CheckBox chkGrantOption;
        private ComboBox cboColumn;
        private Label label6;
        private ComboBox cboTable;
        private Label label5;
        private ComboBox cboObjectPrivilege;
        private Button btnRevokeObjColumn;
        private Button btnGrantObjColumn;
        private DataGridView dgvObjectPrivileges;
        private Label label8;
        private ComboBox cboGranteeRole;
        private Label label7;
        private ComboBox cboRole;
        private Button btnRevokeRole;
        private Button btnGrantRole;
        private CheckBox chkRoleAdminOption;
        private DataGridView dgvRoleGrants;
    }
}