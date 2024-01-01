using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input_1;
            int input_2;
            input_1 = Convert.ToInt16(textBox1.Text);
            input_2 = Convert.ToInt16(textBox2.Text);
            int result = input_1 + input_2;
            textBox3.Text = result.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            int input_1;
            int input_2;
            input_1 = Convert.ToInt16(textBox1.Text);
            input_2 = Convert.ToInt16(textBox2.Text);
            int result = input_1 - input_2;
            textBox3.Text = result.ToString();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            int input_1;
            int input_2;
            input_1 = Convert.ToInt16(textBox1.Text);
            input_2 = Convert.ToInt16(textBox2.Text);
            int result = input_1 * input_2;
            textBox3.Text = result.ToString();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            int input_1;
            int input_2;
            input_1 = Convert.ToInt16(textBox1.Text);
            input_2 = Convert.ToInt16(textBox2.Text);
            int result = input_1 / input_2;
            textBox3.Text = result.ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            //this.BackColor = Color.Green;
        }
    }
}
