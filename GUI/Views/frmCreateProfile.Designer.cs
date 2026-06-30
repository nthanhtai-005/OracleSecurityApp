namespace GUI.Views
{
    partial class frmCreateProfile
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
            txtProfileName = new TextBox();
            numFailedLogin = new NumericUpDown();
            numPasswordLife = new NumericUpDown();
            numSessions = new NumericUpDown();
            btnCreate = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnBack = new Button();
            numPasswordLock = new NumericUpDown();
            numPasswordGrace = new NumericUpDown();
            numConnectTime = new NumericUpDown();
            numIdleTime = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cboIdleTimeType = new ComboBox();
            cboConnectTimeType = new ComboBox();
            cboPasswordGraceType = new ComboBox();
            cboPasswordLockType = new ComboBox();
            cboSessionsType = new ComboBox();
            cboPasswordLifeType = new ComboBox();
            cboFailedLoginType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numFailedLogin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordLife).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSessions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordLock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordGrace).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numConnectTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numIdleTime).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 129);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Profile Name:";
            // 
            // txtProfileName
            // 
            txtProfileName.Location = new Point(493, 119);
            txtProfileName.Margin = new Padding(3, 4, 3, 4);
            txtProfileName.Name = "txtProfileName";
            txtProfileName.Size = new Size(137, 27);
            txtProfileName.TabIndex = 1;
            // 
            // numFailedLogin
            // 
            numFailedLogin.Location = new Point(493, 163);
            numFailedLogin.Margin = new Padding(3, 4, 3, 4);
            numFailedLogin.Name = "numFailedLogin";
            numFailedLogin.Size = new Size(137, 27);
            numFailedLogin.TabIndex = 2;
            // 
            // numPasswordLife
            // 
            numPasswordLife.Location = new Point(493, 223);
            numPasswordLife.Margin = new Padding(3, 4, 3, 4);
            numPasswordLife.Name = "numPasswordLife";
            numPasswordLife.Size = new Size(137, 27);
            numPasswordLife.TabIndex = 3;
            // 
            // numSessions
            // 
            numSessions.Location = new Point(493, 271);
            numSessions.Margin = new Padding(3, 4, 3, 4);
            numSessions.Name = "numSessions";
            numSessions.Size = new Size(137, 27);
            numSessions.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(280, 495);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(122, 57);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 173);
            label2.Name = "label2";
            label2.Size = new Size(157, 20);
            label2.TabIndex = 6;
            label2.Text = "Failed Login Attempts:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(274, 225);
            label3.Name = "label3";
            label3.Size = new Size(138, 20);
            label3.TabIndex = 7;
            label3.Text = "Password Life Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(274, 273);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 8;
            label4.Text = "Sessions Per User:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(568, 495);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(122, 57);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // numPasswordLock
            // 
            numPasswordLock.Location = new Point(493, 309);
            numPasswordLock.Margin = new Padding(3, 4, 3, 4);
            numPasswordLock.Name = "numPasswordLock";
            numPasswordLock.Size = new Size(137, 27);
            numPasswordLock.TabIndex = 10;
            // 
            // numPasswordGrace
            // 
            numPasswordGrace.Location = new Point(493, 348);
            numPasswordGrace.Margin = new Padding(3, 4, 3, 4);
            numPasswordGrace.Name = "numPasswordGrace";
            numPasswordGrace.Size = new Size(137, 27);
            numPasswordGrace.TabIndex = 11;
            // 
            // numConnectTime
            // 
            numConnectTime.Location = new Point(493, 387);
            numConnectTime.Margin = new Padding(3, 4, 3, 4);
            numConnectTime.Name = "numConnectTime";
            numConnectTime.Size = new Size(137, 27);
            numConnectTime.TabIndex = 12;
            // 
            // numIdleTime
            // 
            numIdleTime.Location = new Point(493, 425);
            numIdleTime.Margin = new Padding(3, 4, 3, 4);
            numIdleTime.Name = "numIdleTime";
            numIdleTime.Size = new Size(137, 27);
            numIdleTime.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 320);
            label5.Name = "label5";
            label5.Size = new Size(144, 20);
            label5.TabIndex = 14;
            label5.Text = "Password Lock Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(274, 359);
            label6.Name = "label6";
            label6.Size = new Size(152, 20);
            label6.TabIndex = 15;
            label6.Text = "Password Grace Time:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 436);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 16;
            label7.Text = "Idle Time:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(274, 397);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 17;
            label8.Text = "Connect Time:";
            // 
            // cboIdleTimeType
            // 
            cboIdleTimeType.FormattingEnabled = true;
            cboIdleTimeType.Location = new Point(689, 433);
            cboIdleTimeType.Name = "cboIdleTimeType";
            cboIdleTimeType.Size = new Size(151, 28);
            cboIdleTimeType.TabIndex = 46;
            // 
            // cboConnectTimeType
            // 
            cboConnectTimeType.FormattingEnabled = true;
            cboConnectTimeType.Location = new Point(689, 394);
            cboConnectTimeType.Name = "cboConnectTimeType";
            cboConnectTimeType.Size = new Size(151, 28);
            cboConnectTimeType.TabIndex = 45;
            // 
            // cboPasswordGraceType
            // 
            cboPasswordGraceType.FormattingEnabled = true;
            cboPasswordGraceType.Location = new Point(689, 351);
            cboPasswordGraceType.Name = "cboPasswordGraceType";
            cboPasswordGraceType.Size = new Size(151, 28);
            cboPasswordGraceType.TabIndex = 44;
            // 
            // cboPasswordLockType
            // 
            cboPasswordLockType.FormattingEnabled = true;
            cboPasswordLockType.Location = new Point(689, 312);
            cboPasswordLockType.Name = "cboPasswordLockType";
            cboPasswordLockType.Size = new Size(151, 28);
            cboPasswordLockType.TabIndex = 43;
            // 
            // cboSessionsType
            // 
            cboSessionsType.FormattingEnabled = true;
            cboSessionsType.Location = new Point(689, 265);
            cboSessionsType.Name = "cboSessionsType";
            cboSessionsType.Size = new Size(151, 28);
            cboSessionsType.TabIndex = 42;
            // 
            // cboPasswordLifeType
            // 
            cboPasswordLifeType.FormattingEnabled = true;
            cboPasswordLifeType.Location = new Point(689, 217);
            cboPasswordLifeType.Name = "cboPasswordLifeType";
            cboPasswordLifeType.Size = new Size(151, 28);
            cboPasswordLifeType.TabIndex = 41;
            // 
            // cboFailedLoginType
            // 
            cboFailedLoginType.FormattingEnabled = true;
            cboFailedLoginType.Location = new Point(689, 165);
            cboFailedLoginType.Name = "cboFailedLoginType";
            cboFailedLoginType.Size = new Size(151, 28);
            cboFailedLoginType.TabIndex = 40;
            // 
            // frmCreateProfile
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
            Controls.Add(btnCreate);
            Controls.Add(numSessions);
            Controls.Add(numPasswordLife);
            Controls.Add(numFailedLogin);
            Controls.Add(txtProfileName);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCreateProfile";
            Text = "frmCreateProfile";
            Load += frmCreateProfile_Load;
            ((System.ComponentModel.ISupportInitialize)numFailedLogin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordLife).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSessions).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordLock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPasswordGrace).EndInit();
            ((System.ComponentModel.ISupportInitialize)numConnectTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numIdleTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProfileName;
        private NumericUpDown numFailedLogin;
        private NumericUpDown numPasswordLife;
        private NumericUpDown numSessions;
        private Button btnCreate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnBack;
        private NumericUpDown numPasswordLock;
        private NumericUpDown numPasswordGrace;
        private NumericUpDown numConnectTime;
        private NumericUpDown numIdleTime;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cboIdleTimeType;
        private ComboBox cboConnectTimeType;
        private ComboBox cboPasswordGraceType;
        private ComboBox cboPasswordLockType;
        private ComboBox cboSessionsType;
        private ComboBox cboPasswordLifeType;
        private ComboBox cboFailedLoginType;
    }
}