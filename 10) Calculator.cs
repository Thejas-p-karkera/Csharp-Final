using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPrep1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Total, option;
        double num1, num2, result;

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn9.Text;
        }

        private void btnMns_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(textBox.Text);

            textBox.Text = textBox.Text + option;
        }

        private void btnMlt_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(textBox.Text);

            textBox.Text = textBox.Text + option;
        }

        private void btnDvd_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(textBox.Text);

textBox.Text = textBox.Text + option;        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btnDot.Text;
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox.Text.Substring(textBox.Text.LastIndexOf(option)+1));

            if(option == "+")
            {
                result = num1 + num2;
            }

            if (option == "-")
            {
                result = num1 - num2;
            }

            if (option == "*")
            {
                result = num1 * num2;
            }

            if (option == "/")
            {
                result = num1 / num2;
            }

            textBox.Text = result+" ";

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void btnPls_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(textBox.Text);

            textBox.Text = textBox.Text + option;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + btn0.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
