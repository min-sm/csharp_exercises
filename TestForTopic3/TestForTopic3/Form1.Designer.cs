namespace TestForTopic3
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
            this.lbl_numOne = new System.Windows.Forms.Label();
            this.lbl_numTwo = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cmdMinus = new System.Windows.Forms.Button();
            this.cmdMultiply = new System.Windows.Forms.Button();
            this.cmdDivision = new System.Windows.Forms.Button();
            this.cmdModulus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_numOne
            // 
            this.lbl_numOne.AutoSize = true;
            this.lbl_numOne.Location = new System.Drawing.Point(76, 97);
            this.lbl_numOne.Name = "lbl_numOne";
            this.lbl_numOne.Size = new System.Drawing.Size(45, 16);
            this.lbl_numOne.TabIndex = 0;
            this.lbl_numOne.Text = "Num 1";
            // 
            // lbl_numTwo
            // 
            this.lbl_numTwo.AutoSize = true;
            this.lbl_numTwo.Location = new System.Drawing.Point(77, 150);
            this.lbl_numTwo.Name = "lbl_numTwo";
            this.lbl_numTwo.Size = new System.Drawing.Size(45, 16);
            this.lbl_numTwo.TabIndex = 1;
            this.lbl_numTwo.Text = "Num 2";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(180, 91);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(206, 22);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(180, 144);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(206, 22);
            this.txtNum2.TabIndex = 3;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(57, 222);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(87, 38);
            this.cmdAdd.TabIndex = 4;
            this.cmdAdd.Text = "+";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdMinus
            // 
            this.cmdMinus.Location = new System.Drawing.Point(180, 222);
            this.cmdMinus.Name = "cmdMinus";
            this.cmdMinus.Size = new System.Drawing.Size(87, 38);
            this.cmdMinus.TabIndex = 5;
            this.cmdMinus.Text = "-";
            this.cmdMinus.UseVisualStyleBackColor = true;
            this.cmdMinus.Click += new System.EventHandler(this.cmdMinus_Click);
            // 
            // cmdMultiply
            // 
            this.cmdMultiply.Location = new System.Drawing.Point(299, 222);
            this.cmdMultiply.Name = "cmdMultiply";
            this.cmdMultiply.Size = new System.Drawing.Size(87, 38);
            this.cmdMultiply.TabIndex = 6;
            this.cmdMultiply.Text = "*";
            this.cmdMultiply.UseVisualStyleBackColor = true;
            this.cmdMultiply.Click += new System.EventHandler(this.cmdMultiply_Click);
            // 
            // cmdDivision
            // 
            this.cmdDivision.Location = new System.Drawing.Point(424, 222);
            this.cmdDivision.Name = "cmdDivision";
            this.cmdDivision.Size = new System.Drawing.Size(87, 38);
            this.cmdDivision.TabIndex = 7;
            this.cmdDivision.Text = "/";
            this.cmdDivision.UseVisualStyleBackColor = true;
            this.cmdDivision.Click += new System.EventHandler(this.cmdDivision_Click);
            // 
            // cmdModulus
            // 
            this.cmdModulus.Location = new System.Drawing.Point(557, 222);
            this.cmdModulus.Name = "cmdModulus";
            this.cmdModulus.Size = new System.Drawing.Size(87, 38);
            this.cmdModulus.TabIndex = 8;
            this.cmdModulus.Text = "%";
            this.cmdModulus.UseVisualStyleBackColor = true;
            this.cmdModulus.Click += new System.EventHandler(this.cmdModulus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdModulus);
            this.Controls.Add(this.cmdDivision);
            this.Controls.Add(this.cmdMultiply);
            this.Controls.Add(this.cmdMinus);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lbl_numTwo);
            this.Controls.Add(this.lbl_numOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_numOne;
        private System.Windows.Forms.Label lbl_numTwo;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.Button cmdMinus;
        private System.Windows.Forms.Button cmdMultiply;
        private System.Windows.Forms.Button cmdDivision;
        private System.Windows.Forms.Button cmdModulus;
    }
}

