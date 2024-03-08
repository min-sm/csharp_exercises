namespace Topic5Task1
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
            this.txtBx1 = new System.Windows.Forms.TextBox();
            this.txtBx2 = new System.Windows.Forms.TextBox();
            this.txtBx3 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblObjChoose = new System.Windows.Forms.Label();
            this.txtBxWhich = new System.Windows.Forms.TextBox();
            this.txtBxRes = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.cmdSmallest = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBx1
            // 
            this.txtBx1.Location = new System.Drawing.Point(61, 128);
            this.txtBx1.Name = "txtBx1";
            this.txtBx1.Size = new System.Drawing.Size(100, 22);
            this.txtBx1.TabIndex = 0;
            // 
            // txtBx2
            // 
            this.txtBx2.Location = new System.Drawing.Point(215, 128);
            this.txtBx2.Name = "txtBx2";
            this.txtBx2.Size = new System.Drawing.Size(100, 22);
            this.txtBx2.TabIndex = 1;
            // 
            // txtBx3
            // 
            this.txtBx3.Location = new System.Drawing.Point(369, 128);
            this.txtBx3.Name = "txtBx3";
            this.txtBx3.Size = new System.Drawing.Size(100, 22);
            this.txtBx3.TabIndex = 2;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(58, 84);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(42, 16);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Num1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(212, 84);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(42, 16);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Num2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(366, 84);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(42, 16);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Num3";
            // 
            // lblObjChoose
            // 
            this.lblObjChoose.AutoSize = true;
            this.lblObjChoose.Location = new System.Drawing.Point(516, 84);
            this.lblObjChoose.Name = "lblObjChoose";
            this.lblObjChoose.Size = new System.Drawing.Size(79, 16);
            this.lblObjChoose.TabIndex = 6;
            this.lblObjChoose.Text = "Which One?";
            // 
            // txtBxWhich
            // 
            this.txtBxWhich.Location = new System.Drawing.Point(519, 128);
            this.txtBxWhich.Name = "txtBxWhich";
            this.txtBxWhich.Size = new System.Drawing.Size(100, 22);
            this.txtBxWhich.TabIndex = 7;
            // 
            // txtBxRes
            // 
            this.txtBxRes.Location = new System.Drawing.Point(679, 128);
            this.txtBxRes.Name = "txtBxRes";
            this.txtBxRes.Size = new System.Drawing.Size(564, 22);
            this.txtBxRes.TabIndex = 8;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(676, 84);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(45, 16);
            this.lblRes.TabIndex = 9;
            this.lblRes.Text = "Result";
            // 
            // cmdSmallest
            // 
            this.cmdSmallest.AutoSize = true;
            this.cmdSmallest.Location = new System.Drawing.Point(352, 235);
            this.cmdSmallest.Name = "cmdSmallest";
            this.cmdSmallest.Size = new System.Drawing.Size(75, 26);
            this.cmdSmallest.TabIndex = 11;
            this.cmdSmallest.Text = "Calculate";
            this.cmdSmallest.UseVisualStyleBackColor = true;
            this.cmdSmallest.Click += new System.EventHandler(this.cmdSmallest_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(352, 305);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 13;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 450);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdSmallest);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtBxRes);
            this.Controls.Add(this.txtBxWhich);
            this.Controls.Add(this.lblObjChoose);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtBx3);
            this.Controls.Add(this.txtBx2);
            this.Controls.Add(this.txtBx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx1;
        private System.Windows.Forms.TextBox txtBx2;
        private System.Windows.Forms.TextBox txtBx3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblObjChoose;
        private System.Windows.Forms.TextBox txtBxWhich;
        private System.Windows.Forms.TextBox txtBxRes;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Button cmdSmallest;
        private System.Windows.Forms.Button cmdSave;
    }
}

