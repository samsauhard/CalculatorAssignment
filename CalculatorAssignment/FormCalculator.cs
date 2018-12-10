using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAssignment
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
            this.Text = "Calculator Assignment 1";
        }

        // Declare Variables
        public double operand1, operand2;
        String operation1;
        char operation;

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            button0.Click += new EventHandler(btn_Click);
            button1.Click += new EventHandler(btn_Click);
            button2.Click += new EventHandler(btn_Click);
            button3.Click += new EventHandler(btn_Click);
            button4.Click += new EventHandler(btn_Click);
            button5.Click += new EventHandler(btn_Click);
            button6.Click += new EventHandler(btn_Click);
            button7.Click += new EventHandler(btn_Click);
            button8.Click += new EventHandler(btn_Click);
            button9.Click += new EventHandler(btn_Click);
            dotBtn.Click += new EventHandler(btn_Click);
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "button0":
                    textBox1.Text += "0";
                    break;
                case "button1":
                    textBox1.Text += "1";
                    break;
                case "button2":
                    textBox1.Text += "2";
                    break;
                case "button3":
                    textBox1.Text += "3"; ;
                    break;
                case "button4":
                    textBox1.Text += "4";
                    break;
                case "button5":
                    textBox1.Text += "5";
                    break;
                case "button6":
                    textBox1.Text += "6";
                    break;
                case "button7":
                    textBox1.Text += "7";
                    break;
                case "button8":
                    textBox1.Text += "8";
                    break;
                case "button9":
                    textBox1.Text += "9";
                    break;
                case "dotBtn":
                    if (!textBox1.Text.Contains("."))
                        textBox1.Text += ".";
                    break;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
            operation = '+';
            textBox1.Text = string.Empty;
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
            operation = '-';
            textBox1.Text = string.Empty;
        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
            operation = '*';
            textBox1.Text = string.Empty;
        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
            operation = '/';
            textBox1.Text = string.Empty;
        }

        private void rootBtn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
            operation1 = "ROOT";
            textBox1.Text = string.Empty;
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
            operation1 = "LOG";
            textBox1.Text = string.Empty;
        }

        private void oneByXBtn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(textBox1.Text);
            operation1 = "OnebyX";
            textBox1.Text = string.Empty;
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            operand2 = double.Parse(textBox1.Text);
            Calculation calc = new Calculation();
            if (operation == '+')
            {
                string result = Convert.ToString(calc.Calculator(Calculation.cEnum.Addition,
                    operand1, operand2));
                textBox1.Text = result.ToString();
            }
            else if (operation == '-')
            {
                string result = Convert.ToString(calc.Calculator(Calculation.cEnum.Subtraction,
                    operand1, operand2));
                textBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                string result = Convert.ToString(calc.Calculator(Calculation.cEnum.Multiply,
                    operand1, operand2));
                textBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                string result = Convert.ToString(calc.Calculator(Calculation.cEnum.Divide,
                    operand1, operand2));
                textBox1.Text = result.ToString();
            }
        }
    }

}
