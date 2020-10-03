using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp07_insert_array
{
    public partial class Form1 : Form
    {
        int[] array = { 1, 2, 3, 4, 5, 6 };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length, new_length;
            int no;
            int val, j;
            int[] temp;

            length = array.Length;
            no = Convert.ToInt32(textBox1.Text);
            val = Convert.ToInt32(textBox2.Text);

            if ((no - 1) < -1 || (no - 1) >= length)
            {
                MessageBox.Show("輸入錯誤的範圍");
                return;
            }

            new_length = length + 1;
            temp = new int[new_length];

            for (int i = 0; i < no; i++)
                temp[i] = array[i];

            temp[no] = val;

            j = no + 1;

            for (int i = no; i < length; i++, j++)
                temp[j] = array[i];

            Array.Resize(ref array, new_length);

            for (int i = 0; i < new_length; i++)
                array[i] = temp[i];

            foreach (var item in array)
                textBox3.AppendText(item.ToString() + "\r\n");

        }
    }
}
