namespace Topic5TasksTest
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
            this.comboBxGenre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBxGenre
            // 
            this.comboBxGenre.FormattingEnabled = true;
            this.comboBxGenre.Location = new System.Drawing.Point(207, 168);
            this.comboBxGenre.Name = "comboBxGenre";
            this.comboBxGenre.Size = new System.Drawing.Size(121, 24);
            this.comboBxGenre.TabIndex = 0;
            // this.comboBxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBxGenre_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBxGenre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBxGenre;
    }
}

