namespace GUI.Views
{
    partial class frmAssignProfile
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
            btnCancel = new Button();
            txtUsername = new TextBox();
            btnSave = new Button();
            label3 = new Label();
            label2 = new Label();
            cboProfile = new ComboBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(433, 286);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(398, 147);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(197, 23);
            txtUsername.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(291, 286);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 19;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 213);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 18;
            label3.Text = "Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 150);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 17;
            label2.Text = "Username";
            // 
            // cboProfile
            // 
            cboProfile.FormattingEnabled = true;
            cboProfile.Location = new Point(398, 210);
            cboProfile.Name = "cboProfile";
            cboProfile.Size = new Size(197, 23);
            cboProfile.TabIndex = 23;
            // 
            // frmAssignProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboProfile);
            Controls.Add(btnCancel);
            Controls.Add(txtUsername);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "frmAssignProfile";
            Text = "frmAssignProfile";
            Load += frmAssignProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private TextBox txtUsername;
        private Button btnSave;
        private Label label3;
        private Label label2;
        private ComboBox cboProfile;
    }
}