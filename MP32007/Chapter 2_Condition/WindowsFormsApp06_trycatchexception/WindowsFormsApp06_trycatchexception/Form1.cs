using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp06_trycatchexception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a = 1, b = 1, c;
            bool fgerror;

            try
            {
                a = Convert.ToInt32(textBox1.Text);
                b = Convert.ToInt32(textBox2.Text);
                fgerror = false;
            }
            catch (FormatException ex)
            {
                textBox3.AppendText(ex.Message + "\r\n");
                a = 1;
                b = 1;
                fgerror = true;
            }
            finally
            {
                textBox3.AppendText("a=" + a.ToString() + "\r\n");
                textBox3.AppendText("b=" + b.ToString() + "\r\n");
            }
            if (fgerror == false)
                try
                {
                    c = a / b;
                    label3.Text = c.ToString();
                    label3.Visible = true;
                }
                catch (DivideByZeroException ex2)
                {
                    textBox3.AppendText(ex2.Message);
                    label3.Text = "";
                    b = 1;
                    textBox2.Text = b.ToString();
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label3.Visible = false;
        }
    }
}
