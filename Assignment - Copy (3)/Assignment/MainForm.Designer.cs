namespace Assignment
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTargetCalories = new System.Windows.Forms.Label();
            this.lblYourWeight = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActivitiesTitle = new System.Windows.Forms.Label();
            this.chkBxWalking = new System.Windows.Forms.CheckBox();
            this.gpBxWalking = new System.Windows.Forms.GroupBox();
            this.txtWalkingTimeTaken = new System.Windows.Forms.TextBox();
            this.lblWalkingTimeTaken = new System.Windows.Forms.Label();
            this.txtWalkingDistance = new System.Windows.Forms.TextBox();
            this.lblWalkingDistance = new System.Windows.Forms.Label();
            this.txtWalkingSteps = new System.Windows.Forms.TextBox();
            this.lblWalkingSteps = new System.Windows.Forms.Label();
            this.gpBxSwimming = new System.Windows.Forms.GroupBox();
            this.txtSwimmingHeartRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSwimmingTimeTaken = new System.Windows.Forms.TextBox();
            this.lblSwimmingTimeTaken = new System.Windows.Forms.Label();
            this.txtSwimmingNumOfLap = new System.Windows.Forms.TextBox();
            this.lblSwimmingNumOfLaps = new System.Windows.Forms.Label();
            this.chkBxSwimming = new System.Windows.Forms.CheckBox();
            this.gpBxBicycle = new System.Windows.Forms.GroupBox();
            this.txtBicyclingHeartRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBicyclingTimeTaken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBicycleDistance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBxBicycling = new System.Windows.Forms.CheckBox();
            this.gpBxTennis = new System.Windows.Forms.GroupBox();
            this.txtTennisHeartRate = new System.Windows.Forms.TextBox();
            this.txtTennisTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxTennisNumOfServes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkBxTennis = new System.Windows.Forms.CheckBox();
            this.gpBxBasketball = new System.Windows.Forms.GroupBox();
            this.txtBxBasketballHeartRate = new System.Windows.Forms.TextBox();
            this.txtBxBasketballTimeTaken = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblBasketBallHeartRate = new System.Windows.Forms.Label();
            this.txtBxBasketballNumOfShots = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkBxBasketball = new System.Windows.Forms.CheckBox();
            this.gpBxWrestling = new System.Windows.Forms.GroupBox();
            this.txtBxWrestlingHeartRate = new System.Windows.Forms.TextBox();
            this.txtBxWrestlingTimeTaken = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBxWrestlingNumOfTakeDown = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkBxWrestling = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.txtNewWeight = new System.Windows.Forms.TextBox();
            this.txtNewTargetCalories = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.cmdUserGuide = new System.Windows.Forms.Button();
            this.lblUserGuide = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpBxWalking.SuspendLayout();
            this.gpBxSwimming.SuspendLayout();
            this.gpBxBicycle.SuspendLayout();
            this.gpBxTennis.SuspendLayout();
            this.gpBxBasketball.SuspendLayout();
            this.gpBxWrestling.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(18, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(150, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, ";
            // 
            // lblTargetCalories
            // 
            this.lblTargetCalories.AutoSize = true;
            this.lblTargetCalories.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTargetCalories.Location = new System.Drawing.Point(19, 108);
            this.lblTargetCalories.Name = "lblTargetCalories";
            this.lblTargetCalories.Size = new System.Drawing.Size(161, 23);
            this.lblTargetCalories.TabIndex = 1;
            this.lblTargetCalories.Text = "Your target calories:";
            // 
            // lblYourWeight
            // 
            this.lblYourWeight.AutoSize = true;
            this.lblYourWeight.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourWeight.Location = new System.Drawing.Point(19, 178);
            this.lblYourWeight.Name = "lblYourWeight";
            this.lblYourWeight.Size = new System.Drawing.Size(105, 23);
            this.lblYourWeight.TabIndex = 3;
            this.lblYourWeight.Text = "Your weight:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.lblTargetCalories);
            this.panel1.Controls.Add(this.lblYourWeight);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 244);
            this.panel1.TabIndex = 5;
            // 
            // lblActivitiesTitle
            // 
            this.lblActivitiesTitle.AutoSize = true;
            this.lblActivitiesTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivitiesTitle.Location = new System.Drawing.Point(327, 22);
            this.lblActivitiesTitle.Name = "lblActivitiesTitle";
            this.lblActivitiesTitle.Size = new System.Drawing.Size(145, 28);
            this.lblActivitiesTitle.TabIndex = 5;
            this.lblActivitiesTitle.Text = "Activities";
            // 
            // chkBxWalking
            // 
            this.chkBxWalking.AutoSize = true;
            this.chkBxWalking.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxWalking.Location = new System.Drawing.Point(336, 133);
            this.chkBxWalking.Name = "chkBxWalking";
            this.chkBxWalking.Size = new System.Drawing.Size(92, 27);
            this.chkBxWalking.TabIndex = 6;
            this.chkBxWalking.Text = "Walking";
            this.chkBxWalking.UseVisualStyleBackColor = true;
            this.chkBxWalking.CheckedChanged += new System.EventHandler(this.chkBxWalking_CheckedChanged);
            // 
            // gpBxWalking
            // 
            this.gpBxWalking.Controls.Add(this.txtWalkingTimeTaken);
            this.gpBxWalking.Controls.Add(this.lblWalkingTimeTaken);
            this.gpBxWalking.Controls.Add(this.txtWalkingDistance);
            this.gpBxWalking.Controls.Add(this.lblWalkingDistance);
            this.gpBxWalking.Controls.Add(this.txtWalkingSteps);
            this.gpBxWalking.Controls.Add(this.lblWalkingSteps);
            this.gpBxWalking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBxWalking.Location = new System.Drawing.Point(336, 179);
            this.gpBxWalking.Name = "gpBxWalking";
            this.gpBxWalking.Size = new System.Drawing.Size(150, 295);
            this.gpBxWalking.TabIndex = 7;
            this.gpBxWalking.TabStop = false;
            this.gpBxWalking.Text = "Metrics";
            this.gpBxWalking.Visible = false;
            // 
            // txtWalkingTimeTaken
            // 
            this.txtWalkingTimeTaken.Location = new System.Drawing.Point(19, 244);
            this.txtWalkingTimeTaken.Name = "txtWalkingTimeTaken";
            this.txtWalkingTimeTaken.Size = new System.Drawing.Size(100, 27);
            this.txtWalkingTimeTaken.TabIndex = 5;
            // 
            // lblWalkingTimeTaken
            // 
            this.lblWalkingTimeTaken.AutoSize = true;
            this.lblWalkingTimeTaken.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWalkingTimeTaken.Location = new System.Drawing.Point(16, 208);
            this.lblWalkingTimeTaken.Name = "lblWalkingTimeTaken";
            this.lblWalkingTimeTaken.Size = new System.Drawing.Size(73, 17);
            this.lblWalkingTimeTaken.TabIndex = 4;
            this.lblWalkingTimeTaken.Text = "Time Taken";
            // 
            // txtWalkingDistance
            // 
            this.txtWalkingDistance.Location = new System.Drawing.Point(19, 155);
            this.txtWalkingDistance.Name = "txtWalkingDistance";
            this.txtWalkingDistance.Size = new System.Drawing.Size(100, 27);
            this.txtWalkingDistance.TabIndex = 3;
            // 
            // lblWalkingDistance
            // 
            this.lblWalkingDistance.AutoSize = true;
            this.lblWalkingDistance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWalkingDistance.Location = new System.Drawing.Point(16, 119);
            this.lblWalkingDistance.Name = "lblWalkingDistance";
            this.lblWalkingDistance.Size = new System.Drawing.Size(57, 17);
            this.lblWalkingDistance.TabIndex = 2;
            this.lblWalkingDistance.Text = "Distance";
            // 
            // txtWalkingSteps
            // 
            this.txtWalkingSteps.Location = new System.Drawing.Point(19, 73);
            this.txtWalkingSteps.Name = "txtWalkingSteps";
            this.txtWalkingSteps.Size = new System.Drawing.Size(100, 27);
            this.txtWalkingSteps.TabIndex = 1;
            // 
            // lblWalkingSteps
            // 
            this.lblWalkingSteps.AutoSize = true;
            this.lblWalkingSteps.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWalkingSteps.Location = new System.Drawing.Point(16, 37);
            this.lblWalkingSteps.Name = "lblWalkingSteps";
            this.lblWalkingSteps.Size = new System.Drawing.Size(40, 17);
            this.lblWalkingSteps.TabIndex = 0;
            this.lblWalkingSteps.Text = "Steps";
            // 
            // gpBxSwimming
            // 
            this.gpBxSwimming.Controls.Add(this.txtSwimmingHeartRate);
            this.gpBxSwimming.Controls.Add(this.label1);
            this.gpBxSwimming.Controls.Add(this.txtSwimmingTimeTaken);
            this.gpBxSwimming.Controls.Add(this.lblSwimmingTimeTaken);
            this.gpBxSwimming.Controls.Add(this.txtSwimmingNumOfLap);
            this.gpBxSwimming.Controls.Add(this.lblSwimmingNumOfLaps);
            this.gpBxSwimming.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBxSwimming.Location = new System.Drawing.Point(533, 179);
            this.gpBxSwimming.Name = "gpBxSwimming";
            this.gpBxSwimming.Size = new System.Drawing.Size(150, 295);
            this.gpBxSwimming.TabIndex = 9;
            this.gpBxSwimming.TabStop = false;
            this.gpBxSwimming.Text = "Metrics";
            this.gpBxSwimming.Visible = false;
            // 
            // txtSwimmingHeartRate
            // 
            this.txtSwimmingHeartRate.Location = new System.Drawing.Point(19, 244);
            this.txtSwimmingHeartRate.Name = "txtSwimmingHeartRate";
            this.txtSwimmingHeartRate.Size = new System.Drawing.Size(100, 27);
            this.txtSwimmingHeartRate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Heart Rate";
            // 
            // txtSwimmingTimeTaken
            // 
            this.txtSwimmingTimeTaken.Location = new System.Drawing.Point(19, 155);
            this.txtSwimmingTimeTaken.Name = "txtSwimmingTimeTaken";
            this.txtSwimmingTimeTaken.Size = new System.Drawing.Size(100, 27);
            this.txtSwimmingTimeTaken.TabIndex = 3;
            // 
            // lblSwimmingTimeTaken
            // 
            this.lblSwimmingTimeTaken.AutoSize = true;
            this.lblSwimmingTimeTaken.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmingTimeTaken.Location = new System.Drawing.Point(16, 119);
            this.lblSwimmingTimeTaken.Name = "lblSwimmingTimeTaken";
            this.lblSwimmingTimeTaken.Size = new System.Drawing.Size(73, 17);
            this.lblSwimmingTimeTaken.TabIndex = 2;
            this.lblSwimmingTimeTaken.Text = "Time Taken";
            // 
            // txtSwimmingNumOfLap
            // 
            this.txtSwimmingNumOfLap.Location = new System.Drawing.Point(19, 73);
            this.txtSwimmingNumOfLap.Name = "txtSwimmingNumOfLap";
            this.txtSwimmingNumOfLap.Size = new System.Drawing.Size(100, 27);
            this.txtSwimmingNumOfLap.TabIndex = 1;
            // 
            // lblSwimmingNumOfLaps
            // 
            this.lblSwimmingNumOfLaps.AutoSize = true;
            this.lblSwimmingNumOfLaps.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmingNumOfLaps.Location = new System.Drawing.Point(16, 37);
            this.lblSwimmingNumOfLaps.Name = "lblSwimmingNumOfLaps";
            this.lblSwimmingNumOfLaps.Size = new System.Drawing.Size(100, 17);
            this.lblSwimmingNumOfLaps.TabIndex = 0;
            this.lblSwimmingNumOfLaps.Text = "Number of laps";
            // 
            // chkBxSwimming
            // 
            this.chkBxSwimming.AutoSize = true;
            this.chkBxSwimming.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxSwimming.Location = new System.Drawing.Point(533, 133);
            this.chkBxSwimming.Name = "chkBxSwimming";
            this.chkBxSwimming.Size = new System.Drawing.Size(111, 27);
            this.chkBxSwimming.TabIndex = 8;
            this.chkBxSwimming.Text = "Swimming";
            this.chkBxSwimming.UseVisualStyleBackColor = true;
            this.chkBxSwimming.CheckedChanged += new System.EventHandler(this.chkBxSwimming_CheckedChanged);
            // 
            // gpBxBicycle
            // 
            this.gpBxBicycle.Controls.Add(this.txtBicyclingHeartRate);
            this.gpBxBicycle.Controls.Add(this.label2);
            this.gpBxBicycle.Controls.Add(this.txtBicyclingTimeTaken);
            this.gpBxBicycle.Controls.Add(this.label3);
            this.gpBxBicycle.Controls.Add(this.txtBicycleDistance);
            this.gpBxBicycle.Controls.Add(this.label4);
            this.gpBxBicycle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBxBicycle.Location = new System.Drawing.Point(725, 179);
            this.gpBxBicycle.Name = "gpBxBicycle";
            this.gpBxBicycle.Size = new System.Drawing.Size(150, 295);
            this.gpBxBicycle.TabIndex = 11;
            this.gpBxBicycle.TabStop = false;
            this.gpBxBicycle.Text = "Metrics";
            this.gpBxBicycle.Visible = false;
            // 
            // txtBicyclingHeartRate
            // 
            this.txtBicyclingHeartRate.Location = new System.Drawing.Point(19, 73);
            this.txtBicyclingHeartRate.Name = "txtBicyclingHeartRate";
            this.txtBicyclingHeartRate.Size = new System.Drawing.Size(100, 27);
            this.txtBicyclingHeartRate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Heart Rate";
            // 
            // txtBicyclingTimeTaken
            // 
            this.txtBicyclingTimeTaken.Location = new System.Drawing.Point(19, 155);
            this.txtBicyclingTimeTaken.Name = "txtBicyclingTimeTaken";
            this.txtBicyclingTimeTaken.Size = new System.Drawing.Size(100, 27);
            this.txtBicyclingTimeTaken.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Taken";
            // 
            // txtBicycleDistance
            // 
            this.txtBicycleDistance.Location = new System.Drawing.Point(19, 244);
            this.txtBicycleDistance.Name = "txtBicycleDistance";
            this.txtBicycleDistance.Size = new System.Drawing.Size(100, 27);
            this.txtBicycleDistance.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Distance";
            // 
            // chkBxBicycling
            // 
            this.chkBxBicycling.AutoSize = true;
            this.chkBxBicycling.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxBicycling.Location = new System.Drawing.Point(725, 133);
            this.chkBxBicycling.Name = "chkBxBicycling";
            this.chkBxBicycling.Size = new System.Drawing.Size(98, 27);
            this.chkBxBicycling.TabIndex = 10;
            this.chkBxBicycling.Text = "Bicycling";
            this.chkBxBicycling.UseVisualStyleBackColor = true;
            this.chkBxBicycling.CheckedChanged += new System.EventHandler(this.chkBxBicycling_CheckedChanged);
            // 
            // gpBxTennis
            // 
            this.gpBxTennis.Controls.Add(this.txtTennisHeartRate);
            this.gpBxTennis.Controls.Add(this.txtTennisTime);
            this.gpBxTennis.Controls.Add(this.label6);
            this.gpBxTennis.Controls.Add(this.label5);
            this.gpBxTennis.Controls.Add(this.txtBxTennisNumOfServes);
            this.gpBxTennis.Controls.Add(this.label7);
            this.gpBxTennis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBxTennis.Location = new System.Drawing.Point(906, 179);
            this.gpBxTennis.Name = "gpBxTennis";
            this.gpBxTennis.Size = new System.Drawing.Size(150, 295);
            this.gpBxTennis.TabIndex = 13;
            this.gpBxTennis.TabStop = false;
            this.gpBxTennis.Text = "Metrics";
            this.gpBxTennis.Visible = false;
            // 
            // txtTennisHeartRate
            // 
            this.txtTennisHeartRate.Location = new System.Drawing.Point(19, 73);
            this.txtTennisHeartRate.Name = "txtTennisHeartRate";
            this.txtTennisHeartRate.Size = new System.Drawing.Size(100, 27);
            this.txtTennisHeartRate.TabIndex = 5;
            // 
            // txtTennisTime
            // 
            this.txtTennisTime.Location = new System.Drawing.Point(19, 155);
            this.txtTennisTime.Name = "txtTennisTime";
            this.txtTennisTime.Size = new System.Drawing.Size(100, 27);
            this.txtTennisTime.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time Taken";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Heart Rate";
            // 
            // txtBxTennisNumOfServes
            // 
            this.txtBxTennisNumOfServes.Location = new System.Drawing.Point(19, 244);
            this.txtBxTennisNumOfServes.Name = "txtBxTennisNumOfServes";
            this.txtBxTennisNumOfServes.Size = new System.Drawing.Size(100, 27);
            this.txtBxTennisNumOfServes.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Number of Serves";
            // 
            // chkBxTennis
            // 
            this.chkBxTennis.AutoSize = true;
            this.chkBxTennis.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxTennis.Location = new System.Drawing.Point(906, 133);
            this.chkBxTennis.Name = "chkBxTennis";
            this.chkBxTennis.Size = new System.Drawing.Size(79, 27);
            this.chkBxTennis.TabIndex = 12;
            this.chkBxTennis.Text = "Tennis";
            this.chkBxTennis.UseVisualStyleBackColor = true;
            this.chkBxTennis.CheckedChanged += new System.EventHandler(this.chkBxTennis_CheckedChanged);
            // 
            // gpBxBasketball
            // 
            this.gpBxBasketball.Controls.Add(this.txtBxBasketballHeartRate);
            this.gpBxBasketball.Controls.Add(this.txtBxBasketballTimeTaken);
            this.gpBxBasketball.Controls.Add(this.label8);
            this.gpBxBasketball.Controls.Add(this.lblBasketBallHeartRate);
            this.gpBxBasketball.Controls.Add(this.txtBxBasketballNumOfShots);
            this.gpBxBasketball.Controls.Add(this.label10);
            this.gpBxBasketball.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBxBasketball.Location = new System.Drawing.Point(1093, 179);
            this.gpBxBasketball.Name = "gpBxBasketball";
            this.gpBxBasketball.Size = new System.Drawing.Size(150, 295);
            this.gpBxBasketball.TabIndex = 15;
            this.gpBxBasketball.TabStop = false;
            this.gpBxBasketball.Text = "Metrics";
            this.gpBxBasketball.Visible = false;
            // 
            // txtBxBasketballHeartRate
            // 
            this.txtBxBasketballHeartRate.Location = new System.Drawing.Point(19, 73);
            this.txtBxBasketballHeartRate.Name = "txtBxBasketballHeartRate";
            this.txtBxBasketballHeartRate.Size = new System.Drawing.Size(100, 27);
            this.txtBxBasketballHeartRate.TabIndex = 5;
            // 
            // txtBxBasketballTimeTaken
            // 
            this.txtBxBasketballTimeTaken.Location = new System.Drawing.Point(19, 155);
            this.txtBxBasketballTimeTaken.Name = "txtBxBasketballTimeTaken";
            this.txtBxBasketballTimeTaken.Size = new System.Drawing.Size(100, 27);
            this.txtBxBasketballTimeTaken.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Time Taken";
            // 
            // lblBasketBallHeartRate
            // 
            this.lblBasketBallHeartRate.AutoSize = true;
            this.lblBasketBallHeartRate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasketBallHeartRate.Location = new System.Drawing.Point(16, 37);
            this.lblBasketBallHeartRate.Name = "lblBasketBallHeartRate";
            this.lblBasketBallHeartRate.Size = new System.Drawing.Size(70, 17);
            this.lblBasketBallHeartRate.TabIndex = 4;
            this.lblBasketBallHeartRate.Text = "Heart Rate";
            // 
            // txtBxBasketballNumOfShots
            // 
            this.txtBxBasketballNumOfShots.Location = new System.Drawing.Point(19, 244);
            this.txtBxBasketballNumOfShots.Name = "txtBxBasketballNumOfShots";
            this.txtBxBasketballNumOfShots.Size = new System.Drawing.Size(100, 27);
            this.txtBxBasketballNumOfShots.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Number of shots";
            // 
            // chkBxBasketball
            // 
            this.chkBxBasketball.AutoSize = true;
            this.chkBxBasketball.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxBasketball.Location = new System.Drawing.Point(1093, 133);
            this.chkBxBasketball.Name = "chkBxBasketball";
            this.chkBxBasketball.Size = new System.Drawing.Size(108, 27);
            this.chkBxBasketball.TabIndex = 14;
            this.chkBxBasketball.Text = "Basketball";
            this.chkBxBasketball.UseVisualStyleBackColor = true;
            this.chkBxBasketball.CheckedChanged += new System.EventHandler(this.chkBxBasketball_CheckedChanged);
            // 
            // gpBxWrestling
            // 
            this.gpBxWrestling.Controls.Add(this.txtBxWrestlingHeartRate);
            this.gpBxWrestling.Controls.Add(this.txtBxWrestlingTimeTaken);
            this.gpBxWrestling.Controls.Add(this.label9);
            this.gpBxWrestling.Controls.Add(this.label11);
            this.gpBxWrestling.Controls.Add(this.txtBxWrestlingNumOfTakeDown);
            this.gpBxWrestling.Controls.Add(this.label12);
            this.gpBxWrestling.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBxWrestling.Location = new System.Drawing.Point(1270, 179);
            this.gpBxWrestling.Name = "gpBxWrestling";
            this.gpBxWrestling.Size = new System.Drawing.Size(150, 295);
            this.gpBxWrestling.TabIndex = 17;
            this.gpBxWrestling.TabStop = false;
            this.gpBxWrestling.Text = "Metrics";
            this.gpBxWrestling.Visible = false;
            // 
            // txtBxWrestlingHeartRate
            // 
            this.txtBxWrestlingHeartRate.Location = new System.Drawing.Point(19, 73);
            this.txtBxWrestlingHeartRate.Name = "txtBxWrestlingHeartRate";
            this.txtBxWrestlingHeartRate.Size = new System.Drawing.Size(100, 27);
            this.txtBxWrestlingHeartRate.TabIndex = 5;
            // 
            // txtBxWrestlingTimeTaken
            // 
            this.txtBxWrestlingTimeTaken.Location = new System.Drawing.Point(19, 155);
            this.txtBxWrestlingTimeTaken.Name = "txtBxWrestlingTimeTaken";
            this.txtBxWrestlingTimeTaken.Size = new System.Drawing.Size(100, 27);
            this.txtBxWrestlingTimeTaken.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Time Taken";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Heart Rate";
            // 
            // txtBxWrestlingNumOfTakeDown
            // 
            this.txtBxWrestlingNumOfTakeDown.Location = new System.Drawing.Point(19, 244);
            this.txtBxWrestlingNumOfTakeDown.Name = "txtBxWrestlingNumOfTakeDown";
            this.txtBxWrestlingNumOfTakeDown.Size = new System.Drawing.Size(100, 27);
            this.txtBxWrestlingNumOfTakeDown.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Number of takedown";
            // 
            // chkBxWrestling
            // 
            this.chkBxWrestling.AutoSize = true;
            this.chkBxWrestling.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBxWrestling.Location = new System.Drawing.Point(1270, 133);
            this.chkBxWrestling.Name = "chkBxWrestling";
            this.chkBxWrestling.Size = new System.Drawing.Size(104, 27);
            this.chkBxWrestling.TabIndex = 16;
            this.chkBxWrestling.Text = "Wrestling";
            this.chkBxWrestling.UseVisualStyleBackColor = true;
            this.chkBxWrestling.CheckedChanged += new System.EventHandler(this.chkBxWrestling_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(328, 509);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(10, 23);
            this.lblResult.TabIndex = 18;
            this.lblResult.Text = "\r\n";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmdEdit);
            this.panel2.Controls.Add(this.txtNewWeight);
            this.panel2.Controls.Add(this.txtNewTargetCalories);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(0, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 282);
            this.panel2.TabIndex = 6;
            // 
            // cmdEdit
            // 
            this.cmdEdit.AutoSize = true;
            this.cmdEdit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEdit.Location = new System.Drawing.Point(198, 223);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.cmdEdit.Size = new System.Drawing.Size(89, 49);
            this.cmdEdit.TabIndex = 10;
            this.cmdEdit.Text = "Edit";
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // txtNewWeight
            // 
            this.txtNewWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewWeight.Location = new System.Drawing.Point(23, 180);
            this.txtNewWeight.Name = "txtNewWeight";
            this.txtNewWeight.Size = new System.Drawing.Size(194, 27);
            this.txtNewWeight.TabIndex = 5;
            // 
            // txtNewTargetCalories
            // 
            this.txtNewTargetCalories.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewTargetCalories.Location = new System.Drawing.Point(23, 114);
            this.txtNewTargetCalories.Name = "txtNewTargetCalories";
            this.txtNewTargetCalories.Size = new System.Drawing.Size(194, 27);
            this.txtNewTargetCalories.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(276, 28);
            this.label13.TabIndex = 0;
            this.label13.Text = "Update Your Data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 23);
            this.label14.TabIndex = 1;
            this.label14.Text = "Your new target calories:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 23);
            this.label15.TabIndex = 3;
            this.label15.Text = "Your new weight:";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.AutoSize = true;
            this.cmdCalculate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalculate.Location = new System.Drawing.Point(1288, 496);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.cmdCalculate.Size = new System.Drawing.Size(130, 49);
            this.cmdCalculate.TabIndex = 11;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // cmdUserGuide
            // 
            this.cmdUserGuide.AutoSize = true;
            this.cmdUserGuide.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUserGuide.Location = new System.Drawing.Point(508, 37);
            this.cmdUserGuide.Name = "cmdUserGuide";
            this.cmdUserGuide.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);
            this.cmdUserGuide.Size = new System.Drawing.Size(144, 49);
            this.cmdUserGuide.TabIndex = 11;
            this.cmdUserGuide.Text = "User Guide";
            this.cmdUserGuide.UseVisualStyleBackColor = true;
            this.cmdUserGuide.Click += new System.EventHandler(this.cmdUserGuide_Click);
            // 
            // lblUserGuide
            // 
            this.lblUserGuide.AutoSize = true;
            this.lblUserGuide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserGuide.Location = new System.Drawing.Point(680, 19);
            this.lblUserGuide.Name = "lblUserGuide";
            this.lblUserGuide.Size = new System.Drawing.Size(650, 100);
            this.lblUserGuide.TabIndex = 19;
            this.lblUserGuide.Text = resources.GetString("lblUserGuide.Text");
            this.lblUserGuide.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(171)))), ((int)(((byte)(172)))));
            this.ClientSize = new System.Drawing.Size(1447, 566);
            this.Controls.Add(this.lblUserGuide);
            this.Controls.Add(this.cmdUserGuide);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.gpBxWrestling);
            this.Controls.Add(this.chkBxWrestling);
            this.Controls.Add(this.gpBxBasketball);
            this.Controls.Add(this.chkBxBasketball);
            this.Controls.Add(this.gpBxTennis);
            this.Controls.Add(this.chkBxTennis);
            this.Controls.Add(this.gpBxBicycle);
            this.Controls.Add(this.chkBxBicycling);
            this.Controls.Add(this.gpBxSwimming);
            this.Controls.Add(this.chkBxSwimming);
            this.Controls.Add(this.gpBxWalking);
            this.Controls.Add(this.chkBxWalking);
            this.Controls.Add(this.lblActivitiesTitle);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpBxWalking.ResumeLayout(false);
            this.gpBxWalking.PerformLayout();
            this.gpBxSwimming.ResumeLayout(false);
            this.gpBxSwimming.PerformLayout();
            this.gpBxBicycle.ResumeLayout(false);
            this.gpBxBicycle.PerformLayout();
            this.gpBxTennis.ResumeLayout(false);
            this.gpBxTennis.PerformLayout();
            this.gpBxBasketball.ResumeLayout(false);
            this.gpBxBasketball.PerformLayout();
            this.gpBxWrestling.ResumeLayout(false);
            this.gpBxWrestling.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTargetCalories;
        private System.Windows.Forms.Label lblYourWeight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActivitiesTitle;
        private System.Windows.Forms.CheckBox chkBxWalking;
        private System.Windows.Forms.GroupBox gpBxWalking;
        private System.Windows.Forms.Label lblWalkingSteps;
        private System.Windows.Forms.TextBox txtWalkingSteps;
        private System.Windows.Forms.TextBox txtWalkingTimeTaken;
        private System.Windows.Forms.Label lblWalkingTimeTaken;
        private System.Windows.Forms.TextBox txtWalkingDistance;
        private System.Windows.Forms.Label lblWalkingDistance;
        private System.Windows.Forms.GroupBox gpBxSwimming;
        private System.Windows.Forms.TextBox txtSwimmingHeartRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSwimmingTimeTaken;
        private System.Windows.Forms.Label lblSwimmingTimeTaken;
        private System.Windows.Forms.TextBox txtSwimmingNumOfLap;
        private System.Windows.Forms.Label lblSwimmingNumOfLaps;
        private System.Windows.Forms.CheckBox chkBxSwimming;
        private System.Windows.Forms.GroupBox gpBxBicycle;
        private System.Windows.Forms.TextBox txtBicyclingHeartRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBicyclingTimeTaken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBicycleDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBxBicycling;
        private System.Windows.Forms.GroupBox gpBxTennis;
        private System.Windows.Forms.TextBox txtTennisHeartRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTennisTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxTennisNumOfServes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkBxTennis;
        private System.Windows.Forms.GroupBox gpBxBasketball;
        private System.Windows.Forms.TextBox txtBxBasketballHeartRate;
        private System.Windows.Forms.TextBox txtBxBasketballTimeTaken;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBasketBallHeartRate;
        private System.Windows.Forms.TextBox txtBxBasketballNumOfShots;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkBxBasketball;
        private System.Windows.Forms.GroupBox gpBxWrestling;
        private System.Windows.Forms.TextBox txtBxWrestlingHeartRate;
        private System.Windows.Forms.TextBox txtBxWrestlingTimeTaken;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBxWrestlingNumOfTakeDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkBxWrestling;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNewWeight;
        private System.Windows.Forms.TextBox txtNewTargetCalories;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Button cmdUserGuide;
        private System.Windows.Forms.Label lblUserGuide;
    }
}