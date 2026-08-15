using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        private double firstNumber = 0;
        private string operatorSelected = "";
        private bool isNewEntry = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (isNewEntry)
            {
                txtDisplay.Text = clickedButton.Text;
                isNewEntry = false;
            }
            else
            {
                txtDisplay.Text += clickedButton.Text;
            }
        }

        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            firstNumber = double.Parse(txtDisplay.Text);
            operatorSelected = clickedButton.Text;
            isNewEntry = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (operatorSelected)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
            }

            txtDisplay.Text = result.ToString();
            isNewEntry = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            firstNumber = 0;
            operatorSelected = "";
            isNewEntry = true;
        }

        private void button0_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button1_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button2_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button3_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button4_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button5_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button6_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button7_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button8_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);
        private void button9_Click(object sender, EventArgs e) => NumberButton_Click(sender, e);

        private void buttonAdd_Click(object sender, EventArgs e) => OperatorButton_Click(sender, e);
        private void buttonSub_Click(object sender, EventArgs e) => OperatorButton_Click(sender, e);
        private void buttonMultiply_Click(object sender, EventArgs e) => OperatorButton_Click(sender, e);
        private void buttonDivide_Click(object sender, EventArgs e) => OperatorButton_Click(sender, e);
    }
}