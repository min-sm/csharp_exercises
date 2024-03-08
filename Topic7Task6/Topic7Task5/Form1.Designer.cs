namespace Topic7Task5
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
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cmdFind = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.chkOut = new System.Windows.Forms.CheckBox();
            this.cmdCheckOut = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(112, 52);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(57, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Enter Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(207, 47);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(76, 20);
            this.txtYear.TabIndex = 1;
            // 
            // cmdFind
            // 
            this.cmdFind.AutoSize = true;
            this.cmdFind.Location = new System.Drawing.Point(169, 107);
            this.cmdFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(56, 23);
            this.cmdFind.TabIndex = 2;
            this.cmdFind.Text = "Find";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(89, 269);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(35, 13);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "label1";
            // 
            // chkOut
            // 
            this.chkOut.AutoSize = true;
            this.chkOut.Location = new System.Drawing.Point(265, 111);
            this.chkOut.Name = "chkOut";
            this.chkOut.Size = new System.Drawing.Size(83, 17);
            this.chkOut.TabIndex = 4;
            this.chkOut.Text = "Check Out?";
            this.chkOut.UseVisualStyleBackColor = true;
            // 
            // cmdCheckOut
            // 
            this.cmdCheckOut.AutoSize = true;
            this.cmdCheckOut.Location = new System.Drawing.Point(150, 171);
            this.cmdCheckOut.Name = "cmdCheckOut";
            this.cmdCheckOut.Size = new System.Drawing.Size(75, 23);
            this.cmdCheckOut.TabIndex = 5;
            this.cmdCheckOut.Text = "Check Out";
            this.cmdCheckOut.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(274, 260);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(46, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "Enter ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(353, 253);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmdCheckOut);
            this.Controls.Add(this.chkOut);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.CheckBox chkOut;
        private System.Windows.Forms.Button cmdCheckOut;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}

