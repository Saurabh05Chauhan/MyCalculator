using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isOperatorAdded = false;
        private bool isBracketAdded = false;
        private bool isBracketClosed = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num1Button_Click(object sender, EventArgs e)
        {
            if (isBracketClosed != false)
            {
                if (this.calculatorTextBox.Text.ElementAt(this.calculatorTextBox.Text.Length - 1) != ')')
                {
                    this.calculatorTextBox.Text += "1";

                }
                else
                {
                    this.calculatorTextBox.Text += "*1";

                }
            }
            else
            {
                if (this.calculatorTextBox.Text == "0")
                {
                    this.calculatorTextBox.Text = "1";
                }
                else
                {
                    this.calculatorTextBox.Text += ('1');

                }
            }


            this.calculate();
            this.isOperatorAdded = false;

        }

        private void num2Button_Click(object sender, EventArgs e)
        {
            if (isBracketClosed != false)
            {
                if (this.calculatorTextBox.Text.ElementAt(this.calculatorTextBox.Text.Length - 1) != ')')
                {
                    this.calculatorTextBox.Text += "2";

                }
                else
                {
                    this.calculatorTextBox.Text += "*2";

                }
            }
            else
            {

            
            if (this.calculatorTextBox.Text == "0" )
            {
                this.calculatorTextBox.Text = "2";
            }
            else
            {
                this.calculatorTextBox.Text += ('2');
            }
            }
            this.calculate();
            this.isOperatorAdded = false;
        }

        private void num3Button_Click(object sender, EventArgs e)
        {
            if (isBracketClosed != false)
            {
                if (this.calculatorTextBox.Text.ElementAt(this.calculatorTextBox.Text.Length - 1) != ')')
                {
                    this.calculatorTextBox.Text += "3";

                }
                else
                {
                    this.calculatorTextBox.Text += "*3";

                }
            }
            else
            {
                if (this.calculatorTextBox.Text == "0" )
                {
                    this.calculatorTextBox.Text = "3";
                }
                else
                {
                    this.calculatorTextBox.Text += ('3');
                }
            }
            
            this.calculate();
            this.isOperatorAdded = false;
        }

        private void num4Button_Click(object sender, EventArgs e)
        {
            if (isBracketClosed != false)
            {
                if (this.calculatorTextBox.Text.ElementAt(this.calculatorTextBox.Text.Length - 1) != ')')
                {
                    this.calculatorTextBox.Text += "4";

                }
                else
                {
                    this.calculatorTextBox.Text += "*4";

                }
            }
            else
            {
                if (this.calculatorTextBox.Text == "0")
                {
                    this.calculatorTextBox.Text = "4";
                }
                else
                {
                    this.calculatorTextBox.Text += ('4');
                }
            }
            
            this.calculate();
            this.isOperatorAdded = false;
        }

        private void num5Button_Click(object sender, EventArgs e)
        {
            if (isBracketClosed != false)
            {
                if (this.calculatorTextBox.Text.ElementAt(this.calculatorTextBox.Text.Length - 1) != ')')
                {
                    this.calculatorTextBox.Text += "5";

                }
                else
                {
                    this.calculatorTextBox.Text += "*5";

                }
            }
            else
            {
                if (this.calculatorTextBox.Text == "0")
                {
                    this.calculatorTextBox.Text = "5";
                }
                else
                {
                    this.calculatorTextBox.Text += ('5');
                }
            }
            
            this.calculate();
            this.isOperatorAdded = false;
        }

        private void num6Button_Click(object sender, EventArgs e)
        {

            if (isBracketClosed != false)
            {
                if (this.calculatorTextBox.Text.ElementAt(this.calculatorTextBox.Text.Length - 1) != ')')
                {
                    this.calculatorTextBox.Text += "6";

                }
                else
                {
                    this.calculatorTextBox.Text += "*6";

                }
            }
            else
            {
                if (this.calculatorTextBox.Text == "0")
                {
                    this.calculatorTextBox.Text = "6";
                }
                else
                {
                    this.calculatorTextBox.Text += ('6');
                }
            }
            


            this.calculate();
            this.isOperatorAdded = false;
        }

        private void num7Button_Click(object sender, EventArgs e)
        {

            if (isBracketClosed != false)
            {
                if (this.calculatorTextBox.Text.ElementAt(this.calculatorTextBox.Text.Length - 1) != ')')
                {
                    this.calculatorTextBox.Text += "7";

                }
                else
                {
                    this.calculatorTextBox.Text += "*7";

                }
            }
            else
            {
                if (this.calculatorTextBox.Text == "0")
                {
                    this.calculatorTextBox.Text = "7";
                }
                else
                {
                    this.calculatorTextBox.Text += "7";
                }
            }

            this.calculate();
            this.isOperatorAdded = false;
        }

        private void num8Button_Click(object sender, EventArgs e)
        {
            if (isBracketClosed != false)
            {
                if (this.calculatorTextBox.Text.ElementAt(this.calculatorTextBox.Text.Length - 1) != ')')
                {
                    this.calculatorTextBox.Text += "8";

                }
                else
                {
                    this.calculatorTextBox.Text += "*8";

                }
            }
            else
            {
                if (this.calculatorTextBox.Text == "0" )
                {
                    this.calculatorTextBox.Text = "8";
                }
                else
                {
                    this.calculatorTextBox.Text += '8';
                }
            }
            
            this.calculate();
            this.isOperatorAdded = false;
        }

        private void num9Button_Click(object sender, EventArgs e)
        {

            if (isBracketClosed != false)
            {
                if (this.calculatorTextBox.Text.ElementAt(this.calculatorTextBox.Text.Length - 1) != ')')
                {
                    this.calculatorTextBox.Text += "9";

                }
                else
                {
                    this.calculatorTextBox.Text += "*9";

                }
            }
            else
            {
                if (this.calculatorTextBox.Text == "0" )
                {
                    this.calculatorTextBox.Text = "9";
                }
                else
                {
                    this.calculatorTextBox.Text += ('9');
                }
            }
            
            this.calculate();
            this.isOperatorAdded = false;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            var string1 = this.calculatorTextBox.Text;
            if (isBracketAdded == false)
            {
                if (string1.EndsWith("+") || string1.EndsWith("-") || string1.EndsWith("*") || string1.EndsWith("/"))
                {
                    //this.calucalateLabel.Text = "";
                }
                else
                {
                    DataTable dt = new DataTable();
                    var answer = dt.Compute(this.calculatorTextBox.Text, "");
                    this.calculatorTextBox.Text = answer.ToString();
                    this.calucalateLabel.Text = "";
                }
                
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string text = this.calculatorTextBox.Text;
            if (text.ElementAt(text.Length - 1) != '+' && this.isOperatorAdded == false)
            {
                this.calculatorTextBox.Text += "+";
                this.isOperatorAdded = true;
            }

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            string text = this.calculatorTextBox.Text;
            if (text.ElementAt(text.Length - 1) != '-' && this.isOperatorAdded == false)
            {
                this.calculatorTextBox.Text += "-";
                this.isOperatorAdded = true;

            }

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            string text = this.calculatorTextBox.Text;
            if (text.ElementAt(text.Length - 1) != '*' && this.isOperatorAdded == false)
            {
                this.calculatorTextBox.Text += "*";
                this.isOperatorAdded = true;

            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            string text = this.calculatorTextBox.Text;
            if (text.ElementAt(text.Length - 1) != '/' && this.isOperatorAdded == false)
            {
                this.calculatorTextBox.Text += "/";
                this.isOperatorAdded = true;

            }
        }

        private void percentageButton_Click(object sender, EventArgs e)
        {
            string text = this.calculatorTextBox.Text;
            if (text.ElementAt(text.Length - 1) != '%' && this.isOperatorAdded == false)
            {
                this.calculatorTextBox.Text += "%";
                this.isOperatorAdded = true;
            }
        }

        private void bracketsButton_Click(object sender, EventArgs e)
        {
            this.isOperatorAdded = true;
            string text = this.calculatorTextBox.Text;
            char atLast = text.ElementAt(text.Length - 1);
            var isNumeric = int.TryParse(atLast.ToString(), out int n);
            if (this.calculatorTextBox.Text.IndexOf('(') == -1)
            {
                if (isNumeric)
                {
                    this.calculatorTextBox.Text += "*(";
                    this.isBracketAdded = true;
                }
                else
                {
                    this.calculatorTextBox.Text += "(";
                    this.isBracketAdded = true;
                }
            }
            else
            {
                if (text.ElementAt(text.Length - 1) != '(')
                {
                    this.calculatorTextBox.Text += ")";
                    this.isBracketAdded = false;
                    this.isBracketClosed = true;
                }
                else
                {
                    this.calculatorTextBox.Text += "(";
                    this.isBracketAdded = true;
                }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {

           var string1 = this.calculatorTextBox.Text.Substring(0,this.calculatorTextBox.Text.Length - 1);
            this.calculatorTextBox.Text = string1;
            if(string1.EndsWith("+")|| string1.EndsWith("-")|| string1.EndsWith("*")|| string1.EndsWith("/"))
            {
                this.calucalateLabel.Text = "";
            }
            else
            {
                this.calculate();
            }
            
            
        }

        private void num10Button_Click(object sender, EventArgs e)
        {
            if (isBracketClosed != false)
            {
                if (this.calculatorTextBox.Text.ElementAt(this.calculatorTextBox.Text.Length - 1) != ')')
                {
                    this.calculatorTextBox.Text += "0";

                }
                else
                {
                    this.calculatorTextBox.Text += "*0";

                }
            }
            else
            {
                if (this.calculatorTextBox.Text == "0" )
                {
                    this.calculatorTextBox.Text = "0";
                }
                else
                {
                    this.calculatorTextBox.Text += ('0');
                }
            }
            
            this.calculate();
            this.isOperatorAdded = false;
        }

        private void PointButton_Click(object sender, EventArgs e)
        {
            if (this.calculatorTextBox.Text == "0")
            {
                this.calculatorTextBox.Text = ".";
            }
            else
            {
                this.calculatorTextBox.Text += ('.');
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.isOperatorAdded = false;

            this.calculatorTextBox.Text = "0";

            this.calucalateLabel.Text = "";
        }

        private void calculate()
        {
            if (isBracketAdded == false)
            {
                DataTable dt = new DataTable();
                var answer = dt.Compute(this.calculatorTextBox.Text, "");
                this.calucalateLabel.Text = answer.ToString();
            }

        }
    }
}
