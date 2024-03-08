namespace Topic4Task2
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtMultiplicand = new System.Windows.Forms.TextBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.lblAns = new System.Windows.Forms.Label();
            this.lblMultiplicand = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(124, 147);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(194, 16);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "The answer will be shown here: ";
            // 
            // txtMultiplicand
            // 
            this.txtMultiplicand.Location = new System.Drawing.Point(218, 208);
            this.txtMultiplicand.Name = "txtMultiplicand";
            this.txtMultiplicand.Size = new System.Drawing.Size(100, 22);
            this.txtMultiplicand.TabIndex = 1;
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.AutoSize = true;
            this.cmdCalculate.Location = new System.Drawing.Point(173, 348);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(75, 26);
            this.cmdCalculate.TabIndex = 2;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(403, 147);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 16);
            this.lblAns.TabIndex = 3;
            // 
            // lblMultiplicand
            // 
            this.lblMultiplicand.AutoSize = true;
            this.lblMultiplicand.Location = new System.Drawing.Point(113, 208);
            this.lblMultiplicand.Name = "lblMultiplicand";
            this.lblMultiplicand.Size = new System.Drawing.Size(78, 16);
            this.lblMultiplicand.TabIndex = 4;
            this.lblMultiplicand.Text = "Multiplicand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Multiplier (up to)";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(218, 263);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(100, 22);
            this.txtMultiplier.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMultiplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMultiplicand);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.txtMultiplicand);
            this.Controls.Add(this.lblDescription);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtMultiplicand;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Label lblMultiplicand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMultiplier;
    }
}

