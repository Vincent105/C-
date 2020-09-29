using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp03_arraymethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int [] arr1 = { 15, 35, 18, 5, 19, 2, 13, 8, 22};
            int[] arr2 = { 11, 12, 13, 14, 15, 16 };
            int c;
            int[] arr4;
            int[] arr5 = new int[arr1.Length];

            textBox1.AppendText("--------sort---------\r\n");
            Array.Sort(arr1);
            //Array.Sort(arr1, 1, 3)
            foreach (var item in arr1)
                textBox1.AppendText(item.ToString() + "\r\n");

            textBox1.AppendText("----binary search----\r\n");
            c = Array.BinarySearch(arr1, 18);
            if (c < 0)
                textBox1.AppendText("找不到");
            else
                textBox1.AppendText("你要找的資料在第" + c.ToString() + "個陣列位置");

            textBox1.AppendText("----clear-\r\n");
            Array.Clear(arr1, 2, 4);
            foreach (var item in arr1)
                textBox1.AppendText(item.ToString() + "\r\n");

            textBox1.AppendText("----clone-\r\n");
            arr4 = (int []) arr2.Clone();
            foreach (var item in arr4)
                textBox1.AppendText(item.ToString() + "\r\n");

            textBox1.AppendText("----copy-\r\n");
            Array.Copy(arr1, arr5, 5);
            foreach(ValueType item in arr5)
                textBox1.AppendText(item.ToString() + "\r\n");

            textBox1.AppendText("----copyto-\r\n");
            arr1.CopyTo(arr5, 0);
            foreach (ValueType item in arr5)
                textBox1.AppendText(item.ToString() + "\r\n");

            textBox1.AppendText("----reverse-\r\n");
            Array.Reverse(arr1);
            foreach (ValueType item in arr1)
                textBox1.AppendText(item.ToString() + "\r\n");
        }
    }
}
