namespace Student_Help_iEnabler_2
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.studentNolbl = new System.Windows.Forms.Label();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.studentNoInputBox = new System.Windows.Forms.TextBox();
            this.PasswordInputBox = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.showPassCheckBox = new System.Windows.Forms.CheckBox();
            this.loginBox = new System.Windows.Forms.GroupBox();
            this.forgotPassword = new System.Windows.Forms.Label();
            this.UniversityBadge = new System.Windows.Forms.PictureBox();
            this.contactlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Instructionslbl = new System.Windows.Forms.Label();
            this.WebsiteTitlelbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.loginBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniversityBadge)).BeginInit();
            this.SuspendLayout();
            // 
            // studentNolbl
            // 
            this.studentNolbl.AutoSize = true;
            this.studentNolbl.BackColor = System.Drawing.Color.Transparent;
            this.studentNolbl.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.studentNolbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNolbl.ForeColor = System.Drawing.Color.Black;
            this.studentNolbl.Location = new System.Drawing.Point(138, 268);
            this.studentNolbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentNolbl.Name = "studentNolbl";
            this.studentNolbl.Size = new System.Drawing.Size(131, 20);
            this.studentNolbl.TabIndex = 0;
            this.studentNolbl.Text = "Student Number :";
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.AutoSize = true;
            this.Passwordlbl.BackColor = System.Drawing.Color.Transparent;
            this.Passwordlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.ForeColor = System.Drawing.Color.Black;
            this.Passwordlbl.Location = new System.Drawing.Point(138, 327);
            this.Passwordlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(85, 20);
            this.Passwordlbl.TabIndex = 1;
            this.Passwordlbl.Text = "Password  :";
            // 
            // studentNoInputBox
            // 
            this.studentNoInputBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.studentNoInputBox.Location = new System.Drawing.Point(142, 291);
            this.studentNoInputBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studentNoInputBox.Multiline = true;
            this.studentNoInputBox.Name = "studentNoInputBox";
            this.studentNoInputBox.Size = new System.Drawing.Size(285, 25);
            this.studentNoInputBox.TabIndex = 2;
            // 
            // PasswordInputBox
            // 
            this.PasswordInputBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PasswordInputBox.Location = new System.Drawing.Point(142, 350);
            this.PasswordInputBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PasswordInputBox.Multiline = true;
            this.PasswordInputBox.Name = "PasswordInputBox";
            this.PasswordInputBox.Size = new System.Drawing.Size(285, 25);
            this.PasswordInputBox.TabIndex = 3;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Loginbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(142, 446);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(285, 41);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "LOGIN";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // showPassCheckBox
            // 
            this.showPassCheckBox.AutoSize = true;
            this.showPassCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.showPassCheckBox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassCheckBox.ForeColor = System.Drawing.Color.Black;
            this.showPassCheckBox.Location = new System.Drawing.Point(142, 391);
            this.showPassCheckBox.Name = "showPassCheckBox";
            this.showPassCheckBox.Size = new System.Drawing.Size(121, 21);
            this.showPassCheckBox.TabIndex = 5;
            this.showPassCheckBox.Text = "Show Password";
            this.showPassCheckBox.UseVisualStyleBackColor = false;
            this.showPassCheckBox.CheckedChanged += new System.EventHandler(this.showCheckBox_CheckedChanged);
            // 
            // loginBox
            // 
            this.loginBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBox.BackColor = System.Drawing.Color.White;
            this.loginBox.Controls.Add(this.forgotPassword);
            this.loginBox.Controls.Add(this.UniversityBadge);
            this.loginBox.Controls.Add(this.contactlbl);
            this.loginBox.Controls.Add(this.label6);
            this.loginBox.Controls.Add(this.label5);
            this.loginBox.Controls.Add(this.Instructionslbl);
            this.loginBox.Controls.Add(this.WebsiteTitlelbl);
            this.loginBox.Controls.Add(this.studentNoInputBox);
            this.loginBox.Controls.Add(this.Loginbtn);
            this.loginBox.Controls.Add(this.showPassCheckBox);
            this.loginBox.Controls.Add(this.PasswordInputBox);
            this.loginBox.Controls.Add(this.studentNolbl);
            this.loginBox.Controls.Add(this.Passwordlbl);
            this.loginBox.Location = new System.Drawing.Point(403, 58);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(553, 559);
            this.loginBox.TabIndex = 6;
            this.loginBox.TabStop = false;
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPassword.ForeColor = System.Drawing.Color.LimeGreen;
            this.forgotPassword.Location = new System.Drawing.Point(314, 395);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(113, 17);
            this.forgotPassword.TabIndex = 12;
            this.forgotPassword.Text = "Forgot Password?";
            this.forgotPassword.Click += new System.EventHandler(this.forgotPaaword_Click);
            // 
            // UniversityBadge
            // 
            this.UniversityBadge.Image = global::Student_Help_iEnabler_2.Properties.Resources.ChatGPT_Image_Apr_22__2026__08_23_56_PM;
            this.UniversityBadge.Location = new System.Drawing.Point(204, 57);
            this.UniversityBadge.Name = "UniversityBadge";
            this.UniversityBadge.Size = new System.Drawing.Size(160, 110);
            this.UniversityBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UniversityBadge.TabIndex = 11;
            this.UniversityBadge.TabStop = false;
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlbl.Location = new System.Drawing.Point(139, 509);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(304, 17);
            this.contactlbl.TabIndex = 10;
            this.contactlbl.Text = "Don\'t have an account? Please contact university";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 508);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 8;
            // 
            // Instructionslbl
            // 
            this.Instructionslbl.AutoSize = true;
            this.Instructionslbl.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructionslbl.Location = new System.Drawing.Point(149, 216);
            this.Instructionslbl.Name = "Instructionslbl";
            this.Instructionslbl.Size = new System.Drawing.Size(278, 17);
            this.Instructionslbl.TabIndex = 7;
            this.Instructionslbl.Text = "Welcome back! Please loginin to your account.";
            // 
            // WebsiteTitlelbl
            // 
            this.WebsiteTitlelbl.AutoSize = true;
            this.WebsiteTitlelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebsiteTitlelbl.Location = new System.Drawing.Point(169, 170);
            this.WebsiteTitlelbl.Name = "WebsiteTitlelbl";
            this.WebsiteTitlelbl.Size = new System.Drawing.Size(232, 28);
            this.WebsiteTitlelbl.TabIndex = 6;
            this.WebsiteTitlelbl.Text = "Student iEnabler Portal";
            this.WebsiteTitlelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(585, 650);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(341, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "@2026 Student iEnabler System. All rights resered.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1340, 730);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.loginBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.Text = "LogInForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginBox.ResumeLayout(false);
            this.loginBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniversityBadge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentNolbl;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.TextBox studentNoInputBox;
        private System.Windows.Forms.TextBox PasswordInputBox;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.CheckBox showPassCheckBox;
        private System.Windows.Forms.GroupBox loginBox;
        private System.Windows.Forms.Label WebsiteTitlelbl;
        private System.Windows.Forms.Label Instructionslbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label contactlbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox UniversityBadge;
        private System.Windows.Forms.Label forgotPassword;
    }
}

