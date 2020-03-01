using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Window
{
    public partial class Form1 : Form
    {
        double firstNumber;
        double secondNumber;
        string myOperator;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                label4.Text = "your input is not a number";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                secondNumber = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                label4.Text = "your input is not a number";
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            myOperator = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (myOperator)
            {
                case "+":
                    label4.Text = $"{firstNumber + secondNumber}";
                    break;
                case "-":
                    label4.Text = $"{firstNumber - secondNumber}";
                    break;
                case "*":
                    label4.Text = $"{firstNumber * secondNumber}";
                    break;
                case "/":
                    if (secondNumber < 1e-5)
                        label4.Text = "can't devide 0";
                    else
                        label4.Text = $"{firstNumber / secondNumber}";
                    break;
                default:
                    label4.Text = "your operator is invalid";
                    break;
            } 
        }
    }
}
