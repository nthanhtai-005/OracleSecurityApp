namespace GUI.Views
{
    partial class frmProfileManagement
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
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnCreateProfile = new Button();
            dgvProfiles = new DataGridView();
            btnDeleteProfile = new Button();
            btnEditProfile = new Button();
            btnRefresh = new Button();
            txtSearchProfile = new TextBox();
            btnSearch = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfiles).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(97, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 97);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 43);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 7;
            label1.Text = "PROFILE MANAGEMENT";
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1091, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(246, 181);
            panel2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(239, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 125);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 10;
            label2.Text = "WELCOME!";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(51, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 107);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnCreateProfile
            // 
            btnCreateProfile.Location = new Point(71, 229);
            btnCreateProfile.Name = "btnCreateProfile";
            btnCreateProfile.Size = new Size(117, 48);
            btnCreateProfile.TabIndex = 12;
            btnCreateProfile.Text = "Create";
            btnCreateProfile.UseVisualStyleBackColor = true;
            btnCreateProfile.Click += btnCreateProfile_Click;
            // 
            // dgvProfiles
            // 
            dgvProfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfiles.Location = new Point(29, 311);
            dgvProfiles.Name = "dgvProfiles";
            dgvProfiles.RowHeadersWidth = 51;
            dgvProfiles.Size = new Size(1291, 184);
            dgvProfiles.TabIndex = 13;
            // 
            // btnDeleteProfile
            // 
            btnDeleteProfile.Location = new Point(387, 229);
            btnDeleteProfile.Name = "btnDeleteProfile";
            btnDeleteProfile.Size = new Size(117, 48);
            btnDeleteProfile.TabIndex = 15;
            btnDeleteProfile.Text = "Delete";
            btnDeleteProfile.UseVisualStyleBackColor = true;
            btnDeleteProfile.Click += btnDelete_Click;
            // 
            // btnEditProfile
            // 
            btnEditProfile.Location = new Point(232, 229);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(117, 48);
            btnEditProfile.TabIndex = 14;
            btnEditProfile.Text = "Edit";
            btnEditProfile.UseVisualStyleBackColor = true;
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1150, 240);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(117, 48);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearchProfile
            // 
            txtSearchProfile.Location = new Point(205, 161);
            txtSearchProfile.Margin = new Padding(3, 4, 3, 4);
            txtSearchProfile.Name = "txtSearchProfile";
            txtSearchProfile.Size = new Size(223, 27);
            txtSearchProfile.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(498, 161);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // frmProfileManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 629);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchProfile);
            Controls.Add(btnRefresh);
            Controls.Add(btnDeleteProfile);
            Controls.Add(btnEditProfile);
            Controls.Add(dgvProfiles);
            Controls.Add(btnCreateProfile);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmProfileManagement";
            Text = "CreateUser";
            Load += frmProfileManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnCreateProfile;
        private DataGridView dgvProfiles;
        private Button btnDeleteProfile;
        private Button btnEditProfile;
        private Button btnRefresh;
        private TextBox txtSearchProfile;
        private Button btnSearch;
    }
}