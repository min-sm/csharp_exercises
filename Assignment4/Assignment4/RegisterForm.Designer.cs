namespace AssignmentDraft
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
            this.registerMainPanel = new System.Windows.Forms.Panel();
            this.chkBxShowPwd = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPasswordWarning = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsernameWarning = new System.Windows.Forms.Label();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblRegisterTxt = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.lblDebug1 = new System.Windows.Forms.Label();
            this.registerMainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerMainPanel
            // 
            this.registerMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(72)))));
            this.registerMainPanel.Controls.Add(this.chkBxShowPwd);
            this.registerMainPanel.Controls.Add(this.label1);
            this.registerMainPanel.Controls.Add(this.confirmPassword);
            this.registerMainPanel.Controls.Add(this.textBox1);
            this.registerMainPanel.Controls.Add(this.lblPasswordWarning);
            this.registerMainPanel.Controls.Add(this.panel2);
            this.registerMainPanel.Controls.Add(this.lblUsernameWarning);
            this.registerMainPanel.Controls.Add(this.cmdRegister);
            this.registerMainPanel.Controls.Add(this.lblPassword);
            this.registerMainPanel.Controls.Add(this.txtPassword);
            this.registerMainPanel.Controls.Add(this.lblUsername);
            this.registerMainPanel.Controls.Add(this.txtUsername);
            this.registerMainPanel.Controls.Add(this.lblRegisterTxt);
            this.registerMainPanel.Location = new System.Drawing.Point(35, 50);
            this.registerMainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerMainPanel.Name = "registerMainPanel";
            this.registerMainPanel.Size = new System.Drawing.Size(900, 425);
            this.registerMainPanel.TabIndex = 0;
            // 
            // chkBxShowPwd
            // 
            this.chkBxShowPwd.AutoSize = true;
            this.chkBxShowPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxShowPwd.ForeColor = System.Drawing.Color.White;
            this.chkBxShowPwd.Location = new System.Drawing.Point(559, 288);
            this.chkBxShowPwd.Name = "chkBxShowPwd";
            this.chkBxShowPwd.Size = new System.Drawing.Size(151, 24);
            this.chkBxShowPwd.TabIndex = 16;
            this.chkBxShowPwd.Text = "Show Password";
            this.chkBxShowPwd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(507, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Passwords don\'t match. Please re-enter both passwords.";
            this.label1.Visible = false;
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword.ForeColor = System.Drawing.Color.White;
            this.confirmPassword.Location = new System.Drawing.Point(296, 242);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(146, 23);
            this.confirmPassword.TabIndex = 14;
            this.confirmPassword.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(511, 238);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '⁕';
            this.textBox1.Size = new System.Drawing.Size(199, 27);
            this.textBox1.TabIndex = 13;
            // 
            // lblPasswordWarning
            // 
            this.lblPasswordWarning.AutoSize = true;
            this.lblPasswordWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordWarning.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPasswordWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.lblPasswordWarning.Location = new System.Drawing.Point(507, 136);
            this.lblPasswordWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPasswordWarning.Name = "lblPasswordWarning";
            this.lblPasswordWarning.Size = new System.Drawing.Size(382, 40);
            this.lblPasswordWarning.TabIndex = 12;
            this.lblPasswordWarning.Text = "Password\'s length must be 12 letters and \r\nhave at least contain 1 lowercase and " +
    "1 uppercase letter.";
            this.lblPasswordWarning.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Assignment4.Properties.Resources.register_illustration;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 300);
            this.panel2.TabIndex = 0;
            // 
            // lblUsernameWarning
            // 
            this.lblUsernameWarning.AutoSize = true;
            this.lblUsernameWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameWarning.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.lblUsernameWarning.Location = new System.Drawing.Point(507, 73);
            this.lblUsernameWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsernameWarning.Name = "lblUsernameWarning";
            this.lblUsernameWarning.Size = new System.Drawing.Size(320, 20);
            this.lblUsernameWarning.TabIndex = 11;
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
            this.cmdRegister.Location = new System.Drawing.Point(370, 347);
            this.cmdRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Padding = new System.Windows.Forms.Padding(20, 7, 20, 7);
            this.cmdRegister.Size = new System.Drawing.Size(160, 53);
            this.cmdRegister.TabIndex = 10;
            this.cmdRegister.Text = "Register";
            this.cmdRegister.UseVisualStyleBackColor = false;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(362, 182);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 23);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(511, 178);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(199, 27);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(355, 105);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 23);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(511, 101);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(199, 27);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblRegisterTxt
            // 
            this.lblRegisterTxt.AutoSize = true;
            this.lblRegisterTxt.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTxt.ForeColor = System.Drawing.Color.White;
            this.lblRegisterTxt.Location = new System.Drawing.Point(372, 25);
            this.lblRegisterTxt.Name = "lblRegisterTxt";
            this.lblRegisterTxt.Size = new System.Drawing.Size(156, 33);
            this.lblRegisterTxt.TabIndex = 1;
            this.lblRegisterTxt.Text = "Register";
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(32, 503);
            this.lblDebug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(77, 16);
            this.lblDebug.TabIndex = 1;
            this.lblDebug.Text = "Debugging:";
            // 
            // lblDebug1
            // 
            this.lblDebug1.AutoSize = true;
            this.lblDebug1.Location = new System.Drawing.Point(760, 503);
            this.lblDebug1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebug1.Name = "lblDebug1";
            this.lblDebug1.Size = new System.Drawing.Size(77, 16);
            this.lblDebug1.TabIndex = 2;
            this.lblDebug1.Text = "Debugging:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(982, 528);
            this.Controls.Add(this.lblDebug1);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.registerMainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.registerMainPanel.ResumeLayout(false);
            this.registerMainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel registerMainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRegisterTxt;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.Label lblUsernameWarning;
        private System.Windows.Forms.Label lblPasswordWarning;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Label lblDebug1;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBxShowPwd;
    }
}