namespace Topic3Test1
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
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.cmdPressMe = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(94, 57);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "Age";
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(94, 129);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(73, 16);
            this.lblBasePrice.TabIndex = 1;
            this.lblBasePrice.Text = "Base Price";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(223, 57);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(223, 129);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 3;
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Location = new System.Drawing.Point(97, 196);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(142, 20);
            this.chkDiscount.TabIndex = 4;
            this.chkDiscount.Text = "Receives Discount";
            this.chkDiscount.UseVisualStyleBackColor = true;
            // 
            // cmdPressMe
            // 
            this.cmdPressMe.Location = new System.Drawing.Point(145, 286);
            this.cmdPressMe.Name = "cmdPressMe";
            this.cmdPressMe.Size = new System.Drawing.Size(122, 46);
            this.cmdPressMe.TabIndex = 5;
            this.cmdPressMe.Text = "Press Me";
            this.cmdPressMe.UseVisualStyleBackColor = true;
            this.cmdPressMe.Click += new System.EventHandler(this.cmdPressMe_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(105, 249);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 16);
            this.lblOutput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.cmdPressMe);
            this.Controls.Add(this.chkDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.lblAge);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.Button cmdPressMe;
        private System.Windows.Forms.Label lblOutput;
    }
}

