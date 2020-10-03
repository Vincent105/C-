using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp05_Search_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] array = { 4, 12, 87, 45, 14, 13, 56, 9, 33, 6, 21, 8};
            int len;
            int val;

            val = Convert.ToInt32(textBox1.Text);
            len = array.Length;

            for (int i = 0; i < len ; i++)
                if (val == array[i])
                {
                    label2.Text = "找到了在第" + (i + 1).ToString() + "個字元";
                    return;
                }
            label2.Text = "找不到";

        }
    }
}
