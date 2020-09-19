using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp02_IF_Else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            age = Convert.ToInt32(textBox1.Text);

            if (age <= 18)
            {
                MessageBox.Show("未滿18歲不能買酒");
            }
            else
            {
                label2.Visible = true;
                textBox2.Visible = true;
                button2.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt32(textBox2.Text);

            label4.Text = (number * 32).ToString();
        }
    }
}
