namespace GUI.Views
{
    partial class frmDataDictionary
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvPrivileges = new DataGridView();
            tabPage2 = new TabPage();
            dgvRoles = new DataGridView();
            tabPage3 = new TabPage();
            dgvProfiles = new DataGridView();
            tabPage4 = new TabPage();
            dgvUsers = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrivileges).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfiles).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(786, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvPrivileges);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(778, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Quản lý quyền";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPrivileges
            // 
            dgvPrivileges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrivileges.Location = new Point(6, 17);
            dgvPrivileges.Name = "dgvPrivileges";
            dgvPrivileges.RowHeadersWidth = 51;
            dgvPrivileges.Size = new Size(766, 370);
            dgvPrivileges.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvRoles);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(778, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Quản lý Role";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRoles
            // 
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(6, 6);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersWidth = 51;
            dgvRoles.Size = new Size(766, 381);
            dgvRoles.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvProfiles);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(778, 393);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Quản lý Profile";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvProfiles
            // 
            dgvProfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfiles.Location = new Point(6, 6);
            dgvProfiles.Name = "dgvProfiles";
            dgvProfiles.RowHeadersWidth = 51;
            dgvProfiles.Size = new Size(766, 381);
            dgvProfiles.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(dgvUsers);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(778, 393);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Thông tin User";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(6, 6);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(766, 381);
            dgvUsers.TabIndex = 0;
            // 
            // frmDataDictionary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "frmDataDictionary";
            Text = "frmDataDictionary";
            Load += frmDataDictionary_Load_1;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrivileges).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProfiles).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvPrivileges;
        private TabPage tabPage2;
        private DataGridView dgvRoles;
        private TabPage tabPage3;
        private DataGridView dgvProfiles;
        private TabPage tabPage4;
        private DataGridView dgvUsers;
    }
}