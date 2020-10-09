using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10_dynamic_array
{
    public partial class Form1 : Form
    {
        Button[,] btn = new Button[3, 3];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int w_h = 50;
            int gap = w_h + 20;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    btn[i, j] = new Button();
                    btn[i, j].Tag = i * 3 + j;
                    btn[i, j].Text = btn[i, j].Tag.ToString();
                    btn[i, j].Width = w_h;
                    btn[i, j].Height = w_h;
                    btn[i, j].Location = new Point(70 + j * gap, 70 + i * gap);
                    btn[i, j].Click += MyClick;
                    this.Controls.Add(btn[i, j]);
                }

        }

        private void MyClick(object sender, EventArgs e)
        {
            string str;

            //sender參數 控制滑鼠或鍵盤事件
            str = ((Button)sender).Tag.ToString();
            label1.Text = str;
        }
    }
}
