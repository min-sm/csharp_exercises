namespace AssignmentDraft
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
            this.loginMainPanel = new System.Windows.Forms.Panel();
            this.chkBxShowPwd = new System.Windows.Forms.CheckBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.lblNotAMember2 = new System.Windows.Forms.Label();
            this.lblNotAMember1 = new System.Windows.Forms.Label();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLoginText = new System.Windows.Forms.Label();
            this.loginMainPanel.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginMainPanel
            // 
            this.loginMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.loginMainPanel.Controls.Add(this.chkBxShowPwd);
            this.loginMainPanel.Controls.Add(this.panelRight);
            this.loginMainPanel.Controls.Add(this.cmdLogin);
            this.loginMainPanel.Controls.Add(this.txtPassword);
            this.loginMainPanel.Controls.Add(this.label1);
            this.loginMainPanel.Controls.Add(this.txtUsername);
            this.loginMainPanel.Controls.Add(this.lblEmail);
            this.loginMainPanel.Controls.Add(this.lblLoginText);
            this.loginMainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginMainPanel.Location = new System.Drawing.Point(109, 50);
            this.loginMainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginMainPanel.Name = "loginMainPanel";
            this.loginMainPanel.Size = new System.Drawing.Size(700, 425);
            this.loginMainPanel.TabIndex = 0;
            // 
            // chkBxShowPwd
            // 
            this.chkBxShowPwd.AutoSize = true;
            this.chkBxShowPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxShowPwd.ForeColor = System.Drawing.Color.Black;
            this.chkBxShowPwd.Location = new System.Drawing.Point(100, 247);
            this.chkBxShowPwd.Name = "chkBxShowPwd";
            this.chkBxShowPwd.Size = new System.Drawing.Size(151, 24);
            this.chkBxShowPwd.TabIndex = 17;
            this.chkBxShowPwd.Text = "Show Password";
            this.chkBxShowPwd.UseVisualStyleBackColor = true;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(79)))));
            this.panelRight.Controls.Add(this.cmdRegister);
            this.panelRight.Controls.Add(this.lblNotAMember2);
            this.panelRight.Controls.Add(this.lblNotAMember1);
            this.panelRight.Location = new System.Drawing.Point(500, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(200, 425);
            this.panelRight.TabIndex = 1;
            // 
            // cmdRegister
            // 
            this.cmdRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdRegister.AutoSize = true;
            this.cmdRegister.BackColor = System.Drawing.Color.Transparent;
            this.cmdRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdRegister.FlatAppearance.BorderSize = 3;
            this.cmdRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegister.ForeColor = System.Drawing.Color.White;
            this.cmdRegister.Location = new System.Drawing.Point(21, 247);
            this.cmdRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.cmdRegister.Size = new System.Drawing.Size(160, 54);
            this.cmdRegister.TabIndex = 2;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = false;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // lblNotAMember2
            // 
            this.lblNotAMember2.AutoSize = true;
            this.lblNotAMember2.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotAMember2.ForeColor = System.Drawing.Color.White;
            this.lblNotAMember2.Location = new System.Drawing.Point(25, 80);
            this.lblNotAMember2.Name = "lblNotAMember2";
            this.lblNotAMember2.Size = new System.Drawing.Size(153, 33);
            this.lblNotAMember2.TabIndex = 1;
            this.lblNotAMember2.Text = "MEMBER?";
            // 
            // lblNotAMember1
            // 
            this.lblNotAMember1.AutoSize = true;
            this.lblNotAMember1.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotAMember1.ForeColor = System.Drawing.Color.White;
            this.lblNotAMember1.Location = new System.Drawing.Point(25, 39);
            this.lblNotAMember1.Name = "lblNotAMember1";
            this.lblNotAMember1.Size = new System.Drawing.Size(113, 33);
            this.lblNotAMember1.TabIndex = 0;
            this.lblNotAMember1.Text = "NOT A";
            // 
            // cmdLogin
            // 
            this.cmdLogin.AutoSize = true;
            this.cmdLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(79)))));
            this.cmdLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogin.ForeColor = System.Drawing.Color.White;
            this.cmdLogin.Location = new System.Drawing.Point(52, 289);
            this.cmdLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.cmdLogin.Size = new System.Drawing.Size(127, 52);
            this.cmdLogin.TabIndex = 3;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = false;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(52, 193);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(199, 27);
            this.txtPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(52, 119);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(199, 27);
            this.txtUsername.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(49, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Username";
            // 
            // lblLoginText
            // 
            this.lblLoginText.AutoSize = true;
            this.lblLoginText.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginText.ForeColor = System.Drawing.Color.Black;
            this.lblLoginText.Location = new System.Drawing.Point(45, 31);
            this.lblLoginText.Name = "lblLoginText";
            this.lblLoginText.Size = new System.Drawing.Size(111, 33);
            this.lblLoginText.TabIndex = 3;
            this.lblLoginText.Text = "LOGIN";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(982, 528);
            this.Controls.Add(this.loginMainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.loginMainPanel.ResumeLayout(false);
            this.loginMainPanel.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginMainPanel;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label lblNotAMember1;
        private System.Windows.Forms.Label lblNotAMember2;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLoginText;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.CheckBox chkBxShowPwd;
    }
}

