namespace Topic6Task
{
    partial class FrmCashMachine
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
            this.cmdBalance = new System.Windows.Forms.Button();
            this.cmdWithdrawl = new System.Windows.Forms.Button();
            this.cmdReceipt = new System.Windows.Forms.Button();
            this.cmdDeny = new System.Windows.Forms.Button();
            this.cmdConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmd7 = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmdC = new System.Windows.Forms.Button();
            this.cmd0 = new System.Windows.Forms.Button();
            this.cmdA = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdBalance
            // 
            this.cmdBalance.Location = new System.Drawing.Point(0, 0);
            this.cmdBalance.Name = "cmdBalance";
            this.cmdBalance.Size = new System.Drawing.Size(123, 60);
            this.cmdBalance.TabIndex = 0;
            this.cmdBalance.Text = "Balance";
            this.cmdBalance.UseVisualStyleBackColor = true;
            this.cmdBalance.Click += new System.EventHandler(this.cmdBalance_Click);
            // 
            // cmdWithdrawl
            // 
            this.cmdWithdrawl.Location = new System.Drawing.Point(0, 60);
            this.cmdWithdrawl.Name = "cmdWithdrawl";
            this.cmdWithdrawl.Size = new System.Drawing.Size(123, 60);
            this.cmdWithdrawl.TabIndex = 1;
            this.cmdWithdrawl.Text = "Withdrawl";
            this.cmdWithdrawl.UseVisualStyleBackColor = true;
            this.cmdWithdrawl.Click += new System.EventHandler(this.cmdWithdrawl_Click);
            // 
            // cmdReceipt
            // 
            this.cmdReceipt.Location = new System.Drawing.Point(0, 120);
            this.cmdReceipt.Name = "cmdReceipt";
            this.cmdReceipt.Size = new System.Drawing.Size(123, 60);
            this.cmdReceipt.TabIndex = 2;
            this.cmdReceipt.Text = "Withdraw with Receipt";
            this.cmdReceipt.UseVisualStyleBackColor = true;
            this.cmdReceipt.Click += new System.EventHandler(this.cmdReceipt_Click);
            // 
            // cmdDeny
            // 
            this.cmdDeny.Location = new System.Drawing.Point(0, 240);
            this.cmdDeny.Name = "cmdDeny";
            this.cmdDeny.Size = new System.Drawing.Size(123, 60);
            this.cmdDeny.TabIndex = 4;
            this.cmdDeny.Text = "Deny";
            this.cmdDeny.UseVisualStyleBackColor = true;
            this.cmdDeny.Click += new System.EventHandler(this.cmdDeny_Click);
            // 
            // cmdConfirm
            // 
            this.cmdConfirm.Location = new System.Drawing.Point(0, 180);
            this.cmdConfirm.Name = "cmdConfirm";
            this.cmdConfirm.Size = new System.Drawing.Size(123, 60);
            this.cmdConfirm.TabIndex = 3;
            this.cmdConfirm.Text = "Confirm";
            this.cmdConfirm.UseVisualStyleBackColor = true;
            this.cmdConfirm.Click += new System.EventHandler(this.cmdConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lblOutput);
            this.panel1.Controls.Add(this.lblDisplay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmdBalance);
            this.panel1.Controls.Add(this.cmdDeny);
            this.panel1.Controls.Add(this.cmdWithdrawl);
            this.panel1.Controls.Add(this.cmdConfirm);
            this.panel1.Controls.Add(this.cmdReceipt);
            this.panel1.Location = new System.Drawing.Point(49, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 300);
            this.panel1.TabIndex = 5;
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDisplay.Location = new System.Drawing.Point(148, 105);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(355, 29);
            this.lblDisplay.TabIndex = 6;
            this.lblDisplay.Text = "Enter Your Pin Number to login.";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(220, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Money Marketplace";
            // 
            // cmd7
            // 
            this.cmd7.Location = new System.Drawing.Point(604, 153);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(50, 50);
            this.cmd7.TabIndex = 6;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // cmd8
            // 
            this.cmd8.Location = new System.Drawing.Point(660, 153);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(50, 50);
            this.cmd8.TabIndex = 7;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            this.cmd8.Click += new System.EventHandler(this.cmd8_Click);
            // 
            // cmd9
            // 
            this.cmd9.Location = new System.Drawing.Point(716, 153);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(50, 50);
            this.cmd9.TabIndex = 8;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmd3
            // 
            this.cmd3.Location = new System.Drawing.Point(716, 265);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(50, 50);
            this.cmd3.TabIndex = 11;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(660, 265);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(50, 50);
            this.cmd2.TabIndex = 10;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(604, 265);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(50, 50);
            this.cmd1.TabIndex = 9;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd6
            // 
            this.cmd6.Location = new System.Drawing.Point(716, 209);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(50, 50);
            this.cmd6.TabIndex = 14;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd5
            // 
            this.cmd5.Location = new System.Drawing.Point(660, 209);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(50, 50);
            this.cmd5.TabIndex = 13;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmd4
            // 
            this.cmd4.Location = new System.Drawing.Point(604, 209);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(50, 50);
            this.cmd4.TabIndex = 12;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmdC
            // 
            this.cmdC.Location = new System.Drawing.Point(716, 321);
            this.cmdC.Name = "cmdC";
            this.cmdC.Size = new System.Drawing.Size(50, 50);
            this.cmdC.TabIndex = 17;
            this.cmdC.Text = "C";
            this.cmdC.UseVisualStyleBackColor = true;
            this.cmdC.Click += new System.EventHandler(this.cmdC_Click);
            // 
            // cmd0
            // 
            this.cmd0.Location = new System.Drawing.Point(660, 321);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(50, 50);
            this.cmd0.TabIndex = 16;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // cmdA
            // 
            this.cmdA.Location = new System.Drawing.Point(604, 321);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(50, 50);
            this.cmdA.TabIndex = 15;
            this.cmdA.Text = "A";
            this.cmdA.UseVisualStyleBackColor = true;
            // 
            // txtText
            // 
            this.txtText.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtText.ForeColor = System.Drawing.SystemColors.Window;
            this.txtText.Location = new System.Drawing.Point(605, 89);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(160, 22);
            this.txtText.TabIndex = 18;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOutput.Location = new System.Drawing.Point(150, 176);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(118, 42);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "label2";
            // 
            // FrmCashMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.cmdC);
            this.Controls.Add(this.cmd0);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.cmd6);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.cmd9);
            this.Controls.Add(this.cmd8);
            this.Controls.Add(this.cmd7);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCashMachine";
            this.Text = "Cash Machine";
            this.Load += new System.EventHandler(this.FrmCashMachine_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBalance;
        private System.Windows.Forms.Button cmdWithdrawl;
        private System.Windows.Forms.Button cmdReceipt;
        private System.Windows.Forms.Button cmdDeny;
        private System.Windows.Forms.Button cmdConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd7;
        private System.Windows.Forms.Button cmd8;
        private System.Windows.Forms.Button cmd9;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd6;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmdC;
        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblOutput;
    }
}

