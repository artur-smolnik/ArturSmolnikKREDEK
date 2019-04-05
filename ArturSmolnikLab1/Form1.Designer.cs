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
            this.populationNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(274, 12);
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
            this.populationNumberInfo.Size = new System.Drawing.Size(131, 17);
            this.populationNumberInfo.TabIndex = 3;
            this.populationNumberInfo.Text = "Population number:";
            this.populationNumberInfo.Click += new System.EventHandler(this.populationNumberInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.populationNumberInfo);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.populationNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MainWorldTimer;
        private System.Windows.Forms.Label populationNumber;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label populationNumberInfo;
    }
}

