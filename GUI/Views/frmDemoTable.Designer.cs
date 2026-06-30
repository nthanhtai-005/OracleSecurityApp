namespace GUI.Views
{
    partial class frmDemoTable
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
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtFullname = new TextBox();
            btnInsert = new Button();
            dgvData = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.ForeColor = Color.YellowGreen;
            txtUsername.Location = new Point(113, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(281, 31);
            txtUsername.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(546, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(113, 110);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(281, 31);
            txtFullname.TabIndex = 2;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.Highlight;
            btnInsert.ForeColor = SystemColors.ActiveCaptionText;
            btnInsert.Location = new Point(42, 173);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(281, 70);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Thêm";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(42, 304);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(962, 484);
            dgvData.TabIndex = 4;
            dgvData.CellClick += dgvData_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 6;
            label2.Text = "Fullname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 36);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.Highlight;
            btnUpdate.ForeColor = SystemColors.ActiveCaptionText;
            btnUpdate.Location = new Point(397, 173);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(281, 70);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Sửa";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.Highlight;
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(753, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(281, 70);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmDemoTable
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 827);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Controls.Add(btnInsert);
            Controls.Add(txtFullname);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Name = "frmDemoTable";
            Text = "frmDemoTable";
            Load += frmDemoTable_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtFullname;
        private Button btnInsert;
        private DataGridView dgvData;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnUpdate;
        private Button btnDelete;
    }
}