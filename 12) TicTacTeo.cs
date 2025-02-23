using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPrep2
{
    public partial class Form1 : Form
    {
        bool checker;

        void enable_true()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }
        void restart()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }

        void score()
        {
            if(btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X" ||
               btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X" ||
               btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X" ||
               btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" ||
               btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X" ||
               btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X" ||
               btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X" ||
               btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X")
            {
                MessageBox.Show("The winner is player X");
                restart();
                enable_true();
                checker = false;
            }


            if (btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O" ||
                btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O" ||
                btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O" ||
                btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" ||
                btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O" ||
                btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O" ||
                btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O" ||
                btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O")
            {
                MessageBox.Show("The winner is player O");
                restart();
                enable_true();
                checker = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(checker==false)
            {
                btn1.Text = "X";
                checker = true;
            }
            else
            {
                btn1.Text = "O";
                checker = false;
            }
            btn1.Enabled = false;
            score();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn2.Text = "X";
                checker = true;
            }
            else
            {
                btn2.Text = "O";
                checker = false;
            }
            btn2.Enabled = false;
            score();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn3.Text = "X";
                checker = true;
            }
            else
            {
                btn3.Text = "O";
                checker = false;
            }
            btn3.Enabled = false;
            score();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn4.Text = "X";
                checker = true;
            }
            else
            {
                btn4.Text = "O";
                checker = false;
            }
            btn4.Enabled = false;
            score();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn5.Text = "X";
                checker = true;
            }
            else
            {
                btn5.Text = "O";
                checker = false;
            }
            btn5.Enabled = false;
            score();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn6.Text = "X";
                checker = true;
            }
            else
            {
                btn6.Text = "O";
                checker = false;
            }
            btn6.Enabled = false;
            score();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn7.Text = "X";
                checker = true;
            }
            else
            {
                btn7.Text = "O";
                checker = false;
            }
            btn7.Enabled = false;
            score();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn8.Text = "X";
                checker = true;
            }
            else
            {
                btn8.Text = "O";
                checker = false;
            }
            btn8.Enabled = false;
            score();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn9.Text = "X";
                checker = true;
            }
            else
            {
                btn9.Text = "O";
                checker = false;
            }
            btn9.Enabled = false;
            score();
        }
    }
}
