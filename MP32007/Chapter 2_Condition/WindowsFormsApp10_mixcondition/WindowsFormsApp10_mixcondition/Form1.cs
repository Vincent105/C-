using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10_mixcondition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month, day;
            try
            {
                month = Convert.ToInt32(textBox1.Text);
                day = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (month < 1 || month > 12)
            {
                MessageBox.Show("請輸入正確的月份");
                return;
            }
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day < 1 || day > 31)
                    {
                        MessageBox.Show("請輸入正確的日期");
                        return;
                    }
                    break;
            }
            switch (month)
            {
                case 2:
                    if (day < 1 || day > 28)
                    {
                        MessageBox.Show("請輸入正確的日期");
                        return;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (day < 1 || day > 30)
                    {
                        MessageBox.Show("請輸入正確的日期");
                        return;
                    }
                    break;
            }
            switch (month)
            {
                case 1:
                    if (day < 12)
                        label3.Text = "摩羯座";
                    else
                        label3.Text = "水瓶座";
                    break;
                case 2:
                    if (day < 19)
                        label3.Text = "水瓶座";
                    else
                        label3.Text = "雙魚座";
                    break;
                case 3:
                    if (day < 20)
                        label3.Text = "雙魚座";
                    else
                        label3.Text = "其他";
                    break;
                default:
                    label3.Text = "unknow";
                    break;
            }


        }
    }
}
