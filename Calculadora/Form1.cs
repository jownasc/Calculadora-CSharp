using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operatorClicked = "";
        bool isOperatorClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void click_button(object sender, EventArgs e)
        {
            if(resultBox.Text == "0" || (isOperatorClicked))
            {
                resultBox.Clear();
                

            }

            isOperatorClicked = false;
            Button button = (Button)sender;

            if (button.Text ==".")
            {
                if (resultBox.Text.Contains("."))
                {
                    resultBox.Text = resultBox.Text + button.Text;
                }    
            }
            else
            {
                resultBox.Text = resultBox.Text + button.Text;
            }
                        
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                btnEqual.PerformClick();
                operatorClicked = button.Text;
                isOperatorClicked = true;

            }
            else
            {
                operatorClicked = button.Text;
                resultValue = Double.Parse(resultBox.Text);
                isOperatorClicked = true;
            }
            operatorClicked = button.Text;
            resultValue = Double.Parse(resultBox.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resultBox.Text = "0";
            resultValue = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operatorClicked)
            {
                case "+":
                    resultBox.Text = (resultValue + Double.Parse(resultBox.Text)).ToString();
                    break;
                case "-":
                    resultBox.Text = (resultValue - Double.Parse(resultBox.Text)).ToString();
                    break;
                case "×":
                    resultBox.Text = (resultValue * Double.Parse(resultBox.Text)).ToString();
                    break;
                case "÷":
                    resultBox.Text = (resultValue / Double.Parse(resultBox.Text)).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
