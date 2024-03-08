namespace Topic5Tasks
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBxWhichOne = new System.Windows.Forms.ComboBox();
            this.cmdDisplay = new System.Windows.Forms.Button();
            this.lblDisplayBookNo = new System.Windows.Forms.Label();
            this.lblDisplayAuthor = new System.Windows.Forms.Label();
            this.lblDisplayTitle = new System.Windows.Forms.Label();
            this.lblDisplayIsbn = new System.Windows.Forms.Label();
            this.lblDisplayGenre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBxGenre
            // 
            this.comboBxGenre.FormattingEnabled = true;
            this.comboBxGenre.Location = new System.Drawing.Point(194, 237);
            this.comboBxGenre.Name = "comboBxGenre";
            this.comboBxGenre.Size = new System.Drawing.Size(222, 24);
            this.comboBxGenre.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(86, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(33, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // cmdSave
            // 
            this.cmdSave.AutoSize = true;
            this.cmdSave.Location = new System.Drawing.Point(80, 412);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 26);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(194, 44);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(194, 105);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(86, 111);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(45, 16);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(194, 173);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(100, 22);
            this.txtIsbn.TabIndex = 7;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(86, 179);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(38, 16);
            this.lblIsbn.TabIndex = 6;
            this.lblIsbn.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Genre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Which Book?";
            // 
            // comboBxWhichOne
            // 
            this.comboBxWhichOne.FormattingEnabled = true;
            this.comboBxWhichOne.Location = new System.Drawing.Point(194, 307);
            this.comboBxWhichOne.Name = "comboBxWhichOne";
            this.comboBxWhichOne.Size = new System.Drawing.Size(200, 24);
            this.comboBxWhichOne.TabIndex = 9;
            // 
            // cmdDisplay
            // 
            this.cmdDisplay.AutoSize = true;
            this.cmdDisplay.Location = new System.Drawing.Point(219, 412);
            this.cmdDisplay.Name = "cmdDisplay";
            this.cmdDisplay.Size = new System.Drawing.Size(75, 26);
            this.cmdDisplay.TabIndex = 11;
            this.cmdDisplay.Text = "Display";
            this.cmdDisplay.UseVisualStyleBackColor = true;
            this.cmdDisplay.Click += new System.EventHandler(this.cmdDisplay_Click);
            // 
            // lblDisplayBookNo
            // 
            this.lblDisplayBookNo.AutoSize = true;
            this.lblDisplayBookNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayBookNo.Location = new System.Drawing.Point(503, 40);
            this.lblDisplayBookNo.Name = "lblDisplayBookNo";
            this.lblDisplayBookNo.Size = new System.Drawing.Size(119, 29);
            this.lblDisplayBookNo.TabIndex = 12;
            this.lblDisplayBookNo.Text = "Book No: ";
            // 
            // lblDisplayAuthor
            // 
            this.lblDisplayAuthor.AutoSize = true;
            this.lblDisplayAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayAuthor.Location = new System.Drawing.Point(503, 166);
            this.lblDisplayAuthor.Name = "lblDisplayAuthor";
            this.lblDisplayAuthor.Size = new System.Drawing.Size(94, 29);
            this.lblDisplayAuthor.TabIndex = 13;
            this.lblDisplayAuthor.Text = "Author: ";
            // 
            // lblDisplayTitle
            // 
            this.lblDisplayTitle.AutoSize = true;
            this.lblDisplayTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTitle.Location = new System.Drawing.Point(503, 101);
            this.lblDisplayTitle.Name = "lblDisplayTitle";
            this.lblDisplayTitle.Size = new System.Drawing.Size(73, 29);
            this.lblDisplayTitle.TabIndex = 14;
            this.lblDisplayTitle.Text = "Title: ";
            // 
            // lblDisplayIsbn
            // 
            this.lblDisplayIsbn.AutoSize = true;
            this.lblDisplayIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayIsbn.Location = new System.Drawing.Point(503, 237);
            this.lblDisplayIsbn.Name = "lblDisplayIsbn";
            this.lblDisplayIsbn.Size = new System.Drawing.Size(81, 29);
            this.lblDisplayIsbn.TabIndex = 15;
            this.lblDisplayIsbn.Text = "ISBN: ";
            // 
            // lblDisplayGenre
            // 
            this.lblDisplayGenre.AutoSize = true;
            this.lblDisplayGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayGenre.Location = new System.Drawing.Point(503, 307);
            this.lblDisplayGenre.Name = "lblDisplayGenre";
            this.lblDisplayGenre.Size = new System.Drawing.Size(92, 29);
            this.lblDisplayGenre.TabIndex = 16;
            this.lblDisplayGenre.Text = "Genre: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplayGenre);
            this.Controls.Add(this.lblDisplayIsbn);
            this.Controls.Add(this.lblDisplayTitle);
            this.Controls.Add(this.lblDisplayAuthor);
            this.Controls.Add(this.lblDisplayBookNo);
            this.Controls.Add(this.cmdDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBxWhichOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.comboBxGenre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBxGenre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBxWhichOne;
        private System.Windows.Forms.Button cmdDisplay;
        private System.Windows.Forms.Label lblDisplayBookNo;
        private System.Windows.Forms.Label lblDisplayAuthor;
        private System.Windows.Forms.Label lblDisplayTitle;
        private System.Windows.Forms.Label lblDisplayIsbn;
        private System.Windows.Forms.Label lblDisplayGenre;
    }
}

