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
            label1.Location = new Point(240, 97);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Profile Name:";
            // 
            // txtProfileName
            // 
            txtProfileName.Location = new Point(431, 89);
            txtProfileName.Name = "txtProfileName";
            txtProfileName.Size = new Size(120, 23);
            txtProfileName.TabIndex = 1;
            // 
            // numFailedLogin
            // 
            numFailedLogin.Location = new Point(431, 122);
            numFailedLogin.Name = "numFailedLogin";
            numFailedLogin.Size = new Size(120, 23);
            numFailedLogin.TabIndex = 2;
            // 
            // numPasswordLife
            // 
            numPasswordLife.Location = new Point(431, 167);
            numPasswordLife.Name = "numPasswordLife";
            numPasswordLife.Size = new Size(120, 23);
            numPasswordLife.TabIndex = 3;
            // 
            // numSessions
            // 
            numSessions.Location = new Point(431, 203);
            numSessions.Name = "numSessions";
            numSessions.Size = new Size(120, 23);
            numSessions.TabIndex = 4;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(245, 371);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(107, 43);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 130);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 6;
            label2.Text = "Failed Login Attempts:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 169);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 7;
            label3.Text = "Password Life Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 205);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 8;
            label4.Text = "Sessions Per User:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(497, 371);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(107, 43);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // numPasswordLock
            // 
            numPasswordLock.Location = new Point(431, 232);
            numPasswordLock.Name = "numPasswordLock";
            numPasswordLock.Size = new Size(120, 23);
            numPasswordLock.TabIndex = 10;
            // 
            // numPasswordGrace
            // 
            numPasswordGrace.Location = new Point(431, 261);
            numPasswordGrace.Name = "numPasswordGrace";
            numPasswordGrace.Size = new Size(120, 23);
            numPasswordGrace.TabIndex = 11;
            // 
            // numConnectTime
            // 
            numConnectTime.Location = new Point(431, 290);
            numConnectTime.Name = "numConnectTime";
            numConnectTime.Size = new Size(120, 23);
            numConnectTime.TabIndex = 12;
            // 
            // numIdleTime
            // 
            numIdleTime.Location = new Point(431, 319);
            numIdleTime.Name = "numIdleTime";
            numIdleTime.Size = new Size(120, 23);
            numIdleTime.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 240);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 14;
            label5.Text = "Password Lock Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 269);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 15;
            label6.Text = "Password Grace Time:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 327);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 16;
            label7.Text = "Idle Time:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(240, 298);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 17;
            label8.Text = "Connect Time:";
            // 
            // frmCreateProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}