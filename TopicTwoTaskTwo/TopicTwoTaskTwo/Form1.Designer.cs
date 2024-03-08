namespace TopicTwoTaskTwo
{
    partial class frmRunAway
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
            this.cmdRunAway = new System.Windows.Forms.Button();
            this.lblOne = new System.Windows.Forms.Label();
            this.cmdYes = new System.Windows.Forms.Button();
            this.lblAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdRunAway
            // 
            this.cmdRunAway.Location = new System.Drawing.Point(413, 200);
            this.cmdRunAway.Name = "cmdRunAway";
            this.cmdRunAway.Size = new System.Drawing.Size(150, 50);
            this.cmdRunAway.TabIndex = 0;
            this.cmdRunAway.Text = "No";
            this.cmdRunAway.UseVisualStyleBackColor = true;
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(343, 114);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(94, 29);
            this.lblOne.TabIndex = 1;
            this.lblOne.Text = "Chit Lr?";
            // 
            // cmdYes
            // 
            this.cmdYes.Location = new System.Drawing.Point(192, 200);
            this.cmdYes.Name = "cmdYes";
            this.cmdYes.Size = new System.Drawing.Size(150, 50);
            this.cmdYes.TabIndex = 2;
            this.cmdYes.Text = "Yes";
            this.cmdYes.UseVisualStyleBackColor = true;
            this.cmdYes.Click += new System.EventHandler(this.cmdYes_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAns.ForeColor = System.Drawing.Color.Red;
            this.lblAns.Location = new System.Drawing.Point(246, 301);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(285, 38);
            this.lblAns.TabIndex = 3;
            this.lblAns.Text = "Love you too babe";
            this.lblAns.Visible = false;
            // 
            // frmRunAway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.cmdYes);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.cmdRunAway);
            this.Name = "frmRunAway";
            this.Text = "frmRunAway";
            this.Load += new System.EventHandler(this.frmRunAway_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRunAway;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Button cmdYes;
        private System.Windows.Forms.Label lblAns;
    }
}

