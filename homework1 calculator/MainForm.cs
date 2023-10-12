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

            if (ExpressionTextBox.Text != "0" 
                && result != Convert.ToDouble(NumbersTextBox.Text))
                ResultButton.PerformClick();

            operation = button.Text;

            ExpressionTextBox.Text = NumbersTextBox.Text + operation;

            number1 = Convert.ToDouble(NumbersTextBox.Text);
            NumbersTextBox.Text = "0";
        }

        private void ResultButton_Click(object sender, EventArgs e)
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
                case "%":
                    result = Convert.ToDouble(NumbersTextBox.Text) * number1 / 100;
                    break;
                default:
                    break;
            }

            ExpressionTextBox.Text += NumbersTextBox.Text;
            NumbersTextBox.Text = result.ToString();

            
        }

        private void CEButton_Click(object sender, EventArgs e)
        {
            NumbersTextBox.Text = "0";
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            NumbersTextBox.Text = "0";
            ExpressionTextBox.Text = "0";
            number1 = 0;
            result = 0;
            operation = null;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (NumbersTextBox.Text.Length == 1) NumbersTextBox.Text = "0";
            else NumbersTextBox.Text = NumbersTextBox.Text[..^1];
        }

        private void OneByXButton_Click(object sender, EventArgs e)
        {
            if (ExpressionTextBox.Text != "0")
                ResultButton.PerformClick();

            ExpressionTextBox.Text = "1/" + NumbersTextBox.Text;
            result = 1 / Convert.ToDouble(NumbersTextBox.Text);
            NumbersTextBox.Text = result.ToString();
        }

        private void XSquaredButton_Click(object sender, EventArgs e)
        {
            if (ExpressionTextBox.Text != "0")
                ResultButton.PerformClick();

            ExpressionTextBox.Text = NumbersTextBox.Text + "²";
            result = Math.Pow(Convert.ToDouble(NumbersTextBox.Text), 2);
            NumbersTextBox.Text = result.ToString();
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            if (ExpressionTextBox.Text != "0")
                ResultButton.PerformClick();

            ExpressionTextBox.Text = "√" + NumbersTextBox.Text;
            result = Math.Sqrt(Convert.ToDouble(NumbersTextBox.Text));
            NumbersTextBox.Text = result.ToString();
        }

    }
}
