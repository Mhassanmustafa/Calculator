using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Boolean isOperationPerforn = false;
        public double result = 0.0;
        public String operationPerformed = "";

        public Form1()
        {
           
            InitializeComponent();
            textBoxResult.Text = " ";
        }


        private void button12_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || (isOperationPerforn)){
                resultBox.Clear();
            }
            isOperationPerforn = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!(resultBox.Text.Contains(".")))
                {
                    resultBox.Text = resultBox.Text + b.Text;
                }
            }
            else
            {

                resultBox.Text = resultBox.Text + b.Text;
            }
        }

        public void operatorClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(result != 0)
            {
                //button21.PerformClick();
                operationPerformed = b.Text;
                textBoxResult.Text =  result + " " + operationPerformed;
                resultBox.Clear();
                isOperationPerforn = false;
                
            }
            else
            {
                operationPerformed = b.Text;
                result = Double.Parse(resultBox.Text);
                textBoxResult.Text = result + " " + operationPerformed;
                isOperationPerforn = true;
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    resultBox.Text = (result + Double.Parse(resultBox.Text)).ToString();
                    break;
                case "-":
                    resultBox.Text = (result - Double.Parse(resultBox.Text)).ToString();
                    break;
                case "*":
                    resultBox.Text = (result * Double.Parse(resultBox.Text)).ToString();
                    break;
                case "/":
                    resultBox.Text = (result / Double.Parse(resultBox.Text)).ToString();
                    break;
                case "%":
                    resultBox.Text = (result % Double.Parse(resultBox.Text)).ToString();
                    break;
                case "X^2":
                    resultBox.Text = (result * result).ToString();
                    break;
                case "1/x":
                    resultBox.Text = (1 / result).ToString();
                    break;
                case "√":
                    resultBox.Text = Math.Sqrt(result).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(resultBox.Text);
            textBoxResult.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
            result = 0.0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (resultBox.Text.Length > 0)
            {
                int length = resultBox.Text.Length;
                resultBox.Text = resultBox.Text.Substring(0, length - 1);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double result = Double.Parse(resultBox.Text);
            result = result * (-1);
            resultBox.Text = result.ToString();
        }
    }
}
