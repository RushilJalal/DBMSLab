using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1_calculator
{
    public partial class Form1 : Form
    {
        String str1 = "";
        String str2 = "";
        char opr;
        double res = 0.0;
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                str1 += "0";
                textBox1.Text = str1;
            }
            else
            {
                str2 += "0";
                textBox1.Text = str1 + opr + str2;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            opr = '+';
            c++;
            textBox1.Text += opr;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                str1 += "7";
                textBox1.Text = str1;
            }
            else
            {
                str2 += "7";
                textBox1.Text = str1 + opr + str2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                str1 += "1";
                textBox1.Text = str1;
            }
            else
            {
                str2 += "1";
                textBox1.Text = str1 + opr + str2;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                str1 += "2";
                textBox1.Text = str1;
            }
            else
            {
                str2 += "2";
                textBox1.Text = str1 + opr + str2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                str1 += "3";
                textBox1.Text = str1;
            }
            else
            {
                str2 += "3";
                textBox1.Text = str1 + opr + str2;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                str1 += "4";
                textBox1.Text = str1;
            }
            else
            {
                str2 += "4";
                textBox1.Text = str1 + opr + str2;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                str1 += "5";
                textBox1.Text = str1;
            }
            else
            {
                    str2 += "5";
                textBox1.Text = str1 + opr + str2;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                str1 += "6";
                textBox1.Text = str1;
            }
            else
            {
                str2 += "6";
                textBox1.Text = str1 + opr + str2;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                str1 += "8";
                textBox1.Text = str1;
            }
            else
            {
                str2 += "8";
                textBox1.Text = str1 + opr + str2;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                str1 += "9";
                textBox1.Text = str1;
            }
            else
            {
                str2 += "9";
                textBox1.Text = str1 + opr + str2;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double num1, num2;
            double.TryParse(str1, out num1);
            double.TryParse(str2, out num2);

            if (opr == '+')
            {
                res = num1 + num2;
            }
            else if (opr == '-')
            {
                res = num1 - num2;
            }
            else if (opr == '*')
            {
                res = num1 * num2;
            }
            else if (opr == '/')
            {
                if (num2 != 0)
                {
                    res = num1 / num2;
                }
                else
                {
                    textBox1.Text = "DIV/Zero!";
                    return; // Exit the method to avoid further execution
                }
            }

            textBox1.Text = res.ToString();
            str1 = res.ToString();
            str2 = "";
            c = 0;
        }


        private void button13_Click(object sender, EventArgs e)
        {
            opr = '-';
            c++;
            textBox1.Text += opr;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            opr = '*';
            c++;
            textBox1.Text += opr;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            opr = '/';
            c++;
            textBox1.Text += opr;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double num;
            double.TryParse(textBox1.Text, out num);
            res = Math.Sin(num * (Math.PI / 180));
            textBox1.Text = res.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double num;
            double.TryParse(textBox1.Text, out num);
            textBox1.Text = Math.Log(num).ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            str1 = "";
            str2 = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double num;
            double.TryParse(textBox1.Text, out num);
            num *= num;
            textBox1.Text = num.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double num;
            double.TryParse(textBox1.Text, out num);
            textBox1.Text = Math.Cos(num * (Math.PI / 180).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (c == 0)
            {
                str1 += ".";
                textBox1.Text = str1;
            }
            else
            {
                str2 += ".";
                textBox1.Text = str1 + opr + str2;
            }
        }
    }
}
