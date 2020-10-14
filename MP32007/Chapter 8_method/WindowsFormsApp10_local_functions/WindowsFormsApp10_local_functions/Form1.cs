using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10_local_functions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single avg;
            int s1, s2;

            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);

            avg = compute(s1, s2);

            if (avg == -1)
                label3.Text = "輸入錯誤";
            else
                label3.Text = avg.ToString();

        }

        Single compute(int s1, int s2)
        {
            bool checkscore(int v)
            {
                if (v < 0 || v > 100)
                    return false;
                else
                    return true;
            }

            if (!checkscore(s1) || !checkscore(s2))
                return -1;
            else
                return (s1 + s2) / 2.0f;
        }
    }
}
