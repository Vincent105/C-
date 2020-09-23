using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp05_continueBreak
{
    public partial class Form1 : Form
    {
        bool fg = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fg = true;
            textBox1.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fg = false;
            textBox2.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fg = true;
            radioButton1.Checked = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            fg = false;
            radioButton2.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int val;
            string str;

            textBox3.Clear();

            for (int i = 1; i <= 10; i++)
            {
                if (fg == true)
                {
                    val = Convert.ToInt32(textBox1.Text);

                    if (i == val)
                        continue;
                }
                else
                {
                    val = Convert.ToInt32(textBox2.Text);

                    if (i == val)
                        break;
                }
                sum += i;
                str = "i=" + i.ToString() + "\t" + "sum=" + sum.ToString();
                textBox3.AppendText(str + "\r\n");
            }

        }
    }
}
