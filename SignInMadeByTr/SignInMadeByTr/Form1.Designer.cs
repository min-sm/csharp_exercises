namespace SignInMadeByTr
{
    partial class Form1
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
            this.lblWelcomeTxt = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdLogin = new System.Windows.Forms.Button();
            this.cmdSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeTxt
            // 
            this.lblWelcomeTxt.AutoSize = true;
            this.lblWelcomeTxt.Location = new System.Drawing.Point(96, 77);
            this.lblWelcomeTxt.Name = "lblWelcomeTxt";
            this.lblWelcomeTxt.Size = new System.Drawing.Size(71, 16);
            this.lblWelcomeTxt.TabIndex = 0;
            this.lblWelcomeTxt.Text = "Welcome: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(288, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(288, 216);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // cmdLogin
            // 
            this.cmdLogin.AutoSize = true;
            this.cmdLogin.Location = new System.Drawing.Point(104, 337);
            this.cmdLogin.Name = "cmdLogin";
            this.cmdLogin.Size = new System.Drawing.Size(75, 26);
            this.cmdLogin.TabIndex = 3;
            this.cmdLogin.Text = "Login";
            this.cmdLogin.UseVisualStyleBackColor = true;
            this.cmdLogin.Click += new System.EventHandler(this.cmdLogin_Click);
            // 
            // cmdSignUp
            // 
            this.cmdSignUp.AutoSize = true;
            this.cmdSignUp.Location = new System.Drawing.Point(483, 337);
            this.cmdSignUp.Name = "cmdSignUp";
            this.cmdSignUp.Size = new System.Drawing.Size(75, 26);
            this.cmdSignUp.TabIndex = 4;
            this.cmdSignUp.Text = "Sign Up";
            this.cmdSignUp.UseVisualStyleBackColor = true;
            this.cmdSignUp.Click += new System.EventHandler(this.cmdSignUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSignUp);
            this.Controls.Add(this.cmdLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblWelcomeTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeTxt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdLogin;
        private System.Windows.Forms.Button cmdSignUp;
    }
}

