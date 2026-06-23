namespace GUI.Views
{
    partial class frmUserManagement
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
            btnCreate = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnLock = new Button();
            btnUnLock = new Button();
            btnRefresh = new Button();
            dgvUsers = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            btnAssignProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(33, 171);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(102, 36);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(160, 171);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 36);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(296, 171);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLock
            // 
            btnLock.Location = new Point(612, 171);
            btnLock.Margin = new Padding(3, 2, 3, 2);
            btnLock.Name = "btnLock";
            btnLock.Size = new Size(102, 36);
            btnLock.TabIndex = 3;
            btnLock.Text = "Lock";
            btnLock.UseVisualStyleBackColor = true;
            btnLock.Click += btnLock_Click;
            // 
            // btnUnLock
            // 
            btnUnLock.Location = new Point(719, 171);
            btnUnLock.Margin = new Padding(3, 2, 3, 2);
            btnUnLock.Name = "btnUnLock";
            btnUnLock.Size = new Size(102, 36);
            btnUnLock.TabIndex = 4;
            btnUnLock.Text = "Unlock";
            btnUnLock.UseVisualStyleBackColor = true;
            btnUnLock.Click += btnUnLock_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(999, 171);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(102, 36);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(21, 220);
            dgvUsers.Margin = new Padding(3, 2, 3, 2);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(1130, 222);
            dgvUsers.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 32);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 7;
            label1.Text = "USER MANAGEMENT";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(95, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 94);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(45, 13);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 80);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(955, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 136);
            panel2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 112);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 94);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 10;
            label2.Text = "WELCOME!";
            // 
            // btnAssignProfile
            // 
            btnAssignProfile.Location = new Point(504, 171);
            btnAssignProfile.Margin = new Padding(3, 2, 3, 2);
            btnAssignProfile.Name = "btnAssignProfile";
            btnAssignProfile.Size = new Size(102, 36);
            btnAssignProfile.TabIndex = 11;
            btnAssignProfile.Text = "Assign Profile";
            btnAssignProfile.UseVisualStyleBackColor = true;
            btnAssignProfile.Click += btnAssignProfile_Click;
            // 
            // frmUserManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 472);
            Controls.Add(btnAssignProfile);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnUnLock);
            Controls.Add(btnLock);
            Controls.Add(dgvUsers);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnCreate);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmUserManagement";
            Text = "frmUser";
            Load += frmUserManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreate;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnLock;
        private Button btnUnLock;
        private Button btnRefresh;
        private DataGridView dgvUsers;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Button btnAssignProfile;
    }
}