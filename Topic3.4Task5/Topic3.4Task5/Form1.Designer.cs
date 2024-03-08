namespace Topic3._4Task5
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
            this.txtBx = new System.Windows.Forms.TextBox();
            this.cmdCheck = new System.Windows.Forms.Button();
            this.txtBx1 = new System.Windows.Forms.TextBox();
            this.txtBx2 = new System.Windows.Forms.TextBox();
            this.lblHighestMark = new System.Windows.Forms.Label();
            this.lblSub1 = new System.Windows.Forms.Label();
            this.lblSub2 = new System.Windows.Forms.Label();
            this.lblSub3 = new System.Windows.Forms.Label();
            this.lblSub1Mark = new System.Windows.Forms.Label();
            this.lblSub2Mark = new System.Windows.Forms.Label();
            this.lblSub3Mark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(355, 185);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(100, 22);
            this.txtBx.TabIndex = 0;
            // 
            // cmdCheck
            // 
            this.cmdCheck.Location = new System.Drawing.Point(367, 222);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(75, 23);
            this.cmdCheck.TabIndex = 1;
            this.cmdCheck.Text = "Check";
            this.cmdCheck.UseVisualStyleBackColor = true;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // txtBx1
            // 
            this.txtBx1.Location = new System.Drawing.Point(494, 185);
            this.txtBx1.Name = "txtBx1";
            this.txtBx1.Size = new System.Drawing.Size(100, 22);
            this.txtBx1.TabIndex = 2;
            // 
            // txtBx2
            // 
            this.txtBx2.Location = new System.Drawing.Point(207, 185);
            this.txtBx2.Name = "txtBx2";
            this.txtBx2.Size = new System.Drawing.Size(100, 22);
            this.txtBx2.TabIndex = 3;
            // 
            // lblHighestMark
            // 
            this.lblHighestMark.AutoSize = true;
            this.lblHighestMark.Location = new System.Drawing.Point(204, 313);
            this.lblHighestMark.Name = "lblHighestMark";
            this.lblHighestMark.Size = new System.Drawing.Size(102, 16);
            this.lblHighestMark.TabIndex = 4;
            this.lblHighestMark.Text = "Highest Mark is ";
            // 
            // lblSub1
            // 
            this.lblSub1.AutoSize = true;
            this.lblSub1.Location = new System.Drawing.Point(352, 149);
            this.lblSub1.Name = "lblSub1";
            this.lblSub1.Size = new System.Drawing.Size(62, 16);
            this.lblSub1.TabIndex = 5;
            this.lblSub1.Text = "Subject 1";
            // 
            // lblSub2
            // 
            this.lblSub2.AutoSize = true;
            this.lblSub2.Location = new System.Drawing.Point(491, 149);
            this.lblSub2.Name = "lblSub2";
            this.lblSub2.Size = new System.Drawing.Size(62, 16);
            this.lblSub2.TabIndex = 6;
            this.lblSub2.Text = "Subject 2";
            // 
            // lblSub3
            // 
            this.lblSub3.AutoSize = true;
            this.lblSub3.Location = new System.Drawing.Point(204, 149);
            this.lblSub3.Name = "lblSub3";
            this.lblSub3.Size = new System.Drawing.Size(62, 16);
            this.lblSub3.TabIndex = 7;
            this.lblSub3.Text = "Subject 3";
            // 
            // lblSub1Mark
            // 
            this.lblSub1Mark.AutoSize = true;
            this.lblSub1Mark.Location = new System.Drawing.Point(204, 351);
            this.lblSub1Mark.Name = "lblSub1Mark";
            this.lblSub1Mark.Size = new System.Drawing.Size(111, 16);
            this.lblSub1Mark.TabIndex = 8;
            this.lblSub1Mark.Text = "Subject 1 Mark is ";
            // 
            // lblSub2Mark
            // 
            this.lblSub2Mark.AutoSize = true;
            this.lblSub2Mark.Location = new System.Drawing.Point(204, 389);
            this.lblSub2Mark.Name = "lblSub2Mark";
            this.lblSub2Mark.Size = new System.Drawing.Size(111, 16);
            this.lblSub2Mark.TabIndex = 9;
            this.lblSub2Mark.Text = "Subject 2 Mark is ";
            // 
            // lblSub3Mark
            // 
            this.lblSub3Mark.AutoSize = true;
            this.lblSub3Mark.Location = new System.Drawing.Point(204, 425);
            this.lblSub3Mark.Name = "lblSub3Mark";
            this.lblSub3Mark.Size = new System.Drawing.Size(111, 16);
            this.lblSub3Mark.TabIndex = 10;
            this.lblSub3Mark.Text = "Subject 3 Mark is ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSub3Mark);
            this.Controls.Add(this.lblSub2Mark);
            this.Controls.Add(this.lblSub1Mark);
            this.Controls.Add(this.lblSub3);
            this.Controls.Add(this.lblSub2);
            this.Controls.Add(this.lblSub1);
            this.Controls.Add(this.lblHighestMark);
            this.Controls.Add(this.txtBx2);
            this.Controls.Add(this.txtBx1);
            this.Controls.Add(this.cmdCheck);
            this.Controls.Add(this.txtBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.TextBox txtBx1;
        private System.Windows.Forms.TextBox txtBx2;
        private System.Windows.Forms.Label lblHighestMark;
        private System.Windows.Forms.Label lblSub1;
        private System.Windows.Forms.Label lblSub2;
        private System.Windows.Forms.Label lblSub3;
        private System.Windows.Forms.Label lblSub1Mark;
        private System.Windows.Forms.Label lblSub2Mark;
        private System.Windows.Forms.Label lblSub3Mark;
    }
}

