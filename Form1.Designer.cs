
using DotNetty.Transport.Bootstrapping;

namespace MyCalculator
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
            this.calculatorTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.bracketsButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.num10Button = new System.Windows.Forms.Button();
            this.num1Button = new System.Windows.Forms.Button();
            this.num2Button = new System.Windows.Forms.Button();
            this.num3Button = new System.Windows.Forms.Button();
            this.num4Button = new System.Windows.Forms.Button();
            this.num5Button = new System.Windows.Forms.Button();
            this.num6Button = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.PointButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.num9Button = new System.Windows.Forms.Button();
            this.num8Button = new System.Windows.Forms.Button();
            this.num7Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calucalateLabel = new System.Windows.Forms.Label();
            this.btnCE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calculatorTextBox
            // 
            this.calculatorTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.calculatorTextBox.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.calculatorTextBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.calculatorTextBox.Location = new System.Drawing.Point(45, 42);
            this.calculatorTextBox.Name = "calculatorTextBox";
            this.calculatorTextBox.ReadOnly = true;
            this.calculatorTextBox.Size = new System.Drawing.Size(367, 22);
            this.calculatorTextBox.TabIndex = 0;
            this.calculatorTextBox.Text = "0";
            this.calculatorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(45, 110);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // bracketsButton
            // 
            this.bracketsButton.Location = new System.Drawing.Point(145, 110);
            this.bracketsButton.Name = "bracketsButton";
            this.bracketsButton.Size = new System.Drawing.Size(75, 23);
            this.bracketsButton.TabIndex = 2;
            this.bracketsButton.Text = "()";
            this.bracketsButton.UseVisualStyleBackColor = true;
            this.bracketsButton.Click += new System.EventHandler(this.bracketsButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(237, 110);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 4;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // num10Button
            // 
            this.num10Button.Location = new System.Drawing.Point(145, 286);
            this.num10Button.Name = "num10Button";
            this.num10Button.Size = new System.Drawing.Size(75, 23);
            this.num10Button.TabIndex = 8;
            this.num10Button.Text = "0";
            this.num10Button.UseVisualStyleBackColor = true;
            this.num10Button.Click += new System.EventHandler(this.num10Button_Click);
            // 
            // num1Button
            // 
            this.num1Button.Location = new System.Drawing.Point(45, 243);
            this.num1Button.Name = "num1Button";
            this.num1Button.Size = new System.Drawing.Size(75, 23);
            this.num1Button.TabIndex = 9;
            this.num1Button.Text = "1";
            this.num1Button.UseVisualStyleBackColor = true;
            this.num1Button.Click += new System.EventHandler(this.num1Button_Click);
            // 
            // num2Button
            // 
            this.num2Button.Location = new System.Drawing.Point(145, 243);
            this.num2Button.Name = "num2Button";
            this.num2Button.Size = new System.Drawing.Size(75, 23);
            this.num2Button.TabIndex = 10;
            this.num2Button.Text = "2";
            this.num2Button.UseVisualStyleBackColor = true;
            this.num2Button.Click += new System.EventHandler(this.num2Button_Click);
            // 
            // num3Button
            // 
            this.num3Button.Location = new System.Drawing.Point(237, 243);
            this.num3Button.Name = "num3Button";
            this.num3Button.Size = new System.Drawing.Size(75, 23);
            this.num3Button.TabIndex = 20;
            this.num3Button.Text = "3";
            this.num3Button.UseVisualStyleBackColor = true;
            this.num3Button.Click += new System.EventHandler(this.num3Button_Click);
            // 
            // num4Button
            // 
            this.num4Button.Location = new System.Drawing.Point(45, 198);
            this.num4Button.Name = "num4Button";
            this.num4Button.Size = new System.Drawing.Size(75, 23);
            this.num4Button.TabIndex = 19;
            this.num4Button.Text = "4";
            this.num4Button.UseVisualStyleBackColor = true;
            this.num4Button.Click += new System.EventHandler(this.num4Button_Click);
            // 
            // num5Button
            // 
            this.num5Button.Location = new System.Drawing.Point(145, 198);
            this.num5Button.Name = "num5Button";
            this.num5Button.Size = new System.Drawing.Size(75, 23);
            this.num5Button.TabIndex = 18;
            this.num5Button.Text = "5";
            this.num5Button.UseVisualStyleBackColor = true;
            this.num5Button.Click += new System.EventHandler(this.num5Button_Click);
            // 
            // num6Button
            // 
            this.num6Button.Location = new System.Drawing.Point(237, 198);
            this.num6Button.Name = "num6Button";
            this.num6Button.Size = new System.Drawing.Size(75, 23);
            this.num6Button.TabIndex = 17;
            this.num6Button.Text = "6";
            this.num6Button.UseVisualStyleBackColor = true;
            this.num6Button.Click += new System.EventHandler(this.num6Button_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(337, 156);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 15;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(337, 198);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Location = new System.Drawing.Point(337, 243);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(75, 66);
            this.equalButton.TabIndex = 13;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);
            // 
            // PointButton
            // 
            this.PointButton.Location = new System.Drawing.Point(237, 286);
            this.PointButton.Name = "PointButton";
            this.PointButton.Size = new System.Drawing.Size(75, 23);
            this.PointButton.TabIndex = 12;
            this.PointButton.Text = ".";
            this.PointButton.UseVisualStyleBackColor = true;
            this.PointButton.Click += new System.EventHandler(this.PointButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(337, 110);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 24;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // num9Button
            // 
            this.num9Button.Location = new System.Drawing.Point(237, 156);
            this.num9Button.Name = "num9Button";
            this.num9Button.Size = new System.Drawing.Size(75, 23);
            this.num9Button.TabIndex = 23;
            this.num9Button.Text = "9";
            this.num9Button.UseVisualStyleBackColor = true;
            this.num9Button.Click += new System.EventHandler(this.num9Button_Click);
            // 
            // num8Button
            // 
            this.num8Button.Location = new System.Drawing.Point(145, 156);
            this.num8Button.Name = "num8Button";
            this.num8Button.Size = new System.Drawing.Size(75, 23);
            this.num8Button.TabIndex = 22;
            this.num8Button.Text = "8";
            this.num8Button.UseVisualStyleBackColor = true;
            this.num8Button.Click += new System.EventHandler(this.num8Button_Click);
            // 
            // num7Button
            // 
            this.num7Button.Location = new System.Drawing.Point(45, 156);
            this.num7Button.Name = "num7Button";
            this.num7Button.Size = new System.Drawing.Size(75, 23);
            this.num7Button.TabIndex = 21;
            this.num7Button.Text = "7";
            this.num7Button.UseVisualStyleBackColor = true;
            this.num7Button.Click += new System.EventHandler(this.num7Button_Click);
           
            // 
            // calucalateLabel
            // 
            this.calucalateLabel.AutoSize = true;
            this.calucalateLabel.Location = new System.Drawing.Point(334, 76);
            this.calucalateLabel.Name = "calucalateLabel";
            this.calucalateLabel.Size = new System.Drawing.Size(0, 17);
            this.calucalateLabel.TabIndex = 25;
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(45, 286);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(75, 23);
            this.btnCE.TabIndex = 26;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(441, 384);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.calucalateLabel);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.num9Button);
            this.Controls.Add(this.num8Button);
            this.Controls.Add(this.num7Button);
            this.Controls.Add(this.num3Button);
            this.Controls.Add(this.num4Button);
            this.Controls.Add(this.num5Button);
            this.Controls.Add(this.num6Button);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.PointButton);
            this.Controls.Add(this.num2Button);
            this.Controls.Add(this.num1Button);
            this.Controls.Add(this.num10Button);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.bracketsButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculatorTextBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calculatorTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button bracketsButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button num10Button;
        private System.Windows.Forms.Button num1Button;
        private System.Windows.Forms.Button num2Button;
        private System.Windows.Forms.Button num3Button;
        private System.Windows.Forms.Button num4Button;
        private System.Windows.Forms.Button num5Button;
        private System.Windows.Forms.Button num6Button;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button PointButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button num9Button;
        private System.Windows.Forms.Button num8Button;
        private System.Windows.Forms.Button num7Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label calucalateLabel;
        private System.Windows.Forms.Button btnCE;
    }
}

