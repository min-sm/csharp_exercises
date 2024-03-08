namespace Topic5Test
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtYouTyped = new System.Windows.Forms.TextBox();
            this.cmdStore = new System.Windows.Forms.Button();
            this.cmdDisplay = new System.Windows.Forms.Button();
            this.lblAgeAdjustment = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWhich = new System.Windows.Forms.TextBox();
            this.cmdAdjust = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(102, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(102, 108);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "You typed:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(214, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(214, 105);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 4;
            // 
            // txtYouTyped
            // 
            this.txtYouTyped.Location = new System.Drawing.Point(214, 265);
            this.txtYouTyped.Name = "txtYouTyped";
            this.txtYouTyped.Size = new System.Drawing.Size(100, 22);
            this.txtYouTyped.TabIndex = 5;
            // 
            // cmdStore
            // 
            this.cmdStore.AutoSize = true;
            this.cmdStore.Location = new System.Drawing.Point(160, 383);
            this.cmdStore.Name = "cmdStore";
            this.cmdStore.Size = new System.Drawing.Size(94, 26);
            this.cmdStore.TabIndex = 6;
            this.cmdStore.Text = "Store Details";
            this.cmdStore.UseVisualStyleBackColor = true;
            this.cmdStore.Click += new System.EventHandler(this.cmdStore_Click);
            // 
            // cmdDisplay
            // 
            this.cmdDisplay.AutoSize = true;
            this.cmdDisplay.Location = new System.Drawing.Point(273, 383);
            this.cmdDisplay.Name = "cmdDisplay";
            this.cmdDisplay.Size = new System.Drawing.Size(75, 26);
            this.cmdDisplay.TabIndex = 7;
            this.cmdDisplay.Text = "Display";
            this.cmdDisplay.UseVisualStyleBackColor = true;
            this.cmdDisplay.Click += new System.EventHandler(this.cmdDisplay_Click);
            // 
            // lblAgeAdjustment
            // 
            this.lblAgeAdjustment.AutoSize = true;
            this.lblAgeAdjustment.Location = new System.Drawing.Point(72, 155);
            this.lblAgeAdjustment.Name = "lblAgeAdjustment";
            this.lblAgeAdjustment.Size = new System.Drawing.Size(101, 16);
            this.lblAgeAdjustment.TabIndex = 8;
            this.lblAgeAdjustment.Text = "Age Adjustment";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(214, 149);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Which One?";
            // 
            // txtWhich
            // 
            this.txtWhich.Location = new System.Drawing.Point(214, 200);
            this.txtWhich.Name = "txtWhich";
            this.txtWhich.Size = new System.Drawing.Size(100, 22);
            this.txtWhich.TabIndex = 11;
            // 
            // cmdAdjust
            // 
            this.cmdAdjust.AutoSize = true;
            this.cmdAdjust.Location = new System.Drawing.Point(376, 383);
            this.cmdAdjust.Name = "cmdAdjust";
            this.cmdAdjust.Size = new System.Drawing.Size(82, 26);
            this.cmdAdjust.TabIndex = 12;
            this.cmdAdjust.Text = "Adjust Age";
            this.cmdAdjust.UseVisualStyleBackColor = true;
            this.cmdAdjust.Click += new System.EventHandler(this.cmdAdjust_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdAdjust);
            this.Controls.Add(this.txtWhich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAgeAdjustment);
            this.Controls.Add(this.cmdDisplay);
            this.Controls.Add(this.cmdStore);
            this.Controls.Add(this.txtYouTyped);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtYouTyped;
        private System.Windows.Forms.Button cmdStore;
        private System.Windows.Forms.Button cmdDisplay;
        private System.Windows.Forms.Label lblAgeAdjustment;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWhich;
        private System.Windows.Forms.Button cmdAdjust;
    }
}

