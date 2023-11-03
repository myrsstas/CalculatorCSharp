using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTB.Text);
            double secondNumber = Convert.ToDouble(secondNumberTB.Text);
            resultTB.Text = (firstNumber + secondNumber).ToString();

        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTB.Text);
            double secondNumber = Convert.ToDouble(secondNumberTB.Text);
            resultTB.Text = (firstNumber - secondNumber).ToString();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTB.Text);
            double secondNumber = Convert.ToDouble(secondNumberTB.Text);
            resultTB.Text = (firstNumber * secondNumber).ToString();
        }

        private void division_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTB.Text);
            double secondNumber = Convert.ToDouble(secondNumberTB.Text);
            if (secondNumber != 0)
            {
                resultTB.Text = (firstNumber / secondNumber).ToString();
            } else
            {
                resultTB.Text = "Undefined";
            }
        }
    }
}
