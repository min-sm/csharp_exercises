namespace Topic6Test
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
            this.lblNumToAdd = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdAddNew = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumToAdd
            // 
            this.lblNumToAdd.AutoSize = true;
            this.lblNumToAdd.Location = new System.Drawing.Point(34, 68);
            this.lblNumToAdd.Name = "lblNumToAdd";
            this.lblNumToAdd.Size = new System.Drawing.Size(97, 16);
            this.lblNumToAdd.TabIndex = 0;
            this.lblNumToAdd.Text = "Number to Add";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(181, 62);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 1;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.AutoSize = true;
            this.cmdCalculate.Location = new System.Drawing.Point(37, 195);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(75, 26);
            this.cmdCalculate.TabIndex = 2;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdAddNew
            // 
            this.cmdAddNew.AutoSize = true;
            this.cmdAddNew.Location = new System.Drawing.Point(206, 195);
            this.cmdAddNew.Name = "cmdAddNew";
            this.cmdAddNew.Size = new System.Drawing.Size(75, 26);
            this.cmdAddNew.TabIndex = 3;
            this.cmdAddNew.Text = "Add New";
            this.cmdAddNew.UseVisualStyleBackColor = true;
            this.cmdAddNew.Click += new System.EventHandler(this.cmdAddNew_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(97, 136);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(116, 16);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "0 Numbers Added";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.cmdAddNew);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lblNumToAdd);
            this.Name = "Form1";
            this.Text = "Average";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumToAdd;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdAddNew;
        private System.Windows.Forms.Label lblNum;
    }
}

