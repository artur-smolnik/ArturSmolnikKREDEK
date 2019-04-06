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
            this.buttonTestButton = new System.Windows.Forms.Button();
            this.labelPopulationNumberInfo = new System.Windows.Forms.Label();
            this.labelPlanetsNumberInfo = new System.Windows.Forms.Label();
            this.labelPlanetsNumber = new System.Windows.Forms.Label();
            this.labelTechLevelInfo = new System.Windows.Forms.Label();
            this.labelTechLevel = new System.Windows.Forms.Label();
            this.buttonAddPlanet = new System.Windows.Forms.Button();
            this.buttonAddRace = new System.Windows.Forms.Button();
            this.labelRacesAmount = new System.Windows.Forms.Label();
            this.labelRacesAmountInfo = new System.Windows.Forms.Label();
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
            this.labelPopulationNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonTestButton
            // 
            this.buttonTestButton.Location = new System.Drawing.Point(270, 36);
            this.buttonTestButton.Name = "buttonTestButton";
            this.buttonTestButton.Size = new System.Drawing.Size(165, 23);
            this.buttonTestButton.TabIndex = 2;
            this.buttonTestButton.Text = "TestButton";
            this.buttonTestButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonTestButton.UseVisualStyleBackColor = true;
            this.buttonTestButton.Click += new System.EventHandler(this.button_Click);
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
            this.labelPopulationNumberInfo.Click += new System.EventHandler(this.populationNumberInfo_Click);
            // 
            // labelPlanetsNumberInfo
            // 
            this.labelPlanetsNumberInfo.AutoSize = true;
            this.labelPlanetsNumberInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelPlanetsNumberInfo.Location = new System.Drawing.Point(12, 36);
            this.labelPlanetsNumberInfo.Name = "labelPlanetsNumberInfo";
            this.labelPlanetsNumberInfo.Size = new System.Drawing.Size(132, 17);
            this.labelPlanetsNumberInfo.TabIndex = 4;
            this.labelPlanetsNumberInfo.Text = "Conquered planets:";
            this.labelPlanetsNumberInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlanetsNumberInfo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelPlanetsNumber
            // 
            this.labelPlanetsNumber.AutoSize = true;
            this.labelPlanetsNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelPlanetsNumber.Location = new System.Drawing.Point(149, 36);
            this.labelPlanetsNumber.Name = "labelPlanetsNumber";
            this.labelPlanetsNumber.Size = new System.Drawing.Size(16, 17);
            this.labelPlanetsNumber.TabIndex = 5;
            this.labelPlanetsNumber.Text = "0";
            this.labelPlanetsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlanetsNumber.Click += new System.EventHandler(this.PlanetsNumber_Click);
            // 
            // labelTechLevelInfo
            // 
            this.labelTechLevelInfo.AutoSize = true;
            this.labelTechLevelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTechLevelInfo.Location = new System.Drawing.Point(12, 65);
            this.labelTechLevelInfo.Name = "labelTechLevelInfo";
            this.labelTechLevelInfo.Size = new System.Drawing.Size(77, 17);
            this.labelTechLevelInfo.TabIndex = 4;
            this.labelTechLevelInfo.Text = "Tech level:";
            this.labelTechLevelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTechLevelInfo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelTechLevel
            // 
            this.labelTechLevel.AutoSize = true;
            this.labelTechLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelTechLevel.Location = new System.Drawing.Point(149, 65);
            this.labelTechLevel.Name = "labelTechLevel";
            this.labelTechLevel.Size = new System.Drawing.Size(16, 17);
            this.labelTechLevel.TabIndex = 5;
            this.labelTechLevel.Text = "0";
            this.labelTechLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTechLevel.Click += new System.EventHandler(this.techLevel_Click);
            // 
            // buttonAddPlanet
            // 
            this.buttonAddPlanet.Location = new System.Drawing.Point(270, 65);
            this.buttonAddPlanet.Name = "buttonAddPlanet";
            this.buttonAddPlanet.Size = new System.Drawing.Size(165, 23);
            this.buttonAddPlanet.TabIndex = 6;
            this.buttonAddPlanet.Text = "buttonAddPlanet";
            this.buttonAddPlanet.UseVisualStyleBackColor = true;
            //this.buttonAddPlanet.Click += new System.EventHandler(this.addPlanet_Click);
            // 
            // buttonAddRace
            // 
            this.buttonAddRace.Location = new System.Drawing.Point(270, 94);
            this.buttonAddRace.Name = "buttonAddRace";
            this.buttonAddRace.Size = new System.Drawing.Size(165, 23);
            this.buttonAddRace.TabIndex = 7;
            this.buttonAddRace.Text = "addRace";
            this.buttonAddRace.UseVisualStyleBackColor = true;
            this.buttonAddRace.Click += new System.EventHandler(this.buttonAddRace_Click);
            // 
            // labelRacesAmount
            // 
            this.labelRacesAmount.AutoSize = true;
            this.labelRacesAmount.BackColor = System.Drawing.Color.Yellow;
            this.labelRacesAmount.Location = new System.Drawing.Point(149, 94);
            this.labelRacesAmount.Name = "labelRacesAmount";
            this.labelRacesAmount.Size = new System.Drawing.Size(16, 17);
            this.labelRacesAmount.TabIndex = 8;
            this.labelRacesAmount.Text = "0";
            this.labelRacesAmount.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // labelRacesAmountInfo
            // 
            this.labelRacesAmountInfo.AutoSize = true;
            this.labelRacesAmountInfo.BackColor = System.Drawing.Color.Yellow;
            this.labelRacesAmountInfo.Location = new System.Drawing.Point(12, 94);
            this.labelRacesAmountInfo.Name = "labelRacesAmountInfo";
            this.labelRacesAmountInfo.Size = new System.Drawing.Size(103, 17);
            this.labelRacesAmountInfo.TabIndex = 9;
            this.labelRacesAmountInfo.Text = "Races amount:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.labelRacesAmountInfo);
            this.Controls.Add(this.labelRacesAmount);
            this.Controls.Add(this.buttonAddRace);
            this.Controls.Add(this.buttonAddPlanet);
            this.Controls.Add(this.labelTechLevel);
            this.Controls.Add(this.labelPlanetsNumber);
            this.Controls.Add(this.labelTechLevelInfo);
            this.Controls.Add(this.labelPlanetsNumberInfo);
            this.Controls.Add(this.labelPopulationNumberInfo);
            this.Controls.Add(this.buttonTestButton);
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
        private System.Windows.Forms.Button buttonTestButton;
        private System.Windows.Forms.Label labelPopulationNumberInfo;
        private System.Windows.Forms.Label labelPlanetsNumberInfo;
        private System.Windows.Forms.Label labelPlanetsNumber;
        private System.Windows.Forms.Label labelTechLevelInfo;
        private System.Windows.Forms.Label labelTechLevel;
        private System.Windows.Forms.Button buttonAddPlanet;
        private System.Windows.Forms.Button buttonAddRace;
        private System.Windows.Forms.Label labelRacesAmount;
        private System.Windows.Forms.Label labelRacesAmountInfo;
    }
}

