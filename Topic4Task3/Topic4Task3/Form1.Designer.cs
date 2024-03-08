namespace Topic4Task3
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
            this.txtBxFirst = new System.Windows.Forms.TextBox();
            this.txtBxSec = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.cmdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxFirst
            // 
            this.txtBxFirst.Location = new System.Drawing.Point(434, 99);
            this.txtBxFirst.Name = "txtBxFirst";
            this.txtBxFirst.Size = new System.Drawing.Size(100, 22);
            this.txtBxFirst.TabIndex = 0;
            // 
            // txtBxSec
            // 
            this.txtBxSec.Location = new System.Drawing.Point(434, 159);
            this.txtBxSec.Name = "txtBxSec";
            this.txtBxSec.Size = new System.Drawing.Size(100, 22);
            this.txtBxSec.TabIndex = 1;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(297, 247);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(195, 16);
            this.lblAns.TabIndex = 2;
            this.lblAns.Text = "The answers will be shown here";
            // 
            // cmdBtn
            // 
            this.cmdBtn.Location = new System.Drawing.Point(616, 159);
            this.cmdBtn.Name = "cmdBtn";
            this.cmdBtn.Size = new System.Drawing.Size(75, 23);
            this.cmdBtn.TabIndex = 3;
            this.cmdBtn.Text = "Click me";
            this.cmdBtn.UseVisualStyleBackColor = true;
            this.cmdBtn.Click += new System.EventHandler(this.cmdBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdBtn);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.txtBxSec);
            this.Controls.Add(this.txtBxFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxFirst;
        private System.Windows.Forms.TextBox txtBxSec;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Button cmdBtn;
    }
}

