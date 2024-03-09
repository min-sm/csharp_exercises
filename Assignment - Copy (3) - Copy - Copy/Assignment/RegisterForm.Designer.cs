namespace Assignment
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkBxShowPwd = new System.Windows.Forms.CheckBox();
            this.lblConfirmPasswordWarning = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordWarning = new System.Windows.Forms.Label();
            this.lblUsernameWarning = new System.Windows.Forms.Label();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblRegisterTxt = new System.Windows.Forms.Label();
            this.registerImg = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.chkBxShowPwd);
            this.panel1.Controls.Add(this.lblConfirmPasswordWarning);
            this.panel1.Controls.Add(this.confirmPassword);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.lblPasswordWarning);
            this.panel1.Controls.Add(this.lblUsernameWarning);
            this.panel1.Controls.Add(this.cmdRegister);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblRegisterTxt);
            this.panel1.Controls.Add(this.registerImg);
            this.panel1.Location = new System.Drawing.Point(35, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 425);
            this.panel1.TabIndex = 0;
            // 
            // chkBxShowPwd
            // 
            this.chkBxShowPwd.AutoSize = true;
            this.chkBxShowPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxShowPwd.ForeColor = System.Drawing.Color.White;
            this.chkBxShowPwd.Location = new System.Drawing.Point(605, 304);
            this.chkBxShowPwd.Name = "chkBxShowPwd";
            this.chkBxShowPwd.Size = new System.Drawing.Size(151, 24);
            this.chkBxShowPwd.TabIndex = 28;
            this.chkBxShowPwd.Text = "Show Password";
            this.chkBxShowPwd.UseVisualStyleBackColor = true;
            this.chkBxShowPwd.CheckedChanged += new System.EventHandler(this.chkBxShowPwd_CheckedChanged);
            // 
            // lblConfirmPasswordWarning
            // 
            this.lblConfirmPasswordWarning.AutoSize = true;
            this.lblConfirmPasswordWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPasswordWarning.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.lblConfirmPasswordWarning.Location = new System.Drawing.Point(506, 265);
            this.lblConfirmPasswordWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmPasswordWarning.Name = "lblConfirmPasswordWarning";
            this.lblConfirmPasswordWarning.Size = new System.Drawing.Size(271, 20);
            this.lblConfirmPasswordWarning.TabIndex = 27;
            this.lblConfirmPasswordWarning.Text = "Passwords don\'t match. Re-enter both.";
            this.lblConfirmPasswordWarning.Visible = false;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.Color.White;
            this.confirmPassword.Location = new System.Drawing.Point(271, 240);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(156, 23);
            this.confirmPassword.TabIndex = 26;
            this.confirmPassword.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(506, 236);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '⁕';
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 27);
            this.txtConfirmPassword.TabIndex = 25;
            // 
            // lblPasswordWarning
            // 
            this.lblPasswordWarning.AutoSize = true;
            this.lblPasswordWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordWarning.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.lblPasswordWarning.Location = new System.Drawing.Point(506, 182);
            this.lblPasswordWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordWarning.Name = "lblPasswordWarning";
            this.lblPasswordWarning.Size = new System.Drawing.Size(377, 40);
            this.lblPasswordWarning.TabIndex = 24;
            this.lblPasswordWarning.Text = "Passwords must be 12 characters with 1 lowercase and \r\n1 uppercase letter.";
            this.lblPasswordWarning.Visible = false;
            // 
            // lblUsernameWarning
            // 
            this.lblUsernameWarning.AutoSize = true;
            this.lblUsernameWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameWarning.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.lblUsernameWarning.Location = new System.Drawing.Point(506, 112);
            this.lblUsernameWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameWarning.Name = "lblUsernameWarning";
            this.lblUsernameWarning.Size = new System.Drawing.Size(333, 20);
            this.lblUsernameWarning.TabIndex = 23;
            this.lblUsernameWarning.Text = "Username can only contain letters and numbes.";
            this.lblUsernameWarning.Visible = false;
            // 
            // cmdRegister
            // 
            this.cmdRegister.AutoSize = true;
            this.cmdRegister.BackColor = System.Drawing.Color.Transparent;
            this.cmdRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdRegister.FlatAppearance.BorderSize = 3;
            this.cmdRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRegister.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegister.ForeColor = System.Drawing.Color.White;
            this.cmdRegister.Location = new System.Drawing.Point(365, 349);
            this.cmdRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.cmdRegister.Size = new System.Drawing.Size(160, 53);
            this.cmdRegister.TabIndex = 22;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = false;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(337, 157);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 23);
            this.lblPassword.TabIndex = 21;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(506, 153);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '⁕';
            this.txtPassword.Size = new System.Drawing.Size(250, 27);
            this.txtPassword.TabIndex = 20;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(330, 87);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 23);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(506, 83);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 27);
            this.txtUsername.TabIndex = 18;
            // 
            // lblRegisterTxt
            // 
            this.lblRegisterTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRegisterTxt.AutoSize = true;
            this.lblRegisterTxt.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTxt.ForeColor = System.Drawing.Color.White;
            this.lblRegisterTxt.Location = new System.Drawing.Point(372, 27);
            this.lblRegisterTxt.Name = "lblRegisterTxt";
            this.lblRegisterTxt.Size = new System.Drawing.Size(156, 33);
            this.lblRegisterTxt.TabIndex = 17;
            this.lblRegisterTxt.Text = "Register";
            // 
            // registerImg
            // 
            this.registerImg.BackgroundImage = global::Assignment.Properties.Resources.register_illustration;
            this.registerImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.registerImg.Location = new System.Drawing.Point(0, 62);
            this.registerImg.Name = "registerImg";
            this.registerImg.Size = new System.Drawing.Size(300, 300);
            this.registerImg.TabIndex = 0;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(982, 528);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel registerImg;
        private System.Windows.Forms.CheckBox chkBxShowPwd;
        private System.Windows.Forms.Label lblConfirmPasswordWarning;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblPasswordWarning;
        private System.Windows.Forms.Label lblUsernameWarning;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblRegisterTxt;
    }
}