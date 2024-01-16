using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bankform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.nameValue = textBox1.Text;
            form2.AddressValue = textBox2.Text;
            int age;
            if(int.TryParse(textBox3.Text, out age))
            {
                form2.AgeValue = textBox3.Text;
                form2.Show();
            }
            else
            {
                MessageBox.Show("Enter valid age");
            }

            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
