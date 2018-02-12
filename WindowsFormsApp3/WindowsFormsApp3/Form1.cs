using System;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            double result = Sum(firstValue, secondValue);
            textBox3.Text = Convert.ToString(result);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            double result = Subtraction (firstValue, secondValue);
            textBox3.Text = Convert.ToString(result);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            double result = Multiplication (firstValue, secondValue);
            textBox3.Text = Convert.ToString(result);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            double result = Division (firstValue, secondValue);
            textBox3.Text = Convert.ToString(result);
        }

        public static double Sum(double a , double b)
        {
            return a + b;
        }
        public static double Subtraction(double a, double b)
        {
            return a - b;
        }
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
        public static double Division(double a, double b)
        {
            return a / b;
        }
    }
}
