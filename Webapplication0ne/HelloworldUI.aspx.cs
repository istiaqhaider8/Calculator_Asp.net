using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webapplication0ne
{
    public partial class HelloworldUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Calculator");

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double sceoundNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = Add(firstNumber, sceoundNumber);
            resultLabel.Text = result.ToString();

        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double sceoundNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = subtract(firstNumber, sceoundNumber);
            resultLabel.Text = result.ToString();

        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double sceoundNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = multiply(firstNumber, sceoundNumber);
            resultLabel.Text = result.ToString();

        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            double sceoundNumber = Convert.ToDouble(secondNumberTextBox.Text);
            double result = division(firstNumber, sceoundNumber);
            resultLabel.Text = result.ToString();

        }

        private double Add(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private double subtract(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private double multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private double division(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

    }
}