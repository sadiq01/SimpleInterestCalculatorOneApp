namespace SimpleInterestCalculatorOneApp
{
    partial class SimpleInterestCalculatorUi
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
            this.principalAmountTextBox = new System.Windows.Forms.TextBox();
            this.annualInterestRateTextBox = new System.Windows.Forms.TextBox();
            this.timePeriodTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalAmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // principalAmountTextBox
            // 
            this.principalAmountTextBox.Location = new System.Drawing.Point(165, 25);
            this.principalAmountTextBox.Name = "principalAmountTextBox";
            this.principalAmountTextBox.Size = new System.Drawing.Size(127, 20);
            this.principalAmountTextBox.TabIndex = 0;
            // 
            // annualInterestRateTextBox
            // 
            this.annualInterestRateTextBox.Location = new System.Drawing.Point(165, 60);
            this.annualInterestRateTextBox.Name = "annualInterestRateTextBox";
            this.annualInterestRateTextBox.Size = new System.Drawing.Size(127, 20);
            this.annualInterestRateTextBox.TabIndex = 1;
            // 
            // timePeriodTextBox
            // 
            this.timePeriodTextBox.Location = new System.Drawing.Point(165, 95);
            this.timePeriodTextBox.Name = "timePeriodTextBox";
            this.timePeriodTextBox.Size = new System.Drawing.Size(127, 20);
            this.timePeriodTextBox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(217, 132);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalAmountTextBox
            // 
            this.totalAmountTextBox.Location = new System.Drawing.Point(165, 191);
            this.totalAmountTextBox.Name = "totalAmountTextBox";
            this.totalAmountTextBox.Size = new System.Drawing.Size(127, 20);
            this.totalAmountTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Principal Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Annual Interest Rate(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time Period(In Year)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Amount(Result)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Noted that Interest Calculation Interval:Yearly";
            // 
            // SimpleInterestCalculatorUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 283);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalAmountTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.timePeriodTextBox);
            this.Controls.Add(this.annualInterestRateTextBox);
            this.Controls.Add(this.principalAmountTextBox);
            this.Name = "SimpleInterestCalculatorUi";
            this.Text = "A Simple Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox principalAmountTextBox;
        private System.Windows.Forms.TextBox annualInterestRateTextBox;
        private System.Windows.Forms.TextBox timePeriodTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox totalAmountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

