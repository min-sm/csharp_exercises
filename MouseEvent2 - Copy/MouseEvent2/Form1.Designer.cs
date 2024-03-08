namespace MouseEvent2
{
    partial class frmMouse
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
            this.lblMouse = new System.Windows.Forms.Label();
            this.btnOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Location = new System.Drawing.Point(185, 114);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(44, 16);
            this.lblMouse.TabIndex = 0;
            this.lblMouse.Text = "label1";
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(236, 195);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(193, 58);
            this.btnOne.TabIndex = 1;
            this.btnOne.Text = "button1";
            this.btnOne.UseVisualStyleBackColor = true;
            // this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // this.btnOne.MouseMove += new System.EventHandler(this.btnOne_MouseMove);
            // 
            // frmMouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.lblMouse);
            this.Name = "frmMouse";
            this.Text = "frmMouse";
            this.Load += new System.EventHandler(this.frmMouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMouse;
        private System.Windows.Forms.Button btnOne;
    }
}

