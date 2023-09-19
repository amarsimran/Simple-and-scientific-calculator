using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculator
{
    public partial class Calculator : Form

    {

        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";
        string memory = "";
        float value1;
       
        public Calculator()
        {
            InitializeComponent();
        }

       
        private void btnnum1_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "1";
            CalculatorDisplay.Text += userInput;
        }

       
        private void btnnum2_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "2";
            CalculatorDisplay.Text = "2";
        }

        private void btnnum3_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "3";
            CalculatorDisplay.Text = "3";
        }

        private void btnnum4_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "4";
            CalculatorDisplay.Text = "4";
        }

        private void btnnum5_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "5";
            CalculatorDisplay.Text = "5";
        }

        private void btnnum6_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "6";
            CalculatorDisplay.Text = "6";
        }

        private void btnnum7_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "7";
            CalculatorDisplay.Text = "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "8";
            CalculatorDisplay.Text = "8";
        }

        private void btnnum9_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "9";
            CalculatorDisplay.Text = "9";
        }

        private void btnnum0_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "0";
            CalculatorDisplay.Text = "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = ".";
        }
        private void btnDivision_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            //Add
            if(function == '+')
            {
                result = firstNum + secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
            //Substraction
            else if(function == '-')
            {
                result = firstNum - secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
            //Divide
            else if(function == '/')
            {
               if(secondNum == '0')
                {
                    CalculatorDisplay.Text = "No";
                }
               else
                {
                    result = firstNum / secondNum;
                    CalculatorDisplay.Text = result.ToString();
                }
            }
            //Multiplication
            else if(function == '*')
            {
                result = firstNum * secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
        }

      

        private void button19_Click(object sender, EventArgs e)
        {
            double sqroot;
            value1 = float.Parse(CalculatorDisplay.Text);
            sqroot = value1 * value1;
            CalculatorDisplay.Text = sqroot.ToString();
        }

        private void lblInput_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = memory.ToString();

        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "0";
            memory = 0.ToString();
            btnMR.Enabled = false;
            btnMC.Enabled = false;
       
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(CalculatorDisplay.Text).ToString();
            btnMC.Enabled = true;
            btnMR.Enabled = true;
            


        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            memory += double.Parse(CalculatorDisplay.Text);
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {
          //  memory -= double.Parse(CalculatorDisplay.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            CalculatorDisplay.Text = "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = CalculatorDisplay.Text.Remove(Text.Length - 1);
            if (CalculatorDisplay.Text.Length == 0)
                CalculatorDisplay.Text = "0";
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            //percentage : (value 1/ 100)
        }

        private void btnsqr_Click(object sender, EventArgs e)
        {
            double sqr;
            value1 = float.Parse(CalculatorDisplay.Text);
            sqr = value1 * value1;
            CalculatorDisplay.Text = sqr.ToString();
        }

        private void btnsq_Click(object sender, EventArgs e)
        {
            double sqr;
            value1 = float.Parse(CalculatorDisplay.Text);
            sqr = value1 * value1;
            CalculatorDisplay.Text = sqr.ToString();
        }
    }

}
