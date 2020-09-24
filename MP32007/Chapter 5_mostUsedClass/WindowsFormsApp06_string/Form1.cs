using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp06_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "abcdefghijk";
            string str2 = "abcdefghijz";
            const string str3 = "尼好嗎?";
            string str4 = "\0\0";
            string str5;
            int v;
            bool fg;
            string[] str6;

            //字串長度
            textBox1.AppendText(str1.Length.ToString() + "\r\n");
            textBox1.AppendText(str3.Length.ToString() + "\r\n");
            textBox1.AppendText(str4.Length.ToString() + "\r\n");

            //取出某個字元
            textBox1.AppendText(str1[3].ToString() + "\r\n");

            //比較是否相同
            v = string.Compare(str1, str2);
            textBox1.AppendText(v.ToString() + "\r\n");

            //串接字串
            str5 = string.Concat("vincent" + str3);
            textBox1.AppendText(str5.ToString() + "\r\n");

            //搜尋字串
            fg = str1.Contains("cde");
            textBox1.AppendText(fg.ToString() + "\r\n");

            fg = str1.EndsWith("IJK", false, null);
            textBox1.AppendText(fg.ToString() + "\r\n");
            fg = str1.EndsWith("IJK", true, null);
            textBox1.AppendText(fg.ToString() + "\r\n");

            //填滿字串
            str5 = str3.PadRight(10, 'c');
            textBox1.AppendText(str5 + "\r\n");

            //刪除字串
            str5 = str1.Remove(2, 4);
            textBox1.AppendText(str5 + "\r\n");

            //取代字串
            str1 = "This is a book";
            str5 = str1.Replace('o', 'x');
            textBox1.AppendText(str5 + "\r\n");

            //切割字串
            str5 = "This is a book"; 
            str6 = str5.Split(' ');
            foreach (var s in str6) 
                textBox1.AppendText(s + "\r\n");

            str5 = "          This is a book";
            textBox1.AppendText(str5.Trim() +"\r\n");
        }

    }
}
