using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp08_dowhile
{
    public partial class Form1 : Form
    {
        bool fg = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            fg = checkBox1.Checked;
            checkBox1.Text = "fg=" + fg.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int i = 1;
            textBox1.Text = "";
            do
            {
                sum += 1;
                textBox1.AppendText(sum.ToString() + "\r\n");
                i++;
                Application.DoEvents();

            } while (fg == true && i <= 10);
        }
    }
}
