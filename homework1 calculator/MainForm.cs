using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1_calculator
{
    public partial class MainForm : Form
    {

        private double number1 = 0;
        private double result = 0;
        private string operation;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (NumbersTextBox.Text == "0") NumbersTextBox.Text = null;
            NumbersTextBox.Text += button.Text;
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            if (NumbersTextBox.Text.StartsWith('-'))
            {
                NumbersTextBox.Text = NumbersTextBox.Text.Substring(1);
            }
 
            else
            {
                NumbersTextBox.Text = '-' + NumbersTextBox.Text;
            }
        }

        private void FloatButton_Click(object sender, EventArgs e)
        {
            if (!NumbersTextBox.Text.Contains(','))
            {
                NumbersTextBox.Text += ",";
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            

            if (ExpressionTextBox.Text == "0")
            {
                //ExpressionTextBox.Text = NumbersTextBox.Text + operation;
            }
            else
            {
                if (result != Convert.ToDouble(NumbersTextBox.Text))
                    ResultButton.PerformClick();
      
                //ExpressionTextBox.Text = result.ToString() + operation;

            }
            
            operation = button.Text;

            ExpressionTextBox.Text = NumbersTextBox.Text + operation;

            number1 = Convert.ToDouble(NumbersTextBox.Text);
            NumbersTextBox.Text = "0";
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (NumbersTextBox.Text != "0")
            {
                switch (operation)
                {
                    case "+":
                        result = number1 + Convert.ToDouble(NumbersTextBox.Text);
                        break;
                    case "-":
                        result = number1 - Convert.ToDouble(NumbersTextBox.Text);
                        break;
                    case "×":
                        result = number1 * Convert.ToDouble(NumbersTextBox.Text);
                        break;
                    case "÷":
                        result = number1 / Convert.ToDouble(NumbersTextBox.Text);
                        break;
                    default:
                        break;
                }

                ExpressionTextBox.Text += NumbersTextBox.Text;
                NumbersTextBox.Text = result.ToString();

            }
        }
    }
}
