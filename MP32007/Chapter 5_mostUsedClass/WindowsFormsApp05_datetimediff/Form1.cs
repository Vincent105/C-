using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp05_datetimediff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(2000, 11, 25);
            DateTime dt1, dt2;
            int v;
            string str;

            dt1 = dt.AddDays(10);
            textBox1.AppendText(dt1.ToString() + "\r\n");

            //日期比較
            v = dt.CompareTo(new DateTime(1999, 1, 1));
            textBox1.AppendText(v.ToString() + "\r\n");
            v = DateTime.Compare(new DateTime(1999, 1, 1), dt);
            textBox1.AppendText(v.ToString() + "\r\n");
            v = DateTime.Compare(dt, dt);
            textBox1.AppendText(v.ToString() + "\r\n");
            v = DateTime.Compare(dt, new DateTime(1999, 1, 1));
            textBox1.AppendText(v.ToString() + "\r\n");

            v = DateTime.DaysInMonth(2020, 12);
            textBox1.AppendText(v.ToString() + "\r\n");

            //字串轉日期格式
            dt2 = DateTime.Parse("2018/7/25T14:30:20");
            textBox1.AppendText(dt2.ToString() + "\r\n");

            //日期相減
            textBox1.AppendText(dt1.Subtract(dt).ToString() + "\r\n");

            //顯示短時間
            str = dt2.ToShortTimeString();
            textBox1.AppendText(str + "\r\n");
        }
    }
}
