using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp06_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int move = 10;
            int index = 0;

            pictureBox1.Left = x; //設定初使位置
            pictureBox1.Width = imageList1.ImageSize.Width;
            pictureBox1.Height = imageList1.ImageSize.Height;

            while (x + pictureBox1.Width + move < ClientSize.Width)
            {
                pictureBox1.Image = imageList1.Images[index];
                x += move; //下次移動位置
                pictureBox1.Left = x;

                if (++index > 4) //索引加1，若圖片編號 > 4 
                    index = 0;   //重編號0開始

                Refresh();
                System.Threading.Thread.Sleep(100);

                Application.DoEvents();
            }

        }
    }
}
