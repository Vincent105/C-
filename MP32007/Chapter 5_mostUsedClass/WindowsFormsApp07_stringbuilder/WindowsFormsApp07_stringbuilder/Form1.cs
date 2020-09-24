using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp07_stringbuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder str1;

            str1 = new StringBuilder(5);
            
            str1.Append("1234");
            textBox1.AppendText("str1=" + str1.ToString() + "\r\n");
            textBox1.AppendText("Capacity:" + str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText("Length:" + str1.Length.ToString() + "\r\n");
            
            str1.Append("5678");
            textBox1.AppendText("str1=" + str1.ToString() + "\r\n");
            textBox1.AppendText("Capacity:" + str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText("Length:" + str1.Length.ToString() + "\r\n");

            str1.Length = 15;
            textBox1.AppendText("str1=" + str1.ToString() + "\r\n");
            textBox1.AppendText("Capacity:" + str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText("Length:" + str1.Length.ToString() + "\r\n");

            str1.Clear();
            str1.Append("123");
            textBox1.AppendText("str1=" + str1.ToString() + "\r\n");
            textBox1.AppendText("Capacity:" + str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText("Length:" + str1.Length.ToString() + "\r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            StringBuilder str1;
            str1 = new StringBuilder();
            textBox1.AppendText(str1.Capacity.ToString() + "\r\n");

            str1.Append("12345678901234567");
            textBox1.AppendText("str1=" + str1.ToString() + "\r\n");
            textBox1.AppendText("Capacity:" + str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText("Length:" + str1.Length.ToString() + "\r\n");

            str1.Length = 10;
            textBox1.AppendText("str1=" + str1.ToString() + "\r\n");
            textBox1.AppendText("Capacity:" + str1.Capacity.ToString() + "\r\n");
            textBox1.AppendText("Length:" + str1.Length.ToString() + "\r\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            StringBuilder str1 = new StringBuilder("123");
            StringBuilder str2 = new StringBuilder();

            char[]  c = { 'a', 'b', 'c', 'd', 'e' };
            char[] c1 = new char[4];

            textBox1.AppendText(str1.Length.ToString() + "\r\n");
            str1.AppendLine();
            textBox1.AppendText(str2.Length.ToString() + "\r\n");

            //appendline換行符號
            textBox1.AppendText("====================\r\n");
            str1.Append('c', 5).AppendLine("dddddd");
            textBox1.AppendText(str1.ToString() + "\r\n");
            textBox1.AppendText(str1.Length.ToString() + "\r\n");

            //依格式附加字串
            str2.AppendFormat("我與{0}一同買了{1}個電腦", "小明", 1);
            textBox1.AppendText(str2.ToString() + "\r\n");

            str2.CopyTo(1, c1, 0, 4);
            textBox1.AppendText(new string(c1) + "\r\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            StringBuilder str1 = new StringBuilder("abcd");
            StringBuilder str2 = new StringBuilder("1234567");

            //Equals除了比對內容 還比對容量及最大容量
            textBox1.AppendText(str1.Equals("abcd").ToString() + "\r\n");
            textBox1.AppendText(str1.Equals(new StringBuilder("abcd")).ToString() + "\r\n");

            //插入字串
            str2.Insert(3, "abc", 1);
            textBox1.AppendText(str2.ToString() + "\r\n");
            str2.Insert(3, "ijk", 2);
            textBox1.AppendText(str2.ToString() + "\r\n");

            //移除字串
            str2.Remove(3, 6);
            textBox1.AppendText(str2.ToString() + "\r\n");

            //替換字串
            str2.Clear();
            str2.Append("123abc456abc789abc");
            str2.Replace("abc","zzz",3 ,9);
            textBox1.AppendText(str2.ToString() + "\r\n");

        }
    }
}
