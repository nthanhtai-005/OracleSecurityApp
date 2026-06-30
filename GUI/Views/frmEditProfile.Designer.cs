namespace GUI.Views
{
    partial class frmEditProfile
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
            numFailedLogin = new NumericUpDown();
            txtProfileName = new TextBox();
            btnSave = new Button();
            numPasswordLife = new NumericUpDown();
            numSessions = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnBack = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            numIdleTime = new NumericUpDown();
            numConnectTime = new NumericUpDown();
            numPasswordGrace = new NumericUpDown();
            numPasswordLock = new NumericUpDown();
            cboFailedLoginType = new ComboBox();
            cboPasswordLifeType = new ComboBox();
            cboSessionsType = new ComboBox();
            cboPasswordLockType = new ComboBox();
            cboPasswordGraceType = new ComboBox();
            cboConnectTimeType = new ComboBox();
            cboIdleTimeType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numFailedLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordLife).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSessions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdleTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numConnectTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordGrace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordLock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 51);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Profile Name:\n";
            // 
            // numFailedLogin
            // 
            numFailedLogin.Location = new Point(527, 117);
            numFailedLogin.Margin = new Padding(3, 4, 3, 4);
            numFailedLogin.Name = "numFailedLogin";
            numFailedLogin.Size = new Size(137, 27);
            numFailedLogin.TabIndex = 1;
            numFailedLogin.ValueChanged += numFailedLogin_ValueChanged;
            // 
            // txtProfileName
            // 
            txtProfileName.Location = new Point(527, 40);
            txtProfileName.Margin = new Padding(3, 4, 3, 4);
            txtProfileName.Name = "txtProfileName";
            txtProfileName.ReadOnly = true;
            txtProfileName.Size = new Size(137, 27);
            txtProfileName.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(305, 509);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 49);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numPasswordLife
            // 
            numPasswordLife.Location = new Point(527, 176);
            numPasswordLife.Margin = new Padding(3, 4, 3, 4);
            numPasswordLife.Name = "numPasswordLife";
            numPasswordLife.Size = new Size(137, 27);
            numPasswordLife.TabIndex = 4;
            // 
            // numSessions
            // 
            numSessions.Location = new Point(527, 233);
            numSessions.Margin = new Padding(3, 4, 3, 4);
            numSessions.Name = "numSessions";
            numSessions.Size = new Size(137, 27);
            numSessions.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 128);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 6;
            label2.Text = "Failed Login Attempts:\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 187);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 7;
            label3.Text = "Password Life Time:\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(305, 244);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 8;
            label4.Text = "Sessions Per User:\n";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(498, 509);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(134, 49);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(305, 388);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 25;
            label8.Text = "Connect Time:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(305, 448);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 24;
            label7.Text = "Idle Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 349);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 23;
            label6.Text = "Password Grace Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 300);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 22;
            label5.Text = "Password Lock Time:";
            // 
            // numIdleTime
            // 
            numIdleTime.Location = new Point(527, 437);
            numIdleTime.Margin = new Padding(3, 4, 3, 4);
            numIdleTime.Name = "numIdleTime";
            numIdleTime.Size = new Size(137, 27);
            numIdleTime.TabIndex = 21;
            // 
            // numConnectTime
            // 
            numConnectTime.Location = new Point(527, 377);
            numConnectTime.Margin = new Padding(3, 4, 3, 4);
            numConnectTime.Name = "numConnectTime";
            numConnectTime.Size = new Size(137, 27);
            numConnectTime.TabIndex = 20;
            // 
            // numPasswordGrace
            // 
            numPasswordGrace.Location = new Point(527, 339);
            numPasswordGrace.Margin = new Padding(3, 4, 3, 4);
            numPasswordGrace.Name = "numPasswordGrace";
            numPasswordGrace.Size = new Size(137, 27);
            numPasswordGrace.TabIndex = 19;
            // 
            // numPasswordLock
            // 
            numPasswordLock.Location = new Point(527, 289);
            numPasswordLock.Margin = new Padding(3, 4, 3, 4);
            numPasswordLock.Name = "numPasswordLock";
            numPasswordLock.Size = new Size(137, 27);
            numPasswordLock.TabIndex = 18;
            // 
            // cboFailedLoginType
            // 
            cboFailedLoginType.FormattingEnabled = true;
            cboFailedLoginType.Location = new Point(710, 116);
            cboFailedLoginType.Name = "cboFailedLoginType";
            cboFailedLoginType.Size = new Size(151, 28);
            cboFailedLoginType.TabIndex = 33;
            // 
            // cboPasswordLifeType
            // 
            cboPasswordLifeType.FormattingEnabled = true;
            cboPasswordLifeType.Location = new Point(710, 175);
            cboPasswordLifeType.Name = "cboPasswordLifeType";
            cboPasswordLifeType.Size = new Size(151, 28);
            cboPasswordLifeType.TabIndex = 34;
            // 
            // cboSessionsType
            // 
            cboSessionsType.FormattingEnabled = true;
            cboSessionsType.Location = new Point(710, 232);
            cboSessionsType.Name = "cboSessionsType";
            cboSessionsType.Size = new Size(151, 28);
            cboSessionsType.TabIndex = 35;
            cboSessionsType.SelectedIndexChanged += this.cboPasswordLockType_SelectedIndexChanged;
            // 
            // cboPasswordLockType
            // 
            cboPasswordLockType.FormattingEnabled = true;
            cboPasswordLockType.Location = new Point(710, 288);
            cboPasswordLockType.Name = "cboPasswordLockType";
            cboPasswordLockType.Size = new Size(151, 28);
            cboPasswordLockType.TabIndex = 36;
            cboPasswordLockType.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // cboPasswordGraceType
            // 
            cboPasswordGraceType.FormattingEnabled = true;
            cboPasswordGraceType.Location = new Point(710, 338);
            cboPasswordGraceType.Name = "cboPasswordGraceType";
            cboPasswordGraceType.Size = new Size(151, 28);
            cboPasswordGraceType.TabIndex = 37;
            // 
            // cboConnectTimeType
            // 
            cboConnectTimeType.FormattingEnabled = true;
            cboConnectTimeType.Location = new Point(710, 380);
            cboConnectTimeType.Name = "cboConnectTimeType";
            cboConnectTimeType.Size = new Size(151, 28);
            cboConnectTimeType.TabIndex = 38;
            // 
            // cboIdleTimeType
            // 
            cboIdleTimeType.FormattingEnabled = true;
            cboIdleTimeType.Location = new Point(710, 440);
            cboIdleTimeType.Name = "cboIdleTimeType";
            cboIdleTimeType.Size = new Size(151, 28);
            cboIdleTimeType.TabIndex = 39;
            // 
            // frmEditProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(cboIdleTimeType);
            Controls.Add(cboConnectTimeType);
            Controls.Add(cboPasswordGraceType);
            Controls.Add(cboPasswordLockType);
            Controls.Add(cboSessionsType);
            Controls.Add(cboPasswordLifeType);
            Controls.Add(cboFailedLoginType);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numIdleTime);
            Controls.Add(numConnectTime);
            Controls.Add(numPasswordGrace);
            Controls.Add(numPasswordLock);
            Controls.Add(btnBack);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numSessions);
            Controls.Add(numPasswordLife);
            Controls.Add(btnSave);
            Controls.Add(txtProfileName);
            Controls.Add(numFailedLogin);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmEditProfile";
            Text = "frmEditProfile";
            Load += frmEditProfile_Load;
            ((System.ComponentModel.ISupportInitialize)numFailedLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordLife).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSessions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdleTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numConnectTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordGrace).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordLock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numFailedLogin;
        private TextBox txtProfileName;
        private Button btnSave;
        private NumericUpDown numPasswordLife;
        private NumericUpDown numSessions;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnBack;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown numIdleTime;
        private NumericUpDown numConnectTime;
        private NumericUpDown numPasswordGrace;
        private NumericUpDown numPasswordLock;
        private ComboBox cboFailedLoginType;
        private ComboBox cboPasswordLifeType;
        private ComboBox cboSessionsType;
        private ComboBox cboPasswordLockType;
        private ComboBox cboPasswordGraceType;
        private ComboBox cboConnectTimeType;
        private ComboBox cboIdleTimeType;
    }
}