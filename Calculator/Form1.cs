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
        private double firstNumber;
        private double secondNumber;
        private string operation;
        public Form1()
        {
            InitializeComponent();
        }


        private void button17_Click(object sender, EventArgs e)
        {


            // Get the text from the TextBox
            string equation = textBox1.Text;

            // Replace the comma with a dot to handle decimal numbers correctly
            equation = equation.Replace(',', '.');

            // Split the equation into tokens using the space as the separator
            string[] tokens = equation.Split(' ');

            // Parse the first number
            firstNumber = double.Parse(tokens[0]);

            // Get the operator
            operation = tokens[1];

            // Parse the second number
            secondNumber = double.Parse(tokens[2]);

            // Calculate the result
            double result = CalculateResult();

            // Display the result
            MessageBox.Show("The result is " + result);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if ((textBox1.Text == "") || (text[text.Length - 1] == ' '))
            {
                MessageBox.Show("Please add a valid number first!");
            }
            else if (text[text.Length - 1] == ',')
            {
                DisplayText("0 - ");
            }
            else
            {
                DisplayText(" - ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayText("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DisplayText("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DisplayText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DisplayText("6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DisplayText("7");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DisplayText("8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DisplayText("9");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DisplayText("0");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if (textBox1.Text == "")
            {
                DisplayText("0,");
            }
            else if (text[text.Length - 1] == ',')
            {
                MessageBox.Show("Please put a number prior to adding a comma!");
            }
            else if (text[text.Length - 1] == ' ')
            {
                DisplayText("0,");
            }
            else
            {
                DisplayText(",");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if ((textBox1.Text == "") || (text[text.Length - 1] == ' '))
            {
                MessageBox.Show("Please add a valid number first!");
            }
            else if (text[text.Length - 1] == ',')
            {
                DisplayText("0 + ");
            }
            else
            {
                DisplayText(" + ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if ((textBox1.Text == "") || (text[text.Length - 1] == ' '))
            {
                MessageBox.Show("Please add a valid number first!");
            }
            else if (text[text.Length - 1] == ',')
            {
                DisplayText("0 * ");
            }
            else
            {
                DisplayText(" * ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            if ((textBox1.Text == "") || (text[text.Length - 1] == ' '))
            {
                MessageBox.Show("Please add a valid number first!");
            }
            else if (text[text.Length - 1] == ',')
            {
                DisplayText("0 / ");
            }
            else
            {
                DisplayText(" / ");
            }
        }
        private void DisplayText(string addition)
        {
            textBox1.Text = textBox1.Text + addition;
        }

        private double CalculateResult()
        {
            switch (operation)
            {
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                case "*":
                    return firstNumber * secondNumber;
                case "/":
                    // Check if the second number is zero to avoid division by zero
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Error: Division by zero");
                        return 0;
                    }
                    else
                    {
                        return firstNumber / secondNumber;
                    }
                default:
                    // If the operator is not recognized, show an error message
                    MessageBox.Show("Error: Unknown operator " + operation);
                    return 0;
            }
        }
    }
}
