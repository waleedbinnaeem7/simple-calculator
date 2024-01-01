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
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "admin" && txt_password.Text == "123")
            {
               // MessageBox.Show("valid user");
                Calculator sc = new Calculator ();
                sc.Show();

            }
            else
            { 
                MessageBox.Show("invalid user");
            }
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
