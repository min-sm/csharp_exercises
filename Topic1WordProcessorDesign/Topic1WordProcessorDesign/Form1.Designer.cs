namespace Topic1WordProcessorDesign
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
            this.cmdBold = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmdItalic = new System.Windows.Forms.Button();
            this.cmdStrikeThrough = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdUnderline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdBold
            // 
            this.cmdBold.AutoSize = true;
            this.cmdBold.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBold.Location = new System.Drawing.Point(58, 28);
            this.cmdBold.Name = "cmdBold";
            this.cmdBold.Size = new System.Drawing.Size(58, 56);
            this.cmdBold.TabIndex = 0;
            this.cmdBold.Text = "B";
            this.cmdBold.UseVisualStyleBackColor = false;
            this.cmdBold.Click += new System.EventHandler(this.cmdBold_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Arial",
            "Broadway",
            "Calibri"});
            this.comboBox1.Location = new System.Drawing.Point(136, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select Font";
            // 
            // cmdItalic
            // 
            this.cmdItalic.AutoSize = true;
            this.cmdItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdItalic.Location = new System.Drawing.Point(282, 28);
            this.cmdItalic.Name = "cmdItalic";
            this.cmdItalic.Size = new System.Drawing.Size(40, 56);
            this.cmdItalic.TabIndex = 2;
            this.cmdItalic.Text = "𝑖";
            this.cmdItalic.UseVisualStyleBackColor = true;
            this.cmdItalic.Click += new System.EventHandler(this.cmdItalic_Click);
            // 
            // cmdStrikeThrough
            // 
            this.cmdStrikeThrough.AutoSize = true;
            this.cmdStrikeThrough.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdStrikeThrough.Location = new System.Drawing.Point(411, 35);
            this.cmdStrikeThrough.Name = "cmdStrikeThrough";
            this.cmdStrikeThrough.Size = new System.Drawing.Size(70, 42);
            this.cmdStrikeThrough.TabIndex = 3;
            this.cmdStrikeThrough.Text = "abc";
            this.cmdStrikeThrough.UseVisualStyleBackColor = true;
            this.cmdStrikeThrough.Click += new System.EventHandler(this.cmdStrikeThrough_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.comboBox2.Location = new System.Drawing.Point(136, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.Text = "Select font size";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(365, 225);
            this.textBox1.TabIndex = 5;
            // 
            // cmdUnderline
            // 
            this.cmdUnderline.AutoSize = true;
            this.cmdUnderline.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUnderline.Location = new System.Drawing.Point(342, 28);
            this.cmdUnderline.Name = "cmdUnderline";
            this.cmdUnderline.Size = new System.Drawing.Size(44, 56);
            this.cmdUnderline.TabIndex = 6;
            this.cmdUnderline.Text = "U";
            this.cmdUnderline.UseVisualStyleBackColor = true;
            this.cmdUnderline.Click += new System.EventHandler(this.cmdUnderline_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdUnderline);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.cmdStrikeThrough);
            this.Controls.Add(this.cmdItalic);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmdBold);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBold;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cmdItalic;
        private System.Windows.Forms.Button cmdStrikeThrough;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdUnderline;
    }
}

