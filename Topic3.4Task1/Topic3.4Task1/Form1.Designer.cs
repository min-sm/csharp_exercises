namespace Topic3._4Task1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxNum1 = new System.Windows.Forms.TextBox();
            this.txtBxNum2 = new System.Windows.Forms.TextBox();
            this.optAdd = new System.Windows.Forms.RadioButton();
            this.optSub = new System.Windows.Forms.RadioButton();
            this.optMultiply = new System.Windows.Forms.RadioButton();
            this.optDivision = new System.Windows.Forms.RadioButton();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.lblAns = new System.Windows.Forms.Label();
            this.lblLargest = new System.Windows.Forms.Label();
            this.lblFirstNumIs = new System.Windows.Forms.Label();
            this.lblSecNumIs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num2";
            // 
            // txtBxNum1
            // 
            this.txtBxNum1.Location = new System.Drawing.Point(226, 90);
            this.txtBxNum1.Name = "txtBxNum1";
            this.txtBxNum1.Size = new System.Drawing.Size(100, 22);
            this.txtBxNum1.TabIndex = 2;
            // 
            // txtBxNum2
            // 
            this.txtBxNum2.Location = new System.Drawing.Point(226, 137);
            this.txtBxNum2.Name = "txtBxNum2";
            this.txtBxNum2.Size = new System.Drawing.Size(100, 22);
            this.txtBxNum2.TabIndex = 3;
            // 
            // optAdd
            // 
            this.optAdd.AutoSize = true;
            this.optAdd.Location = new System.Drawing.Point(84, 231);
            this.optAdd.Name = "optAdd";
            this.optAdd.Size = new System.Drawing.Size(53, 20);
            this.optAdd.TabIndex = 4;
            this.optAdd.TabStop = true;
            this.optAdd.Text = "Add";
            this.optAdd.UseVisualStyleBackColor = true;
            // 
            // optSub
            // 
            this.optSub.AutoSize = true;
            this.optSub.Location = new System.Drawing.Point(166, 231);
            this.optSub.Name = "optSub";
            this.optSub.Size = new System.Drawing.Size(77, 20);
            this.optSub.TabIndex = 5;
            this.optSub.TabStop = true;
            this.optSub.Text = "Subtract";
            this.optSub.UseVisualStyleBackColor = true;
            // 
            // optMultiply
            // 
            this.optMultiply.AutoSize = true;
            this.optMultiply.Location = new System.Drawing.Point(284, 231);
            this.optMultiply.Name = "optMultiply";
            this.optMultiply.Size = new System.Drawing.Size(73, 20);
            this.optMultiply.TabIndex = 6;
            this.optMultiply.TabStop = true;
            this.optMultiply.Text = "Multiply";
            this.optMultiply.UseVisualStyleBackColor = true;
            // 
            // optDivision
            // 
            this.optDivision.AutoSize = true;
            this.optDivision.Location = new System.Drawing.Point(402, 231);
            this.optDivision.Name = "optDivision";
            this.optDivision.Size = new System.Drawing.Size(76, 20);
            this.optDivision.TabIndex = 7;
            this.optDivision.TabStop = true;
            this.optDivision.Text = "Division";
            this.optDivision.UseVisualStyleBackColor = true;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.AutoSize = true;
            this.cmdCalculate.Location = new System.Drawing.Point(166, 326);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(106, 50);
            this.cmdCalculate.TabIndex = 8;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(25, 400);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(147, 16);
            this.lblAns.TabIndex = 9;
            this.lblAns.Text = "The calculated result is ";
            // 
            // lblLargest
            // 
            this.lblLargest.AutoSize = true;
            this.lblLargest.Location = new System.Drawing.Point(413, 314);
            this.lblLargest.Name = "lblLargest";
            this.lblLargest.Size = new System.Drawing.Size(142, 16);
            this.lblLargest.TabIndex = 10;
            this.lblLargest.Text = "The largest number is: ";
            // 
            // lblFirstNumIs
            // 
            this.lblFirstNumIs.AutoSize = true;
            this.lblFirstNumIs.Location = new System.Drawing.Point(413, 359);
            this.lblFirstNumIs.Name = "lblFirstNumIs";
            this.lblFirstNumIs.Size = new System.Drawing.Size(96, 16);
            this.lblFirstNumIs.TabIndex = 11;
            this.lblFirstNumIs.Text = "First number is ";
            // 
            // lblSecNumIs
            // 
            this.lblSecNumIs.AutoSize = true;
            this.lblSecNumIs.Location = new System.Drawing.Point(413, 400);
            this.lblSecNumIs.Name = "lblSecNumIs";
            this.lblSecNumIs.Size = new System.Drawing.Size(118, 16);
            this.lblSecNumIs.TabIndex = 12;
            this.lblSecNumIs.Text = "Second number is ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSecNumIs);
            this.Controls.Add(this.lblFirstNumIs);
            this.Controls.Add(this.lblLargest);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.optDivision);
            this.Controls.Add(this.optMultiply);
            this.Controls.Add(this.optSub);
            this.Controls.Add(this.optAdd);
            this.Controls.Add(this.txtBxNum2);
            this.Controls.Add(this.txtBxNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxNum1;
        private System.Windows.Forms.TextBox txtBxNum2;
        private System.Windows.Forms.RadioButton optAdd;
        private System.Windows.Forms.RadioButton optSub;
        private System.Windows.Forms.RadioButton optMultiply;
        private System.Windows.Forms.RadioButton optDivision;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Label lblLargest;
        private System.Windows.Forms.Label lblFirstNumIs;
        private System.Windows.Forms.Label lblSecNumIs;
    }
}

