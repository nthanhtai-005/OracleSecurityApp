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
            label1.Location = new Point(267, 38);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Profile Name:\n";
            // 
            // numFailedLogin
            // 
            numFailedLogin.Location = new Point(461, 88);
            numFailedLogin.Name = "numFailedLogin";
            numFailedLogin.Size = new Size(120, 23);
            numFailedLogin.TabIndex = 1;
            // 
            // txtProfileName
            // 
            txtProfileName.Location = new Point(461, 30);
            txtProfileName.Name = "txtProfileName";
            txtProfileName.ReadOnly = true;
            txtProfileName.Size = new Size(120, 23);
            txtProfileName.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(267, 382);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(117, 37);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // numPasswordLife
            // 
            numPasswordLife.Location = new Point(461, 132);
            numPasswordLife.Name = "numPasswordLife";
            numPasswordLife.Size = new Size(120, 23);
            numPasswordLife.TabIndex = 4;
            // 
            // numSessions
            // 
            numSessions.Location = new Point(461, 175);
            numSessions.Name = "numSessions";
            numSessions.Size = new Size(120, 23);
            numSessions.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 96);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 6;
            label2.Text = "Failed Login Attempts:\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 140);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 7;
            label3.Text = "Password Life Time:\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 183);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 8;
            label4.Text = "Sessions Per User:\n";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(436, 382);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(117, 37);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(267, 291);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 25;
            label8.Text = "Connect Time:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(267, 336);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 24;
            label7.Text = "Idle Time:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 262);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 23;
            label6.Text = "Password Grace Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 225);
            label5.Name = "label5";
            label5.Size = new Size(118, 15);
            label5.TabIndex = 22;
            label5.Text = "Password Lock Time:";
            // 
            // numIdleTime
            // 
            numIdleTime.Location = new Point(461, 328);
            numIdleTime.Name = "numIdleTime";
            numIdleTime.Size = new Size(120, 23);
            numIdleTime.TabIndex = 21;
            // 
            // numConnectTime
            // 
            numConnectTime.Location = new Point(461, 283);
            numConnectTime.Name = "numConnectTime";
            numConnectTime.Size = new Size(120, 23);
            numConnectTime.TabIndex = 20;
            // 
            // numPasswordGrace
            // 
            numPasswordGrace.Location = new Point(461, 254);
            numPasswordGrace.Name = "numPasswordGrace";
            numPasswordGrace.Size = new Size(120, 23);
            numPasswordGrace.TabIndex = 19;
            // 
            // numPasswordLock
            // 
            numPasswordLock.Location = new Point(461, 217);
            numPasswordLock.Name = "numPasswordLock";
            numPasswordLock.Size = new Size(120, 23);
            numPasswordLock.TabIndex = 18;
            // 
            // frmEditProfile
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
            Controls.Add(numSessions);
            Controls.Add(numPasswordLife);
            Controls.Add(btnSave);
            Controls.Add(txtProfileName);
            Controls.Add(numFailedLogin);
            Controls.Add(label1);
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
    }
}