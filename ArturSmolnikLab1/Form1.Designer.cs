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
            this.MainWorldTimer = new System.Windows.Forms.Timer(this.components);
            this.populationNumber = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.populationNumberInfo = new System.Windows.Forms.Label();
            this.planetsNumberInfo = new System.Windows.Forms.Label();
            this.PlanetsNumber = new System.Windows.Forms.Label();
            this.techLevelInfo = new System.Windows.Forms.Label();
            this.techLevel = new System.Windows.Forms.Label();
            this.addPlanet = new System.Windows.Forms.Button();
            this.buttonAddRace = new System.Windows.Forms.Button();
            this.racesAmount = new System.Windows.Forms.Label();
            this.racesAmountInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainWorldTimer
            // 
            this.MainWorldTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // populationNumber
            // 
            this.populationNumber.AutoSize = true;
            this.populationNumber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.populationNumber.Location = new System.Drawing.Point(149, 9);
            this.populationNumber.Name = "populationNumber";
            this.populationNumber.Size = new System.Drawing.Size(16, 17);
            this.populationNumber.TabIndex = 0;
            this.populationNumber.Text = "0";
            this.populationNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.populationNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(270, 36);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "TestButton";
            this.testButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.button_Click);
            // 
            // populationNumberInfo
            // 
            this.populationNumberInfo.AutoSize = true;
            this.populationNumberInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.populationNumberInfo.Location = new System.Drawing.Point(12, 9);
            this.populationNumberInfo.Name = "populationNumberInfo";
            this.populationNumberInfo.Size = new System.Drawing.Size(79, 17);
            this.populationNumberInfo.TabIndex = 3;
            this.populationNumberInfo.Text = "Population:";
            this.populationNumberInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.populationNumberInfo.Click += new System.EventHandler(this.populationNumberInfo_Click);
            // 
            // planetsNumberInfo
            // 
            this.planetsNumberInfo.AutoSize = true;
            this.planetsNumberInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.planetsNumberInfo.Location = new System.Drawing.Point(12, 36);
            this.planetsNumberInfo.Name = "planetsNumberInfo";
            this.planetsNumberInfo.Size = new System.Drawing.Size(132, 17);
            this.planetsNumberInfo.TabIndex = 4;
            this.planetsNumberInfo.Text = "Conquered planets:";
            this.planetsNumberInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.planetsNumberInfo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PlanetsNumber
            // 
            this.PlanetsNumber.AutoSize = true;
            this.PlanetsNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PlanetsNumber.Location = new System.Drawing.Point(149, 36);
            this.PlanetsNumber.Name = "PlanetsNumber";
            this.PlanetsNumber.Size = new System.Drawing.Size(16, 17);
            this.PlanetsNumber.TabIndex = 5;
            this.PlanetsNumber.Text = "0";
            this.PlanetsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlanetsNumber.Click += new System.EventHandler(this.PlanetsNumber_Click);
            // 
            // techLevelInfo
            // 
            this.techLevelInfo.AutoSize = true;
            this.techLevelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.techLevelInfo.Location = new System.Drawing.Point(12, 65);
            this.techLevelInfo.Name = "techLevelInfo";
            this.techLevelInfo.Size = new System.Drawing.Size(77, 17);
            this.techLevelInfo.TabIndex = 4;
            this.techLevelInfo.Text = "Tech level:";
            this.techLevelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.techLevelInfo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // techLevel
            // 
            this.techLevel.AutoSize = true;
            this.techLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.techLevel.Location = new System.Drawing.Point(149, 65);
            this.techLevel.Name = "techLevel";
            this.techLevel.Size = new System.Drawing.Size(16, 17);
            this.techLevel.TabIndex = 5;
            this.techLevel.Text = "0";
            this.techLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.techLevel.Click += new System.EventHandler(this.techLevel_Click);
            // 
            // addPlanet
            // 
            this.addPlanet.Location = new System.Drawing.Point(270, 65);
            this.addPlanet.Name = "addPlanet";
            this.addPlanet.Size = new System.Drawing.Size(75, 23);
            this.addPlanet.TabIndex = 6;
            this.addPlanet.Text = "addPlanet";
            this.addPlanet.UseVisualStyleBackColor = true;
            this.addPlanet.Click += new System.EventHandler(this.addPlanet_Click);
            // 
            // buttonAddRace
            // 
            this.buttonAddRace.Location = new System.Drawing.Point(270, 94);
            this.buttonAddRace.Name = "buttonAddRace";
            this.buttonAddRace.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRace.TabIndex = 7;
            this.buttonAddRace.Text = "addRace";
            this.buttonAddRace.UseVisualStyleBackColor = true;
            this.buttonAddRace.Click += new System.EventHandler(this.buttonAddRace_Click);
            // 
            // racesAmount
            // 
            this.racesAmount.AutoSize = true;
            this.racesAmount.BackColor = System.Drawing.Color.Yellow;
            this.racesAmount.Location = new System.Drawing.Point(149, 94);
            this.racesAmount.Name = "racesAmount";
            this.racesAmount.Size = new System.Drawing.Size(16, 17);
            this.racesAmount.TabIndex = 8;
            this.racesAmount.Text = "0";
            this.racesAmount.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // racesAmountInfo
            // 
            this.racesAmountInfo.AutoSize = true;
            this.racesAmountInfo.BackColor = System.Drawing.Color.Yellow;
            this.racesAmountInfo.Location = new System.Drawing.Point(12, 94);
            this.racesAmountInfo.Name = "racesAmountInfo";
            this.racesAmountInfo.Size = new System.Drawing.Size(103, 17);
            this.racesAmountInfo.TabIndex = 9;
            this.racesAmountInfo.Text = "Races amount:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.racesAmountInfo);
            this.Controls.Add(this.racesAmount);
            this.Controls.Add(this.buttonAddRace);
            this.Controls.Add(this.addPlanet);
            this.Controls.Add(this.techLevel);
            this.Controls.Add(this.PlanetsNumber);
            this.Controls.Add(this.techLevelInfo);
            this.Controls.Add(this.planetsNumberInfo);
            this.Controls.Add(this.populationNumberInfo);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.populationNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MainWorldTimer;
        private System.Windows.Forms.Label populationNumber;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label populationNumberInfo;
        private System.Windows.Forms.Label planetsNumberInfo;
        private System.Windows.Forms.Label PlanetsNumber;
        private System.Windows.Forms.Label techLevelInfo;
        private System.Windows.Forms.Label techLevel;
        private System.Windows.Forms.Button addPlanet;
        private System.Windows.Forms.Button buttonAddRace;
        private System.Windows.Forms.Label racesAmount;
        private System.Windows.Forms.Label racesAmountInfo;
    }
}

