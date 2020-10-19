using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10_functions_overloading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "兩數相加=" + add(3, 5).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "兩數相加=" + add(4.2, 3.6).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "兩數相加=" + add(7, 2.6).ToString();
        }

        int add(int a, int b)
        {
            label2.Text = "呼叫第一個函式";
            return a + b;
        }
        double add(double a, double b)
        {
            label2.Text = "呼叫第二個函式";
            return a + b;
        }
        double add(int a, double b)
        {
            label2.Text = "呼叫第三個函式";
            return a + b;
        }
    }
}
