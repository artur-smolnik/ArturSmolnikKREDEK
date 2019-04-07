namespace ArturSmolnikLab1
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
            this.components = new System.ComponentModel.Container();
            this.timerMainWorldTimer = new System.Windows.Forms.Timer(this.components);
            this.labelPopulationNumber = new System.Windows.Forms.Label();
            this.buttonStartButton = new System.Windows.Forms.Button();
            this.labelPopulationNumberInfo = new System.Windows.Forms.Label();
            this.labelPlanetsNumberInfo = new System.Windows.Forms.Label();
            this.labelPlanetsNumber = new System.Windows.Forms.Label();
            this.labelTechLevelInfo = new System.Windows.Forms.Label();
            this.labelTechLevel = new System.Windows.Forms.Label();
            this.labelRacesAmount = new System.Windows.Forms.Label();
            this.labelRacesAmountInfo = new System.Windows.Forms.Label();
            this.labelCurrentPlanetInfo = new System.Windows.Forms.Label();
            this.labelInhabitantsInfo = new System.Windows.Forms.Label();
            this.labelInhabitants = new System.Windows.Forms.Label();
            this.labelDensityInfo = new System.Windows.Forms.Label();
            this.labelDensity = new System.Windows.Forms.Label();
            this.buttonSpeedUp = new System.Windows.Forms.Button();
            this.buttonSlowDown = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // timerMainWorldTimer
            // 
            this.timerMainWorldTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPopulationNumber
            // 
            this.labelPopulationNumber.AutoSize = true;
            this.labelPopulationNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPopulationNumber.Location = new System.Drawing.Point(149, 9);
            this.labelPopulationNumber.Name = "labelPopulationNumber";
            this.labelPopulationNumber.Size = new System.Drawing.Size(16, 17);
            this.labelPopulationNumber.TabIndex = 0;
            this.labelPopulationNumber.Text = "0";
            this.labelPopulationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPopulationNumber.Click += new System.EventHandler(this.LabelPopulation);
            // 
            // buttonStartButton
            // 
            this.buttonStartButton.Location = new System.Drawing.Point(285, 30);
            this.buttonStartButton.Name = "buttonStartButton";
            this.buttonStartButton.Size = new System.Drawing.Size(165, 23);
            this.buttonStartButton.TabIndex = 2;
            this.buttonStartButton.Text = "Start";
            this.buttonStartButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStartButton.UseVisualStyleBackColor = true;
            this.buttonStartButton.Click += new System.EventHandler(this.ButtonStart);
            // 
            // labelPopulationNumberInfo
            // 
            this.labelPopulationNumberInfo.AutoSize = true;
            this.labelPopulationNumberInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelPopulationNumberInfo.Location = new System.Drawing.Point(12, 9);
            this.labelPopulationNumberInfo.Name = "labelPopulationNumberInfo";
            this.labelPopulationNumberInfo.Size = new System.Drawing.Size(79, 17);
            this.labelPopulationNumberInfo.TabIndex = 3;
            this.labelPopulationNumberInfo.Text = "Population:";
            this.labelPopulationNumberInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPopulationNumberInfo.Click += new System.EventHandler(this.LabelPopulationNumberInfo);
            // 
            // labelPlanetsNumberInfo
            // 
            this.labelPlanetsNumberInfo.AutoSize = true;
            this.labelPlanetsNumberInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelPlanetsNumberInfo.Location = new System.Drawing.Point(12, 94);
            this.labelPlanetsNumberInfo.Name = "labelPlanetsNumberInfo";
            this.labelPlanetsNumberInfo.Size = new System.Drawing.Size(132, 17);
            this.labelPlanetsNumberInfo.TabIndex = 4;
            this.labelPlanetsNumberInfo.Text = "Conquered planets:";
            this.labelPlanetsNumberInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlanetsNumberInfo.Click += new System.EventHandler(this.LabelTechLevelInfo);
            // 
            // labelPlanetsNumber
            // 
            this.labelPlanetsNumber.AutoSize = true;
            this.labelPlanetsNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelPlanetsNumber.Location = new System.Drawing.Point(149, 94);
            this.labelPlanetsNumber.Name = "labelPlanetsNumber";
            this.labelPlanetsNumber.Size = new System.Drawing.Size(16, 17);
            this.labelPlanetsNumber.TabIndex = 5;
            this.labelPlanetsNumber.Text = "0";
            this.labelPlanetsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlanetsNumber.Click += new System.EventHandler(this.LabelPlanetsNumber);
            // 
            // labelTechLevelInfo
            // 
            this.labelTechLevelInfo.AutoSize = true;
            this.labelTechLevelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTechLevelInfo.Location = new System.Drawing.Point(12, 117);
            this.labelTechLevelInfo.Name = "labelTechLevelInfo";
            this.labelTechLevelInfo.Size = new System.Drawing.Size(77, 17);
            this.labelTechLevelInfo.TabIndex = 4;
            this.labelTechLevelInfo.Text = "Tech level:";
            this.labelTechLevelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTechLevelInfo.Click += new System.EventHandler(this.LabelTechLevelInfo);
            // 
            // labelTechLevel
            // 
            this.labelTechLevel.AutoSize = true;
            this.labelTechLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTechLevel.Location = new System.Drawing.Point(149, 117);
            this.labelTechLevel.Name = "labelTechLevel";
            this.labelTechLevel.Size = new System.Drawing.Size(16, 17);
            this.labelTechLevel.TabIndex = 5;
            this.labelTechLevel.Text = "0";
            this.labelTechLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTechLevel.Click += new System.EventHandler(this.LabelTechLevel);
            // 
            // labelRacesAmount
            // 
            this.labelRacesAmount.AutoSize = true;
            this.labelRacesAmount.BackColor = System.Drawing.Color.Yellow;
            this.labelRacesAmount.Location = new System.Drawing.Point(149, 143);
            this.labelRacesAmount.Name = "labelRacesAmount";
            this.labelRacesAmount.Size = new System.Drawing.Size(16, 17);
            this.labelRacesAmount.TabIndex = 8;
            this.labelRacesAmount.Text = "0";
            this.labelRacesAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRacesAmount.Click += new System.EventHandler(this.LabelRacesAmount);
            // 
            // labelRacesAmountInfo
            // 
            this.labelRacesAmountInfo.AutoSize = true;
            this.labelRacesAmountInfo.BackColor = System.Drawing.Color.Yellow;
            this.labelRacesAmountInfo.Location = new System.Drawing.Point(12, 143);
            this.labelRacesAmountInfo.Name = "labelRacesAmountInfo";
            this.labelRacesAmountInfo.Size = new System.Drawing.Size(103, 17);
            this.labelRacesAmountInfo.TabIndex = 9;
            this.labelRacesAmountInfo.Text = "Races amount:";
            this.labelRacesAmountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRacesAmountInfo.Click += new System.EventHandler(this.LabelRacesAmountInfo);
            // 
            // labelCurrentPlanetInfo
            // 
            this.labelCurrentPlanetInfo.AutoSize = true;
            this.labelCurrentPlanetInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelCurrentPlanetInfo.Location = new System.Drawing.Point(24, 36);
            this.labelCurrentPlanetInfo.Name = "labelCurrentPlanetInfo";
            this.labelCurrentPlanetInfo.Size = new System.Drawing.Size(129, 17);
            this.labelCurrentPlanetInfo.TabIndex = 10;
            this.labelCurrentPlanetInfo.Text = "Current planet info:";
            this.labelCurrentPlanetInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCurrentPlanetInfo.Click += new System.EventHandler(this.LabelCurrentPlanetInfo);
            // 
            // labelInhabitantsInfo
            // 
            this.labelInhabitantsInfo.AutoSize = true;
            this.labelInhabitantsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelInhabitantsInfo.Location = new System.Drawing.Point(12, 65);
            this.labelInhabitantsInfo.Name = "labelInhabitantsInfo";
            this.labelInhabitantsInfo.Size = new System.Drawing.Size(81, 17);
            this.labelInhabitantsInfo.TabIndex = 11;
            this.labelInhabitantsInfo.Text = "Inhabitants:";
            this.labelInhabitantsInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInhabitantsInfo.Click += new System.EventHandler(this.LabelInhabitantsInfo);
            // 
            // labelInhabitants
            // 
            this.labelInhabitants.AutoSize = true;
            this.labelInhabitants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelInhabitants.Location = new System.Drawing.Point(149, 65);
            this.labelInhabitants.Name = "labelInhabitants";
            this.labelInhabitants.Size = new System.Drawing.Size(16, 17);
            this.labelInhabitants.TabIndex = 12;
            this.labelInhabitants.Text = "0";
            this.labelInhabitants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInhabitants.Click += new System.EventHandler(this.LabelInhabitants);
            // 
            // labelDensityInfo
            // 
            this.labelDensityInfo.AutoSize = true;
            this.labelDensityInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelDensityInfo.Location = new System.Drawing.Point(12, 171);
            this.labelDensityInfo.Name = "labelDensityInfo";
            this.labelDensityInfo.Size = new System.Drawing.Size(59, 17);
            this.labelDensityInfo.TabIndex = 13;
            this.labelDensityInfo.Text = "Density:";
            this.labelDensityInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDensityInfo.Click += new System.EventHandler(this.LabelDensityInfo);
            // 
            // labelDensity
            // 
            this.labelDensity.AutoSize = true;
            this.labelDensity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelDensity.Location = new System.Drawing.Point(149, 171);
            this.labelDensity.Name = "labelDensity";
            this.labelDensity.Size = new System.Drawing.Size(16, 17);
            this.labelDensity.TabIndex = 14;
            this.labelDensity.Text = "0";
            this.labelDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDensity.Click += new System.EventHandler(this.LabelDensity);
            // 
            // buttonSpeedUp
            // 
            this.buttonSpeedUp.Location = new System.Drawing.Point(285, 59);
            this.buttonSpeedUp.Name = "buttonSpeedUp";
            this.buttonSpeedUp.Size = new System.Drawing.Size(105, 23);
            this.buttonSpeedUp.TabIndex = 15;
            this.buttonSpeedUp.Text = "SpeedUp";
            this.buttonSpeedUp.UseVisualStyleBackColor = true;
            this.buttonSpeedUp.Click += new System.EventHandler(this.ButtonSpeedUp);
            // 
            // buttonSlowDown
            // 
            this.buttonSlowDown.Location = new System.Drawing.Point(285, 94);
            this.buttonSlowDown.Name = "buttonSlowDown";
            this.buttonSlowDown.Size = new System.Drawing.Size(75, 23);
            this.buttonSlowDown.TabIndex = 16;
            this.buttonSlowDown.Text = "Slow down";
            this.buttonSlowDown.UseVisualStyleBackColor = true;
            this.buttonSlowDown.Click += new System.EventHandler(this.ButtonSlowDown);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.buttonSlowDown);
            this.Controls.Add(this.buttonSpeedUp);
            this.Controls.Add(this.labelDensity);
            this.Controls.Add(this.labelDensityInfo);
            this.Controls.Add(this.labelInhabitants);
            this.Controls.Add(this.labelInhabitantsInfo);
            this.Controls.Add(this.labelCurrentPlanetInfo);
            this.Controls.Add(this.labelRacesAmountInfo);
            this.Controls.Add(this.labelRacesAmount);
            this.Controls.Add(this.labelTechLevel);
            this.Controls.Add(this.labelPlanetsNumber);
            this.Controls.Add(this.labelTechLevelInfo);
            this.Controls.Add(this.labelPlanetsNumberInfo);
            this.Controls.Add(this.labelPopulationNumberInfo);
            this.Controls.Add(this.buttonStartButton);
            this.Controls.Add(this.labelPopulationNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMainWorldTimer;
        private System.Windows.Forms.Label labelPopulationNumber;
        private System.Windows.Forms.Button buttonStartButton;
        private System.Windows.Forms.Label labelPopulationNumberInfo;
        private System.Windows.Forms.Label labelPlanetsNumberInfo;
        private System.Windows.Forms.Label labelPlanetsNumber;
        private System.Windows.Forms.Label labelTechLevelInfo;
        private System.Windows.Forms.Label labelTechLevel;
        private System.Windows.Forms.Label labelRacesAmount;
        private System.Windows.Forms.Label labelRacesAmountInfo;
        private System.Windows.Forms.Label labelCurrentPlanetInfo;
        private System.Windows.Forms.Label labelInhabitantsInfo;
        private System.Windows.Forms.Label labelInhabitants;
        private System.Windows.Forms.Label labelDensityInfo;
        private System.Windows.Forms.Label labelDensity;
        private System.Windows.Forms.Button buttonSpeedUp;
        private System.Windows.Forms.Button buttonSlowDown;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

