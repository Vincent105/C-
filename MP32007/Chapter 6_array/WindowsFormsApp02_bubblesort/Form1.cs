using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp02_bubblesort
{
    public partial class Form1 : Form
    {
        int[] array = { 27, 22, 29, 15, 18, 15, 33, 26 };
        int length;
        int temp;
        string str = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in array)
                str += item.ToString() + ",";
            textBox1.AppendText("原始資料:" + str + "\r\n");

            length = array.Length;
            textBox1.AppendText("陣列長度:" + length.ToString() + "\r\n");

            //氣泡排序法
            for (int i = 0; i < length - 1; i++)
                for (int j = length - 1; j >= 1; j--)
                    if (array[j] < array[j - 1])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }

            str = "";
            foreach (var item in array)
                str += item.ToString() + ",";
            textBox1.AppendText("氣泡排序:" + str + "\r\n");
                
        }

    }
}
