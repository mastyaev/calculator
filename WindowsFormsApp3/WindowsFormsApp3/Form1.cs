using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            double result = Sum(firstValue, secondValue);
            textBox3.Text = Convert.ToString(result);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            double result = Sum(firstValue, secondValue);
            textBox3.Text = Convert.ToString(result);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            double result = Sum(firstValue, secondValue);
            textBox3.Text = Convert.ToString(result);
        }

        public static double Sum(double a , double b)
        {
            return a + b;
        }
        public static double Razn(double a, double b)
        {
            return a - b;
        }
        public static double Umnog(double a, double b)
        {
            return a * b;
        }
        public static double Del(double a, double b)
        {
            return a / b;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Razn(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(Del(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }
    }
}
